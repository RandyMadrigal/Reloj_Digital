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
            Fecha_y_Hora();
        }

        //Se hace una llamada al evento Tick cada vez que 
        // El intervalo en este caso "1000 Milisegundos" 
        //llega a su final
        private void timer1_Tick(object sender, EventArgs e)
        {
            Fecha_y_Hora();
        }

        private void Fecha_y_Hora()
        {
            labelReloj.Text = DateTime.Now.ToLongTimeString();
            LabelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //Enabled indica si el temnporizador esta funcionando.
            if(timer1.Enabled)
            {
                BtnStop.Text = "Play";
                timer1.Stop();
            }
            else
            {
                BtnStop.Text = "Stop";
                timer1.Start();
            }
        }
    }
}
