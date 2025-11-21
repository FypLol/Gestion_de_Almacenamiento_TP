using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Almacenamiento_TP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            BDHelper.Inicializar();
        }


        private void btn_iniciarsesion_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.Trim();
            string contrasena = txt_contraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                "Campos vacíos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;

            }

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(BDHelper.CadenaConexion))
                {
                    conexion.Open();

                    string query = "SELECT COUNT(*) FROM usuarios WHERE usuario=@usuario AND contrasena=@contrasena";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Inicio de sesión exitoso",
                                            "Bienvenido",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            this.Hide();
                            frmDashboard panel = new frmDashboard();
                            panel.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.",
                                            "Error de inicio de sesión",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message,
                                "Error de BD",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);


            }

        }     

        private void btn_registrarUser_Click(object sender, EventArgs e)
        {
            frm_registroUsuario registroUsuario = new frm_registroUsuario();
            registroUsuario.ShowDialog();
        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
