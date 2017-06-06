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

namespace CuentasXCobrar.Cruds.Transacciones
{
    public partial class FrmEditar_Transacciones : Form
    {
        public CuentasXCobrar.Transacciones transaccion { get; set; }
        private DBCuentasxCobrarEntities entities = new DBCuentasxCobrarEntities();
        //SqlConnection ocon = null;

        public FrmEditar_Transacciones()
        {
            InitializeComponent();
        }
        
        private void FrmEditar_Transacciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBCuentasxCobrarDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dBCuentasxCobrarDataSet.Clientes);
            // TODO: This line of code loads data into the 'dBCuentasxCobrarDataSet.TipoDocumentos' table. You can move, or remove it, as needed.
            this.tipoDocumentosTableAdapter.Fill(this.dBCuentasxCobrarDataSet.TipoDocumentos);
            // TODO: This line of code loads data into the 'dBCuentasxCobrarDataSet.TipoMovimientos' table. You can move, or remove it, as needed.
            this.tipoMovimientosTableAdapter.Fill(this.dBCuentasxCobrarDataSet.TipoMovimientos);


            if (transaccion != null)
            {
                nupID.Value = transaccion.IdTrans;
                cbxCliente.SelectedValue = transaccion.IdCliente;
                cbxTipoDocumento.SelectedValue = transaccion.IdDoc;
                cbxTipoMovimiento.SelectedValue = transaccion.IdMovimiento;
                txtNumDoc.Text = transaccion.NumeroDocumento.ToString();
                dtpFecha.Value = transaccion.Fecha;
                txtMonto.Text = transaccion.Monto.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            entities.Transacciones.Add(new CuentasXCobrar.Transacciones
            {
                IdTrans = Convert.ToInt16(nupID.Value),
                IdMovimiento = Convert.ToInt16(cbxTipoMovimiento.SelectedValue),
                IdDoc = Convert.ToInt16(cbxTipoDocumento.SelectedValue),
                IdCliente = Convert.ToInt16(cbxCliente.SelectedValue),
                NumeroDocumento = Convert.ToInt16(txtNumDoc.Text),
                Fecha = dtpFecha.Value,
                Monto = Convert.ToInt64(txtMonto.Text)
            });

            entities.SaveChanges();
            MessageBox.Show("Datos guardados con exito");
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            CuentasXCobrar.Transacciones transaccion = entities.Transacciones.Find(nupID.Value);
            if (transaccion != null)
            {
                entities.Transacciones.Remove(transaccion);
                entities.SaveChanges();
                MessageBox.Show("El Movimiento ha sido eliminado con exito");
            }
            else
            {
                MessageBox.Show("El movimiento no existe");
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
