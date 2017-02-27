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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void multiplicate_Click(object sender, EventArgs e)
        {
            operand_1 = input;
            operation = 'x';
            input = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void equal_Click(object sender, EventArgs e)
        {

        }

        private void change_sign_Click(object sender, EventArgs e)
        {

        }

        private void dot_button_Click(object sender, EventArgs e)
        {

        }

        private void plus_Click(object sender, EventArgs e)
        {
            operand_1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void backslash_Click(object sender, EventArgs e)
        {

        }

        private void cut_button_Click(object sender, EventArgs e)
        {

        }

        private void pow_2_Click(object sender, EventArgs e)
        {

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
        private void left_bracket_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
