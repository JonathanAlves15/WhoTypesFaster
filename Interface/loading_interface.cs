using Controles;

namespace Interface
{
    public partial class loading_interface : Form
    {
        Client client;
        telaInicial_interface telaInicial;
        public loading_interface(Client client, telaInicial_interface telaInicial)
        {
            InitializeComponent();
            this.telaInicial = telaInicial;
            this.client = client;
        }

        private void loading_interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Desconectar();
            telaInicial.Show();
        }
    }
}
