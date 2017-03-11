using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;        //storing user input
        string operand_1 = string.Empty;    //storing first operand
        string operand_2 = string.Empty;    //storing second operand
        char operation;                     //char for operation
        double result = 0.0;                //calculated result
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            // System.Console.WriteLine(e.KeyChar);
            if (e.KeyCode == Keys.D0)
            {
                button_0.PerformClick();
            }
            else if (e.KeyCode == Keys.D1)
            {
                button_1.PerformClick();
            }
            else if (e.KeyCode == Keys.D2)
            {
                button_2.PerformClick();
            }
            else if (e.KeyCode == Keys.D3)
            {
                button_3.PerformClick();
            }
            else if (e.KeyCode == Keys.D4)
            {
                button_4.PerformClick();
            }
            else if (e.KeyCode == Keys.D5)
            {
                button_5.PerformClick();
            }
            else if (e.KeyCode == Keys.D6)
            {
                button_6.PerformClick();
            }
            else if (e.KeyCode == Keys.D7)
            {
                button_7.PerformClick();
            }
            else if (e.KeyCode == Keys.D8)
            {
                button_8.PerformClick();
            }
            else if (e.KeyCode == Keys.D9)
            {
                button_9.PerformClick();
            }
            else if (e.KeyCode == Keys.D0)
            {
                button_0.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                button_1.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                button_2.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                button_3.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                button_4.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                button_5.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                button_6.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                button_7.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                button_8.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                button_9.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                button_0.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                plus.PerformClick();
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void multiplicate_Click(object sender, EventArgs e)
        {
            operand_1 = input;
            operation = 'x';
            input = string.Empty;
        }

        private void factor_real_Click(object sender, EventArgs e)
        {
            int tmp = 1;
            for(int i = 0; i<= Convert.ToInt16(textBox1.Text); i++)
            {
                tmp = i * tmp;
            }
            textBox1.Text = tmp.ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            result = System.Math.Sqrt(Convert.ToDouble(textBox1.Text));
            textBox1.Text = result.ToString();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            operand_2 = input;
            double num_1, num_2;
            double.TryParse(operand_1, out num_1);
            double.TryParse(operand_2, out num_2);

            if(operation == '+')
            {
                result = num_1 + num_2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num_1 - num_2;
                textBox1.Text = result.ToString();
            }
            else if (operation == 'x')
            {
                result = num_1 * num_2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num_2 != 0)
                {
                    result = num_1 / num_2;
                    textBox1.Text = result.ToString();
                }
                else
                {
                   
                    textBox1.Text = "Error!";
                }
            }
           /* else if(operation == '^')
            {
                result = System.Math.Pow(num_1, 2);
                textBox1.Text = result.ToString();
            } */
           
        }

        private void change_sign_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text.Contains("-"))
            {
                this.textBox1.Text = this.textBox1.Text.Remove(0, 1);
            }
            else
            {
                this.textBox1.Text = "-" + this.textBox1.Text;
            }
        }

        private void dot_button_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
            // input += '.';
            //this.textBox1.Text += input;

            if(this.textBox1.Text.Contains("."))
            {
                this.textBox1.Text = this.textBox1.Text;
            }
            else
            {
                this.textBox1.Text = this.textBox1.Text + "0.";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand_1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void backslash_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int n = str.Length;
            textBox1.Text = (str.Substring(0, n - 1));

        }

        private void cut_button_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand_1 = string.Empty;
            this.operand_2 = string.Empty;
        }

        private void pow_2_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = result.ToString();
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operand_1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operand_1 = input;
            operation = '-';
            input = string.Empty;
        }
        private void button_0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 0;
            this.textBox1.Text += input;
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 1;
            this.textBox1.Text += input;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 2;
            this.textBox1.Text += input;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 3;
            this.textBox1.Text += input;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 4;
            this.textBox1.Text += input;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 5;
            this.textBox1.Text += input;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 6;
            this.textBox1.Text += input;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 7;
            this.textBox1.Text += input;
        }

        private void button_8_Click(object sender, EventArgs e)
        { 
            this.textBox1.Text = "";
            input += 8;
            this.textBox1.Text += input;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += 9;
            this.textBox1.Text += input;

        }
        private void lg_x_Click(object sender, EventArgs e)
        {
            result = System.Math.Log10(Convert.ToDouble(textBox1.Text));
            textBox1.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     /* private void keyboard(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "D0":
                    button_0.PerformClick();
                    break;
                case "1":
                    button_1.PerformClick();
                    break;
                case "3":
                    button_3.PerformClick();
                    break;
                case "4":
                    button_4.PerformClick();
                    break;
                case "5":
                    button_5.PerformClick();
                    break;
                case "6":
                    button_6.PerformClick();
                    break;
                case "7":
                    button_7.PerformClick();
                    break;
                case "8":
                    button_8.PerformClick();
                    break;
                case "9":
                    button_9.PerformClick();
                    break;
            }

        }*/ 
       }
   }

