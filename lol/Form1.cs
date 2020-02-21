//auto text by capu

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autotxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Program by capu", "Autotext",MessageBoxButtons.OK);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(this.richTextBox1.Text + "{enter}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
        }

        //stuff
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 100;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 2000;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 10000;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 5000;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 500;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 7000;
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 11000;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 2000;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 8000;
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 12000;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 3000;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 4000;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 9000;
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 13000;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 5000;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 6000;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 10000;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            this.timer1.Interval = 14000;
        }
    }
}
