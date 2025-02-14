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
            components = new System.ComponentModel.Container();
            PlayerOneRtb = new RichTextBox();
            TextToWriteLbl = new Label();
            CountDown = new System.Windows.Forms.Timer(components);
            TimerLbl = new Label();
            SuspendLayout();
            // 
            // PlayerOneRtb
            // 
            PlayerOneRtb.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerOneRtb.Location = new Point(14, 218);
            PlayerOneRtb.Name = "PlayerOneRtb";
            PlayerOneRtb.Size = new Size(710, 214);
            PlayerOneRtb.TabIndex = 1;
            PlayerOneRtb.Text = "";
            PlayerOneRtb.TextChanged += PlayerOneRtb_TextChanged;
            // 
            // TextToWriteLbl
            // 
            TextToWriteLbl.AutoEllipsis = true;
            TextToWriteLbl.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextToWriteLbl.Location = new Point(14, 9);
            TextToWriteLbl.Name = "TextToWriteLbl";
            TextToWriteLbl.Size = new Size(711, 207);
            TextToWriteLbl.TabIndex = 3;
            TextToWriteLbl.Text = "Teste";
            // 
            // CountDown
            // 
            CountDown.Interval = 1000;
            CountDown.Tick += CountDown_Tick;
            // 
            // TimerLbl
            // 
            TimerLbl.AutoSize = true;
            TimerLbl.Font = new Font("Arial", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerLbl.Location = new Point(320, 74);
            TimerLbl.Name = "TimerLbl";
            TimerLbl.Size = new Size(82, 89);
            TimerLbl.TabIndex = 4;
            TimerLbl.Text = "3";
            // 
            // arena_interface
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 444);
            Controls.Add(TimerLbl);
            Controls.Add(TextToWriteLbl);
            Controls.Add(PlayerOneRtb);
            Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "arena_interface";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += arena_interface_FormClosing;
            Load += arena_interface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox PlayerOneRtb;
        private Label TextToWriteLbl;
        private System.Windows.Forms.Timer CountDown;
        private Label TimerLbl;
    }
}