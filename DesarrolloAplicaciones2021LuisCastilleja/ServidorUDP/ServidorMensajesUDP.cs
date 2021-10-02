using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServidorUDP
{
   public class ServidorMensajesUDP
    {
        UdpClient servidor = new UdpClient() { EnableBroadcast = true };

        public void Enviar(string mensaje, string tipo)
        {
            string datos = $"{mensaje}|{tipo}";
            byte[] buffer = Encoding.UTF8.GetBytes(datos);
            servidor.Send(buffer, buffer.Length, new IPEndPoint(IPAddress.Broadcast, 4700));
        }
    }
}
