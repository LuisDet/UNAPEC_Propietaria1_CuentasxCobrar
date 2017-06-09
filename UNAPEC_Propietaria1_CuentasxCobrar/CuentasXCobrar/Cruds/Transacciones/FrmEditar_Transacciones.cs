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
        public CuentasXCobrar.Transacciones transacciones { get; set; }
        private DBCuentasxCobrarEntities entities = new DBCuentasxCobrarEntities();
        SqlConnection ocon = null;

        public FrmEditar_Transacciones()
        {
            InitializeComponent();
        }

        private void FrmEditar_Transacciones_Load(object sender, EventArgs e)
        {
            ocon = new SqlConnection("Data Source=software-unapec.database.windows.net;Initial Catalog=DBCuentasxCobrar;Integrated Security=False;User ID=unapecsql;Password=admin@1234;Connect Timeout=15;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            ocon.Open();
            cbxMovimientos_fillFromDB();
            cbxDoc_fillFromDB();
            cbxClientes_fillFromDB();

            
            if (transacciones != null)
            {
                nupID.Value = transacciones.IdTrans;
                cbxMovimiento.SelectedValue = transacciones.IdMovimiento;
                cbxDoc.SelectedValue = transacciones.IdDoc;
                cbxCliente.SelectedValue = transacciones.IdCliente;
                txtNumeroDoc.Text = transacciones.NumeroDocumento.ToString();
                txtMonto.Text = transacciones.Monto.ToString();
            }
            else
            {
                var IdTrans_NUD = from em in entities.Transacciones
                                  orderby em.IdTrans descending
                                  select em.IdTrans;
                nupID.Value = (IdTrans_NUD.FirstOrDefault() + 1);
            }

        }

        #region Llenado dinamico de ComboBoxes
        private void cbxMovimientos_fillFromDB()
        {
            string sSql1 = "select * from TipoMovimientos ORDER BY IdMovimiento";
            SqlDataAdapter oDa1 = new SqlDataAdapter(sSql1, ocon);
            DataTable oTabla1 = new DataTable();
            oDa1.Fill(oTabla1);

            cbxMovimiento.DataSource = oTabla1;
            cbxMovimiento.DisplayMember = "Tipo";
            cbxMovimiento.ValueMember = "IdMovimiento";
        }
        private void cbxDoc_fillFromDB()
        {
            string sSql2 = "select * from TipoDocumentos ORDER BY IdDoc";
            SqlDataAdapter oDa2 = new SqlDataAdapter(sSql2, ocon);
            DataTable oTabla2 = new DataTable();
            oDa2.Fill(oTabla2);

            cbxDoc.DataSource = oTabla2;
            cbxDoc.DisplayMember = "Descripcion";
            cbxDoc.ValueMember = "IdDoc";
        }

        private void cbxClientes_fillFromDB()
        {
            string sSql3 = "select * from Clientes ORDER BY IdCliente";
            SqlDataAdapter oDa3 = new SqlDataAdapter(sSql3, ocon);
            DataTable oTabla3 = new DataTable();
            oDa3.Fill(oTabla3);

            cbxCliente.DataSource = oTabla3;
            cbxCliente.DisplayMember = "Nombre";
            cbxCliente.ValueMember = "IdCliente";
        }
        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    entities.Transacciones.Add(new CuentasXCobrar.Transacciones
                    {
                        IdTrans = Int16.Parse(nupID.Value.ToString()),
                        IdMovimiento = Int32.Parse(cbxMovimiento.SelectedValue.ToString()),
                        IdDoc = Int32.Parse(cbxDoc.SelectedValue.ToString()),
                        IdCliente = Int32.Parse(cbxCliente.SelectedValue.ToString()),
                        NumeroDocumento = Convert.ToInt32(txtNumeroDoc.Text),
                        Fecha = dtpFecha.Value,
                        Monto = Convert.ToDecimal(txtMonto.Text)
                    });
                    entities.SaveChanges();
                    MessageBox.Show("Datos guardados con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n\n" + ex.Message);
                }
            this.Close();
            }
            else
            {
                MessageBox.Show("Datos invalidos. Ingrese datos correctos.");
                this.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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


        #region Eventos de validacion

        private void nupID_Validating(object sender, CancelEventArgs e)
        {
            var Trans = from em in entities.Transacciones
                        where (em.IdTrans == (int)nupID.Value
                        )
                        select em.IdTrans;

            int Contador = Trans.Count();

            bool cancel = false;
            if (Contador >= 0)
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

        private void txtNumeroDoc_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (txtNumeroDoc.Text != "")
            {
                cancel = false;
            }
            else
            {
                cancel = true;
                this.errorProvider1.SetError(txtNumeroDoc, "Debe ingresar un Monto.");
            }
            e.Cancel = cancel;
        }

        private void txtNumeroDoc_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtNumeroDoc, string.Empty);
        }

        private void txtNumeroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMonto_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            if (txtMonto.Text != "")
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

        private void txtMonto_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtMonto, string.Empty);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        #endregion

       
    }
}
