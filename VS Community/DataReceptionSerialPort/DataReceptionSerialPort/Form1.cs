using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataReceptionSerialPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (serialPort.IsOpen)
            {
                serialPort.Open();
                tbRX.Text = "Port Opened :)";
            }
            else
            {
                tbRX.Text = "Port busy or not connected :/";
            }
        }

        private string rxString;
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            rxString = serialPort.ReadExisting();
            this.Invoke(new EventHandler(displayText));
        }

        private void displayText(object sender, EventArgs e)
        {
            tbRX.AppendText(rxString);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            serialPort.Write(tbRX.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbTX.Clear();
            tbRX.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }

        private void tbTX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (serialPort.IsOpen && cbIM.Checked)
            {
                char[] ch = new char[1];
                ch[0] = e.KeyChar;
                serialPort.Write(ch, 0, 1);
            }
        }
    }
}
