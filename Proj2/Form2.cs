using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj2
{
    public partial class Form2 : Form
    {
        public static Form2 Instance1;
        public string Result1;
        public Form2()
        {
            InitializeComponent();
            Instance1 = this;
            Result1 = label6.Text;
        }
        private Dictionary<string, string> RememberVal = new Dictionary<string, string>();

        private void Form2_Load(object sender, EventArgs e)
        {
            // COMBOBOX - ITEMS

            List<States> ListTest = new List<States>();
            ListTest.Add(new States() { ID = "0", Name = "i7" });
            ListTest.Add(new States() { ID = "1", Name = "i5" });
            ListTest.Add(new States() { ID = "2", Name = "i3" });

            RememberVal["i7"] = "3000";
            RememberVal["i5"] = "2000";
            RememberVal["i3"] = "1000";

            comboBox1.DataSource = ListTest;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Name";

            // LISTBOX - ITEMS

            List<States> ListBox = new List<States>();

            ListBox.Add(new States() { ID = "0", Name = "240 GB SSD" });
            ListBox.Add(new States() { ID = "1", Name = "500 GB SATA" });
            ListBox.Add(new States() { ID = "2", Name = "1000 GB SATA" });

            RememberVal["240 GB SSD"] = "1000";
            RememberVal["500 GB SATA"] = "2000";
            RememberVal["1000 GB SATA"] = "3000";

            listBox1.DataSource = ListBox;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "Name";

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Procesor";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "zł";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item = ((States)comboBox1.SelectedItem).Name;
            if (RememberVal.ContainsKey(Item))
            {
                textBox1.Text = RememberVal[Item];
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item1 = ((States)listBox1.SelectedItem).Name;
            if (RememberVal.ContainsKey(Item1))
            {
                textBox2.Text = RememberVal[Item1];
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            Int32.TryParse(textBox1.Text, out x);
            Int32.TryParse(textBox2.Text, out y);
            int Result = 0;

            Result = x + y;
            label6.Text = Result.ToString();
            Form1 F1 = new Form1();

            F1.TextBox3 = label6.Text;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
    }

}
