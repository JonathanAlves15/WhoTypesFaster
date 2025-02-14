namespace Interface
{
    partial class arena_interface
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
            RageQuitBtn = new Button();
            PlayerOneRtb = new RichTextBox();
            TextToWriteLbl = new Label();
            SuspendLayout();
            // 
            // RageQuitBtn
            // 
            RageQuitBtn.Location = new Point(12, 409);
            RageQuitBtn.Name = "RageQuitBtn";
            RageQuitBtn.Size = new Size(94, 29);
            RageQuitBtn.TabIndex = 0;
            RageQuitBtn.Text = "Sair";
            RageQuitBtn.UseVisualStyleBackColor = true;
            RageQuitBtn.Click += RageQuitBtn_Click;
            // 
            // PlayerOneRtb
            // 
            PlayerOneRtb.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerOneRtb.Location = new Point(12, 178);
            PlayerOneRtb.Name = "PlayerOneRtb";
            PlayerOneRtb.Size = new Size(621, 225);
            PlayerOneRtb.TabIndex = 1;
            PlayerOneRtb.Text = "";
            PlayerOneRtb.TextChanged += PlayerOneRtb_TextChanged;
            // 
            // TextToWriteLbl
            // 
            TextToWriteLbl.AutoSize = true;
            TextToWriteLbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextToWriteLbl.Location = new Point(12, 9);
            TextToWriteLbl.Name = "TextToWriteLbl";
            TextToWriteLbl.Size = new Size(62, 23);
            TextToWriteLbl.TabIndex = 3;
            TextToWriteLbl.Text = "label1";
            // 
            // arena_interface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 450);
            Controls.Add(TextToWriteLbl);
            Controls.Add(PlayerOneRtb);
            Controls.Add(RageQuitBtn);
            Name = "arena_interface";
            Text = "Arena";
            FormClosing += arena_interface_FormClosing;
            Load += arena_interface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RageQuitBtn;
        private RichTextBox PlayerOneRtb;
        private Label TextToWriteLbl;
    }
}