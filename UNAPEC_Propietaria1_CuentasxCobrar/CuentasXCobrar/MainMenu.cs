using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasXCobrar
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void detallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cruds.TiposMovimientos.FrmDetalles_TiposMovimientos form = new Cruds.TiposMovimientos.FrmDetalles_TiposMovimientos();
            form.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
