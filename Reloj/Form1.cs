using System;
using System.Drawing;

using System.Windows.Forms;

namespace Reloj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon(@"Icon\reloj.ico");
            pictureBox1.Image = Image.FromFile(@"Icon\clock.gif");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelReloj.Text = DateTime.Now.ToLongTimeString();
            LabelFecha.Text = DateTime.Now.ToLongDateString();
        }

    }
}
