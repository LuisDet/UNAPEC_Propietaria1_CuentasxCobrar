using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            entities.TipoMovimientos.Add(new TipoMovimientos
            {
                IdMovimiento = Convert.ToInt16(nupID.Value),
                Tipo = TxtTipo.Text,
            });
            entities.SaveChanges();
            MessageBox.Show("Datos guardados con exito");
            this.Close();

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
                MessageBox.Show("El movimiento no existe");
            this.Close();
        }
    }
}
