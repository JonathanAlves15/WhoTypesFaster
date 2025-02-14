using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Controles;

namespace Interface
{
    public partial class arena_interface : Form
    {
        private Client cliente;
        string gameText;
        telaInicial_interface telaInicial;
        int progress = 0;
        public arena_interface(string text, Client client, telaInicial_interface telaInical)
        {
            InitializeComponent();
            this.telaInicial = telaInical;
            this.gameText = text;
            this.cliente = client;
            this.TextToWriteLbl.Text = text;
        }

        private void AppendWithColor(RichTextBox rtb, string text, Color color) 
        {
            rtb.SelectionStart = rtb.TextLength;
            rtb.SelectionLength = 0;

            rtb.SelectionColor = color;
            rtb.AppendText(text);
            rtb.SelectionColor = rtb.ForeColor;
        }

        private void arena_interface_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.cliente.Desconectar();
            this.telaInicial.Show();
        }

        private void arena_interface_Load(object sender, EventArgs e)
        {

        }

        private void PlayerOneRtb_TextChanged(object sender, EventArgs e)
        {
            string playerProgress = this.PlayerOneRtb.Text;
            
            if (playerProgress == gameText) 
            {
                string typedText = this.PlayerOneRtb.Text;
                string message = "FINISH|" + typedText;
                cliente.SendMessage(message);
            }

            else if (playerProgress.Length > 0) {
                if (playerProgress[playerProgress.Length - 1] == gameText[progress])
                {
                    progress++;
                }
                else
                {
                    if (progress > 0)
                        progress--;

                    if(playerProgress.Length > 1)
                        playerProgress = playerProgress.Remove(playerProgress.Length - 2);
                    else
                        playerProgress = playerProgress.Remove(playerProgress.Length - 1);

                    int i = PlayerOneRtb.SelectionStart;
                    string textLeft = gameText.Replace(playerProgress, "");

                    AppendWithColor(this.PlayerOneRtb, playerProgress, Color.Black);
                    AppendWithColor(this.PlayerOneRtb, textLeft, Color.Gray);
                    PlayerOneRtb.SelectionStart = i;
                }
            }
        }

        private void RageQuitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnviarBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
