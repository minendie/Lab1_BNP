using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(textBox1.Text, out number) && textBox1.Text != "" && textBox1.Text[0] != '-')
            {
                MessageBox.Show("Please enter the integer number!!!");
                textBox1.Text = string.Empty;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(textBox2.Text, out number) && textBox2.Text != "" && textBox2.Text[0] != '-')
            {
                MessageBox.Show("Please enter the integer number!!!");
                textBox2.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            long sum = 0;
            num1 = Int32.Parse(textBox1.Text.Trim());
            num2 = Int32.Parse(textBox2.Text.Trim());
            sum = num1 + num2;
            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
