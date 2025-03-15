namespace Proj2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
            timer1.Tick += Update;
            timer1.Start();
        }
        private void Update(object sender, EventArgs e)
        {
            if(Data.ResultForm2 != null){ textBox3.Text = Data.ResultForm2; }
            if(Data.ResultForm3 != null){ textBox3.Text = Data.ResultForm3; }
            if(Data.ResultForm2 != null && Data.ResultForm3 != null)
            {
                int x, y;
                Int32.TryParse(Data.ResultForm2, out x);
                Int32.TryParse(Data.ResultForm3, out y);
                int Result = 0;

                Result = x + y;

                textBox3.Text = Result.ToString();
            }
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
        private void textBox3_UpdateTextBox3(object sender, EventArgs e)
        {
        }
        
        public void label2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
