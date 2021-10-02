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

namespace ClienteUDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cliente.MensajeNormalEnviado += Cliente_MensajeNormalEnviado;
            cliente.MensajeAlertaEnviado += Cliente_MensajeAlertaEnviado;
            cliente.MensajeAdvertenciaEnviado += Cliente_MensajeAdvertenciaEnviado;
        }

        private void Cliente_MensajeAdvertenciaEnviado(string obj)
        {
            Invoke((Action)(() =>
            {
                ntfNormal.Icon = new System.Drawing.Icon(Path.GetFullPath("../../Assets/sign-warning-icon_34355.ico"));
                ntfNormal.Text = "Notificacion de Luis Castilleja";
                ntfNormal.Visible = true;
                ntfNormal.BalloonTipText = obj;
                ntfNormal.BalloonTipTitle = "Mensaje de advertencia";
                ntfNormal.ShowBalloonTip(100);
            }));
        }
        private void Cliente_MensajeAlertaEnviado(string obj)
        {
            Invoke((Action)(() =>
            {
            ntfNormal.Icon = new System.Drawing.Icon(Path.GetFullPath("../../Assets/alert_alarm_22185.ico"));
            ntfNormal.Text = "Notificacion de Luis Castilleja";
            ntfNormal.Visible = true;
            ntfNormal.BalloonTipText = obj;
            ntfNormal.BalloonTipTitle = "Mensaje de alerta";
            ntfNormal.ShowBalloonTip(100);
            }));
        }

        private void Cliente_MensajeNormalEnviado(string obj)
        {
            Invoke((Action)(() =>
            {
                ntfNormal.Icon = new System.Drawing.Icon(Path.GetFullPath("../../Assets/inbox_envelope_message_mail_icon_193570.ico"));
                ntfNormal.Text = "Notificacion de Luis Castilleja";
                ntfNormal.Visible = true;
                ntfNormal.BalloonTipText = obj;
                ntfNormal.BalloonTipTitle = "Mensaje Normal";
                ntfNormal.ShowBalloonTip(100);
        }));
        }

        ClienteMensajesUDP cliente = new ClienteMensajesUDP();
        private void Form1_Load(object sender, EventArgs e)
        {
            cliente.Iniciar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
