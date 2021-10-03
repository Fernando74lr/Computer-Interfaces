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

namespace SerialPortTXRXbytes
{
    public partial class Form1 : Form
    {
        // Almacenará # total de bytes recibidos
        int serialBytesToRead = 0;
        // Buffer para almacenar los bytes recibidos
        byte[] byteFrame = new byte[64];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "&Connect")
            {
                spSerialPort.PortName = tbPort.Text;
                spSerialPort.Open();
                btnConnect.Text = "Dis&connect";
                tbPort.Enabled = false;
                tbValueToSend.Enabled = true;
            }
            else
            {
                spSerialPort.Close();
                tbPort.Enabled = true;
                btnConnect.Text = "&Connect";
                tbValueToSend.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] byteToSend = new byte[1];
            byteToSend[0] = (byte)Convert.ToInt32(tbValueToSend.Text);
            spSerialPort.Write(byteToSend, 0, 1);
        }

        private void spSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialBytesToRead = spSerialPort.BytesToRead;

            for (int i=0; i < serialBytesToRead; i++)
            {
                byteFrame[i] = (byte)spSerialPort.ReadByte();
            }
            this.Invoke(new EventHandler(displayDataReceived));
        }

        private void displayDataReceived(object o, EventArgs e)
        {
            for (int i=0; i < serialBytesToRead; i++)
            {
                tbReceivedValue.Text = Convert.ToString(byteFrame[i]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            spSerialPort.Close();
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            spSerialPort.Close();
        }
    }
}
