using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasXCobrar.Cruds.Transacciones
{
    public partial class FrmDetalles_Transacciones : Form
    {
        //public  movimientos { get; set; }
        private DBCuentasxCobrarEntities entities = new DBCuentasxCobrarEntities();
        public FrmDetalles_Transacciones()
        {
            InitializeComponent();
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDetalles_Transacciones_Load(object sender, EventArgs e)
        {

        }
    }
}
