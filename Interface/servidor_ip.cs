﻿namespace Interface
{
    public partial class servidor_ip : Form
    {
        private telaInicial_interface telaInicial;
        public servidor_ip(telaInicial_interface telaInicial)
        {
            InitializeComponent();
            this.telaInicial = telaInicial;
        }

        private void ConectarBtn_Click(object sender, EventArgs e)
        {
            telaInicial.serverIp = textBox1.Text;
            this.Hide();
        }
    }
}
