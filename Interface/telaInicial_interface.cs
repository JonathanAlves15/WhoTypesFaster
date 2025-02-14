using Controles;

namespace Interface
{
    public partial class telaInicial_interface : Form
    {
        private Client cliente;
        private servidor_ip ipForm;
        public string serverIp;
        private arena_interface gameForm;
        private loading_interface loadingForm;

        public telaInicial_interface()
        {
            InitializeComponent();
            this.ipForm = new servidor_ip(this);
            this.cliente = new Client();
            this.cliente.OnMessageReceived += HandleServerMessage;
        }

        private void HandleServerMessage(string message)
        {
            if (message.StartsWith("START|"))
            {
                string receivedText = message.Split('|')[1];
                this.Invoke((MethodInvoker)delegate
                {
                    StartGame(receivedText);
                });
            }

            else if (message == "WIN")
            {
                MessageBox.Show("Você venceu :)");
                this.gameForm.Close();
            }

            else if (message == "LOSE")
            {
                MessageBox.Show("Você perdeu :(");
                this.gameForm.Close();
            }

            else if (message == "OPPONENT_DISCONNECTED")
            {
                MessageBox.Show("O outro jogador desconectou B)");
                this.gameForm.Close();
            }
        }


        private void StartGame(string text)
        {
            this.gameForm = new arena_interface(text, cliente, this);
            this.loadingForm.Hide();
            this.Hide();
            this.gameForm.Show();
        }

        private void JoinByIp_Click(object sender, EventArgs e)
        {
            this.ipForm.ShowDialog();
            if (this.serverIp != null)
            {
                this.cliente.Connect(serverIp, 5000);
                this.Hide();
                this.loadingForm = new loading_interface(this.cliente, this);
                this.loadingForm.Show();
            }
        }
    }
}
