using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zajecia1GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double meow1 = double.Parse(textBox3.Text);
            double celsjusz = (meow1 - 32) / 1.8;
            textBox2.Text = celsjusz.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double meow2 = double.Parse(textBox2.Text);
            double fahrenheit = (meow2 * 1.8) + 32;
            textBox3.Text = fahrenheit.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string dodawanie = "";
            textBox4.Text = dodawanie;
            if (textBox4.Text == "") {
                dodawanie = dodawanie + "1";
            }
            textBox4.Text = dodawanie;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string dodawanie = textBox4.Text;
            if (dodawanie == "1+")
            {
                dodawanie = dodawanie + "2";
            }
            else
            {
                dodawanie = "";
            }
            textBox4.Text = dodawanie;
            if (textBox4.Text == "1+2")
            {
                textBox4.Text = "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string dodawanie = textBox4.Text;
            if (dodawanie == "1")
            {
                dodawanie = dodawanie + "+";
            }
            else
            {
                dodawanie = "";
            }
            textBox4.Text = dodawanie;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
