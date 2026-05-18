using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace viviro_final
{
    public partial class FormGestionPlantas : Form
    {
        private List<Planta> listaPlantas;
        private Planta plantaSeleccionada = null;

        public FormGestionPlantas()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarPlantas();
            ConfigurarEventos();
        }

        private void ConfigurarEventos()
        {
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnCerrar.Click += btnCerrar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            dgvPlantas.CellDoubleClick += dgvPlantas_CellDoubleClick;
            dgvPlantas.SelectionChanged += dgvPlantas_SelectionChanged;
        }

        private void ConfigurarDataGridView()
        {
            dgvPlantas.Columns.Clear();
            dgvPlantas.Columns.Add("Id", "ID");
            dgvPlantas.Columns.Add("NombrePlanta", "Nombre Planta");
            dgvPlantas.Columns.Add("Especie", "Especie");
            dgvPlantas.Columns.Add("NombreCompleto", "Nombre Completo");
            dgvPlantas.Columns.Add("FechaRegistro", "Fecha Registro");

            dgvPlantas.Columns["Id"].Width = 50;
            dgvPlantas.Columns["NombrePlanta"].Width = 150;
            dgvPlantas.Columns["Especie"].Width = 150;
            dgvPlantas.Columns["NombreCompleto"].Width = 200;
            dgvPlantas.Columns["FechaRegistro"].Width = 120;

            dgvPlantas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvPlantas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dgvPlantas.ColumnHeadersHeight = 35;
            dgvPlantas.RowTemplate.Height = 35;
            dgvPlantas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            dgvPlantas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlantas.AllowUserToAddRows = false;
            dgvPlantas.AllowUserToDeleteRows = false;
            dgvPlantas.ReadOnly = true;
            dgvPlantas.MultiSelect = false;
        }

        private void CargarPlantas()
        {
            try
            {
                listaPlantas = PlantaDAL.ObtenerTodasLasPlantas();
                dgvPlantas.Rows.Clear();

                foreach (var p in listaPlantas)
                {
                    dgvPlantas.Rows.Add(
                        p.Id,
                        p.NombrePlanta,
                        string.IsNullOrEmpty(p.Especie) ? "---" : p.Especie,
                        p.NombreCompleto,
                        p.FechaRegistro.ToString("dd/MM/yyyy")
                    );
                }

                lblTotal.Text = $"📊 Total: {listaPlantas.Count} plantas registradas";
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar plantas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombrePlanta.Text = "";
            txtEspecie.Text = "";
            plantaSeleccionada = null;
            pnlFormulario.Visible = false;
        }

        private void CargarPlantaEnFormulario(Planta planta)
        {
            txtNombrePlanta.Text = planta.NombrePlanta;
            txtEspecie.Text = planta.Especie;
            plantaSeleccionada = planta;
            pnlFormulario.Visible = true;
            txtNombrePlanta.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombrePlanta.Text))
            {
                MessageBox.Show("❌ El nombre de la planta es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombrePlanta.Focus();
                return false;
            }
            return true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPlantas.SelectedRows.Count == 0)
            {
                MessageBox.Show("❌ Seleccione una planta para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvPlantas.SelectedRows[0].Cells["Id"].Value);
            var planta = listaPlantas.Find(p => p.Id == id);
            if (planta != null)
            {
                CargarPlantaEnFormulario(planta);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPlantas.SelectedRows.Count == 0)
            {
                MessageBox.Show("❌ Seleccione una planta para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nombrePlanta = dgvPlantas.SelectedRows[0].Cells["NombrePlanta"].Value.ToString();
            string especie = dgvPlantas.SelectedRows[0].Cells["Especie"].Value.ToString();
            especie = especie == "---" ? "Sin especie" : especie;

            DialogResult result = MessageBox.Show($"¿Está seguro de eliminar la planta?\n\n🌿 {nombrePlanta}\n🔬 {especie}\n\n⚠️ Esta acción no se puede deshacer.",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvPlantas.SelectedRows[0].Cells["Id"].Value);
                if (PlantaDAL.EliminarPlanta(id))
                {
                    CargarPlantas();
                    MessageBox.Show("🗑️ Planta eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            string nombre = txtNombrePlanta.Text.Trim();
            string especie = txtEspecie.Text.Trim();

            plantaSeleccionada.NombrePlanta = nombre;
            plantaSeleccionada.Especie = especie;

            if (PlantaDAL.ActualizarPlanta(plantaSeleccionada))
            {
                MessageBox.Show("✅ Planta actualizada exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlFormulario.Visible = false;
                CargarPlantas();
                LimpiarFormulario();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlFormulario.Visible = false;
            LimpiarFormulario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPlantas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dgvPlantas.Rows[e.RowIndex].Cells["Id"].Value);
                var planta = listaPlantas.Find(p => p.Id == id);
                if (planta != null)
                {
                    CargarPlantaEnFormulario(planta);
                }
            }
        }

        private void dgvPlantas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPlantas.SelectedRows.Count > 0)
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void FormGestionPlantas_Load(object sender, EventArgs e)
        {

        }
    }
}