using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas_SalonDeBelleza
{
    public partial class Diagrama : Form
    {
        public Diagrama()
        {
            InitializeComponent();
        }

        private void Diagrama_Load(object sender, EventArgs e)
        {
            pBox.Image = Image.FromFile(@"C:\Users\danib\OneDrive\Imágenes\Aaaa-Facu\Laboratorio\Ejercicios\Salon de belleza\diagrama.png");
        }
    }
}
