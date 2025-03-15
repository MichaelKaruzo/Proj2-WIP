using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj2
{
    public partial class Form3 : Form
    {
        public static Form3 Instance;
        public string Var1;
        public Form3()
        {
            InitializeComponent();
            Instance = this;
            Var1 = textBox2.Text;
        }
        public Dictionary<string, string> RememberVal1 = new Dictionary<string, string>();

        private void Form3_Load(object sender, EventArgs e)
        {
            List<States> List2 = new List<States>();

            List2.Add(new States() { ID = "0", Name = "Monitor1" });
            List2.Add(new States() { ID = "1", Name = "Monitor2" });
            List2.Add(new States() { ID = "2", Name = "Monitor3" });
            List2.Add(new States() { ID = "3", Name = "Monitor4" });
            List2.Add(new States() { ID = "4", Name = "Monitor5" });

            RememberVal1["Monitor1"] = "1000";
            RememberVal1["Monitor2"] = "2000";
            RememberVal1["Monitor3"] = "3000";
            RememberVal1["Monitor4"] = "4000";
            RememberVal1["Monitor5"] = "5000";

            listBox2.DataSource = List2;
            listBox2.ValueMember = "ID";
            listBox2.DisplayMember = "Name";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Item1 = ((States)listBox2.SelectedItem).Name;
            if (RememberVal1.ContainsKey(Item1))
            {
                textBox2.Text = RememberVal1[Item1];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Data.ResultForm3 = textBox2.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
