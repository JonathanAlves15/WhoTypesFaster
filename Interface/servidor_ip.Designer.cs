namespace Interface
{
    partial class servidor_ip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ConectarBtn = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // ConectarBtn
            // 
            ConectarBtn.Location = new Point(143, 12);
            ConectarBtn.Name = "ConectarBtn";
            ConectarBtn.Size = new Size(94, 29);
            ConectarBtn.TabIndex = 1;
            ConectarBtn.Text = "Conectar";
            ConectarBtn.UseVisualStyleBackColor = true;
            ConectarBtn.Click += ConectarBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // servidor_ip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 57);
            Controls.Add(textBox1);
            Controls.Add(ConectarBtn);
            Name = "servidor_ip";
            Text = "servidor_ip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConectarBtn;
        private TextBox textBox1;
    }
}