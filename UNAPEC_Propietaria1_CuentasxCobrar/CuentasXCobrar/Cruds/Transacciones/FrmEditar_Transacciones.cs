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
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                entities.Transacciones.Add(new CuentasXCobrar.Transacciones
                {
                    IdTrans = Convert.ToInt16(nupID.Value),
                    IdMovimiento = Convert.ToInt16(cbxTipoMovimiento.SelectedValue),
                    IdDoc = Convert.ToInt16(cbxTipoDocumento.SelectedValue),
                    IdCliente = Convert.ToInt16(cbxCliente.SelectedValue),
                    NumeroDocumento = Convert.ToInt32(txtNumDoc.Text),
                    Fecha = dtpFecha.Value,
                    Monto = Convert.ToDecimal(txtMonto.Text)
                });
                entities.SaveChanges();
                MessageBox.Show("Datos guardados con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos invalidos. Ingrese datos correctos.");
            }

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

        private void nupID_Validating(object sender, CancelEventArgs e)
        {
            var Trans = from em in entities.Transacciones
                              where (em.IdTrans == (int)nupID.Value
                              )
                              select em.IdTrans;

            int Contador = Trans.Count();

            bool cancel = false;
            if (Contador <= 0)
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                this.errorProvider1.SetError(this.nupID, "El ID ingresado ya existe. Por favor coloque un ID valido");
            }
            e.Cancel = cancel;
        }

        private void nupID_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.nupID, string.Empty);
        }

        private void txtNumDoc_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            var Trans = from em in entities.Transacciones
                              where (em.NumeroDocumento.ToString() == txtNumDoc.Text
                              )
                              select em.NumeroDocumento;

            if (txtNumDoc.Text != Trans.ToString())
            {
                if (txtNumDoc.Text != "")
                {
                    cancel = false;
                }
                else
                {
                    cancel = true;
                    this.errorProvider1.SetError(txtNumDoc, "Debe ingresar un Tipo.");
                }
            }
            else
            {
                cancel = true;
                this.errorProvider1.SetError(txtNumDoc, "El Tipo ingresado ya existe. Por favor coloque un Tipo valido.");
            }
            e.Cancel = cancel;
        }

        private void txtNumDoc_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtNumDoc, string.Empty);
        }

        private void txtMonto_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (txtNumDoc.Text != "")
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                this.errorProvider1.SetError(txtMonto, "Debe ingresar un Monto.");
            }
            e.Cancel = cancel;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMonto_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtMonto, string.Empty);
        }

        private void cbxTipoMovimiento_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (cbxTipoMovimiento.SelectedItem.ToString() == "")
            {
                errorProvider1.SetError(cbxTipoMovimiento, "Por favor seleccione un tipo de movimiento.");
                cancel = false;
                return;
            }
            else
            {
                errorProvider1.SetError(cbxTipoMovimiento, "");
            }
            e.Cancel = cancel;
        }

        private void cbxTipoDocumento_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (cbxTipoDocumento.SelectedItem.ToString() == "")
            {
                errorProvider1.SetError(cbxTipoDocumento, "Por favor seleccione un tipo de documento.");
                cancel = false;
                return;
            }
            else
            {
                errorProvider1.SetError(cbxTipoDocumento, "");
            }
            e.Cancel = cancel;
        }

        private void cbxCliente_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (cbxCliente.SelectedItem.ToString() == "")
            {
                errorProvider1.SetError(cbxCliente, "Por favor seleccione un Cliente.");
                cancel = false;
                return;
            }
            else
            {
                errorProvider1.SetError(cbxCliente, "");
            }
            e.Cancel = cancel;
        }

        private void cbxTipoMovimiento_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cbxTipoMovimiento, string.Empty);
        }

        private void cbxTipoDocumento_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cbxTipoDocumento, string.Empty);
        }

        private void cbxCliente_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(cbxCliente, string.Empty);
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
