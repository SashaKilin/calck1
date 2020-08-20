using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calck2
{
    public partial class Form1 : Form
    {

        public long a;
        public long b;
        public string dev;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;

            textBox1.Text = old + "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;

            textBox1.Text = old + "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;

            textBox1.Text = old + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;

            textBox1.Text = old + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;

            textBox1.Text = old + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;

            textBox1.Text = old + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;

            textBox1.Text = old + "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;

            textBox1.Text = old + "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;

            textBox1.Text = old + "8";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string old = textBox1.Text;

            textBox1.Text = old + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt64(textBox1.Text);

            label1.Text = Convert.ToString(a + "+");

            textBox1.Text = "";

            dev = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt64(textBox1.Text);

            label1.Text = Convert.ToString(a + "-");

            textBox1.Text = "";

            dev = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt64(textBox1.Text);

            label1.Text = Convert.ToString(a + "*");

            textBox1.Text = "";

            dev = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt64(textBox1.Text);

            label1.Text = Convert.ToString(a + "/");

            textBox1.Text = "";

            dev = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double result;

            b = Convert.ToInt64(textBox1.Text);

            if(dev == "/")
            {
                result = a / b;

                textBox1.Text = Convert.ToString(result);

                label1.Text = "";
            }
            else if(dev == "*")
            {
                result = a * b;

                textBox1.Text = Convert.ToString(result);

                label1.Text = "";
            }
            else if(dev == "-")
            {
                result = a - b;

                textBox1.Text = Convert.ToString(result);

                label1.Text = "";
            }

            else if (dev == "+")
            {
                result = a + b;

                textBox1.Text = Convert.ToString(result);

                label1.Text = "";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
