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
    public partial class frm_registroUsuario : Form
    {
        public frm_registroUsuario()
        {
            InitializeComponent();
        }

        private void frm_registroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.Trim();
            string contrasena = txt_contraseña.Text.Trim();
            string confirmarContrasena = txt_confirmar.Text.Trim();

            if (usuario == "" || contrasena == "" || confirmarContrasena == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.",
                                "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                                "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string cadenaConexion = BDHelper.CadenaConexion;

                using (SQLiteConnection conexion = new SQLiteConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Verificar si el usuario ya existe
                    string checkQuery = "SELECT COUNT(*) FROM usuarios WHERE usuario=@usuario";
                    using (SQLiteCommand checkCmd = new SQLiteCommand(checkQuery, conexion))
                    {
                        checkCmd.Parameters.AddWithValue("@usuario", usuario);
                        int existe = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existe > 0)
                        {
                            MessageBox.Show(" Este usuario ya existe.",
                                            "Usuario duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insertar nuevo usuario
                    string insertQuery = "INSERT INTO usuarios (usuario, contrasena) VALUES (@usuario, @contrasena)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@contrasena", contrasena);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Usuario registrado correctamente.",
                                        "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        
    }
}
