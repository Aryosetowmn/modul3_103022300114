using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300114
{
    public partial class Form1 : Form
    {
        int angka1, angka2, hasil, temp;

        public Form1()
        {
            InitializeComponent();
        }

        private void OUTPUT_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 5;
            temp = temp * 10 + 5;
            OUTPUT.Text = temp.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 2;
            temp = temp * 10 + 2;
            OUTPUT.Text = temp.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 3;
            temp = temp * 10 + 3;
            OUTPUT.Text = temp.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 4;
            temp = temp * 10 + 4;
            OUTPUT.Text = temp.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 6;
            temp = temp * 10 + 6;
            OUTPUT.Text = temp.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 7;
            temp = temp * 10 + 7;
            OUTPUT.Text = temp.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 8;
            temp = temp * 10 + 8;
            OUTPUT.Text = temp.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 9;
            temp = temp * 10 + 9;
            OUTPUT.Text = temp.ToString();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            hasil = hasil + temp;
            temp = 0;
            OUTPUT.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            hasil = hasil + temp;
            OUTPUT.Text = hasil.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 1;
            temp = temp * 10 + 1;
            OUTPUT.Text = temp.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 0;
            temp = temp * 10 + 0;
            OUTPUT.Text = temp.ToString();
        }
    }
}
