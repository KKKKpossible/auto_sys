﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_sys_0
{
    public partial class Form1 : Form
    {
        private bool mea_push = false;

        private byte[] mea_cmd = new byte[100];
        private byte[] rst_cmd = new byte[100];
        private byte[] unit_cmd = new byte[100];

        private int pop_count     = 0;
        private int pop_count_max = 0;

        private double forward_buffer = 0.0;

        private object lockObject = new object();

        private byte[] parser = new byte[17];
        private int parse_index = 0;

        private bool disconnect_serial_call;
        private int disconnect_count;

        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke(new EventHandler(SerialReceived));
            }
            catch (Exception ex)
            {
                CatchErrorMeasureReset();
                MessageBox.Show(ex.ToString());
            }
        }
        private void SerialReceived(object sender, EventArgs e)
        {
            try
            {
                lock(lockObject)
                {
                    if(disconnect_serial_call == true)
                    {
                        disconnect_count = 0;
                    }
                    byte[] buffer_input = new byte[1024];

                    int length = serialPort1.BytesToRead;

                    if (length > 1024)
                    {
                        CatchErrorMeasureReset();
                        MessageBox.Show("Buffer Max Error");
                        return;
                    }

                    serialPort1.Read(buffer_input, 0, length);

                    if(timer1.Enabled)
                    {
                        for(int i = 0; i < length; i++)
                        {
                            parser[parse_index++] = buffer_input[i];

                            if(parser[parse_index - 1] == '\n' && parse_index == 17)
                            {
                                parse_index = 0;
                                demoReceiveTextBox.Text += Encoding.ASCII.GetString(parser);
                            }
                            if(parse_index == 17)
                            {
                                MessageBox.Show("Parse Error");
                                CatchErrorMeasureReset();
                            }
                        }
                    }
                    else
                    {
                        demoReceiveTextBox.Text += Encoding.ASCII.GetString(buffer_input);

                    }
                }
            }
            catch(Exception ex)
            {
                CatchErrorMeasureReset();
                MessageBox.Show(ex.ToString());
            }
        }
        private void comboBox1_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                string[] portlist = System.IO.Ports.SerialPort.GetPortNames();

                if (portlist.Length > 0)
                {
                    foreach (string portnumber in portlist)
                    {
                        comboBox1.Items.Add(portnumber);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.BaudRate = Convert.ToInt32(BaudText.Text);
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.Open();
                    WriteSerial("*idn?\n");
                    disconnect_serial_call = false;
                    ConnectButton.BackColor = Color.Red;
                }
                else
                {
                    CatchErrorMeasureReset();
                }
            }
            catch (Exception ex)
            {
                CatchErrorMeasureReset();
                MessageBox.Show(ex.ToString());
            }
        }
        private void MeaButton_Click(object sender, EventArgs e)
        {
            try
            {
                ForwardTBox.Text = "";
                demoReceiveTextBox.Text = "";

                UnitButton.Enabled = false;
                ResetButton.Enabled = false;
                MeaCmdTBox.Enabled = false;
                IntervalTBox.Enabled = false;
                PopCountTbox.Enabled = false;
                demoReceiveTextBox.Enabled = false;

                pop_count = 0;
                pop_count_max = Convert.ToInt32(PopCountTbox.Text);

                if (mea_push == false)
                {
                    mea_push = true;
                    MeaButton.BackColor = Color.Red;
                    timer1.Interval = Convert.ToInt32(IntervalTBox.Text);
                    timer1.Start();
                }
                else
                {
                    MeasureReset();
                }
            }
            catch(Exception ex)
            {
                CatchErrorMeasureReset();
                MessageBox.Show(ex.ToString());
            }
        }
        private void send_Click(object sender, EventArgs e)
        {
            try
            {
                demoReceiveTextBox.Text = "";
                WriteSerial(demo_textbox.Text + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(ForwardTBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                WriteSerial(RstCmdTBox.Text + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void UnitButton_Click(object sender, EventArgs e)
        {
            if(UnitButton.Text == "dBm")
            {
                try
                {
                    WriteSerial(UnitWCmdTbox.Text + "\n");
                    UnitButton.Text = "Watt";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                try
                {
                    WriteSerial(UnitdBmCmdTbox.Text + "\n");
                    UnitButton.Text = "dBm";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string   str     = File.ReadAllText(@"cmd.txt").Replace("\n", ",");
                string[] setting = str.Split(',');
                
                MeaCmdTBox.Text      = setting[0];
                RstCmdTBox.Text      = setting[1];
                UnitdBmCmdTbox.Text  = setting[2];
                UnitWCmdTbox.Text    = setting[3];
                Custom_0CmdTbox.Text = setting[4];
                Custom_1CmdTbox.Text = setting[5];
                BaudText.Text        = setting[6];
                IntervalTBox.Text    = setting[7];
                PopCountTbox.Text    = setting[8];
            }
            catch
            {
                MessageBox.Show("cmd.txt file error");
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                string str =
                MeaCmdTBox.Text        + "\n"
                + RstCmdTBox.Text      + "\n"
                + UnitdBmCmdTbox.Text  + "\n"
                + UnitWCmdTbox.Text    + "\n"
                + Custom_0CmdTbox.Text + "\n"
                + Custom_1CmdTbox.Text + "\n"
                + BaudText.Text        + "\n"
                + IntervalTBox.Text    + "\n"
                + PopCountTbox.Text    + "\n";

                File.WriteAllText("cmd.txt", str);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void WriteSerial(string s_data)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(s_data);
                int length = data.Length;
                int index = 0;
                while(true)
                {
                    if(length > 8)
                    {
                        serialPort1.Write(data, index, 8);
                        length -= 8;
                        index += 8;
                    }
                    else
                    {
                        serialPort1.Write(data, index, length);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                CatchErrorMeasureReset();
                MessageBox.Show(ex.ToString());
            }
        }
        private void CusCmd_0_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(Custom_0CmdTbox.Text + "\n");
                serialPort1.Write(data, 0, data.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CusCmd_1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Encoding.ASCII.GetBytes(Custom_1CmdTbox.Text + "\n");
                serialPort1.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (demoReceiveTextBox.Text != "")
            {
                try
                {
                    string buff_demoReceiveTextBox = string.Copy(demoReceiveTextBox.Text);
                    demoReceiveTextBox.Text = "";
                    pop_count++;

                    if (pop_count > pop_count_max)
                    {
                        pop_count = 0;

                        ForwardTBox.Text = string.Format("{0:0.00}", forward_buffer / Convert.ToDouble(pop_count_max));
                        Clipboard.SetText(ForwardTBox.Text);
                        
                        forward_buffer = 0;
                    }
                    else
                    {
                        string[] setting = buff_demoReceiveTextBox.Split('\n');
                        
                        if(setting.Length > 0)
                        {
                            for(int i = 0; i < setting.Length;)
                            {
                                if(setting[i] != "")
                                {
                                    forward_buffer += Convert.ToDouble(string.Format("{0:0.00}", Convert.ToDouble(setting[i])));
                                    i++;
                                    if (i != setting.Length - 1)
                                    {
                                        pop_count++;
                                    }
                                    if (pop_count > pop_count_max)
                                    {
                                        pop_count = 0;

                                        ForwardTBox.Text = string.Format("{0:0.00}", forward_buffer / Convert.ToDouble(pop_count_max));
                                        Clipboard.SetText(ForwardTBox.Text);

                                        forward_buffer = 0;
                                    }
                                }
                                else
                                {
                                    i++;
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    CatchErrorMeasureReset();
                    MessageBox.Show(ex.ToString());
                }
            }
            WriteSerial(MeaCmdTBox.Text + "\n");
        }

        private void MeasureReset()
        {
            timer1.Stop();

            ForwardTBox.Text = "";

            UnitButton.Enabled = true;
            ResetButton.Enabled = true;
            MeaCmdTBox.Enabled = true;
            IntervalTBox.Enabled = true;
            PopCountTbox.Enabled = true;
            demoReceiveTextBox.Enabled = true;

            mea_push = false;
            MeaButton.BackColor = DefaultBackColor;

            pop_count = 0;
            forward_buffer = 0;
        }

        private void CatchErrorMeasureReset()
        {
            try
            {
                if(ConnectButton.Enabled == true)
                {
                    ConnectButton.Enabled = false;

                    timer1.Stop();

                    ForwardTBox.Text = "";

                    UnitButton.Enabled = true;
                    ResetButton.Enabled = true;
                    MeaCmdTBox.Enabled = true;
                    IntervalTBox.Enabled = true;
                    PopCountTbox.Enabled = true;
                    demoReceiveTextBox.Enabled = true;

                    mea_push = false;
                    MeaButton.BackColor = DefaultBackColor;

                    pop_count = 0;
                    forward_buffer = 0;

                    disconnect_serial_call = true;
                    timer2.Interval = 3333;
                    timer2.Start();
                    MessageBox.Show("Please wait 10sec");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(disconnect_serial_call == true)
            {
                disconnect_count++;
                if(disconnect_count == 3)
                {
                    disconnect_count = 0;
                    serialPort1.Close();
                    ConnectButton.BackColor = DefaultBackColor;
                    timer2.Stop();
                    timer2.Interval = 100;
                    ConnectButton.Enabled = true;
                }
            }
        }
    }
}
