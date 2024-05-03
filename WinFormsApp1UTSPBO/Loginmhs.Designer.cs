namespace WinFormsApp1UTSPBO
{
    partial class Loginmhs
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(196, 99);
            label1.Name = "label1";
            label1.Size = new Size(513, 63);
            label1.TabIndex = 0;
            label1.Text = "Login Mahasiswa";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(373, 233);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 39);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(373, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 39);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(236, 233);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 3;
            label2.Text = "NIM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 335);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(706, 512);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 5;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Loginmhs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 584);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Loginmhs";
            Text = "Loginmhs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}