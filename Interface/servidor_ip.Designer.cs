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
            label1 = new Label();
            SuspendLayout();
            // 
            // ConectarBtn
            // 
            ConectarBtn.Location = new Point(228, 15);
            ConectarBtn.Name = "ConectarBtn";
            ConectarBtn.Size = new Size(106, 28);
            ConectarBtn.TabIndex = 1;
            ConectarBtn.Text = "Conectar";
            ConectarBtn.UseVisualStyleBackColor = true;
            ConectarBtn.Click += ConectarBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(47, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(30, 19);
            label1.TabIndex = 3;
            label1.Text = "IP:";
            // 
            // servidor_ip
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 56);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(ConectarBtn);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "servidor_ip";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ConectarBtn;
        private TextBox textBox1;
        private Label label1;
    }
}