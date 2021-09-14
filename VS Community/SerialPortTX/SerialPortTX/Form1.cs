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

namespace SerialPortTX
{
    public partial class Form1 : Form
    {

        // Cadena de texto para enviar
        private string strBufferOut;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            strBufferOut = "";
            btnSend.Enabled = false;
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchPorts_Click(object sender, EventArgs e)
        {
            string[] puertosDisponibles = SerialPort.GetPortNames();
            cboPorts.Items.Clear();

            foreach (string puerto in puertosDisponibles)
            {
                cboPorts.Items.Add(puerto);
            }

            if (cboPorts.Items.Count > 0)
            {
                cboPorts.SelectedIndex = 3;
                btnConnect.Enabled = true;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConnect.Text == "Conectar")
                {
                    spSerialPort.BaudRate = Int32.Parse(cboBaudrate.Text);
                    spSerialPort.DataBits = 8;
                    spSerialPort.Parity = Parity.None;
                    spSerialPort.StopBits = StopBits.One;
                    spSerialPort.Handshake = Handshake.None;
                    spSerialPort.PortName = cboPorts.Text;

                    try
                    {
                        spSerialPort.Open();
                        btnConnect.Text = "Desconectar";
                        btnSend.Enabled = true;
                        cboPorts.Enabled = false;
                        cboBaudrate.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else if (btnConnect.Text == "Desconectar")
                {
                    spSerialPort.Close();
                    btnConnect.Text = "Conectar";
                    btnSend.Enabled = false;
                    cboBaudrate.Enabled = true;
                    cboPorts.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cboBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
