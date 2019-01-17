using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        static double a=0, w=0, V=0, W=0;
        static int k = 0;
        static int t = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Visible=true;
            //k++;
            //if (k % 2 == 0) textBox1.Visible = false;
            textBox1.Visible = !(textBox1.Visible);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            t++;
            if (t % 2 == 0) textBox2.Visible = false;
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            a = hScrollBar1.Value;
            label1.Text = "Закон движения \r\nX=" + Convert.ToString(a) + "*" + Convert.ToString(w) + "*cos(p*" + Convert.ToString(w) + "*t)\r\nY=" + Convert.ToString(a) + "*" + Convert.ToString(w) + "*sin(p*" + Convert.ToString(w) + "*t)";
            V = a * Math.PI * w * w;
            textBox1.Text = Convert.ToString(Math.Round(V));
            W = a * Math.Pow(Math.PI, 2) * w * w * w;
            textBox2.Text = Convert.ToString(Math.Round(W));

            

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            w = hScrollBar2.Value;
            label1.Text = "Закон движения \r\nX=" + Convert.ToString(a) + "*" + Convert.ToString(w) + "*cos(p*" + Convert.ToString(w) + "*t)\r\nY=" + Convert.ToString(a) + "*" + Convert.ToString(w) + "*sin(p*" + Convert.ToString(w) + "*t)";
            V = a * Math.PI * w * w;
            textBox1.Text = Convert.ToString(Math.Round(V));
            W = a * Math.Pow(Math.PI, 2) * w * w * w;
            textBox2.Text = Convert.ToString(Math.Round(W));
        }

        
    }
}
