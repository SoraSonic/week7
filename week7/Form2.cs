using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            Calculate cal = new Calculate(a, b);
            if(radioButton1.Checked)
                textBox3.Text=Convert.ToString(cal.Plus());
            else if(radioButton2.Checked)
                textBox3.Text=Convert.ToString(cal.Minus());
            else if(radioButton3.Checked)
                textBox3.Text=Convert.ToString(cal.Multiply());
            else if(radioButton4.Checked)
                textBox3.Text = Convert.ToString(cal.Divide());
            else
                textBox3.Text = "check radio box";
        }



    }
}
