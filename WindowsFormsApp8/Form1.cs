using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string s1="";
        bool buton = false;
        public float v1;
        public float v2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".") == true)
            {
                string[] k = (textBox1.Text.Split('.'));
                if (k[1].Length < 2)
                {
                    textBox1.Text = k[0];
                }
                else
                {
                    int p = int.Parse(k[1]);
                    p = p / 10;
                    textBox1.Text = k[0] + "." + p.ToString();
                }
            }
            else
            {
                int s = int.Parse(textBox1.Text);
                s = s / 10;
                textBox1.Text = s.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (buton == true)
            {
                textBox1.Text = "0";
                buton = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {

                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "0";
            s1 = "";
            buton = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (buton == true)
            {
                textBox1.Text = "7";
                buton = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "7";
                }
                else
                {
                    textBox1.Text += "7";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (buton == true)
            {
                textBox1.Text = "8";
                buton = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "8";
                }
                else
                {
                    textBox1.Text += "8";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (buton == true)
            {
                textBox1.Text = "9";
                buton = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "9";
                }
                else
                {
                    textBox1.Text += "9";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (buton == true)
            {
                textBox1.Text = "4";
                buton = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "4";
                }
                else
                {
                    textBox1.Text += "4";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (buton == true)
            {
                textBox1.Text = "5";
                buton = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "5";
                }
                else
                {
                    textBox1.Text += "5";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (buton == true)
            {
                textBox1.Text = "6";
                buton = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "6";
                }
                else
                {
                    textBox1.Text += "6";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (buton == true)
            {
                textBox1.Text = "1";
                buton = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "1";
                }
                else
                {
                    textBox1.Text += "1";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (buton == true)
            {
                textBox1.Text = "2";
                buton = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "2";
                }
                else
                {
                    textBox1.Text += "2";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (buton == true)
            {
                textBox1.Text = "3";
                buton = false;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = "3";
                }
                else
                {
                    textBox1.Text += "3";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains('.')==false)
            {
                textBox1.Text += ".";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1_Shown(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double s = double.Parse(textBox1.Text);
            double n = Math.Sqrt(s);
            textBox1.Text = n.ToString();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if (s1 == "/")
            {
                s1 = "+";
                buton = true;
                button19.PerformClick();
            }
            if (buton == false)
            {
                s1 = "/";
                v1 = float.Parse(textBox1.Text);
                buton = true;
            }
            s1 = "/";
            textBox2.Text = s1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
                if (s1 != "")
                {
                    if (s1 == "/")
                    {
                        v1 = v1 / float.Parse(textBox1.Text);
                        textBox1.Text = (v1).ToString();
                        buton = true;
                    }
                    if (s1 == "*")
                    {
                        v1 = v1 * float.Parse(textBox1.Text);
                        textBox1.Text = (v1).ToString();
                        buton = true;
                    }
                    if (s1 == "+")
                    {
                        v1 = v1 + float.Parse(textBox1.Text);
                        textBox1.Text = (v1).ToString();
                        buton = true;
                    }
                    if (s1 == "-")
                    {
                        v1 = v1 - float.Parse(textBox1.Text);
                        textBox1.Text = (v1).ToString();
                        buton = true;
                    }
                }
                textBox2.Text = "";
                s1 = ""; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(s1=="+")
            {
                s1 = "+";
                buton = true;
                button19.PerformClick();
            }
            if (buton==false)
            {
                s1 = "+";
                v1 = float.Parse(textBox1.Text);
                buton = true;
            }
            s1 = "+";
            textBox2.Text = s1;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (s1 == "*")
            {
                s1 = "*";
                buton = true;
                button19.PerformClick();
            }
            if (buton == false)
            {
                s1 = "*";
                v1 = float.Parse(textBox1.Text);
                buton = true;
            }
            s1 = "*";
            textBox2.Text = s1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text) / 100).ToString();
            buton = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (s1 == "-")
            {
                s1 = "-";
                buton = true;
                button19.PerformClick();
            }
            if (buton == false)
            {
                s1 = "-";
                v1 = float.Parse(textBox1.Text);
                buton = true;
            }
            s1 = "-";
            textBox2.Text = s1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = (float.Parse(textBox1.Text) / 100).ToString();
            buton = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }
    }
}
