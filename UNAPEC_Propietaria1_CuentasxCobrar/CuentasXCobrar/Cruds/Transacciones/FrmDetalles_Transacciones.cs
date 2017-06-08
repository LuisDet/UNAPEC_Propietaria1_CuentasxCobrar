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
            dgvTrans.Columns[2].Visible = false;
            dgvTrans.Columns[3].Visible = false;
            dgvTrans.Columns[10].Visible = false;
            dgvTrans.Columns[11].Visible = false;
            dgvTrans.Columns[12].Visible = false;

            dgvTrans.Columns[0].HeaderText = "ID";
            dgvTrans.Columns[4].HeaderText = "No. Doc.";
            dgvTrans.Columns[5].HeaderText = "Fecha";
            dgvTrans.Columns[6].HeaderText = "Monto";
            dgvTrans.Columns[7].HeaderText = "Movimiento";
            dgvTrans.Columns[8].HeaderText = "Documento";
            dgvTrans.Columns[9].HeaderText = "Cliente";


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarPorConsulta();
        }
        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarPorConsulta();
        }

        private void CargarPorConsulta()
        {
            var Transacciones_Consulta = from em in entities.Transacciones
                            where (em.IdTrans.ToString().StartsWith(TxtBuscar.Text) ||
                            em.NumeroDocumento.ToString().StartsWith(TxtBuscar.Text) ||
                            em.Monto.ToString().StartsWith(TxtBuscar.Text) ||
                            em.TipoMovimientos.Tipo.ToString().StartsWith(TxtBuscar.Text) ||
                            em.TipoDocumentos.Descripcion.ToString().StartsWith(TxtBuscar.Text) ||
                            em.Clientes.Nombre.ToString().StartsWith(TxtBuscar.Text) ||
                            em.Fecha.ToString().StartsWith(TxtBuscar.Text)
                            
                            )
                            select em;
            dgvTrans.DataSource = Transacciones_Consulta.ToList();

            dgvTrans.Columns[0].HeaderText = "ID";
            dgvTrans.Columns[4].HeaderText = "No. Doc.";
            dgvTrans.Columns[5].HeaderText = "Fecha";
            dgvTrans.Columns[6].HeaderText = "Monto";
            dgvTrans.Columns[7].HeaderText = "Movimiento";
            dgvTrans.Columns[8].HeaderText = "Documento";
            dgvTrans.Columns[9].HeaderText = "Cliente";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmEditar_Transacciones frm = new FrmEditar_Transacciones();
            frm.ShowDialog();
            frm.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTrans_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvTrans.CurrentRow;
            CuentasXCobrar.Transacciones transacciones = new CuentasXCobrar.Transacciones();
            transacciones.IdTrans = Int32.Parse(row.Cells[0].Value.ToString());
            transacciones.IdMovimiento = Int32.Parse(row.Cells[1].Value.ToString());
            transacciones.IdDoc = Int32.Parse(row.Cells[2].Value.ToString());
            transacciones.IdCliente = Int32.Parse(row.Cells[3].Value.ToString());
            transacciones.NumeroDocumento = Int32.Parse(row.Cells[4].Value.ToString());
            transacciones.Fecha = Convert.ToDateTime(row.Cells[5].Value.ToString());
            transacciones.Monto = decimal.Parse(row.Cells[6].Value.ToString());

            FrmEditar_Transacciones fet = new FrmEditar_Transacciones();
            fet.transacciones = transacciones;
            fet.ShowDialog();
        }


    }
}
