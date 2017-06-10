using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasXCobrar.Cruds.Asientos_Contables
{
    public partial class FrmDetalles_AsientosContables : Form
    {
        public CuentasXCobrar.Asientos_Contables asientocontable { get; set; }
        DBCuentasxCobrarEntities entities = new DBCuentasxCobrarEntities();

        public FrmDetalles_AsientosContables()
        {
            InitializeComponent();
        }

        private void FrmAsientos_Contables_Load(object sender, EventArgs e)
        {
            AsientosContables();
        }
        private void AsientosContables()
        {
            var AsientosContables = from ac in entities.Asientos_Contables
                                    join ac2 in entities.TipoMovimientos on ac.IdMovimiento equals ac2.IdMovimiento
                                    join ac3 in entities.Clientes on ac.IdCliente equals ac3.IdCliente                                 
                              select new { ac.IdAsiento, ac2.Tipo, ac3.Nombre,
                              ac.Cuenta, ac.Fecha, ac.Monto, ac.Estado};
            dgvAsientosContables.DataSource = AsientosContables.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdAsientosContables fed = new FrmEdAsientosContables();
            fed.Show();

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu fed = new MainMenu();
            fed.Show();
        }

        private void dgvAsientosContables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvAsientosContables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvAsientosContables.SelectedRows[1];
            TipoMovimientos movimientos = new TipoMovimientos();
            movimientos.IdMovimiento = Int32.Parse(row.Cells[0].Value.ToString());
            movimientos.Tipo = row.Cells[1].Value.ToString();
            FrmEdAsientosContables fed = new FrmEdAsientosContables();
            fed.asientocontable = asientocontable;
            fed.ShowDialog();
        }
    }
}
