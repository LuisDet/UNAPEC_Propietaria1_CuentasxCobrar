using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentasXCobrar
{
    public partial class MainMenu : Form
    {
        public Usuarios UsuarioConectado { get; set; }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioSesionForm form = new InicioSesionForm();
            form.ShowDialog();
        }

        private void TiposMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cruds.TiposMovimientos.FrmDetalles_TiposMovimientos form = new Cruds.TiposMovimientos.FrmDetalles_TiposMovimientos();
            form.ShowDialog();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cruds.Transacciones.FrmDetalles_Transacciones form = new Cruds.Transacciones.FrmDetalles_Transacciones();
            form.ShowDialog();
        }
        #region Login
        private void button1_Click(object sender, EventArgs e)
        {
            InicioSesionForm fl = new InicioSesionForm();
            fl.Show();
            this.Close();
        }
        #endregion

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (UsuarioConectado != null)
            {
                labUsuario.Text = UsuarioConectado.Usuario;
            }
        }
    }
}
