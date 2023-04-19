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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double number;
            if (!double.TryParse(textBox1.Text, out number) && textBox1.Text != "" && textBox1.Text[0] != '-')
            {
                MessageBox.Show("Please enter number!!!");
                textBox1.Text = string.Empty;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double number;
            if (!double.TryParse(textBox2.Text, out number) && textBox2.Text != "" && textBox2.Text[0] != '-')
            {
                MessageBox.Show("Please enter number!!!");
                textBox2.Text = string.Empty;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double number;
            if (!double.TryParse(textBox3.Text, out number) && textBox3.Text != "" && textBox3.Text[0] != '-')
            {
                MessageBox.Show("Please enter number!!!");
                textBox3.Text = string.Empty;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            if (a >= b && a >= c)
            {
                textBox4.Text = a.ToString();

            }
            else
            {
                if (b >= c)
                {
                    textBox4.Text = b.ToString();
                }
                else
                {
                    textBox4.Text = c.ToString();
                }
            }
            if (a <= b && a <= c)
            {
                textBox5.Text = a.ToString();

            }
            else
            {
                if (b <= c)
                {
                    textBox5.Text = b.ToString();
                }
                else
                {
                    textBox5.Text = c.ToString();
                }
            }
        }
    }
}
