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
        public CuentasXCobrar.Transacciones transacciones { get; set; }
        private DBCuentasxCobrarEntities entities = new DBCuentasxCobrarEntities();

        public FrmDetalles_Transacciones()
        {
            InitializeComponent();
        }

        #region Cargar Datos del Datagrid View y Consultas.
        private void FrmDetalles_Transacciones_Load(object sender, EventArgs e)
        {
            cargarTransacciones();
        }

        private void FrmDetalles_Transacciones_Activated(object sender, EventArgs e)
        {
            this.Refresh();
            cargarTransacciones();
        }

        private void cargarTransacciones()
        {
            dgvTrans.DataSource = entities.Transacciones.ToList();
            dgvTrans.Columns[1].Visible = false;
            dgvTrans.Columns[3].Visible = false;
            dgvTrans.Columns[5].Visible = false;
            dgvTrans.Columns[10].Visible = false;
            dgvTrans.Columns[11].Visible = false;
            dgvTrans.Columns[12].Visible = false;

            dgvTrans.Columns[0].HeaderText = "Id";
            dgvTrans.Columns[2].HeaderText = "Movimiento";
            dgvTrans.Columns[4].HeaderText = "Documento";
            dgvTrans.Columns[6].HeaderText = "Cliente";
            dgvTrans.Columns[7].HeaderText = "No. Documento";
            dgvTrans.Columns[8].HeaderText = "Fecha";
            dgvTrans.Columns[9].HeaderText = "Monto";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPorConsulta();
        }

        private void CargarPorConsulta()
        {
            var Transacciones_Consulta = from em in entities.Transacciones
                            where (em.IdTrans.ToString().StartsWith(TxtBuscar.Text) ||
                            em.NumeroDocumento.ToString().StartsWith(TxtBuscar.Text) ||
                            em.Monto.ToString().StartsWith(TxtBuscar.Text) ||
                            em.IdMovimiento.ToString().StartsWith(TxtBuscar.Text) ||
                            em.IdDoc.ToString().StartsWith(TxtBuscar.Text) ||
                            em.IdCliente.ToString().StartsWith(TxtBuscar.Text)
                            )
                            select em;
            dgvTrans.DataSource = Transacciones_Consulta.ToList();
            dgvTrans.Columns[1].Visible = false;
            dgvTrans.Columns[3].Visible = false;
            dgvTrans.Columns[5].Visible = false;
            dgvTrans.Columns[10].Visible = false;
            dgvTrans.Columns[11].Visible = false;
            dgvTrans.Columns[12].Visible = false;

            dgvTrans.Columns[0].HeaderText = "Id";
            dgvTrans.Columns[2].HeaderText = "Movimiento";
            dgvTrans.Columns[4].HeaderText = "Documento";
            dgvTrans.Columns[6].HeaderText = "Cliente";
            dgvTrans.Columns[7].HeaderText = "No. Documento";
            dgvTrans.Columns[8].HeaderText = "Fecha";
            dgvTrans.Columns[9].HeaderText = "Monto";
        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEditar_Transacciones frm = new FrmEditar_Transacciones();
            frm.ShowDialog();
            frm.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Enviar datos de la fila seleccionada del datagridview hacia otro formulario.
        private void dgvTrans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvTrans.CurrentRow;
            CuentasXCobrar.Transacciones transacciones = new CuentasXCobrar.Transacciones();
            transacciones.IdTrans = Int32.Parse(row.Cells[0].Value.ToString());
            transacciones.IdMovimiento = Int32.Parse(row.Cells[1].Value.ToString());
            transacciones.IdDoc = Int32.Parse(row.Cells[3].Value.ToString());
            transacciones.IdCliente = Int32.Parse(row.Cells[5].Value.ToString());
            transacciones.NumeroDocumento = Int32.Parse(row.Cells[7].Value.ToString());
            transacciones.Fecha = Convert.ToDateTime(row.Cells[8].Value.ToString());
            transacciones.Monto = decimal.Parse(row.Cells[9].Value.ToString());

            FrmEditar_Transacciones fet = new FrmEditar_Transacciones();
            fet.transacciones = transacciones;
            fet.ShowDialog();
        }
        #endregion
    }
}
