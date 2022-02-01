using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discrim_calc
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

        private void button1_Click(object sender, EventArgs e)
        {
            double A = Int32.Parse(a.Text);
            double B = Int32.Parse(b.Text);
            double C = Int32.Parse(c.Text);
            double Bsqrt = Math.Pow(B, 2);
      
            double dicrim = Bsqrt - 4 * A * C;
            //Console.WriteLine($"{A}, {B}, {C}, {Bsqrt}, {dicrim}");
            discriminator.Text = dicrim.ToString();

            if (dicrim > 0)
            {
                double x1 = (B * -1 + Math.Sqrt(dicrim)) / (2 * A);
                double x2 = (B * -1 - Math.Sqrt(dicrim)) / (2 * A);
                root1.Text = x1.ToString();
                root2.Text = x2.ToString();
                answer.Text = "2 roots";
            }
            else if (dicrim == 0)
            {
                double x1 = (B * -1) / (2 * A);
                root1.Text = x1.ToString();
                answer.Text = "1 root";
            }
            else
            {
                answer.Text = "no roots";
            }
        }
    }
}
