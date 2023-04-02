using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Project_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void LEDButtonControl(bool state)
        {
            btn_on1.Enabled = state;
            btn_off1.Enabled = state;

            btn_on2.Enabled = state;
            btn_off2.Enabled = state;

            btn_on3.Enabled = state;
            btn_off3.Enabled = state;

            btn_on4.Enabled = state;
            btn_off4.Enabled = state;

            btn_on5.Enabled = state;
            btn_off5.Enabled = state;

            btn_on6.Enabled = state;
            btn_off6.Enabled = state;

            btn_on7.Enabled = state;
            btn_off7.Enabled = state;

            btn_on8.Enabled = state;
            btn_off8.Enabled = state;

            btn_on9.Enabled = state;
            btn_off9.Enabled = state;

            btn_on10.Enabled = state;
            btn_off10.Enabled = state;

            btn_on11.Enabled = state;
            btn_off11.Enabled = state;

            btn_on12.Enabled = state;
            btn_off12.Enabled = state;

        }

        private void PatternButtonControl(bool state)
        {
            btn_pattern1.Enabled = state;
            btn_pattern2.Enabled = state;
            btn_pattern3.Enabled = state;
            btn_pattern4.Enabled = state;
            btn_pattern5.Enabled = state;
            btn_pattern6.Enabled = state;
            btn_pattern7.Enabled = state;
            btn_pattern8.Enabled = state;
            btn_pattern9.Enabled = state;
        }

        private void LEDSetDark()
        {

            pictureBox1.Image = Properties.Resources.LED_OFF_modified;
            pictureBox2.Image = Properties.Resources.LED_OFF_modified;
            pictureBox3.Image = Properties.Resources.LED_OFF_modified;
            pictureBox4.Image = Properties.Resources.LED_OFF_modified;
            pictureBox5.Image = Properties.Resources.LED_OFF_modified;
            pictureBox6.Image = Properties.Resources.LED_OFF_modified;
            pictureBox7.Image = Properties.Resources.LED_OFF_modified;
            pictureBox8.Image = Properties.Resources.LED_OFF_modified;
            pictureBox9.Image = Properties.Resources.LED_OFF_modified;
            pictureBox10.Image = Properties.Resources.LED_OFF_modified;
            pictureBox11.Image = Properties.Resources.LED_OFF_modified;
            pictureBox12.Image = Properties.Resources.LED_OFF_modified;

        }

        private void Button_SendData(string data, PictureBox numberLED, Image CusImage)
        {
            if(serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write(data);
                    numberLED.Image = CusImage;
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Connect.Enabled = true;
            btn_Close.Enabled = false;
            btn_patternsEnable.Enabled = false;
            pb_Connect.Value = 0;
            pb_Connect2.Value = 0;
            cmb_ComPort.SelectedIndex = 0;
            cmb_BaundRate.SelectedIndex = 0;

           

            LEDButtonControl(false);
            PatternButtonControl(false);

            LEDSetDark();

        }

        private void cmb_ComPort_DropDown(object sender, EventArgs e)
        {
            String[] portnames = SerialPort.GetPortNames();
            cmb_ComPort.Items.AddRange(portnames);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
             try
            {
                serialPort1.PortName = cmb_ComPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cmb_BaundRate.Text);
                serialPort1.Open();

                btn_Connect.Enabled = false;
                btn_Close.Enabled = true;
                pb_Connect.Value = 100;
                pb_Connect2.Value = 50;

                LEDButtonControl(true);
                btn_patternsEnable.Enabled = true;

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
               try
                {
                    serialPort1.Close();

                    btn_Connect.Enabled = true;
                    btn_Close.Enabled = false;
                    btn_patternsEnable.Enabled = false;
                    pb_Connect.Value = 0;
                    pb_Connect2.Value = 0;

                    cmb_ComPort.SelectedIndex = 0;
                    cmb_BaundRate.SelectedIndex = 0;

                    LEDButtonControl(false);
                    PatternButtonControl(false);
                    LEDSetDark();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_on1_Click(object sender, EventArgs e)
        {
            Button_SendData("1ON#", pictureBox1, Properties.Resources.LED_ON_modified);

            /*if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("1ON#");
                    pictureBox1.Image = Properties.Resources.LED_ON_modified;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }*/

        }

        private void btn_off1_Click(object sender, EventArgs e)
        {
            Button_SendData("1OFF#", pictureBox1, Properties.Resources.LED_OFF_modified);

            /*if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("1OFF#");
                    pictureBox1.Image = Properties.Resources.LED_OFF_modified;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }*/

        }

        private void cmb_ComPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_off2_Click_1(object sender, EventArgs e)
        {
            Button_SendData("2OFF#", pictureBox2, Properties.Resources.LED_OFF_modified);
        }

        private void btn_on2_Click_1(object sender, EventArgs e)
        {
            Button_SendData("2ON#", pictureBox2, Properties.Resources.LED_ON_modified);
        }

        private void btn_on3_Click_1(object sender, EventArgs e)
        {
            Button_SendData("3ON#", pictureBox3, Properties.Resources.LED_ON_modified);
        }

        private void btn_on4_Click_1(object sender, EventArgs e)
        {
            Button_SendData("4ON#", pictureBox4, Properties.Resources.LED_ON_modified);
        }

        private void btn_on5_Click_1(object sender, EventArgs e)
        {
            Button_SendData("5ON#", pictureBox5, Properties.Resources.LED_ON_modified);
        }

        private void btn_on6_Click_1(object sender, EventArgs e)
        {
            Button_SendData("6ON#", pictureBox6, Properties.Resources.LED_ON_modified);
        }

        private void btn_on7_Click_1(object sender, EventArgs e)
        {
            Button_SendData("7ON#", pictureBox7, Properties.Resources.LED_ON_modified);
        }

        private void btn_on8_Click(object sender, EventArgs e)
        {
            Button_SendData("8ON#", pictureBox8, Properties.Resources.LED_ON_modified);
        }

        private void btn_on9_Click(object sender, EventArgs e)
        {
            Button_SendData("9ON#", pictureBox9, Properties.Resources.LED_ON_modified);
        }

        private void btn_on10_Click(object sender, EventArgs e)
        {
            Button_SendData("10ON#", pictureBox10, Properties.Resources.LED_ON_modified);
        }

        private void btn_on11_Click(object sender, EventArgs e)
        {
            Button_SendData("11ON#", pictureBox11, Properties.Resources.LED_ON_modified);
        }

        private void btn_on12_Click(object sender, EventArgs e)
        {
            Button_SendData("12ON#", pictureBox12, Properties.Resources.LED_ON_modified);
        }

        private void btn_off3_Click_1(object sender, EventArgs e)
        {
            Button_SendData("3OFF#", pictureBox3, Properties.Resources.LED_OFF_modified);
        }

        private void btn_off4_Click_1(object sender, EventArgs e)
        {
            Button_SendData("4OFF#", pictureBox4, Properties.Resources.LED_OFF_modified);
        }

        private void btn_off5_Click_1(object sender, EventArgs e)
        {
            Button_SendData("5OFF#", pictureBox5, Properties.Resources.LED_OFF_modified);
        }

        private void btn_off6_Click_1(object sender, EventArgs e)
        {
            Button_SendData("6OFF#", pictureBox6, Properties.Resources.LED_OFF_modified);
        }

        private void btn_off7_Click_1(object sender, EventArgs e)
        {
            Button_SendData("7OFF#", pictureBox7, Properties.Resources.LED_OFF_modified);
        }

        private void btn_off8_Click(object sender, EventArgs e)
        {
            Button_SendData("8OFF#", pictureBox8, Properties.Resources.LED_OFF_modified);
        }

        private void btn_off9_Click(object sender, EventArgs e)
        {
            Button_SendData("9OFF#", pictureBox9, Properties.Resources.LED_OFF_modified);
        }

        private void btn_off10_Click(object sender, EventArgs e)
        {
            Button_SendData("10OFF#", pictureBox10, Properties.Resources.LED_OFF_modified);
        }

        private void btn_off11_Click(object sender, EventArgs e)
        {
            Button_SendData("11OFF#", pictureBox11, Properties.Resources.LED_OFF_modified);
        }

        private void btn_off12_Click(object sender, EventArgs e)
        {
            Button_SendData("12OFF#", pictureBox12, Properties.Resources.LED_OFF_modified);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("7P#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_patternsEnable_Click(object sender, EventArgs e)
        {
            PatternButtonControl(true);
            LEDButtonControl(false);
            pb_Connect2.Value = 100;
        }

        private async void btn_pattern1_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("1P#");

                    

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_pattern2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("2P#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_pattern3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("3P#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_pattern4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("4P#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_pattern5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("5P#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_pattern6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("6P#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_pattern8_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("8P#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btn_pattern9_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Write("9P#");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
