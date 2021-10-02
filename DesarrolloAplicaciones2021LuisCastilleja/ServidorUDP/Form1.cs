using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorUDP
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        ServidorMensajesUDP servidor = new ServidorMensajesUDP();
        
        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbMensaje.Text) && cmbTipoMensaje.SelectedIndex >= 0)
            {
                servidor.Enviar(rtbMensaje.Text, cmbTipoMensaje.Text);
            }
            else if (string.IsNullOrWhiteSpace(rtbMensaje.Text))
            {
                MessageBox.Show("Escriba el mensaje que desea enviar");
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de mensaje que desea enviar");
            }
        }
     
    }
}
