using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k = double.Parse(textBox1.Text);
            double T = double.Parse(textBox2.Text);
            double S = 0, V = 0 , t = 0, delta_t = 0.1, g = 9.81, a = g;
            while (t < T) {
                a = g - k * V * V;
                V += a * delta_t;
                S += V * delta_t;
                t += delta_t;
                chart2.Series[0].Points.AddXY(t, S);
            }
        }
    }
}
