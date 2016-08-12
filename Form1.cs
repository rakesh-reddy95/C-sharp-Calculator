using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        float a;
    float b;
    float c;
    bool plus = false;
    bool minus = false;
    bool multiply = false;
    bool divide = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             a = Convert.ToInt32(display.Text);
            display.Text = "";
            plus = true;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
             a = Convert.ToInt32(display.Text);
        display.Text = "";
        minus = true;
         
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(display.Text);
        display.Text = "";
        multiply = true;
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(display.Text);
        display.Text = "";
        divide = true;
        }

       


      

        private void button19_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(display.Text);
            if (minus == true)
            {
                c = a - b;
                display.Text = Convert.ToString(c);
                
            }
            else if (plus == true)
            {
                c = a + b;
                display.Text = Convert.ToString(c);
            }
            else  if (multiply == true)
            {
                c = a * b;
                display.Text = Convert.ToString(c);
            }
            else if (divide == true)
            {
                c = a / b;
                display.Text = Convert.ToString(c);
            }
            else
            {
                display.Text = "";
            }
        }





       
    }
}