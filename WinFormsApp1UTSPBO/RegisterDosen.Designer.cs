﻿namespace WinFormsApp1UTSPBO
{
    partial class RegisterDosen
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(226, 61);
            label1.Name = "label1";
            label1.Size = new Size(470, 63);
            label1.TabIndex = 0;
            label1.Text = "Register Dosen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 165);
            label2.Name = "label2";
            label2.Size = new Size(77, 32);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 221);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 283);
            label4.Name = "label4";
            label4.Size = new Size(187, 32);
            label4.TabIndex = 3;
            label4.Text = "Nomor Identitas";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 352);
            label5.Name = "label5";
            label5.Size = new Size(84, 32);
            label5.TabIndex = 4;
            label5.Text = "No Hp";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 425);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(346, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 39);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(346, 221);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(350, 39);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(346, 283);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 39);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(346, 352);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(350, 39);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(346, 425);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(350, 39);
            textBox5.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(752, 474);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 11;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            // 
            // RegisterDosen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 532);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterDosen";
            Text = "RegisterDosen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}