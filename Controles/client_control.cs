using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Controles
{
    public class ClientControl
    {
        public TcpClient Client;
        public Stream Stream;
        public Thread ThreadMensagens;

        public event Action<string> MensagemRecebida;

        public void ConectarServidor(string ip, int port)
        {
            try
            {
                this.Client = new TcpClient(ip, port);
                this.Stream = this.Client.GetStream();

                this.ThreadMensagens = new Thread(ReceberMensagem);
                this.ThreadMensagens.Start();
            }
            catch(Exception ex) 
            {
                throw new Exception("Erro ao conectar-se ao servidor: " + ex);
            }
        }

        public void EnviarMensagem(string mensagem) {
            if (this.Client.Connected) {
                try
                {
                    byte[] dadosEnvio = Encoding.UTF8.GetBytes(mensagem);
                    this.Stream.Write(dadosEnvio, 0, dadosEnvio.Length);
                }
                catch(Exception ex)
                {
                    Desconectar();
                    throw new Exception("Falha ao enviar mensagem ao servidor: " + ex);
                }
            }
        }

        private void ReceberMensagem() {
            try
            {
                while (this.Client.Connected)
                {
                    byte[] dadosRecebidos = new byte[1024];
                    int bytesLidos = this.Stream.Read(dadosRecebidos, 0, dadosRecebidos.Length);
                    if (bytesLidos == 0) break; // Conexão fechada pelo servidor

                    string mensagem = Encoding.UTF8.GetString(dadosRecebidos, 0, bytesLidos);

                    // Notifica a interface gráfica se necessário
                    MensagemRecebida?.Invoke(mensagem);
                }
            }
            catch (IOException ex)
            {
                return;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro geral ao receber mensagem: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void Desconectar() {
            if (this.Client.Connected)
            {
                this.Stream.Close();
                this.Client.Close();
                this.ThreadMensagens.Join();
            }
        }
    }
}
