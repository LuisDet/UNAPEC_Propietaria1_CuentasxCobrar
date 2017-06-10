using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasXCobrar.Cruds.Asientos_Contables
{
    public partial class FrmEdAsientosContables : Form
    {
        public CuentasXCobrar.Asientos_Contables asientocontable { get; set; }
        private DBCuentasxCobrarEntities entities = new DBCuentasxCobrarEntities();

        public FrmEdAsientosContables()
        {
            InitializeComponent();
        }

       // private void asientos_ContablesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
       // {
       //     this.Validate();s
       //     this.asientos_ContablesBindingSource.EndEdit();
       //     this.tableAdapterManager.UpdateAll(this.dBCuentasxCobrarDataSet);
       //
       // }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBCuentasxCobrarDataSet);

        }

        private void FrmEdAsientosContables_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBCuentasxCobrarDataSet.Asientos_Contables' Puede moverla o quitarla según sea necesario.
            this.asientos_ContablesTableAdapter.Fill(this.dBCuentasxCobrarDataSet.Asientos_Contables);
            // TODO: esta línea de código carga datos en la tabla 'dBCuentasxCobrarDataSet.TipoMovimientos' Puede moverla o quitarla según sea necesario.
            this.tipoMovimientosTableAdapter.Fill(this.dBCuentasxCobrarDataSet.TipoMovimientos);
            // TODO: esta línea de código carga datos en la tabla 'dBCuentasxCobrarDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dBCuentasxCobrarDataSet.Clientes);

            if (asientocontable != null)
            {
                cbxClientes.SelectedValue = asientocontable.Clientes;
                cbxTipoMovimiento.SelectedValue = asientocontable.IdMovimiento;
                txtCuenta.Text = asientocontable.Cuenta.ToString();
                dtpFecha.Value = asientocontable.Fecha;
                txtMonto.Text = asientocontable.Monto.ToString();
                cbxEstado.SelectedValue = asientocontable.Estado;
            }
        }

        private void lable10_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            entities.Asientos_Contables.Add(new CuentasXCobrar.Asientos_Contables
            {
                IdCliente = Convert.ToInt16(cbxClientes.SelectedValue),
                IdMovimiento = Convert.ToInt16(cbxTipoMovimiento.SelectedValue),
                Cuenta = Convert.ToString(txtCuenta.Text),
                Fecha = dtpFecha.Value,
                Monto = Convert.ToInt64(txtMonto.Text),
                Estado = Convert.ToBoolean(cbxEstado.Text)
            });
            entities.SaveChanges();
            MessageBox.Show("Se a guardado con exito");
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            CuentasXCobrar.Asientos_Contables asientoscontables = entities.Asientos_Contables.Find(txtCuenta.Text);
            if (asientocontable != null)
            {
                entities.Asientos_Contables.Remove(asientocontable);
                entities.SaveChanges();

                MessageBox.Show("Se a eliminado con exito");
            }
            else
            {
                MessageBox.Show("No se a podido eliminar con exito");
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
