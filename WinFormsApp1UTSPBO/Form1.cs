namespace WinFormsApp1UTSPBO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }*/

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
            
                Form2 form2 = new Form2();
                form2.Show();
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            
                RegisterDosen Registerdosen = new RegisterDosen();
                Registerdosen.Show();
            
        }
    }
}
