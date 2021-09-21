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

namespace PartialProject1
{
    public partial class Form1 : Form
    {

        // Variable global para contador del timer.
        int tmrCount = 0;

        public Form1()
        {
            InitializeComponent();
            //Iniciamos apagando los groupBox
            gbDigitalData.Enabled = false;
            gbAnalogData.Enabled = false;
            gbCounter.Enabled = false;
            gbSendingOptions.Enabled = false;
            btnConnect.Enabled = false;
            btnSend.Enabled = false;
            btnPauseCounter.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Cierra la ventana
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Revisa si el radio button de Digital está activo
            if (rbDigital.Checked)
            {
                // Convierte los checkboxes seleccionados a decimal
                int result = 0;
                if (cbDigitalData0.Checked) result += 1;
                if (cbDigitalData1.Checked) result += 2;
                if (cbDigitalData2.Checked) result += 4;
                if (cbDigitalData3.Checked) result += 8;
                if (cbDigitalData4.Checked) result += 16;
                if (cbDigitalData5.Checked) result += 32;
                if (cbDigitalData6.Checked) result += 64;

                // Convierto a char
                char charValue = Convert.ToChar(result);

                // Se actualiza el display
                updateDisplays(result);

                try
                {
                    // Se intenta mandar al puerto seleccionado previamente
                    spSerialPort.Write(Convert.ToString(charValue));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    throw;
                }
            }
            // Revisa si el radio button de Analógico está activo.
            else if (rbAnalog.Checked)
            {
                // Convierto a char
                char charValue = Convert.ToChar(tbAnalogData.Value);

                // Se actualiza el display
                updateDisplays(tbAnalogData.Value);

                try
                {
                    // Se intenta mandar al puerto seleccionado previamente
                    spSerialPort.Write(Convert.ToString(charValue));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    throw;
                }

            }
        }

        // Actualiza y enlista los puertos disponibles
        private void btnScanPorts_Click(object sender, EventArgs e)
        {
            // Obtiene los puertos disponibles y los guarda en un array
            string[] puertosDisponibles = SerialPort.GetPortNames();
            cbPortsList.Items.Clear();

            // Añade los puertos como opciones al combobox
            foreach (string puerto in puertosDisponibles)
            {
                cbPortsList.Items.Add(puerto);
            }

            // Si hay puertos, selecciona la posición 0 y habilita el botón de conectar
            if (cbPortsList.Items.Count > 0)
            {
                cbPortsList.SelectedIndex = 0;
                btnConnect.Enabled = true;
            }
        }

        // Conectar al puerto
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Configura el puerto serial si el botón "Connect" está activo
                if (btnConnect.Text == "Connec&t")
                {
                    // Seleccionamos el Baudrate de 9600 para la comunicación.
                    spSerialPort.BaudRate = 9600;
                    spSerialPort.DataBits = 8;
                    spSerialPort.Parity = Parity.None;
                    spSerialPort.StopBits = StopBits.One;
                    spSerialPort.Handshake = Handshake.None;
                    spSerialPort.PortName = cbPortsList.Text;

                    // Intenta abrir una comunicación serial con el puerto seleccionado
                    // y habilita el groupbox de opciones
                    try
                    {
                        spSerialPort.Open();
                        btnConnect.Text = "Discon&nect";
                        btnSend.Enabled = true;
                        cbPortsList.Enabled = false;
                        gbSendingOptions.Enabled = true;
                        btnScanPorts.Enabled = false;
                        enableGroupBox();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                // Cierra la comunicación serial si el botón de "Disconnect" está activo
                // y deshabilita el groupbox de opciones
                else if (btnConnect.Text == "Discon&nect")
                {
                    spSerialPort.Close();
                    btnConnect.Text = "Connec&t";
                    btnSend.Enabled = false;
                    //cboBaudrate.Enabled = true;
                    cbPortsList.Enabled = true;
                    gbSendingOptions.Enabled = false;
                    btnScanPorts.Enabled = true;
                    gbDigitalData.Enabled = false;
                    gbAnalogData.Enabled = false;
                    gbCounter.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // Escucha los cambios en el groupbox de las opciones
        private void btOpDiAnCo_CheckedChanged(object sender, EventArgs e)
        {
            enableGroupBox();
        }

        // Actualiza el display con el valor enviado por parámetro
        private void updateDisplays(int updateValue)
        {
            // Actualiza el label al valor decimal
            lbDataSentDisplay.Text = updateValue.ToString();
            // Actualiza el progressbar
            pbDataSentDisplay.Value = updateValue;

            // Convierte el valor decimal a binario por medio de restas
            // y actualiza la visibilidad del bit cambiando los colores
            if(updateValue > 63)
            {
                btnDisplay6.BackColor = Color.Blue;
                updateValue -= 64;
            } 
            else btnDisplay6.BackColor = Color.SlateGray;
            if (updateValue > 31)
            {
                btnDisplay5.BackColor = Color.Blue;
                updateValue -= 32;
            }
            else btnDisplay5.BackColor = Color.SlateGray;
            if (updateValue > 15)
            {
                btnDisplay4.BackColor = Color.Blue;
                updateValue -= 16;
            }
            else btnDisplay4.BackColor = Color.SlateGray;
            if (updateValue > 7)
            {
                btnDisplay3.BackColor = Color.Blue;
                updateValue -= 8;
            }
            else btnDisplay3.BackColor = Color.SlateGray;
            if (updateValue > 3)
            {
                btnDisplay2.BackColor = Color.Blue;
                updateValue -= 4;
            }
            else btnDisplay2.BackColor = Color.SlateGray;
            if (updateValue > 1)
            {
                btnDisplay1.BackColor = Color.Blue;
                updateValue -= 2;
            }
            else btnDisplay1.BackColor = Color.SlateGray;
            if (updateValue > 0)
            {
                btnDisplay0.BackColor = Color.Blue;
                updateValue -= 1;
            }
            else btnDisplay0.BackColor = Color.SlateGray;
        }

        // Habilita el groupbox que se haya seleccionado en el groupbox de opciones
        private void enableGroupBox() 
        {
            if (rbDigital.Checked)
            {
                gbDigitalData.Enabled = true;
                gbAnalogData.Enabled = false;
                gbCounter.Enabled = false;
                btnSend.Enabled = true;
            }
            else if (rbAnalog.Checked)
            {
                gbDigitalData.Enabled = false;
                gbAnalogData.Enabled = true;
                gbCounter.Enabled = false;
                btnSend.Enabled = true;
            }
            else if (rbCounter.Checked)
            {
                gbDigitalData.Enabled = false;
                gbAnalogData.Enabled = false;
                gbCounter.Enabled = true;
                btnSend.Enabled = false;
            }
        }

        // Marca todos los checkboxes que de los bits
        private void btnSetAll_Click(object sender, EventArgs e)
        {
            cbDigitalData0.Checked = true;
            cbDigitalData1.Checked = true;
            cbDigitalData2.Checked = true;
            cbDigitalData3.Checked = true;
            cbDigitalData4.Checked = true;
            cbDigitalData5.Checked = true;
            cbDigitalData6.Checked = true;
        }

        // Desmarca todos los checkboxes que de los bits
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            cbDigitalData0.Checked = false;
            cbDigitalData1.Checked = false;
            cbDigitalData2.Checked = false;
            cbDigitalData3.Checked = false;
            cbDigitalData4.Checked = false;
            cbDigitalData5.Checked = false;
            cbDigitalData6.Checked = false;
        }

        // Actualiza el valor del scrollbar analógico al label
        private void tbAnalogData_Scroll(object sender, EventArgs e)
        {
            lbAnalogDataDisplay.Text = (tbAnalogData.Value).ToString();
        }

        // Actualiza el valor del scrollbar del contador al label
        private void sbCounter_Scroll(object sender, ScrollEventArgs e)
        {
            lbCounterDisplay.Text = (sbCounter.Value*10).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Actualiza el valor de la variable global a 0 y actualiza el display (sin enviar datos) 
        private void btnResetCounter_Click(object sender, EventArgs e)
        {
            tmrCount = 0;
            updateDisplays(tmrCount);
        }

        // Inicia el timer (habilita) con su intervalo obtenido de su correspondiente label
        private void btnPlayCounter_Click(object sender, EventArgs e)
        {
            btnPauseCounter.Enabled = true;
            int counter = int.Parse(lbCounterDisplay.Text);
            sbCounter.Enabled = false;
            btnResetCounter.Enabled = false;

            tmrCounter.Interval = counter;
            tmrCounter.Enabled = true;
        }

        // Pausa el timer (deshabilita)
        private void btnPauseCounter_Click(object sender, EventArgs e)
        {
            tmrCounter.Enabled = false;
            btnResetCounter.Enabled = true;
            sbCounter.Enabled = true;
            btnPauseCounter.Enabled = false;
        }

        // Por cada intervalo que pasa se actualiza el display
        // y se intenta enviar el dato por el puerto serial
        private void tmrCounter_Tick(object sender, EventArgs e)
        {
            // Convierto a char
            char charValue = Convert.ToChar(tmrCount);

            // Actualiza display
            updateDisplays(tmrCount);

            try
            {
                // Se intenta mandar al puerto seleccionado previamente
                spSerialPort.Write(Convert.ToString(charValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }

            // Si el contador llegó a su valor máximo lo regresa a 0 y pausa el timer
            if (tmrCount > 126)
            {
                tmrCount = 0;
                tmrCounter.Enabled = false;
                btnPlayCounter.Enabled = true;
                btnPauseCounter.Enabled = false;
                sbCounter.Enabled = true;
            }
            // Incrementa el contador global
            else
            {
                tmrCount++;
            }
        }
    }
}
