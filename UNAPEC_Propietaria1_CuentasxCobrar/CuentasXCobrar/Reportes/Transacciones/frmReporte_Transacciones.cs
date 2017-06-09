using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasXCobrar.Reportes.Transacciones
{
    public partial class frmReporte_Transacciones : Form
    {
        private DBCuentasxCobrarEntities entities = new DBCuentasxCobrarEntities();
        public frmReporte_Transacciones()
        {
            InitializeComponent();
        }

        private void frmReporte_Transacciones_Load(object sender, EventArgs e)
        {
            TransaccionesBindingSource.DataSource = entities.Transacciones.ToList();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Filtro = from em in entities.Transacciones
                                         where (em.TipoMovimientos.Tipo.ToString().StartsWith(txtFiltro.Text) ||
                                         em.TipoDocumentos.Descripcion.ToString().StartsWith(txtFiltro.Text) ||
                                         em.Clientes.Nombre.ToString().StartsWith(txtFiltro.Text) ||
                                         em.Fecha.ToString().StartsWith(txtFiltro.Text)
                                       //|| em.Monto >= Decimal.Parse(txtFiltro.Text) 
                                         )
                                         select em;
            TransaccionesBindingSource.DataSource = Filtro.ToList();
            this.reportViewer1.RefreshReport();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
