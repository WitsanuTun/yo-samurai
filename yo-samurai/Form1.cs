using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yo_samurai
{
    public partial class Form1 : Form
    {
        double redius;       //
        double circum;       //เก็บผลลัพธิ์เส้นรอบวง
        double area;         //เก็บผลลัพธิ
        double pi = 3.14;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bArea_Click(object sender, EventArgs e)
        {
            redius = double.Parse(tRadius.Text);
            area = pi * Math.Pow(redius, 2);
            laArea.Text = area.ToString();
        }

        private void bcircum_Click(object sender, EventArgs e)
        {
            redius = double.Parse(tRadius.Text);   
            circum = 2 * pi * redius;
            laCircum.Text = circum.ToString();
        }
    }
}
