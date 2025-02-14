using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Controles
{
    public class Client
    {
        private TcpClient cliente;
        private NetworkStream stream;
        private Thread receiveThread;
        private UdpClient udpClient;
        public event Action<string> OnMessageReceived;

        public void Connect(string ip, int port)
        {
            try
            {
                this.cliente = new TcpClient(ip, port);
                this.stream = cliente.GetStream();
                this.receiveThread = new Thread(ReceiveData);
                this.receiveThread.Start();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao servidor: " + ex);
            }
        }

        public void DiscoverServer()
        {
            udpClient = new UdpClient(0);
            udpClient.EnableBroadcast = true;
            Thread receiveThread = new Thread(ReceiveBroadcast);
            receiveThread.Start();
        }

        private void ReceiveBroadcast()
        {
            IPEndPoint remoteEP = new IPEndPoint(IPAddress.Any, 5001);

            while (true)
            {
                try
                {
                    byte[] data = udpClient.Receive(ref remoteEP);
                    string message = Encoding.UTF8.GetString(data);
                    if (message.StartsWith("SERVER_DISCOVERY|"))
                    {
                        string[] parts = message.Split('|');
                        string serverIp = parts[1];
                        int serverPort = int.Parse(parts[2]);
                        Connect(serverIp, serverPort);
                        return;
                    }
                }
                catch (Exception ex) 
                {
                    throw new Exception("Erro ao receber mensagem broadcast: " + ex);
                }
            }
        }

        private void ReceiveData()
        {
            byte[] buffer = new byte[1024];
            try
            {
                while (this.cliente.Connected)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    OnMessageReceived?.Invoke(message);
                }
            }
            catch (IOException ex)
            {
                return;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao receber mensagem: " + ex);
            }
            finally 
            {
                Desconectar();
            }
        }

        public void SendMessage(string message)
        {
            try
            {
                if (this.cliente.Connected)
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex) 
            {
                throw new Exception("Erro ao enviar mensagem: " + ex);
            }
        }

        public void Desconectar()
        {
            if (this.cliente.Connected)
            {
                this.stream.Close();
                this.cliente.Close();
            }
        }
    }
}
