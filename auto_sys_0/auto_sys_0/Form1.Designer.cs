
namespace auto_sys_0
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.demoReceiveTextBox = new System.Windows.Forms.TextBox();
            this.UnitButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MeaButton = new System.Windows.Forms.Button();
            this.ForwardTBox = new System.Windows.Forms.TextBox();
            this.demo_textbox = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BaudText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.PopCountTbox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.IntervalTBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MeaCmdTBox = new System.Windows.Forms.TextBox();
            this.CusCmd_1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.RstCmdTBox = new System.Windows.Forms.TextBox();
            this.CusCmd_0 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Custom_1CmdTbox = new System.Windows.Forms.TextBox();
            this.UnitdBmCmdTbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Custom_0CmdTbox = new System.Windows.Forms.TextBox();
            this.UnitWCmdTbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // demoReceiveTextBox
            // 
            this.demoReceiveTextBox.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.demoReceiveTextBox.Location = new System.Drawing.Point(126, 17);
            this.demoReceiveTextBox.Multiline = true;
            this.demoReceiveTextBox.Name = "demoReceiveTextBox";
            this.demoReceiveTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.demoReceiveTextBox.Size = new System.Drawing.Size(620, 51);
            this.demoReceiveTextBox.TabIndex = 0;
            // 
            // UnitButton
            // 
            this.UnitButton.Location = new System.Drawing.Point(292, 39);
            this.UnitButton.Name = "UnitButton";
            this.UnitButton.Size = new System.Drawing.Size(110, 76);
            this.UnitButton.TabIndex = 1;
            this.UnitButton.Text = "dBm";
            this.UnitButton.UseVisualStyleBackColor = true;
            this.UnitButton.Click += new System.EventHandler(this.UnitButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(126, 134);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(180, 68);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(292, 134);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(110, 68);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "RESET";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 77);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 41);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // MeaButton
            // 
            this.MeaButton.Location = new System.Drawing.Point(28, 134);
            this.MeaButton.Name = "MeaButton";
            this.MeaButton.Size = new System.Drawing.Size(122, 68);
            this.MeaButton.TabIndex = 6;
            this.MeaButton.Text = "MEASURE";
            this.MeaButton.UseVisualStyleBackColor = true;
            this.MeaButton.Click += new System.EventHandler(this.MeaButton_Click);
            // 
            // ForwardTBox
            // 
            this.ForwardTBox.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForwardTBox.Location = new System.Drawing.Point(28, 39);
            this.ForwardTBox.Name = "ForwardTBox";
            this.ForwardTBox.Size = new System.Drawing.Size(258, 76);
            this.ForwardTBox.TabIndex = 7;
            // 
            // demo_textbox
            // 
            this.demo_textbox.Location = new System.Drawing.Point(126, 74);
            this.demo_textbox.Name = "demo_textbox";
            this.demo_textbox.Size = new System.Drawing.Size(620, 25);
            this.demo_textbox.TabIndex = 9;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(126, 105);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(620, 31);
            this.send.TabIndex = 11;
            this.send.Text = "send_demo";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(156, 134);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(130, 68);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "COPY";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Demo Recever";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(25, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Forward ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BaudText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Location = new System.Drawing.Point(25, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 233);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(5, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Baud Rate";
            // 
            // BaudText
            // 
            this.BaudText.Location = new System.Drawing.Point(126, 39);
            this.BaudText.Name = "BaudText";
            this.BaudText.Size = new System.Drawing.Size(179, 25);
            this.BaudText.TabIndex = 16;
            this.BaudText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(5, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Serial Port";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ForwardTBox);
            this.panel2.Controls.Add(this.UnitButton);
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this.CopyButton);
            this.panel2.Controls.Add(this.MeaButton);
            this.panel2.Location = new System.Drawing.Point(364, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 233);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.demoReceiveTextBox);
            this.panel3.Controls.Add(this.demo_textbox);
            this.panel3.Controls.Add(this.send);
            this.panel3.Location = new System.Drawing.Point(25, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(763, 429);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.PopCountTbox);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.IntervalTBox);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.MeaCmdTBox);
            this.panel4.Controls.Add(this.CusCmd_1);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.RstCmdTBox);
            this.panel4.Controls.Add(this.CusCmd_0);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.Custom_1CmdTbox);
            this.panel4.Controls.Add(this.UnitdBmCmdTbox);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.Custom_0CmdTbox);
            this.panel4.Controls.Add(this.UnitWCmdTbox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(761, 285);
            this.panel4.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(122, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 15);
            this.label17.TabIndex = 30;
            this.label17.Text = "FORWARD POP COUNT";
            // 
            // PopCountTbox
            // 
            this.PopCountTbox.Location = new System.Drawing.Point(125, 170);
            this.PopCountTbox.Name = "PopCountTbox";
            this.PopCountTbox.Size = new System.Drawing.Size(201, 25);
            this.PopCountTbox.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(122, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "INTERVAL [ms]";
            // 
            // IntervalTBox
            // 
            this.IntervalTBox.Location = new System.Drawing.Point(125, 107);
            this.IntervalTBox.Name = "IntervalTBox";
            this.IntervalTBox.Size = new System.Drawing.Size(201, 25);
            this.IntervalTBox.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(3, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "Cmd Custom";
            // 
            // MeaCmdTBox
            // 
            this.MeaCmdTBox.Location = new System.Drawing.Point(125, 43);
            this.MeaCmdTBox.Name = "MeaCmdTBox";
            this.MeaCmdTBox.Size = new System.Drawing.Size(201, 25);
            this.MeaCmdTBox.TabIndex = 14;
            // 
            // CusCmd_1
            // 
            this.CusCmd_1.Location = new System.Drawing.Point(577, 232);
            this.CusCmd_1.Name = "CusCmd_1";
            this.CusCmd_1.Size = new System.Drawing.Size(106, 26);
            this.CusCmd_1.TabIndex = 15;
            this.CusCmd_1.Text = "CUSTOM_1";
            this.CusCmd_1.UseVisualStyleBackColor = true;
            this.CusCmd_1.Click += new System.EventHandler(this.CusCmd_1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "MEASURE COMMAND";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "CUSTOM_1 COMMAND";
            // 
            // RstCmdTBox
            // 
            this.RstCmdTBox.Location = new System.Drawing.Point(125, 233);
            this.RstCmdTBox.Name = "RstCmdTBox";
            this.RstCmdTBox.Size = new System.Drawing.Size(201, 25);
            this.RstCmdTBox.TabIndex = 16;
            // 
            // CusCmd_0
            // 
            this.CusCmd_0.Location = new System.Drawing.Point(577, 169);
            this.CusCmd_0.Name = "CusCmd_0";
            this.CusCmd_0.Size = new System.Drawing.Size(106, 25);
            this.CusCmd_0.TabIndex = 16;
            this.CusCmd_0.Text = "CUSTOM_0";
            this.CusCmd_0.UseVisualStyleBackColor = true;
            this.CusCmd_0.Click += new System.EventHandler(this.CusCmd_0_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "RESET COMMAND";
            // 
            // Custom_1CmdTbox
            // 
            this.Custom_1CmdTbox.Location = new System.Drawing.Point(370, 233);
            this.Custom_1CmdTbox.Name = "Custom_1CmdTbox";
            this.Custom_1CmdTbox.Size = new System.Drawing.Size(201, 25);
            this.Custom_1CmdTbox.TabIndex = 24;
            // 
            // UnitdBmCmdTbox
            // 
            this.UnitdBmCmdTbox.Location = new System.Drawing.Point(366, 43);
            this.UnitdBmCmdTbox.Name = "UnitdBmCmdTbox";
            this.UnitdBmCmdTbox.Size = new System.Drawing.Size(201, 25);
            this.UnitdBmCmdTbox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "CUSTOM_0 COMMAND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "UNIT DBM COMMAND";
            // 
            // Custom_0CmdTbox
            // 
            this.Custom_0CmdTbox.Location = new System.Drawing.Point(370, 169);
            this.Custom_0CmdTbox.Name = "Custom_0CmdTbox";
            this.Custom_0CmdTbox.Size = new System.Drawing.Size(201, 25);
            this.Custom_0CmdTbox.TabIndex = 22;
            // 
            // UnitWCmdTbox
            // 
            this.UnitWCmdTbox.Location = new System.Drawing.Point(366, 105);
            this.UnitWCmdTbox.Name = "UnitWCmdTbox";
            this.UnitWCmdTbox.Size = new System.Drawing.Size(201, 25);
            this.UnitWCmdTbox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "UNIT WATT COMMAND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Demo Sender";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(21, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 24);
            this.label12.TabIndex = 17;
            this.label12.Text = "Demo Pannel";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(21, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 24);
            this.label13.TabIndex = 18;
            this.label13.Text = "Com Port Pannel";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(360, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 24);
            this.label14.TabIndex = 19;
            this.label14.Text = "Measure Pannel";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 770);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Serial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox demoReceiveTextBox;
        private System.Windows.Forms.Button UnitButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button ResetButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button MeaButton;
        private System.Windows.Forms.TextBox ForwardTBox;
        private System.Windows.Forms.TextBox demo_textbox;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BaudText;
        private System.Windows.Forms.TextBox MeaCmdTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RstCmdTBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UnitdBmCmdTbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox UnitWCmdTbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Custom_0CmdTbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Custom_1CmdTbox;
        private System.Windows.Forms.Button CusCmd_1;
        private System.Windows.Forms.Button CusCmd_0;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox IntervalTBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox PopCountTbox;
    }
}

