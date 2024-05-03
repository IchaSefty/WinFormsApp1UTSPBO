using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1UTSPBO
{
    public partial class Loginmhs : Form
    {
        public int Nomor_Identitas { get; set; }
        public string Password { get; set; }
        public Loginmhs()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepagemhs homepagemhs = new Homepagemhs();
            homepagemhs.Show();
        }
    }
}
