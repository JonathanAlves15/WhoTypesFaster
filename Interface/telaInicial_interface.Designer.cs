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
            JoinByIp = new Button();
            Title = new Label();
            SuspendLayout();
            // 
            // JoinByIp
            // 
            JoinByIp.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            JoinByIp.Location = new Point(129, 87);
            JoinByIp.Name = "JoinByIp";
            JoinByIp.Size = new Size(158, 25);
            JoinByIp.TabIndex = 2;
            JoinByIp.Text = "Conectar-se por IP";
            JoinByIp.UseVisualStyleBackColor = true;
            JoinByIp.Click += JoinByIp_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(89, 8);
            Title.Name = "Title";
            Title.Size = new Size(256, 35);
            Title.TabIndex = 3;
            Title.Text = "Who Types Faster";
            // 
            // telaInicial_interface
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 124);
            Controls.Add(Title);
            Controls.Add(JoinByIp);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "telaInicial_interface";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button JoinByIp;
        private Label Title;
    }
}
