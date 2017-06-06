using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasXCobrar.Cruds.TiposMovimientos
{
    public partial class FrmDetalles_TiposMovimientos : Form
    {
        public TipoMovimientos movimientos { get; set; }
        private DBCuentasxCobrarEntities entities = new DBCuentasxCobrarEntities();

        public FrmDetalles_TiposMovimientos()
        {
            InitializeComponent();
        }

        private void FrmDetalles_TiposMovimientos_Load(object sender, EventArgs e)
        {
            consultarEmpleados();
        }

        private void consultarEmpleados()
        {
            var Movimientos = from em in entities.TipoMovimientos
                              select new { em.IdMovimiento, em.Tipo };
            dgvTiposMovimientos.DataSource = Movimientos.ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }
        private void consultarPorCriterio()
        {
            var Movimientos = from em in entities.TipoMovimientos
                            where (em.IdMovimiento.ToString().StartsWith(TxtBuscar.Text) ||
                            em.Tipo.StartsWith(TxtBuscar.Text)
                            )
                            select new { em.IdMovimiento, em.Tipo };
            dgvTiposMovimientos.DataSource = Movimientos.ToList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEditar_TiposMovimientos form = new FrmEditar_TiposMovimientos();
            form.ShowDialog();
        }

        private void FrmDetalles_TiposMovimientos_Activated(object sender, EventArgs e)
        {
            consultarEmpleados();
        }

        private void dgvTiposMovimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTiposMovimientos.SelectedRows[0];
            TipoMovimientos movimientos = new TipoMovimientos();
            movimientos.IdMovimiento = Int32.Parse(row.Cells[0].Value.ToString());
            movimientos.Tipo = row.Cells[1].Value.ToString();
            FrmEditar_TiposMovimientos fed = new FrmEditar_TiposMovimientos();
            fed.movimientos = movimientos;
            fed.ShowDialog();

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
