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
        int angka1, angka2, hasil;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 1;
        }

        private void OUTPUT_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 9;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            angka1 = int.Parse(OUTPUT.Text);
            OUTPUT.Text = "";

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            angka2 = int.Parse(OUTPUT.Text);
            hasil = angka1 + angka2;
            OUTPUT.Text = hasil.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 1;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            OUTPUT.Text += 0;
        }
    }
}
