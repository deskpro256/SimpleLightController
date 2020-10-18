namespace LightController
{
    partial class LightController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.SerialSendTimer = new System.Windows.Forms.Timer(this.components);
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Device1Button = new System.Windows.Forms.Button();
            this.Device0Button = new System.Windows.Forms.Button();
            this.BlueValueLabel = new System.Windows.Forms.Label();
            this.GreenValueLabel = new System.Windows.Forms.Label();
            this.RedValueLabel = new System.Windows.Forms.Label();
            this.ManualUpdateLabel = new System.Windows.Forms.Label();
            this.AutoUpdateLabel = new System.Windows.Forms.Label();
            this.AutoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.RedBar = new System.Windows.Forms.TrackBar();
            this.BlueBar = new System.Windows.Forms.TrackBar();
            this.SendButton = new System.Windows.Forms.Button();
            this.GreenBar = new System.Windows.Forms.TrackBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SerialGroupBox = new System.Windows.Forms.GroupBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.PortnameLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SerialGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // SerialSendTimer
            // 
            this.SerialSendTimer.Enabled = true;
            this.SerialSendTimer.Interval = 500;
            this.SerialSendTimer.Tick += new System.EventHandler(this.SerialSendTimer_Tick);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Device1Button);
            this.tabPage2.Controls.Add(this.Device0Button);
            this.tabPage2.Controls.Add(this.BlueValueLabel);
            this.tabPage2.Controls.Add(this.GreenValueLabel);
            this.tabPage2.Controls.Add(this.RedValueLabel);
            this.tabPage2.Controls.Add(this.ManualUpdateLabel);
            this.tabPage2.Controls.Add(this.AutoUpdateLabel);
            this.tabPage2.Controls.Add(this.AutoUpdateCheckBox);
            this.tabPage2.Controls.Add(this.BlueLabel);
            this.tabPage2.Controls.Add(this.GreenLabel);
            this.tabPage2.Controls.Add(this.RedLabel);
            this.tabPage2.Controls.Add(this.RedBar);
            this.tabPage2.Controls.Add(this.BlueBar);
            this.tabPage2.Controls.Add(this.SendButton);
            this.tabPage2.Controls.Add(this.GreenBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(286, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Light Control";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Device";
            // 
            // Device1Button
            // 
            this.Device1Button.Location = new System.Drawing.Point(179, 5);
            this.Device1Button.Name = "Device1Button";
            this.Device1Button.Size = new System.Drawing.Size(75, 23);
            this.Device1Button.TabIndex = 20;
            this.Device1Button.Text = "Device 1";
            this.Device1Button.UseVisualStyleBackColor = true;
            this.Device1Button.Click += new System.EventHandler(this.Device1Button_Click);
            // 
            // Device0Button
            // 
            this.Device0Button.Location = new System.Drawing.Point(98, 5);
            this.Device0Button.Name = "Device0Button";
            this.Device0Button.Size = new System.Drawing.Size(75, 23);
            this.Device0Button.TabIndex = 19;
            this.Device0Button.Text = "Device 0";
            this.Device0Button.UseVisualStyleBackColor = true;
            this.Device0Button.Click += new System.EventHandler(this.Device0Button_Click);
            // 
            // BlueValueLabel
            // 
            this.BlueValueLabel.AutoSize = true;
            this.BlueValueLabel.Location = new System.Drawing.Point(174, 168);
            this.BlueValueLabel.Name = "BlueValueLabel";
            this.BlueValueLabel.Size = new System.Drawing.Size(13, 13);
            this.BlueValueLabel.TabIndex = 18;
            this.BlueValueLabel.Text = "0";
            // 
            // GreenValueLabel
            // 
            this.GreenValueLabel.AutoSize = true;
            this.GreenValueLabel.Location = new System.Drawing.Point(174, 117);
            this.GreenValueLabel.Name = "GreenValueLabel";
            this.GreenValueLabel.Size = new System.Drawing.Size(13, 13);
            this.GreenValueLabel.TabIndex = 17;
            this.GreenValueLabel.Text = "0";
            // 
            // RedValueLabel
            // 
            this.RedValueLabel.AutoSize = true;
            this.RedValueLabel.Location = new System.Drawing.Point(174, 66);
            this.RedValueLabel.Name = "RedValueLabel";
            this.RedValueLabel.Size = new System.Drawing.Size(13, 13);
            this.RedValueLabel.TabIndex = 16;
            this.RedValueLabel.Text = "0";
            // 
            // ManualUpdateLabel
            // 
            this.ManualUpdateLabel.AutoSize = true;
            this.ManualUpdateLabel.Location = new System.Drawing.Point(8, 207);
            this.ManualUpdateLabel.Name = "ManualUpdateLabel";
            this.ManualUpdateLabel.Size = new System.Drawing.Size(138, 13);
            this.ManualUpdateLabel.TabIndex = 15;
            this.ManualUpdateLabel.Text = "Updates every time pressed";
            // 
            // AutoUpdateLabel
            // 
            this.AutoUpdateLabel.AutoSize = true;
            this.AutoUpdateLabel.Location = new System.Drawing.Point(165, 207);
            this.AutoUpdateLabel.Name = "AutoUpdateLabel";
            this.AutoUpdateLabel.Size = new System.Drawing.Size(113, 13);
            this.AutoUpdateLabel.TabIndex = 14;
            this.AutoUpdateLabel.Text = "Updates every 500 ms";
            // 
            // AutoUpdateCheckBox
            // 
            this.AutoUpdateCheckBox.AutoSize = true;
            this.AutoUpdateCheckBox.Location = new System.Drawing.Point(168, 187);
            this.AutoUpdateCheckBox.Name = "AutoUpdateCheckBox";
            this.AutoUpdateCheckBox.Size = new System.Drawing.Size(86, 17);
            this.AutoUpdateCheckBox.TabIndex = 13;
            this.AutoUpdateCheckBox.Text = "Auto Update";
            this.AutoUpdateCheckBox.UseVisualStyleBackColor = true;
            this.AutoUpdateCheckBox.CheckedChanged += new System.EventHandler(this.AutoUpdateCheckBox_CheckedChanged);
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.BlueLabel.Location = new System.Drawing.Point(8, 147);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(55, 25);
            this.BlueLabel.TabIndex = 8;
            this.BlueLabel.Text = "Blue";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.GreenLabel.Location = new System.Drawing.Point(8, 95);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(71, 25);
            this.GreenLabel.TabIndex = 7;
            this.GreenLabel.Text = "Green";
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RedLabel.Location = new System.Drawing.Point(8, 43);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(51, 25);
            this.RedLabel.TabIndex = 6;
            this.RedLabel.Text = "Red";
            // 
            // RedBar
            // 
            this.RedBar.Location = new System.Drawing.Point(99, 34);
            this.RedBar.Maximum = 255;
            this.RedBar.Name = "RedBar";
            this.RedBar.Size = new System.Drawing.Size(179, 45);
            this.RedBar.TabIndex = 3;
            this.RedBar.Scroll += new System.EventHandler(this.RedBar_Scroll);
            // 
            // BlueBar
            // 
            this.BlueBar.Location = new System.Drawing.Point(99, 136);
            this.BlueBar.Maximum = 255;
            this.BlueBar.Name = "BlueBar";
            this.BlueBar.Size = new System.Drawing.Size(179, 45);
            this.BlueBar.TabIndex = 5;
            this.BlueBar.Scroll += new System.EventHandler(this.BlueBar_Scroll);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(29, 181);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send!";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // GreenBar
            // 
            this.GreenBar.Location = new System.Drawing.Point(99, 85);
            this.GreenBar.Maximum = 255;
            this.GreenBar.Name = "GreenBar";
            this.GreenBar.Size = new System.Drawing.Size(179, 45);
            this.GreenBar.TabIndex = 4;
            this.GreenBar.Scroll += new System.EventHandler(this.GreenBar_Scroll);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SerialGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(286, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial Port";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SerialGroupBox
            // 
            this.SerialGroupBox.Controls.Add(this.RefreshButton);
            this.SerialGroupBox.Controls.Add(this.SelectButton);
            this.SerialGroupBox.Controls.Add(this.PortBox);
            this.SerialGroupBox.Controls.Add(this.PortnameLabel);
            this.SerialGroupBox.Controls.Add(this.ConnectButton);
            this.SerialGroupBox.Location = new System.Drawing.Point(6, 6);
            this.SerialGroupBox.Name = "SerialGroupBox";
            this.SerialGroupBox.Size = new System.Drawing.Size(272, 216);
            this.SerialGroupBox.TabIndex = 6;
            this.SerialGroupBox.TabStop = false;
            this.SerialGroupBox.Text = "Serial Port Settings";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(115, 28);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(115, 84);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 4;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(92, 57);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(121, 21);
            this.PortBox.TabIndex = 3;
            // 
            // PortnameLabel
            // 
            this.PortnameLabel.AutoSize = true;
            this.PortnameLabel.Location = new System.Drawing.Point(28, 60);
            this.PortnameLabel.Name = "PortnameLabel";
            this.PortnameLabel.Size = new System.Drawing.Size(58, 13);
            this.PortnameLabel.TabIndex = 2;
            this.PortnameLabel.Text = "Port name:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ConnectButton.Location = new System.Drawing.Point(92, 133);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(121, 52);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(294, 255);
            this.tabControl.TabIndex = 7;
            // 
            // LightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 255);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LightController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LightController_FormClosing);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RedBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenBar)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.SerialGroupBox.ResumeLayout(false);
            this.SerialGroupBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Timer SerialSendTimer;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Device1Button;
        private System.Windows.Forms.Button Device0Button;
        private System.Windows.Forms.Label BlueValueLabel;
        private System.Windows.Forms.Label GreenValueLabel;
        private System.Windows.Forms.Label RedValueLabel;
        private System.Windows.Forms.Label ManualUpdateLabel;
        private System.Windows.Forms.Label AutoUpdateLabel;
        private System.Windows.Forms.CheckBox AutoUpdateCheckBox;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.TrackBar RedBar;
        private System.Windows.Forms.TrackBar BlueBar;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TrackBar GreenBar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox SerialGroupBox;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Label PortnameLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TabControl tabControl;
    }
}

