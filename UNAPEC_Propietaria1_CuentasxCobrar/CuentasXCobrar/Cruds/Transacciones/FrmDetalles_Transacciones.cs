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
        public CuentasXCobrar.Transacciones transaccion { get; set; }
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
            consultarTransacciones();
        }

        private void consultarTransacciones()
        {
            var Transaccion = from em in entities.Transacciones
                              join em2 in entities.TipoMovimientos on em.IdMovimiento equals em2.IdMovimiento
                              join em3 in entities.TipoDocumentos on em.IdDoc equals em3.IdDoc
                              join em4 in entities.Clientes on em.IdCliente equals em4.IdCliente
                              select new { em.IdTrans, em2.Tipo, em3.Descripcion, em4.Nombre, em.NumeroDocumento, em.Fecha, em.Monto };
            dgvTransacciones.DataSource = Transaccion.ToList();
        }

        private void consultarPorCriterio()
        {
            var Transaccion = from em in entities.Transacciones
                              join em2 in entities.TipoMovimientos on em.IdMovimiento equals em2.IdMovimiento
                              join em3 in entities.TipoDocumentos on em.IdDoc equals em3.IdDoc
                              join em4 in entities.Clientes on em.IdCliente equals em4.IdCliente
                              where (em.IdTrans.ToString().StartsWith(TxtBuscar.Text) ||
                              em2.Tipo.StartsWith(TxtBuscar.Text) ||
                              em3.Descripcion.StartsWith(TxtBuscar.Text) ||
                              em4.Nombre.StartsWith(TxtBuscar.Text) ||
                              em.NumeroDocumento.ToString().StartsWith(TxtBuscar.Text) ||
                              em.Fecha.ToString().StartsWith(TxtBuscar.Text) ||
                              em.Monto.ToString().StartsWith(TxtBuscar.Text)
                              )
                              select new { em.IdTrans, em2.Tipo, em3.Descripcion, em4.Nombre, em.NumeroDocumento, em.Fecha, em.Monto };
            dgvTransacciones.DataSource = Transaccion.ToList();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEditar_Transacciones form = new FrmEditar_Transacciones();
            form.ShowDialog();
        }

        private void FrmDetalles_Transacciones_Activated(object sender, EventArgs e)
        {
            consultarTransacciones();
        }

        private void dgvTransacciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvTransacciones.SelectedRows[0];
            TipoMovimientos movimientos = new TipoMovimientos();
            movimientos.IdMovimiento = Int32.Parse(row.Cells[0].Value.ToString());
            movimientos.Tipo = row.Cells[1].Value.ToString();
            FrmEditar_Transacciones fed = new FrmEditar_Transacciones();
            fed.transaccion = transaccion;
            fed.ShowDialog();
        }
    }
}
