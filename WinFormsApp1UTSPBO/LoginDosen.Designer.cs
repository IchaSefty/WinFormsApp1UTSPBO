namespace WinFormsApp1UTSPBO
{
    partial class LoginDosen
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 78);
            label1.Name = "label1";
            label1.Size = new Size(368, 63);
            label1.TabIndex = 0;
            label1.Text = "Login Dosen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 202);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 1;
            label2.Text = "Nomor Identitas";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 302);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(385, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(385, 288);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 39);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 275);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(189, 295);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(742, 444);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 7;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LoginDosen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 512);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginDosen";
            Text = "LoginDosen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}