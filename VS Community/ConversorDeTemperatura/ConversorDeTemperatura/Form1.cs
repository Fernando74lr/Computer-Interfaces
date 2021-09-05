using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorDeTemperatura
{
    public partial class converterTemp : Form
    {
        private TextBox objTextBox = null;

        public converterTemp()
        {
            InitializeComponent();
        }

        private void Conversion(object sender)
        {
            objTextBox = (TextBox)sender;

            try
            {
                double grados;
                // Sí se escribió en la caja de texto de grados centígrados.
                if (objTextBox == ctGradosC)
                {
                    grados = Convert.ToDouble(ctGradosC.Text) * 9.0 / 5.0 + 32.0;
                    // Mostrar el resultado redondeado a dos decimales.
                    ctGradosF.Text = string.Format("{0:F2}", grados);
                }

                // Si se escribió en la caja de texto grados Fahrenheit.
                if (objTextBox == ctGradosF)
                {
                    grados = (Convert.ToDouble(ctGradosF.Text) - 32.0)*5.0 / 9.0;
                    // Mostrar el resultado redondeado a dos decimales.
                    ctGradosC.Text = string.Format("{0:F2}", grados);
                }
            }
            catch(FormatException)
            {
                ctGradosC.Text = "0.00";
                ctGradosF.Text = "32.00";
            }
        }

        private void converterTemp_Load(object sender, EventArgs e)
        {
            ctGradosC.Select();
        }

        private void CajaTexto_Enter(object sender, EventArgs e)
        {
            objTextBox = (TextBox)sender;
            objTextBox.SelectAll();
        }

        private void CajaTexto_MouseClick(object sender, MouseEventArgs e)
        {
            objTextBox = (TextBox)sender;
            objTextBox.SelectAll();
        }

        private void CajaTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se pulsó la tecla "Enter", realiza operación.
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true;
                Conversion(sender);
            }
            // Se pulsó la tecla "ESC", cierra la aplicación.
            else if(e.KeyChar  == Convert.ToChar(Keys.Escape))
            {
                this.Close();
            }
            // Se pulsó la tecla "Retroceso".
            else if(e.KeyChar == Convert.ToChar(8))
            {
                e.Handled = false;
            }
            // Se presionó la tecla "Coma".
            else if(e.KeyChar == ',')
            {
                objTextBox = (TextBox)sender;
                if (objTextBox.Text.IndexOf(',') != -1)
                {
                    // Sólo puede haber una coma.
                    e.Handled = true;
                }
            }
            // Se presionó la tecla '-' o '+'.
            else if(e.KeyChar == '-' || e.KeyChar == '+')
            {
                objTextBox = (TextBox)sender;

                // Admitir '-' o '+' sólo en la primera posición.
                if (objTextBox.SelectionLength == objTextBox.TextLength)
                {
                    // Todo el texto está seleccionado: se sobreescribe con el signo.
                    e.Handled = false;
                }
                else if (objTextBox.TextLength != 0)
                {
                    // La primera posición ya está ocupada.
                    e.Handled = true;
                }
            }
            // Se presionó un caractér del '0' al '9'.
            else if(e.KeyChar < '0' || e.KeyChar > '9')
            {
                // Desechar los caracteres que no son dígitos.
                e.Handled = true;
            }
        }

        private void control_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void control_KeyDown(object sender, KeyEventArgs e)
        {
            // Si se pulsó (Alt | Ctrl | Shift) + F1...
            if (e.KeyCode == Keys.F1 && (e.Alt || e.Control || e.Shift))
            {
                // ...
            }
            // Si se pulsó Alt + F2...
            else if (e.KeyCode == Keys.F2 && e.Modifiers == Keys.Alt)
            {
                // ...
            }
        }
    }
}
