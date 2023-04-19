using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // Remove any leading or trailing white spaces
            input = input.Trim();

            // Check if input is empty or contains only white spaces
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter at least one score separated by spaces.");
            }

            // Split the input by spaces
            string[] scores = input.Split(' ');

            // Check if each score is a valid double value
            foreach (string score in scores)
            {
                double value;
                if (!double.TryParse(score, out value))
                {
                    MessageBox.Show("Please enter valid double numbers separated by spaces.");

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            input = input.Trim();  // remove spaces in head and tail
            string[] scores = input.Split(' ');
            // StringBuilder sb = new StringBuilder();
            //int numb_label = scores.Length;

            for (int i = 0; i < scores.Length; i++)
            {
                int labelWidth = 100;
                int labelHeight = 20;
                int margin = 5;
                int labelCount = groupBox1.Controls.OfType<Label>().Count() + 4; // đếm số lượng Label hiện có trong GroupBox
                int x = margin + (labelWidth + margin) * (labelCount % 4); // tính toán tọa độ x của Label mới
                int y = margin + (labelHeight + margin) * (labelCount / 4); // tính toán tọa độ y của Label mới

                Label newlabel = new Label();
                newlabel.Location = new Point(x, y);
                newlabel.Text = "Course " + (i + 1).ToString() + ": " + scores[i];
                groupBox1.Controls.Add(newlabel);
            }




            double[] doubles = Array.ConvertAll(scores, Double.Parse);
            textBox2.Text = Math.Round(doubles.Average(), 2).ToString();
            double dtb = Math.Round(doubles.Average(), 2);
            textBox3.Text = doubles.Max().ToString();
            textBox6.Text = doubles.Min().ToString();
            textBox4.Text = doubles.Count(c => c >= 5).ToString();
            textBox7.Text = (doubles.Count() - doubles.Count(c => c >= 5)).ToString();
            string[] ranks = new string[] { "Excelent", "Good", "Satisfactory", "Poor", "Bad" };
            bool check = false;
            if (dtb >= 8)
            {
                bool flage = true;
                foreach (double score in doubles)
                {
                    if (score < 6.5)
                    {
                        flage = false; break;
                    }
                }
                if (flage)
                {
                    textBox5.Text = "Excelent";
                    check = true;
                }
            }
            if (dtb >= 6.5)
            {
                bool flagg = true;
                foreach (double score in doubles)
                {
                    if (score < 5)
                    {
                        flagg = false; break;
                    }
                }
                if (flagg)
                {
                    textBox5.Text = "Good";
                    check = true;
                }
            }
            if (dtb >= 5)
            {
                bool flags = true;
                foreach (double score in doubles)
                {
                    if (score < 3.5)
                    {
                        flags = false; break;
                    }
                }
                if (flags)
                {
                    textBox5.Text = "Satisfactory";
                    check = true;
                }

            }
            if (dtb >= 3.5 && dtb < 5)
            {
                bool flagp = true;
                foreach (double score in doubles)
                {
                    if (score < 2)
                    {
                        flagp = false; break;
                    }
                }
                if (flagp)
                {
                    textBox5.Text = "Poor";
                    check = true;
                }

            }
            if (!check)
            {
                textBox5.Text = "Bad";
            }



        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_Load_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            int labelWidth = 100;
            int labelHeight = 20;
            int margin = 5;
            int labelCount = groupBox1.Controls.OfType<Label>().Count() + 4; // đếm số lượng Label hiện có trong GroupBox
            int x = margin + (labelWidth + margin) * (labelCount % 4); // tính toán tọa độ x của Label mới
            int y = margin + (labelHeight + margin) * (labelCount / 4); // tính toán tọa độ y của Label mới
        }
    }
}
