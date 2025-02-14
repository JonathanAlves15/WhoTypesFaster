using Controles;

namespace Interface
{
    public partial class telaInicial_interface : Form
    {
        private Client cliente;
        private loading_interface loadingForm = new loading_interface();
        private servidor_ip ipForm;
        public string serverIp;
        private arena_interface gameForm;

        public telaInicial_interface()
        {
            InitializeComponent();
            this.ipForm = new servidor_ip(this);
            cliente = new Client();
            cliente.OnMessageReceived += HandleServerMessage;
        }

        private void host_btn_Click(object sender, EventArgs e)
        {

        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            //cliente.DiscoverServer();
            //this.Hide();
            //loadingForm.Show();
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
                gameForm.Close();
            }

            else if (message == "LOSE")
            {
                MessageBox.Show("Você perdeu :(");
                gameForm.Close();
            }
        }

        private void StartGame(string text)
        {
            gameForm = new arena_interface(text, cliente, this);
            loadingForm.Hide();
            this.Hide();
            gameForm.Show();
        }

        private void JoinByIp_Click(object sender, EventArgs e)
        {
            ipForm.ShowDialog();
            cliente.Connect(serverIp, 5000);
            this.Hide();
            loadingForm.Show();
        }
    }
}
