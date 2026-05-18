using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace viviro_final
{
    public partial class FormGestionTareas : Form
    {
        private List<Tarea> listaTareas;
        private List<Tarea> listaFiltrada;

        public FormGestionTareas()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            ConfigurarEventos();
            CargarTareas();
        }

        private void ConfigurarEventos()
        {
   
            this.btnBuscar.Click += new EventHandler(btnBuscar_Click);
            this.btnFiltrar.Click += new EventHandler(btnFiltrar_Click);
            this.btnCompletado.Click += new EventHandler(btnCompletado_Click);
            this.btnEditar.Click += new EventHandler(btnEditar_Click);
            this.btnEliminar.Click += new EventHandler(btnEliminar_Click);
            this.btnCerrar.Click += new EventHandler(btnCerrar_Click);

            this.txtBuscar.Enter += new EventHandler(txtBuscar_Enter);
            this.txtBuscar.Leave += new EventHandler(txtBuscar_Leave);

            this.dgvTareas.CellDoubleClick += new DataGridViewCellEventHandler(dgvTareas_CellDoubleClick);
        }

        private void ConfigurarDataGridView()
        {
            dgvTareas.Columns.Clear();

            dgvTareas.Columns.Add("NombrePlanta", "Nombre Planta");
            dgvTareas.Columns.Add("TipoAccion", "Acción");
            dgvTareas.Columns.Add("Ubicacion", "Ubicación");
            dgvTareas.Columns.Add("Prioridad", "Prioridad");
            dgvTareas.Columns.Add("FechaInicio", "Fecha Inicio");
            dgvTareas.Columns.Add("FechaFin", "Fecha Fin");
            dgvTareas.Columns.Add("Hora", "Hora");
            dgvTareas.Columns.Add("Completado", "Completado");

            dgvTareas.Columns["NombrePlanta"].Width = 160;
            dgvTareas.Columns["TipoAccion"].Width = 100;
            dgvTareas.Columns["Ubicacion"].Width = 160;
            dgvTareas.Columns["Prioridad"].Width = 100;
            dgvTareas.Columns["FechaInicio"].Width = 100;
            dgvTareas.Columns["FechaFin"].Width = 100;
            dgvTareas.Columns["Hora"].Width = 80;
            dgvTareas.Columns["Completado"].Width = 100;

            dgvTareas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvTareas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dgvTareas.ColumnHeadersHeight = 35;
            dgvTareas.RowTemplate.Height = 35;
            dgvTareas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AllowUserToDeleteRows = false;
            dgvTareas.ReadOnly = true;
            dgvTareas.MultiSelect = false;
        }

        private void CargarTareas(string filtroPrioridad = null)
        {
            try
            {
                listaTareas = TareaDAL.ObtenerTareas();

                if (!string.IsNullOrEmpty(filtroPrioridad) && filtroPrioridad != "Todas")
                {
                    listaFiltrada = listaTareas.Where(t => t.Prioridad == filtroPrioridad).ToList();
                }
                else
                {
                    listaFiltrada = listaTareas.ToList();
                }

                dgvTareas.Rows.Clear();

                foreach (var t in listaFiltrada)
                {
                    string iconoAccion = ObtenerIconoPorAccion(t.TipoAccion);
                    string completadoIcono = t.Completado ? "✅ Sí" : "❌ No";
                    string fechaInicio = t.FechaInicio.ToString("dd/MM/yyyy");
                    string fechaFin = t.FechaFinalizacion.ToString("dd/MM/yyyy");
                    string hora = t.HoraRecuerdo.ToString(@"hh\:mm");

                    int filaIndex = dgvTareas.Rows.Add(
                        $"{iconoAccion} {t.NombrePlanta}",
                        t.TipoAccion,
                        t.Ubicacion,
                        t.Prioridad,
                        fechaInicio,
                        fechaFin,
                        hora,
                        completadoIcono
                    );

                    dgvTareas.Rows[filaIndex].Tag = t.Id;

           
                    switch (t.Prioridad.ToLower())
                    {
                        case "alta":
                            dgvTareas.Rows[filaIndex].Cells[3].Style.BackColor = Color.Red;
                            dgvTareas.Rows[filaIndex].Cells[3].Style.ForeColor = Color.White;
                            break;
                        case "media":
                            dgvTareas.Rows[filaIndex].Cells[3].Style.BackColor = Color.Gold;
                            dgvTareas.Rows[filaIndex].Cells[3].Style.ForeColor = Color.Black;
                            break;
                        case "baja":
                            dgvTareas.Rows[filaIndex].Cells[3].Style.BackColor = Color.LightGreen;
                            dgvTareas.Rows[filaIndex].Cells[3].Style.ForeColor = Color.Black;
                            break;
                    }
                }

                lblTotal.Text = $"📊 Total: {listaFiltrada.Count} tareas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar tareas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerIconoPorAccion(string accion)
        {
            switch (accion.ToLower())
            {
                case "riego": return "💧";
                case "abonar": return "🌿";
                case "poda": return "✂️";
                case "siembra": return "🌱";
                case "trasplante": return "🪴";
                case "fumigación": return "💨";
                default: return "📋";
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(busqueda) || busqueda == "🔍 buscar tarea...")
            {
                CargarTareas(cmbFiltrar.SelectedItem?.ToString());
                return;
            }

            try
            {
                var buscadas = listaTareas.Where(t =>
                    t.NombrePlanta.ToLower().Contains(busqueda) ||
                    t.TipoAccion.ToLower().Contains(busqueda) ||
                    t.Ubicacion.ToLower().Contains(busqueda)).ToList();

                dgvTareas.Rows.Clear();

                foreach (var t in buscadas)
                {
                    string iconoAccion = ObtenerIconoPorAccion(t.TipoAccion);
                    string completadoIcono = t.Completado ? "✅ Sí" : "❌ No";
                    string fechaInicio = t.FechaInicio.ToString("dd/MM/yyyy");
                    string fechaFin = t.FechaFinalizacion.ToString("dd/MM/yyyy");
                    string hora = t.HoraRecuerdo.ToString(@"hh\:mm");

                    int filaIndex = dgvTareas.Rows.Add(
                        $"{iconoAccion} {t.NombrePlanta}",
                        t.TipoAccion,
                        t.Ubicacion,
                        t.Prioridad,
                        fechaInicio,
                        fechaFin,
                        hora,
                        completadoIcono
                    );

                    dgvTareas.Rows[filaIndex].Tag = t.Id;
                }

                lblTotal.Text = $"🔍 Resultados: {buscadas.Count} tareas encontradas";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = cmbFiltrar.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(filtro) || filtro == "Todas")
            {
                CargarTareas(null);
            }
            else
            {
                CargarTareas(filtro);
            }
        }


        private void btnCompletado_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("❌ Seleccione una tarea primero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvTareas.SelectedRows[0].Tag;
            var tarea = listaTareas.FirstOrDefault(t => t.Id == id);

            if (tarea != null)
            {
                bool nuevoEstado = !tarea.Completado;
                if (TareaDAL.MarcarCompletada(id, nuevoEstado))
                {
                    string filtroActual = cmbFiltrar.SelectedItem?.ToString();
                    CargarTareas(filtroActual == "Todas" ? null : filtroActual);
                    MessageBox.Show($"✅ Tarea {(nuevoEstado ? "completada" : "marcada como pendiente")}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("❌ Error al actualizar el estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("❌ Seleccione una tarea para editar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvTareas.SelectedRows[0].Tag;
            var tarea = TareaDAL.ObtenerTareaPorId(id);

            if (tarea != null)
            {
                FormRegistrarTarea form = new FormRegistrarTarea(tarea);
                form.ShowDialog();
                string filtroActual = cmbFiltrar.SelectedItem?.ToString();
                CargarTareas(filtroActual == "Todas" ? null : filtroActual);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("❌ Seleccione una tarea para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta tarea?\n\n⚠️ Esta acción no se puede deshacer.",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = (int)dgvTareas.SelectedRows[0].Tag;
                if (TareaDAL.EliminarTarea(id))
                {
                    string filtroActual = cmbFiltrar.SelectedItem?.ToString();
                    CargarTareas(filtroActual == "Todas" ? null : filtroActual);
                    MessageBox.Show("🗑️ Tarea eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("❌ Error al eliminar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "🔍 Buscar tarea...")
                txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                txtBuscar.Text = "🔍 Buscar tarea...";
        }

        private void dgvTareas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvTareas.Rows[e.RowIndex].Tag == null)
                {
                    MessageBox.Show("No se pudo obtener el ID de la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = (int)dgvTareas.Rows[e.RowIndex].Tag;
                var tarea = TareaDAL.ObtenerTareaPorId(id);

                if (tarea != null)
                {
                    FormResumenTarea resumen = new FormResumenTarea(tarea);
                    resumen.ShowDialog();
                }
            }
        }
    }
}