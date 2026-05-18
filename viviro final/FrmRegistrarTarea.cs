using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ViveroShalom
{
    public partial class FrmRegistrarTarea : Form
    {
        private int tareaIdEditar = -1;

        public FrmRegistrarTarea()
        {
            InitializeComponent();
        }

        public FrmRegistrarTarea(int idTarea)
        {
            InitializeComponent();
            tareaIdEditar = idTarea;
        }

        private void FrmRegistrarTarea_Load(object sender, EventArgs e)
        {
            cmbIcono.Items.Clear();
            cmbIcono.Items.Add("Riego");
            cmbIcono.Items.Add("Abono");
            cmbIcono.Items.Add("Poda");
            cmbIcono.Items.Add("Trasplante");
            cmbIcono.Items.Add("Cosecha");

            cmbPrioridad.Items.Clear();
            cmbPrioridad.Items.Add("Alta");
            cmbPrioridad.Items.Add("Media");
            cmbPrioridad.Items.Add("Baja");

            cmbRepeticion.Items.Clear();
            cmbRepeticion.Items.Add("Cada 1 dia");
            cmbRepeticion.Items.Add("Cada 3 dias");
            cmbRepeticion.Items.Add("Cada 7 dias");
            cmbRepeticion.Items.Add("Cada 8 dias");
            cmbRepeticion.Items.Add("Cada 15 dias");

            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true;

            if (tareaIdEditar != -1)
            {
                CargarDatosParaEditar(tareaIdEditar);
                btnGuardar.Text = "Actualizar Tarea";
                this.Text = "Editar Tarea";
            }
        }

        private void CargarDatosParaEditar(int id)
        {
            try
            {
                using (MySqlConnection con = DatabaseHelper.ObtenerConexion())
                {
                    con.Open();
                    string query = "SELECT * FROM Tareas WHERE Id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtNombrePlanta.Text = reader["NombrePlanta"].ToString();
                        txtEspecie.Text = reader["Especie"].ToString();
                        txtAccion.Text = reader["Accion"].ToString();
                        cmbIcono.SelectedItem = reader["Icono"].ToString();
                        cmbPrioridad.SelectedItem = reader["Prioridad"].ToString();
                        txtUbicacion.Text = reader["Ubicacion"].ToString();
                        dtpFechaInicio.Value = Convert.ToDateTime(reader["FechaInicio"]);
                        dtpFechaFin.Value = Convert.ToDateTime(reader["FechaFin"]);
                        cmbRepeticion.SelectedItem = reader["Repeticion"].ToString();
                        TimeSpan hora = TimeSpan.Parse(reader["Hora"].ToString());
                        dtpHora.Value = DateTime.Today.Add(hora);
                        txtDescripcion.Text = reader["Descripcion"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error al cargar datos: " + ex.Message;
            }
        }

        private bool ValidarCampos()
        {
            if (txtNombrePlanta.Text.Trim() == "")
            {
                lblMensaje.Text = "El nombre de la planta es obligatorio.";
                txtNombrePlanta.Focus();
                return false;
            }
            if (txtAccion.Text.Trim() == "")
            {
                lblMensaje.Text = "El tipo de accion es obligatorio.";
                txtAccion.Focus();
                return false;
            }
            if (cmbIcono.SelectedIndex == -1)
            {
                lblMensaje.Text = "Debe seleccionar un icono.";
                cmbIcono.Focus();
                return false;
            }
            if (cmbPrioridad.SelectedIndex == -1)
            {
                lblMensaje.Text = "Debe seleccionar una prioridad.";
                cmbPrioridad.Focus();
                return false;
            }
            if (txtUbicacion.Text.Trim() == "")
            {
                lblMensaje.Text = "La ubicacion es obligatoria.";
                txtUbicacion.Focus();
                return false;
            }
            if (dtpFechaFin.Value < dtpFechaInicio.Value)
            {
                lblMensaje.Text = "La fecha de fin no puede ser anterior a la fecha de inicio.";
                return false;
            }
            if (cmbRepeticion.SelectedIndex == -1)
            {
                lblMensaje.Text = "Debe seleccionar la frecuencia de repeticion.";
                cmbRepeticion.Focus();
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                if (tareaIdEditar == -1)
                    InsertarTarea();
                else
                    ActualizarTarea();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }

        private void InsertarTarea()
        {
            using (MySqlConnection con = DatabaseHelper.ObtenerConexion())
            {
                con.Open();
                string query = "INSERT INTO Tareas (NombrePlanta, Especie, Accion, Icono, Prioridad, Ubicacion, FechaInicio, FechaFin, Repeticion, Hora, Descripcion, Completada) " +
                               "VALUES (@nombre, @especie, @accion, @icono, @prioridad, @ubicacion, @fechaInicio, @fechaFin, @repeticion, @hora, @descripcion, 0)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", txtNombrePlanta.Text.Trim());
                cmd.Parameters.AddWithValue("@especie", txtEspecie.Text.Trim());
                cmd.Parameters.AddWithValue("@accion", txtAccion.Text.Trim());
                cmd.Parameters.AddWithValue("@icono", cmbIcono.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@prioridad", cmbPrioridad.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ubicacion", txtUbicacion.Text.Trim());
                cmd.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value.Date);
                cmd.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value.Date);
                cmd.Parameters.AddWithValue("@repeticion", cmbRepeticion.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@hora", dtpHora.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            lblMensaje.ForeColor = System.Drawing.Color.Green;
            lblMensaje.Text = "Tarea registrada correctamente.";
            LimpiarCampos();
        }

        private void ActualizarTarea()
        {
            using (MySqlConnection con = DatabaseHelper.ObtenerConexion())
            {
                con.Open();
                string query = "UPDATE Tareas SET NombrePlanta=@nombre, Especie=@especie, Accion=@accion, Icono=@icono, Prioridad=@prioridad, " +
                               "Ubicacion=@ubicacion, FechaInicio=@fechaInicio, FechaFin=@fechaFin, Repeticion=@repeticion, Hora=@hora, Descripcion=@descripcion " +
                               "WHERE Id=@id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", txtNombrePlanta.Text.Trim());
                cmd.Parameters.AddWithValue("@especie", txtEspecie.Text.Trim());
                cmd.Parameters.AddWithValue("@accion", txtAccion.Text.Trim());
                cmd.Parameters.AddWithValue("@icono", cmbIcono.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@prioridad", cmbPrioridad.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@ubicacion", txtUbicacion.Text.Trim());
                cmd.Parameters.AddWithValue("@fechaInicio", dtpFechaInicio.Value.Date);
                cmd.Parameters.AddWithValue("@fechaFin", dtpFechaFin.Value.Date);
                cmd.Parameters.AddWithValue("@repeticion", cmbRepeticion.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@hora", dtpHora.Value.TimeOfDay);
                cmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text.Trim());
                cmd.Parameters.AddWithValue("@id", tareaIdEditar);
                cmd.ExecuteNonQuery();
            }

            lblMensaje.ForeColor = System.Drawing.Color.Green;
            lblMensaje.Text = "Tarea actualizada correctamente.";
        }

        private void LimpiarCampos()
        {
            txtNombrePlanta.Text = "";
            txtEspecie.Text = "";
            txtAccion.Text = "";
            cmbIcono.SelectedIndex = -1;
            cmbPrioridad.SelectedIndex = -1;
            txtUbicacion.Text = "";
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today;
            cmbRepeticion.SelectedIndex = -1;
            txtDescripcion.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
