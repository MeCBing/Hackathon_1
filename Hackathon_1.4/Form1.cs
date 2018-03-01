using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon_1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sets(false);
        }
        string[] N = new string[4];
        string[] P = new string[4];
        string n = string.Empty;
        Random random = new Random();

        public void Sets(bool b)
        {
            textBox1.Enabled = b;
            button3.Enabled = b;
            button2.Enabled = b;
            button1.Enabled = b;
        }
        
        public void SetNumber()
        {
            for(int i=0;i<4;i++)
            {
                N[i] = random.Next(0, 10).ToString();
                for (int j = 0;j < i;j++)
                {
                    if(N[i]==N[j] && i!=j)
                    {
                        i--;
                    }
                }
            }
            //listBox1.DataSource = null;
        }
        List<string> list = new List<string>();

        public void CreateData(string t,string c)
        {
            list.Add(t + " ; " + c);
            listBox1.DataSource = null;
            listBox1.DataSource = list;
        }

        public void CheckTest1(string t)
        {
            var intersectResult = P.Intersect(N);
            int A = 0;
            int B = 0;
            n = N[0] + N[1] + N[2] + N[3];
            if(intersectResult.Count () >0)
            {
                A = intersectResult.Count((x) => t.IndexOf(x) == n.IndexOf(x)); 
            }
            B = intersectResult.Count() - A;
            string s = A + "A" + B + "B";
            CreateData(t, s);
            CheckWin(A, B);
        }

        

        public void CheckTest(string t)
        {
            int A = 0, B = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (t[i].ToString() == N[j].ToString())
                    {
                        if (i == j)
                        {
                            A++;
                        }
                        else if (i != j)
                        {
                            B++;
                        }
                    }
                }
            }
            string s = A + "A" + B + "B";
            CreateData(t, s);
            CheckWin(A, B);
        }

        public void CheckWin(int A,int B)
        {
            if(A==4)
            {
                MessageBox.Show("你贏了");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("答案是 : " + N[0] + N[1] + N[2] + N[3]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            for(int i=0;i<4;i++)
            {
                P[i] = t[i].ToString();
            }
            if(t.Length<=4)
            {
                CheckTest1(t);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetNumber();
            textBox1.Text = "";
            listBox1.DataSource = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetNumber();
            button4.Enabled = false;
            Sets(true);
        }
    }
}
