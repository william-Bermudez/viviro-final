using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace viviro_final
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("❌ Debe ingresar el usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("❌ Debe ingresar la contraseña", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Validar credenciales en la base de datos
            if (ValidarUsuario(txtUsuario.Text.Trim(), txtPassword.Text))
            {
                FormPrincipal main = new FormPrincipal();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("❌ Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
        }

        private bool ValidarUsuario(string usuario, string password)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @password";

                MySqlParameter[] parameters = {
                    new MySqlParameter("@usuario", usuario),
                    new MySqlParameter("@password", password)
                };

                object resultado = DatabaseHelper.ExecuteScalar(query, parameters);
                int count = Convert.ToInt32(resultado);

                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Presionar Enter en el campo usuario lleva al campo contraseña
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        // Presionar Enter en el campo contraseña ejecuta el login
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}