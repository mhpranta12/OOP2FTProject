using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_user
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 x = new Form7();
            x.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 x = new Form4();
            x.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 x = new Form5();
            x.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 x = new Form6();
            x.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 x = new Form8();
            x.ShowDialog();
        }
    }
}
