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

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string s = textBox1.Text;
            int a = Convert.ToInt32(s);
            for (int i = 0; i < a; i++)
            {
                double val = rnd.NextDouble() * (0.1) + 1.0;
                val = val * 1000;
                var p = Math.Truncate(val);
                var t = val - p;
                p = t * 1000;
                t = Math.Truncate(p);
                textBox2.Text = textBox2.Text + " " + Convert.ToString(t);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
