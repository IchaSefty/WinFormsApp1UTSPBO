namespace WinFormsApp1UTSPBO
{
    partial class Homepagemhs
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 50);
            label1.Name = "label1";
            label1.Size = new Size(642, 63);
            label1.TabIndex = 0;
            label1.Text = "Homepage Mahasiswa";
            // 
            // Homepagemhs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 755);
            Controls.Add(label1);
            Name = "Homepagemhs";
            Text = "Homepagemhs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}