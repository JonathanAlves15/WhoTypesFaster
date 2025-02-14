namespace Interface
{
    partial class loading_interface
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
            lblLoading = new Label();
            SuspendLayout();
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Location = new Point(109, 21);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(185, 20);
            lblLoading.TabIndex = 0;
            lblLoading.Text = "Esperando outro jogador...";
            // 
            // loading_interface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 68);
            Controls.Add(lblLoading);
            Name = "loading_interface";
            Text = "loading_interface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoading;
    }
}