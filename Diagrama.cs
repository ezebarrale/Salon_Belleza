using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string path1 = @"mydir"+ "/img/Diagrama.jpeg";
            string fullPath;
            fullPath = Path.GetFullPath(path1);
            pBox.Image = Image.FromFile(path1);
        }
    }
}
