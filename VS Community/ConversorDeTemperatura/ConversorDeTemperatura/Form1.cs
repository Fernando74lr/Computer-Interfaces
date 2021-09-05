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

        private void ctGradosF_KeyPress(object sender, EventArgs e)
        {
            objTextBox = (TextBox)sender;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                // Sí se escribió en la caja de texto de grados centígrados.
                if (objTextBox == ctGradosC)
                {
                    grados = Convert.ToDouble(ctGradosC.Text) * 9.0 / 5.0 + 32.0;
                    // Mostrar el resultado redondeado a dos decimales
                    ctGradosF.Text = string.Format("{0:F2}", grados);
                }

                // Si se escribió en la caja de texto grados Fahrenheit.
                if (objTextBox == ctGradosF)
                {
                    grados = (Convert.ToDouble(ctGradosF.Text) - 32.0)*5.0 / 9.0;
                    // Mostrar el resultado redondeado a dos decimales
                    ctGradosC.Text = string.Format("{0:F2", grados);
                }
            }
            catch(FormatException)
            {
                ctGradosC.Text = "0.00";
                ctGradosF.Text = "32.00";
            }
        }

        private void ctGradosC_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
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
    }
}
