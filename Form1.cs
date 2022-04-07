using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_TDP___Equipo_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Presentación
        private int numImagen = 1;

        private void CargarImgSig()
        {
            if (numImagen > 3)
            {
                numImagen = 1;
            }
            ImgPresentacion.ImageLocation = String.Format(@"Imagenes\{0}.jpg", numImagen);
            numImagen++;
        }
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CargarImgSig();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
