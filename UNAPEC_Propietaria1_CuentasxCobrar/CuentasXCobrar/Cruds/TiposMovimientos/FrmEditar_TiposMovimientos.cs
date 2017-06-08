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
    public partial class FrmEditar_TiposMovimientos : Form
    {
        public TipoMovimientos movimientos { get; set; }
        private DBCuentasxCobrarEntities entities = new DBCuentasxCobrarEntities();

        public FrmEditar_TiposMovimientos()
        {
            InitializeComponent();
        }

        private void FrmEditar_TiposMovimientos_Load(object sender, EventArgs e)
        {
            if (movimientos != null)
            {
                nupID.Value = movimientos.IdMovimiento;
                TxtTipo.Text = movimientos.Tipo;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    entities.TipoMovimientos.Add(new TipoMovimientos
                    {
                        IdMovimiento = (int)nupID.Value,
                        Tipo = TxtTipo.Text,
                    });
                    entities.SaveChanges();
                    MessageBox.Show("Datos guardados con exito");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar. Contacte con soporte tecnico.\n \nError: " + ex.ToString());
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Datos invalidos. Ingrese datos correctos.");
                this.Focus();
            }
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            TipoMovimientos movimientos = entities.TipoMovimientos.Find(nupID.Value);
            if (movimientos != null)
            {
                entities.TipoMovimientos.Remove(movimientos);
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
            var Movimientos = from em in entities.TipoMovimientos
                              where (em.IdMovimiento == (int)nupID.Value
                              )
                              select em.IdMovimiento;

            int Contador = Movimientos.Count();

            bool cancel = false; 
            if (Contador < 0)
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

        private void TxtTipo_Validating(object sender, CancelEventArgs e)
        {
            bool cancel = false;
            var Movimientos = from em in entities.TipoMovimientos
                              where (em.Tipo == TxtTipo.Text
                              )
                              select em.Tipo;
            if (TxtTipo.Text != Movimientos.ToString())
            {
                if (TxtTipo.Text != "")
                {
                    cancel = false;
                }
                else
                {
                    cancel = true;
                    this.errorProvider1.SetError(this.TxtTipo, "Debe ingresar un Tipo.");
                }
            }
            else
            {
                cancel = true;
                this.errorProvider1.SetError(this.TxtTipo, "El Tipo ingresado ya existe. Por favor coloque un Tipo valido.");
            }
            e.Cancel = cancel;
        }

        private void TxtTipo_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(this.TxtTipo, string.Empty);
        }
    }
}
