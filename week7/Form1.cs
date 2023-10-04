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
    public partial class Form1 : Form
    {
        List<Product> productList = new List<Product>();
        public Form1()
        {
            
            productList.Add(new Product(1, "Banh Dau Xanh", 50000));
            productList.Add(new Product(2, "Banh Thap Cam", 40000));
            productList.Add(new Product(3, "Banh Dua", 45000));
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Length > 0 && !char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "this is not a valid number");
            else
                this.errorProvider1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Product item in productList){
                bool logic = Convert.ToInt32(textBox1.Text) == item.getCode();
                if (logic)
                    textBox2.Text = item.getName() + " " + item.getPrice();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }


    }
}
