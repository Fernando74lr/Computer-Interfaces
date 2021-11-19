using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;   

namespace ModbusMasterInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ModbusClient makeConnection()
        {
            ModbusClient modbusclient = new ModbusClient("COM9");
            modbusclient.UnitIdentifier = 1;
            modbusclient.Baudrate = 9600;
            modbusclient.Parity = System.IO.Ports.Parity.None;
            modbusclient.StopBits = System.IO.Ports.StopBits.One;
            return modbusclient;
        }

        private void btnReadInput_Click(object sender, EventArgs e)
        {
            ModbusClient modbusclient = makeConnection();
            modbusclient.Connect();

            bool[] InputStatusArray = modbusclient.ReadDiscreteInputs(0, 1);

            if (InputStatusArray[0] == true)
            {
                lblInputStatus.Text = "ON";
            } else
            {
                lblInputStatus.Text = "OFF";
            }

            modbusclient.Disconnect();
        }

        private void btnReadRegister_Click(object sender, EventArgs e)
        {
            ModbusClient modbusclient = makeConnection();
            modbusclient.Connect();

            int[] InputRegisterArray = modbusclient.ReadInputRegisters(0, 1);

            lblInputRegister.Text = InputRegisterArray[0].ToString();

            modbusclient.Disconnect();
        }
    }
}
