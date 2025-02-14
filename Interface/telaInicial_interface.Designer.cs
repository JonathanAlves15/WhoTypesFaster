using Controles;

namespace Interface
{
    partial class telaInicial_interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            join_btn = new Button();
            JoinByIp = new Button();
            SuspendLayout();
            // 
            // join_btn
            // 
            join_btn.Location = new Point(314, 175);
            join_btn.Name = "join_btn";
            join_btn.Size = new Size(158, 29);
            join_btn.TabIndex = 1;
            join_btn.Text = "Encontrar servidor";
            join_btn.UseVisualStyleBackColor = true;
            join_btn.Click += join_btn_Click;
            // 
            // JoinByIp
            // 
            JoinByIp.Location = new Point(314, 140);
            JoinByIp.Name = "JoinByIp";
            JoinByIp.Size = new Size(158, 29);
            JoinByIp.TabIndex = 2;
            JoinByIp.Text = "Conectar-se por IP";
            JoinByIp.UseVisualStyleBackColor = true;
            JoinByIp.Click += JoinByIp_Click;
            // 
            // telaInicial_interface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 398);
            Controls.Add(JoinByIp);
            Controls.Add(join_btn);
            Name = "telaInicial_interface";
            Text = "Tela Inicial";
            ResumeLayout(false);
        }

        #endregion
        private Button join_btn;
        private Button JoinByIp;
    }
}
