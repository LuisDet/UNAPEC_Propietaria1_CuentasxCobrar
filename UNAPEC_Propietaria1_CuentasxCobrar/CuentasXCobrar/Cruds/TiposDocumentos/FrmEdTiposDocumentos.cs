using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasXCobrar.Cruds.TiposDocumentos
{
    public partial class FrmEdTiposDocumentos : Form
    {
        public CuentasXCobrar.TipoDocumentos tipodocumento { get; set; }
        private DBCuentasxCobrarEntities entities = new DBCuentasxCobrarEntities();

        public FrmEdTiposDocumentos()
        {
            InitializeComponent();
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmEdTiposDocumentos_Load(object sender, EventArgs e)
        {
            if (tipodocumento != null)
            {
                nudId.Value = tipodocumento.IdDoc;
                txtDescripcion.Text = tipodocumento.Descripcion;
                txtCuenta.Text = tipodocumento.CuentaContable.ToString();
                chbEstado.Checked = tipodocumento.Estado;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            entities.TipoDocumentos.Add(new CuentasXCobrar.TipoDocumentos
            {
                IdDoc = Convert.ToInt16(nudId.Value),
                Descripcion = Convert.ToString(txtDescripcion.Text),
                CuentaContable = Convert.ToString(txtCuenta.Text),
                Estado = Convert.ToBoolean(chbEstado.Checked)
            });
            entities.SaveChanges();
            MessageBox.Show("Se a guardado con exito");
            this.Close();
        }
    }
}
