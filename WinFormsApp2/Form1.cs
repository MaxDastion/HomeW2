namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(0, this);
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2(2, this );
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2(1, this);
            form2.Show();
            this.Hide();
        }
        
    
    }
}
