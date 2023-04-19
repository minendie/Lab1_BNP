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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (!int.TryParse(textBox1.Text, out number) && textBox1.Text == "")
            {
                MessageBox.Show("Please enter a valid number!");
                textBox1.Text = string.Empty;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Ones = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] Tens = new string[] { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            int num = int.Parse(textBox1.Text);
            string strWords = "";
            if (num == 0) { textBox2.Text = "zero"; return; }

            if (num > 999 && num < 10000)
            {
                int i = num / 1000;
                strWords = strWords + Ones[i - 1] + " thousand ";
                num = num % 1000;
            }


            if (num > 99 && num < 1000)
            {
                int i = num / 100;
                strWords = strWords + Ones[i - 1] + " hundred ";
                num = num % 100;
            }

            if (num > 19 && num < 100)
            {
                int i = num / 10;
                strWords = strWords + Tens[i - 1] + " ";
                num = num % 10;
            }

            if (num > 0 && num < 20)
            {
                strWords = strWords + Ones[num - 1];
            }

            textBox2.Text = strWords;

        }
    }
}
