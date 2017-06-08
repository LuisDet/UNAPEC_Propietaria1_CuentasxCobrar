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

namespace CuentasXCobrar
{
    public partial class InicioSesionForm : Form
    {
        public Usuarios UsuarioConectado { get; set; }
        public InicioSesionForm()
        {
            InitializeComponent();
        }
        //ConectionString
        string cs = "Data Source=software-unapec.database.windows.net;Initial Catalog=DBCuentasxCobrar;Integrated Security=False;User ID=unapecsql;Password=admin@1234;Connect Timeout=15;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios UsuarioConectado = new Usuarios();
            if (txtUsuario.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Ingrese sus credenciales.");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Usuarios where Usuario=@username and Contraseña=@password", con);
                cmd.Parameters.AddWithValue("@username", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@password", txtPass.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Has logueado exitosamente");
                    this.Hide();
                    MainMenu fm = new MainMenu();
                    UsuarioConectado.Usuario = txtUsuario.Text;
                    fm.UsuarioConectado = UsuarioConectado;
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("No ha podido autenticarse correctamente. Ingrese sus credenciales correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
