namespace Proj2
{
    public partial class Form1 : Form
    {
        public static Form1 Instance2;
        public string TextBox3;
        public Form1()
        {
            InitializeComponent();
            Instance2 = this;
            TextBox3 = textBox3.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();

        }

        public void button2_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { 
        }
    }
}
