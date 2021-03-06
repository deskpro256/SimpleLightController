﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleIO;
using System.IO;
using System.IO.Ports;

namespace LightController
{
    public partial class LightController : Form
    {

        public const uint mcp2200_VID = 0x04D8;  //VID for MCP2200
        public const uint mcp2200_PID = 0x00DF;  //PID for MCP2200
        public bool isConnected = SimpleIOClass.IsConnected();         //Connection status of MCP2200 

        bool Connected = false;
        public string serialPorts;

        int selectedDevice = 0;
        //                                                 R  G  B
        public byte[,] DeviceSettings = new byte[2, 3] { { 0, 0, 0 },
                                                         { 0, 0, 0 } };

        //-----------[RS485 Stuff]-----------------
        public static int BufferSize = 7;
        public byte[] message = new byte[BufferSize];
        public byte[] RS485ReadBytes = new byte[BufferSize - 1];
        public byte[] ReceivedMessage = new byte[BufferSize - 1];
        public byte myID = 0x1C;    //PC soft ID
        public byte STX = 0x7C;
        public byte LookForSTX = 0x00;
        bool replied = false;

        public LightController()
        {
            InitializeComponent();
            UpdateSerialPorts();
            MCP2200Load();
            ConnectButton.Enabled = false;
            selectedDevice = 0;
            Device0Button.Enabled = false;
            SendButton.Enabled = false;
            Device1Button.Enabled = true;
            SerialProgressBar.Value = 0;

        }

        private void UpdateSerialPorts()
        {
            PortBox.Items.Clear();
            serialPorts = "";
            foreach (string s in SerialPort.GetPortNames())
            {
                serialPorts = s;
                if (serialPorts != "")
                {
                    PortBox.Items.Add(serialPorts);
                }
            }
        }


        //----------------------[Serial Stuff]-------------------------------

        private void SelectButton_Click(object sender, EventArgs e)
        {
            serialPort.PortName = PortBox.SelectedItem.ToString();
            ConnectButton.Enabled = true;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateSerialPorts();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                Connected = false;
                ConnectButton.Text = "Connect";
                SerialProgressBar.Value = 0;
                SendButton.Enabled = false;
                try
                {
                    SimpleIOClass.ClearPin(3);
                    serialPort.Close();
                }
                catch (Exception)
                {
                }
            }
            else
            {
                try
                {
                    serialPort.Open();
                    SimpleIOClass.SetPin(3);
                    if (serialPort.IsOpen)
                    {
                        Connected = true;
                        ConnectButton.Text = "Disonnect";
                        SendButton.Enabled = true;
                        SerialProgressBar.Value = 1;
                    }
                }
                catch (Exception)
                {
                    ConnectButton.Text = "Connect";
                    MessageBox.Show("COM port already open!");
                }
            }
        }
        public void MCP2200Load()
        {
            SimpleIOClass.InitMCP2200(mcp2200_VID, mcp2200_PID);
            SimpleIOClass.ConfigureMCP2200(0x00, 9600, 5, 5, false, false, false, false);
            SimpleIOClass.ConfigureIoDefaultOutput(0x00, 0x00);
            SimpleIOClass.SelectDevice(0);
        }
        /*
        //----------------------[Color Selection]-------------------------------
        private void RedBar_Scroll(object sender, EventArgs e)
        {
            RedValueLabel.Text = RedBar.Value.ToString();
            DeviceSettings[selectedDevice, 0] = Convert.ToByte(RedBar.Value);
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            GreenValueLabel.Text = GreenBar.Value.ToString();
            DeviceSettings[selectedDevice, 1] = Convert.ToByte(GreenBar.Value);
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            BlueValueLabel.Text = BlueBar.Value.ToString();
            DeviceSettings[selectedDevice, 2] = Convert.ToByte(BlueBar.Value);
        }
        */
        private void SendButton_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                for (int i = 0; i <= 1; i++)
                {
                    byte ID = Convert.ToByte(i);
                    RS485Send(ID, DeviceSettings[i, 0], DeviceSettings[i, 1], DeviceSettings[i, 2]);
                }
            }
            else
            {
                MessageBox.Show("Serial Port not open!\nPlease connect to a device!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AutoUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoUpdateCheckBox.Checked)
            {
                SendButton.Enabled = false;
            }
            else
            {
                SendButton.Enabled = true;
            }
        }

        private void Device0Button_Click(object sender, EventArgs e)
        {
            selectedDevice = 0;
            Device0Button.Enabled = false;
            Device1Button.Enabled = true;
            //RedBar.Value = Convert.ToInt32(DeviceSettings[selectedDevice, 0]);
            //GreenBar.Value = Convert.ToInt32(DeviceSettings[selectedDevice, 1]);
            //BlueBar.Value = Convert.ToInt32(DeviceSettings[selectedDevice, 2]);
            //RedValueLabel.Text = RedBar.Value.ToString();
            //GreenValueLabel.Text = GreenBar.Value.ToString();
            //BlueValueLabel.Text = BlueBar.Value.ToString();
        }

        private void Device1Button_Click(object sender, EventArgs e)
        {
            selectedDevice = 1;
            Device1Button.Enabled = false;
            Device0Button.Enabled = true;
            //RedBar.Value = Convert.ToInt32(DeviceSettings[selectedDevice, 0]);
            //GreenBar.Value = Convert.ToInt32(DeviceSettings[selectedDevice, 1]);
            //BlueBar.Value = Convert.ToInt32(DeviceSettings[selectedDevice, 2]);
            //RedValueLabel.Text = RedBar.Value.ToString();
            //GreenValueLabel.Text = GreenBar.Value.ToString();
            //BlueValueLabel.Text = BlueBar.Value.ToString();
        }


        private void SerialSendTimer_Tick(object sender, EventArgs e)
        {
            if (AutoUpdateCheckBox.Checked && serialPort.IsOpen)
            {
                for (int i = 0; i <= 1; i++)
                {
                    byte ID = Convert.ToByte(i);
                    RS485Send(ID, DeviceSettings[i, 0], DeviceSettings[i, 1], DeviceSettings[i, 2]);
                }
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                AutoUpdateCheckBox.Enabled = true;
                LookForSTX = Convert.ToByte(serialPort.ReadByte());
                if (LookForSTX == STX)
                {
                    RS485Receive();
                }
            }
            else
            {
                AutoUpdateCheckBox.Enabled = false;
            }


        }

        private void LightController_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                SimpleIOClass.ClearPin(3);
                serialPort.Close();
            }

            Application.Exit();
        }
    }
}
