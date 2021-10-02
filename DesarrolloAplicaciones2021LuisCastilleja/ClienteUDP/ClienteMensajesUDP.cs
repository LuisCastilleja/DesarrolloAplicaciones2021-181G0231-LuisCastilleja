using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClienteUDP
{
   public class ClienteMensajesUDP
    {
        UdpClient cliente;
        public event Action<string> MensajeNormalEnviado, MensajeAlertaEnviado, MensajeAdvertenciaEnviado;
        public void Iniciar()
        {

            Task.Run(() =>
            {
                try
                {

                    IPEndPoint ip = new IPEndPoint(IPAddress.Any, 4700);
                    cliente = new UdpClient();
                    cliente.EnableBroadcast = true;
                    cliente.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    cliente.Client.Bind(new IPEndPoint(IPAddress.Any, 4700));

                    while (true)
                    {
                        byte[] buffer = cliente.Receive(ref ip);
                        string datos = Encoding.UTF8.GetString(buffer, 0, buffer.Length);
                        var mensaje = datos.Split('|');

                        if (mensaje[1] == "Normal")
                        {
                            MensajeNormalEnviado(mensaje[0]);
                        }
                        else if (mensaje[1] == "Alerta")
                        {
                            MensajeAlertaEnviado(mensaje[0]);
                        }
                        else
                        {
                            MensajeAdvertenciaEnviado(mensaje[0]);
                        }
                    }
                }
                catch (SocketException)
                {

                }
            });
        }
    }
}
