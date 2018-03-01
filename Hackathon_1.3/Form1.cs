using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string s = string.Empty;
        public void Setnumber(int a)
        {
            s = s + a;
            textBox1.Text = s;
        }

        private void button_click(object sender, EventArgs e)
        {
            Button bt = (Button)(sender);
            Setnumber(int.Parse(bt.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Setnumber(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Setnumber(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Setnumber(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Setnumber(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Setnumber(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Setnumber(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Setnumber(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Setnumber(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Setnumber(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Setnumber(0);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double C = 0,F = 0;
            if (radioButton1.Checked)
            {
                C = int.Parse(s);
                F = 9.0 / 5.0 * C + 32;
                label1.Text = "結果 : " + C + " °C = " + F + " °F";
            }
            else if(radioButton2.Checked)
            {
                F = int.Parse(s);
                C = ((F - 32) * 5) / 9;
                label1.Text = "結果 : " + F + " °F = " + C + " °C";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            textBox1.Text = string.Empty;
            s = string.Empty;
        }
    }
}
