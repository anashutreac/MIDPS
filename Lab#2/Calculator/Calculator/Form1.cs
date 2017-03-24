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
        string operation;                     //string for operation
        double result = 0;                //calculated result
        bool enter_value = false;

        public Form1()
        {
            InitializeComponent();

        }
         private void Form1_KeyPress(object sender, KeyEventArgs e)
         {
           // System.Console.WriteLine(e.KeyChar);
            if (e.KeyCode == Keys.D0)
            {
                this.button_0.Click += new System.EventHandler(this.button_click);
            }
             else if (e.KeyCode == Keys.D1)
             {
                this.button_1.Click += new System.EventHandler(this.button_click);
             }
             else if (e.KeyCode == Keys.D2)
             {
                 this.button_2.Click += new System.EventHandler(this.button_click);
             }
             else if (e.KeyCode == Keys.D3)
             {
                this.button_3.Click += new System.EventHandler(this.button_click);
             }
             else if (e.KeyCode == Keys.D4)
             {
                 this.button_4.Click += new System.EventHandler(this.button_click);
             }
             else if (e.KeyCode == Keys.D5)
             {
                 this.button_5.Click += new System.EventHandler(this.button_click);
             }
             else if (e.KeyCode == Keys.D6)
             {
                 this.button_6.Click += new System.EventHandler(this.button_click);
             }
             else if (e.KeyCode == Keys.D7)
             {
                 this.button_7.Click += new System.EventHandler(this.button_click);
             }
             else if (e.KeyCode == Keys.D8)
             {
                 this.button_8.Click += new System.EventHandler(this.button_click);
             }
             else if (e.KeyCode == Keys.D9)
             {
                 this.button_9.Click += new System.EventHandler(this.button_click);
             }
            /* else if (e.KeyCode == Keys.D0)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.NumPad1)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.NumPad2)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.NumPad3)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.NumPad4)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.NumPad5)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.NumPad6)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.NumPad7)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.NumPad8)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.NumPad9)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.NumPad0)
             {
                 button_click.PerformClick();
             }
             else if (e.KeyCode == Keys.Add)
             {
                 simpleOperations.PerformClick();
             }
             else if (e.KeyCode == Keys.Divide)
             {
                 simpleOperations.PerformClick();
             }
             else if (e.KeyCode == Keys.Multiply)
             {
                 simpleOperations.PerformClick();
             }
             else if (e.KeyCode == Keys.Enter)
             {
                 equals_Click.PerformClick();
             } */


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Clear();
            enter_value = false;

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;

        }
        private void simpleOperations(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            label1.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (operation)
            {
                case "+":
                    textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(textBox1.Text);
                    double q;
                    q = (result);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }

        }

        private void backslash_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

        }
        private void cut_button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void factor_real_Click(object sender, EventArgs e)
        {
            int tmp = 1;
            for (int i = 0; i <= Convert.ToInt16(textBox1.Text); i++)
            {
                tmp = i * tmp;
            }
            textBox1.Text = tmp.ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sqrt" + "(" + (textBox1.Text) + ")");
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);
        }

        private void change_sign_Click(object sender, EventArgs e)
        {
            if (textBox1.Text[0] == '-')
                textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = "-" + textBox1.Text;
        }

        private void dot_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                textBox1.Text += dot_button.Text;
            }
        }
        private void log_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

         

        private void pow_2_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = result.ToString();
        }

    
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(textBox1.Text);
            label1.Text = System.Convert.ToString("sqrt" + "(" + (textBox1.Text) + ")");
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       }
   }

