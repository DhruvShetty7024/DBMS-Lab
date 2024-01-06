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
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string Op1 = string.Empty;
        string Op2 = string.Empty; 
        double res = 0.0;
        char Operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty; 
            input = input + "1";
            this.textBox1.Text += input;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button25_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            this.textBox1.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "2";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "0";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text; 
            Operator = '+';
            input = string.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = '-';
            input = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = '*';
            input = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = '/';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = '%';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = 's';
            input = string.Empty;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty; 
            input += "(";
            this.textBox1.Text += input;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += ")";
            this.textBox1.Text += input;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Op2 = input;
double num1, num2; double.TryParse(Op1, out num1); double.TryParse(Op2, out num2); if (Operator == '+')
{
res = num1 + num2; this.textBox1.Text = res.ToString();
}
else if (Operator == '-')
{
res = num1 - num2; textBox1.Text = res.ToString();
}
else if (Operator == '*')
{
res = num1 * num2;
    textBox1.Text = res.ToString();
}
else if (Operator == '%')
{
    res = num1 % num2;
    textBox1.Text = res.ToString();
}
else if (Operator == 's')
{
    res = Math.Sin(num1);
    textBox1.Text = res.ToString();
}
else if (Operator == 'c')
{
    res = Math.Cos(num1);
    textBox1.Text = res.ToString();
}
else if (Operator == 't')
{
    res = Math.Tan(num1);
    textBox1.Text = res.ToString();
}
else if (Operator == 'l')
{
    res = Math.Log10(num1);
    textBox1.Text = res.ToString();
}
else if (Operator == 'q')
{
    res = num1*num1;
    textBox1.Text = res.ToString();
}
else if (Operator == 'r')
{
    res =Math.Sqrt(num1);
    textBox1.Text = res.ToString();
}
else if (Operator == 'f')
{
    double n=num1;
    res=1;
    while(n>0)
    {
    res = res*n;
    n--;
    }
    textBox1.Text = res.ToString();
}


            else if (Operator == '/')
{
if (num2 != 0)
{
res = num1 / num2; textBox1.Text = res.ToString();
}
else
{
textBox1.Text = "DIV/Zero!";
}
}
input = string.Empty;
}

        private void button23_Click(object sender, EventArgs e)
        {
            input = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = 'l';
            input = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = 'q';
            input = string.Empty;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = 'c';
            input = string.Empty;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = 't';
            input = string.Empty;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = 'r';
            input = string.Empty;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Op1 = this.textBox1.Text;
            Operator = 'f';
            input = string.Empty;
        }
        }



    }

