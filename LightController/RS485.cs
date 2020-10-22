using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleIO;
using System.IO;
using System.IO.Ports;

namespace LightController
{
    public partial class LightController
    {
        //---------------[RS485Send]-----------------------

        public void RS485Send(byte receiverID, byte red, byte green, byte blue)
        {
            byte CRC = GetCRC(receiverID, myID, red, green, blue);

            message[0] = STX;
            message[1] = receiverID;
            message[2] = myID;
            message[3] = red;
            message[4] = green;
            message[5] = blue;
            message[6] = CRC;

            SimpleIOClass.SetPin(2); //enable sending
            System.Threading.Thread.Sleep(50);
            serialPort.Write(message, 0, 7);
            System.Threading.Thread.Sleep(20);
            SimpleIOClass.ClearPin(2); //disable sending

        }
        public void RS485Receive()
        {
            if (LookForSTX == STX)
            {
                LookForSTX = 0x00;
                serialPort.Read(RS485ReadBytes, 0, 6);
                replied = true;
                IsMyMessageGood();
            }
            else
            {
                replied = false;
            }
        }


        public void IsMyMessageGood()
        {
            byte RecMessageCRC = GetCRC(RS485ReadBytes[0], RS485ReadBytes[1], RS485ReadBytes[2], RS485ReadBytes[3], RS485ReadBytes[4]);

            if (RS485ReadBytes[0] == myID && RS485ReadBytes[5] == RecMessageCRC)
            {
                for (int i = 0; i < BufferSize - 1; i++)
                {
                    RS485ReadBytes[i] = ReceivedMessage[i];
                }
            }

            RedLabel.Text = Convert.ToInt32(ReceivedMessage[2]).ToString();
            GreenLabel.Text = Convert.ToInt32(ReceivedMessage[3]).ToString();
            BlueLabel.Text = Convert.ToInt32(ReceivedMessage[4]).ToString();
            //rgb = red + green + blue;

        }

        public byte GetCRC(byte myid, byte receiverid, byte red, byte green, byte blue)
        {
            // big brain math here
            byte CRC = Convert.ToByte(((STX + myid + receiverid + red + green + blue) ^ 0xff) & 0xff);

            return CRC;
        }

    }
}
