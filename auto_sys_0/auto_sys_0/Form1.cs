using System;
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

        private int g_buff_index = 0;
        private byte[] g_buff = new byte[100];

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
                MessageBox.Show(ex.ToString());
            }
        }

        private void SerialReceived(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer_input = new byte[100];
                if (serialPort1.BytesToRead > 100) return;
                if (g_buff_index >= 100) return;

                demoReceiveTextBox.Text = "";
                serialPort1.Read(buffer_input, 0, serialPort1.BytesToRead);
                demoReceiveTextBox.Text += Encoding.ASCII.GetString(buffer_input);

                if (mea_push == true)
                {
                    mea_push = false;
                    ForwardTBox.Text = demoReceiveTextBox.Text;
                    MeaButton.BackColor = DefaultBackColor;
                }
            }
            catch(Exception ex)
            {
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

                    ConnectButton.BackColor = Color.Red;
                }
                else
                {
                    serialPort1.Close();
                    ConnectButton.BackColor = DefaultBackColor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MeaButton_Click(object sender, EventArgs e)
        {
            try
            {
                WriteSerial(MeaCmdTBox.Text + "\n");
                mea_push = true;
                MeaButton.BackColor = Color.Red;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void send_Click(object sender, EventArgs e)
        {
            try
            {
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
                MeaCmdTBox.Text          + "\n"
                + RstCmdTBox.Text        + "\n"
                + UnitdBmCmdTbox.Text    + "\n"
                + UnitWCmdTbox.Text      + "\n"
                + Custom_0CmdTbox.Text   + "\n"
                + Custom_1CmdTbox.Text   + "\n"
                + BaudText.Text          + "\n";

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
    }
}
