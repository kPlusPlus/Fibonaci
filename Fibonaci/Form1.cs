using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fibonaci
{
    public partial class Form1 : Form
    {
        private cFibonaci cF = new cFibonaci();
        private DateTime StartAt;
        private DateTime EndAt;
        private DateTime SecAt;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = string.Empty;
            int i;
            int iLong = Convert.ToInt32(txtLong.Text);

            textBox1.Clear();
            StartAt = DateTime.Now;

            for(i = 0; i < iLong; i++)
            {
                //textBox1.Text += cF.Fibonacci(i) + Environment.NewLine;         
                SecAt = DateTime.Now;
                str += i + "\t" + cF.Fibonacci(i) + "\t time \t\t" + (SecAt - StartAt) +  Environment.NewLine;
            }

            EndAt = DateTime.Now;
            textBox1.Text = str;
            textBox1.Text += " End Time " + (EndAt - StartAt);
        }
    }
}
