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

        private void btnWriteSingleCoil_Click(object sender, EventArgs e)
        {
            ModbusClient modbusclient = makeConnection();
            modbusclient.Connect();

            bool coilValue;
            if (tbCoilValue.Text == "ON")
            {
                coilValue = false;
                tbCoilValue.Text = "OFF";
            } else
            {
                coilValue = true;
                //tbCoilValue.Text = "ON";
            }

            modbusclient.WriteSingleCoil(0, coilValue);
            modbusclient.Disconnect();
        }

        private void btnWriteSingleRegister_Click(object sender, EventArgs e)
        {
            ModbusClient modbusclient = makeConnection();
            modbusclient.Connect();

            int registerValue;
            registerValue = Convert.ToInt32(tbRegisterValue.Text);
            modbusclient.WriteSingleRegister(0, registerValue);

            modbusclient.Disconnect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Apertura de puerto
            ModbusClient modbusclient = makeConnection();
            modbusclient.Connect();

            // Lectura digital
            bool[] InputStatusArray = modbusclient.ReadDiscreteInputs(0, 1);

            if (InputStatusArray[0] == true)
                lblInputStatus.Text = "ON";
            else
                lblInputStatus.Text = "OFF";

            // Lectura analógica
            int[] InputRegisterArray = modbusclient.ReadInputRegisters(0, 1);
            lblInputRegister.Text = InputRegisterArray[0].ToString();

            // Escritura digital
            bool coilValue;
            if (tbCoilValue.Text == "ON")
            {
                coilValue = false;
                //tbCoilValue.Text = "OFF";
            }
            else
            {
                coilValue = true;
                //tbCoilValue.Text = "ON";
            }

            modbusclient.WriteSingleCoil(0, coilValue);

            // Escritura analógica
            int registerValue;
            registerValue = Convert.ToInt32(tbRegisterValue.Text);
            modbusclient.WriteSingleRegister(0, registerValue);

            // Desconexión
            modbusclient.Disconnect();
        }
    }
}
