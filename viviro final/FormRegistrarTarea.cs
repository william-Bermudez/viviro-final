using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace viviro_final
{
    public partial class FormRegistrarTarea : Form
    {
        private Tarea tareaEditar = null;
        private List<string> listaFotos = new List<string>();
        private int fotoActualIndex = 0;

        // Constructor para CREAR nueva tarea
        public FormRegistrarTarea()
        {
            InitializeComponent();
            ConfigurarComboBox();
            ConfigurarEventos();
        }

        // Constructor para EDITAR tarea existente
        public FormRegistrarTarea(Tarea tarea)
        {
            InitializeComponent();
            ConfigurarComboBox();
            ConfigurarEventos();
            CargarDatosParaEditar(tarea);
        }

        private void ConfigurarEventos()
        {
            this.btnGuardar.Click += new EventHandler(btnGuardar_Click);
            this.btnSeleccionarFotos.Click += new EventHandler(btnSeleccionarFotos_Click);
            this.pbPreview.Click += new EventHandler(pbPreview_Click);
            this.btnAnterior.Click += new EventHandler(btnAnterior_Click);
            this.btnSiguiente.Click += new EventHandler(btnSiguiente_Click);
            this.txtNombrePlanta.KeyPress += new KeyPressEventHandler(txtNombrePlanta_KeyPress);
        }

        private void ConfigurarComboBox()
        {
            cmbTipoAccion.Items.Clear();
            cmbTipoAccion.Items.AddRange(new string[] { "Riego", "Abonar", "Poda", "Siembra", "Trasplante", "Fumigación" });
            cmbTipoAccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoAccion.SelectedIndex = 0;

            cmbPrioridad.Items.Clear();
            cmbPrioridad.Items.AddRange(new string[] { "Alta", "Media", "Baja" });
            cmbPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrioridad.SelectedIndex = 1;

            cmbRepeticion.Items.Clear();
            cmbRepeticion.Items.AddRange(new string[] { "No repetir", "Cada día", "Cada 8 días", "Cada 15 días", "Mensual" });
            cmbRepeticion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepeticion.SelectedIndex = 0;
        }

        private void CargarDatosParaEditar(Tarea tarea)
        {
            tareaEditar = tarea;

            txtNombrePlanta.Text = tarea.NombrePlanta;
            txtEspecie.Text = tarea.Especie;
            cmbTipoAccion.SelectedItem = tarea.TipoAccion;
            cmbPrioridad.SelectedItem = tarea.Prioridad;
            txtUbicacion.Text = tarea.Ubicacion;
            dtpFechaInicio.Value = tarea.FechaInicio;
            dtpFechaFin.Value = tarea.FechaFinalizacion;
            cmbRepeticion.SelectedItem = tarea.Repeticion;
            dtpHora.Value = DateTime.Today.Add(tarea.HoraRecuerdo);
            txtDescripcion.Text = tarea.Descripcion;

            // Cargar múltiples fotos guardadas (separadas por ;)
            if (!string.IsNullOrEmpty(tarea.Fotos))
            {
                listaFotos = tarea.Fotos.Split(';').Where(f => File.Exists(f)).ToList();
                if (listaFotos.Count > 0)
                {
                    fotoActualIndex = 0;
                    MostrarFotoActual();
                    ActualizarInfoFotos();
                }
            }

            this.Text = "✏️ Editar Tarea";
            btnGuardar.Text = "📝 Actualizar Tarea";
        }

        // ==================== SELECCIONAR MÚLTIPLES FOTOS ====================
        private void btnSeleccionarFotos_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Seleccionar una o más fotos";
                openFileDialog.Multiselect = true;
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string archivo in openFileDialog.FileNames)
                    {
                        if (!listaFotos.Contains(archivo))
                        {
                            listaFotos.Add(archivo);
                        }
                    }

                    if (listaFotos.Count > 0)
                    {
                        fotoActualIndex = 0;
                        MostrarFotoActual();
                        ActualizarInfoFotos();
                    }
                }
            }
        }

        private void MostrarFotoActual()
        {
            if (listaFotos.Count > 0 && fotoActualIndex >= 0 && fotoActualIndex < listaFotos.Count)
            {
                try
                {
                    pbPreview.Image = Image.FromFile(listaFotos[fotoActualIndex]);
                    pbPreview.SizeMode = PictureBoxSizeMode.Zoom;
                    lblInfoFotos.Text = $"📷 Foto {fotoActualIndex + 1} de {listaFotos.Count}";
                    lblInfoFotos.ForeColor = Color.Green;

                    btnAnterior.Enabled = (fotoActualIndex > 0);
                    btnSiguiente.Enabled = (fotoActualIndex < listaFotos.Count - 1);
                }
                catch (Exception ex)
                {
                    pbPreview.Image = null;
                    lblInfoFotos.Text = $"❌ Error: {ex.Message}";
                    lblInfoFotos.ForeColor = Color.Red;
                }
            }
            else
            {
                pbPreview.Image = null;
                lblInfoFotos.Text = "📷 Sin fotos seleccionadas";
                lblInfoFotos.ForeColor = Color.Gray;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
            }
        }

        private void ActualizarInfoFotos()
        {
            string fotosTexto = string.Join("; ", listaFotos);
            if (txtFotos != null)
                txtFotos.Text = fotosTexto;
            if (lblTotalFotos != null)
                lblTotalFotos.Text = $"Total: {listaFotos.Count} foto(s)";
        }

        // ==================== NAVEGACIÓN ENTRE FOTOS ====================
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (fotoActualIndex > 0)
            {
                fotoActualIndex--;
                MostrarFotoActual();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (fotoActualIndex < listaFotos.Count - 1)
            {
                fotoActualIndex++;
                MostrarFotoActual();
            }
        }

        // ==================== ABRIR GALERÍA COMPLETA ====================
        private void pbPreview_Click(object sender, EventArgs e)
        {
            if (listaFotos.Count > 0)
            {
                FormGaleriaFotos galeria = new FormGaleriaFotos(listaFotos, fotoActualIndex);
                galeria.ShowDialog();
                MostrarFotoActual();
            }
            else
            {
                MessageBox.Show("No hay fotos para mostrar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ==================== VALIDAR CAMPOS ====================
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombrePlanta.Text))
            {
                MessageBox.Show("❌ El nombre de la planta es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombrePlanta.Focus();
                return false;
            }

            if (cmbTipoAccion.SelectedIndex == -1)
            {
                MessageBox.Show("❌ Debe seleccionar el tipo de acción", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoAccion.Focus();
                return false;
            }

            if (cmbPrioridad.SelectedIndex == -1)
            {
                MessageBox.Show("❌ Debe seleccionar la prioridad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPrioridad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                MessageBox.Show("❌ La ubicación es obligatoria", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUbicacion.Focus();
                return false;
            }

            if (dtpFechaFin.Value < dtpFechaInicio.Value)
            {
                MessageBox.Show("❌ La fecha final no puede ser menor a la fecha inicial", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpFechaFin.Focus();
                return false;
            }

            if (cmbRepeticion.SelectedIndex == -1)
            {
                MessageBox.Show("❌ Debe seleccionar la frecuencia de repetición", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRepeticion.Focus();
                return false;
            }

            return true;
        }

        // ==================== GUARDAR TAREA ====================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string fotosGuardadas = string.Join(";", listaFotos);

            Tarea tarea = new Tarea
            {
                Id = tareaEditar?.Id ?? 0,
                NombrePlanta = txtNombrePlanta.Text.Trim(),
                Especie = txtEspecie.Text.Trim(),
                TipoAccion = cmbTipoAccion.SelectedItem.ToString(),
                Prioridad = cmbPrioridad.SelectedItem.ToString(),
                Ubicacion = txtUbicacion.Text.Trim(),
                FechaInicio = dtpFechaInicio.Value,
                FechaFinalizacion = dtpFechaFin.Value,
                Repeticion = cmbRepeticion.SelectedItem.ToString(),
                HoraRecuerdo = dtpHora.Value.TimeOfDay,
                Descripcion = txtDescripcion.Text.Trim(),
                Fotos = fotosGuardadas,
                Completado = tareaEditar?.Completado ?? false
            };

            bool exito;
            if (tareaEditar == null)
            {
                exito = TareaDAL.AgregarTarea(tarea);
                if (exito)
                    MessageBox.Show("✅ Tarea registrada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                exito = TareaDAL.ActualizarTarea(tarea);
                if (exito)
                    MessageBox.Show("✅ Tarea actualizada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (exito)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // ==================== VALIDAR SOLO LETRAS ====================
        private void txtNombrePlanta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormRegistrarTarea_Load(object sender, EventArgs e)
        {

        }

        private void lblPreview_Click(object sender, EventArgs e)
        {

        }
    }
}