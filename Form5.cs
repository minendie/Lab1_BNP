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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Decimal" && comboBox1.SelectedItem.ToString() == "Decimal")
            {
                decimal value;
                if (!Decimal.TryParse(textBox1.Text, out value))
                {
                    MessageBox.Show("Please enter value in decimal!");
                }
                else
                {
                    textBox2.Text = textBox1.Text;
                }
                   

            }
            if (comboBox2.SelectedItem.ToString() == "Decimal" && comboBox1.SelectedItem.ToString() == "Binary")
            {
                decimal value;
                if (!Decimal.TryParse(textBox1.Text, out value))
                {
                    MessageBox.Show("Please enter value in decimal!");
                }
                else
                {
                    int value2 = int.Parse(textBox1.Text);
                    string binary = Convert.ToString(value2, 2);
                    textBox2.Text = binary;
                }
                
            }
            if (comboBox2.SelectedItem.ToString() == "Decimal" && comboBox1.SelectedItem.ToString() == "Hexadecimal")
            {
                decimal value;
                if (!Decimal.TryParse(textBox1.Text, out value))
                {
                    MessageBox.Show("Please enter value in decimal!");
                }
                else
                {
                    int value2 = int.Parse(textBox1.Text);
                    string hexaval = value2.ToString("X");
                    textBox2.Text = "0x" + hexaval;
                }

                
            }
            if (comboBox2.SelectedItem.ToString() == "Binary" && comboBox1.SelectedItem.ToString() == "Binary")
            {
                bool flag = true;
                for (int i = 0; i< textBox1.Text.Length; i++)
                {
                    int x = (int)textBox1.Text[i];
                    if (x != 0 && x!=1)
                    {
                        MessageBox.Show("Please enter a value in binary!");
                        flag =false;
                        break;
                    }
                }
                if (flag) { textBox2.Text = textBox1.Text; }
                

            }
            if (comboBox2.SelectedItem.ToString() == "Binary" && comboBox1.SelectedItem.ToString() == "Decimal")
            {
                bool flag = true;
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    int x = (int)textBox1.Text[i];
                    if (x != 0 && x != 1)
                    {
                        MessageBox.Show("Please enter a value in binary!");
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    string result = Convert.ToInt32(textBox1.Text, 2).ToString();
                    textBox2.Text = result;
                }
                   
            }
            if (comboBox2.SelectedItem.ToString() == "Binary" && comboBox1.SelectedItem.ToString() == "Hexadecimal")
            {
                bool flag = true;
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    int x = (int)textBox1.Text[i];
                    if (x != 0 && x != 1)
                    {
                        MessageBox.Show("Please enter a value in binary!");
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    string hexaval = Convert.ToInt32(textBox1.Text, 2).ToString("X");
                    textBox2.Text = "0x" + hexaval;

                }

                   
            }
            if (comboBox2.SelectedItem.ToString() == "Hexadecimal" && comboBox1.SelectedItem.ToString() == "Hexadecimal")
            {

                textBox2.Text = textBox1.Text;

            }
            if (comboBox2.SelectedItem.ToString() == "Hexadecimal" && comboBox1.SelectedItem.ToString() == "Decimal")
            {
                string temp = "";
                for (int i = 2; i < textBox1.Text.Length; i++)
                {
                    temp += textBox1.Text[i].ToString();
                }
                int result = Convert.ToInt32(textBox1.Text, 16);
                textBox2.Text = result.ToString();
            }
            if (comboBox2.SelectedItem.ToString() == "Hexadecimal" && comboBox1.SelectedItem.ToString() == "Binary")
            {
                string temp = "";
                for (int i = 2; i < textBox1.Text.Length; i++)
                {
                    temp += textBox1.Text[i].ToString();
                }
                int val = Convert.ToInt32(temp, 16);
                string binary = Convert.ToString(val, 2);
                textBox2.Text = binary;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a number!");
                return;
            }
            else
            {
                if (!int.TryParse(textBox1.Text, out int val))
                {
                    if(double.TryParse(textBox1.Text, out double val2))
                    {
                        MessageBox.Show("Please enter an integer number!");
                    }  
                    else
                    {
                        for (int i = 0; i < textBox1.Text.Length; i++)
                        {

                            if (Char.IsUpper(textBox1.Text[i]))
                            {
                                int x = textBox1.Text[i] - 'A';
                                if (x > 6 && x != 23)
                                {
                                    MessageBox.Show("Please enter a valid number!");
                                    return;
                                }
                            }
                            else
                            {
                                int x = textBox1.Text[i] - 'a';
                                if (x > 6 && x != 23)
                                {
                                    MessageBox.Show("Please enter a valid number!");
                                    return;
                                }
                            }

                        }
                    }
                    
                }

            }
                




            
        }
    }
}
