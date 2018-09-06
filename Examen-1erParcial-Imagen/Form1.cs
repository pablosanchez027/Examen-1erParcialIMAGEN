using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Examen_1erParcial_Imagen
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> Image_Input;

        public Form1()
        {
            InitializeComponent();
        }


        //Cargar imagen
        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image_Input = new Image<Bgr, byte>(ofd.FileName);
                imageBox1.Image = Image_Input;
            }
        }


        //Salida
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Salida perrona del programa perrón", "System Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        //Canny
        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> Image_Canny = new Image<Gray, byte>(Image_Input.Width, Image_Input.Height, new Gray(0));
            Image_Canny = Image_Input.Canny(50, 30);

            imageBox1.Image = Image_Canny;
        }


        //Histograma Rojo
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No funciona","System Message", MessageBoxButtons.OK);
        }


    }
}
