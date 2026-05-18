using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace viviro_final
{
    public partial class FormPrincipal : Form
    {
        private Timer timerNotificaciones;
        private Timer timerActualizarContadores;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenu;

        public FormPrincipal()
        {
            InitializeComponent();
            ConfigurarColumnasDataGridView();
            ConfigurarNotifyIcon();
            CargarTareasProximas();
            ActualizarContadores();
            IniciarTimers();
        }

        private void ConfigurarNotifyIcon()
        {
            notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.Visible = true;
            notifyIcon.Text = "Vivero Shalom - Gestor de Tareas";
            notifyIcon.BalloonTipTitle = "📢 Vivero Shalom";
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;

            contextMenu = new ContextMenuStrip();
            ToolStripMenuItem itemAbrir = new ToolStripMenuItem("📋 Abrir Vivero");
            itemAbrir.Click += (s, e) => { this.WindowState = FormWindowState.Normal; this.BringToFront(); };
            ToolStripMenuItem itemCerrar = new ToolStripMenuItem("❌ Cerrar");
            itemCerrar.Click += (s, e) => { notifyIcon.Visible = false; Application.Exit(); };

            contextMenu.Items.Add(itemAbrir);
            contextMenu.Items.Add(new ToolStripSeparator());
            contextMenu.Items.Add(itemCerrar);

            notifyIcon.ContextMenuStrip = contextMenu;
            notifyIcon.DoubleClick += (s, e) => { this.WindowState = FormWindowState.Normal; this.BringToFront(); };
        }

        private void MostrarNotificacion(string titulo, string mensaje, ToolTipIcon icono = ToolTipIcon.Info)
        {
            notifyIcon.BalloonTipTitle = titulo;
            notifyIcon.BalloonTipText = mensaje;
            notifyIcon.BalloonTipIcon = icono;
            notifyIcon.ShowBalloonTip(5000);
        }

        private void ConfigurarColumnasDataGridView()
        {
            dgvTareas.Columns.Clear();
            dgvTareas.Rows.Clear();

            dgvTareas.Columns.Add("Tipo", "Tipo");
            dgvTareas.Columns.Add("Accion", "Acción");
            dgvTareas.Columns.Add("Ubicacion", "Ubicación");
            dgvTareas.Columns.Add("Prioridad", "Prioridad");
            dgvTareas.Columns.Add("Fecha", "Fecha");
            dgvTareas.Columns.Add("Hora", "Hora");

            dgvTareas.Columns["Tipo"].Width = 60;
            dgvTareas.Columns["Accion"].Width = 220;
            dgvTareas.Columns["Ubicacion"].Width = 180;
            dgvTareas.Columns["Prioridad"].Width = 110;
            dgvTareas.Columns["Fecha"].Width = 220;
            dgvTareas.Columns["Hora"].Width = 80;

            dgvTareas.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold);
            dgvTareas.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGreen;
            dgvTareas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTareas.ColumnHeadersHeight = 35;

            dgvTareas.RowTemplate.Height = 35;
            dgvTareas.DefaultCellStyle.Font = new Font("Tahoma", 9);
            dgvTareas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvTareas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            dgvTareas.BackgroundColor = Color.White;

            dgvTareas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTareas.AllowUserToAddRows = false;
            dgvTareas.AllowUserToDeleteRows = false;
            dgvTareas.ReadOnly = true;
            dgvTareas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvTareas.RowHeadersVisible = false;
            dgvTareas.BorderStyle = BorderStyle.Fixed3D;

            dgvTareas.Refresh();
        }

        private void CargarTareasProximas()
        {
            try
            {
                dgvTareas.Rows.Clear();
                dgvTareas.Refresh();

                DateTime hoy = DateTime.Now.Date;
                DateTime finSemana = hoy.AddDays(7);

                var todasTareas = TareaDAL.ObtenerTareas();

                if (todasTareas == null || todasTareas.Count == 0)
                {
                    dgvTareas.Rows.Add("📋", "No hay tareas registradas", "---", "---", "---", "---");
                    return;
                }

                var tareasSemana = todasTareas
                    .Where(t => t.Completado == false && t.FechaInicio.Date >= hoy && t.FechaInicio.Date <= finSemana)
                    .OrderBy(t => t.FechaInicio)
                    .ThenBy(t => t.HoraRecuerdo)
                    .ToList();

                if (tareasSemana.Count == 0)
                {
                    dgvTareas.Rows.Add("📅", "No hay tareas para esta semana", "---", "---", "---", "---");
                    return;
                }

                foreach (var tarea in tareasSemana)
                {
                    string iconoAccion = ObtenerIconoPorAccion(tarea.TipoAccion);
                    int diasRestantes = (tarea.FechaInicio - hoy).Days;
                    string fechaConDias = $"{tarea.FechaInicio:dd/MM/yyyy} (en {diasRestantes} día{(diasRestantes != 1 ? "s" : "")})";

                    int filaIndex = dgvTareas.Rows.Add(
                        iconoAccion,
                        tarea.TipoAccion + " de " + tarea.NombrePlanta,
                        tarea.Ubicacion,
                        tarea.Prioridad,
                        fechaConDias,
                        tarea.HoraRecuerdo.ToString(@"hh\:mm")
                    );

                    switch (tarea.Prioridad.ToLower())
                    {
                        case "alta":
                            dgvTareas.Rows[filaIndex].Cells[3].Style.BackColor = Color.Red;
                            dgvTareas.Rows[filaIndex].Cells[3].Style.ForeColor = Color.White;
                            dgvTareas.Rows[filaIndex].Cells[3].Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
                            break;
                        case "media":
                            dgvTareas.Rows[filaIndex].Cells[3].Style.BackColor = Color.Gold;
                            dgvTareas.Rows[filaIndex].Cells[3].Style.ForeColor = Color.Black;
                            dgvTareas.Rows[filaIndex].Cells[3].Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
                            break;
                        case "baja":
                            dgvTareas.Rows[filaIndex].Cells[3].Style.BackColor = Color.LightGreen;
                            dgvTareas.Rows[filaIndex].Cells[3].Style.ForeColor = Color.Black;
                            break;
                    }
                }

                dgvTareas.Refresh();
                dgvTareas.Update();
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

        private void ActualizarContadores()
        {
            try
            {
                int totalPlantas = TareaDAL.ContarPlantasTotales();
                int tareasPendientes = TareaDAL.ContarTareasPendientes();

                lblTotalPlantas.Text = $"🌱 Plantas Totales: [{totalPlantas}]";
                lblPendientes.Text = $"⏰ Tareas Pendientes: [{tareasPendientes}]";

                if (tareasPendientes > 10)
                {
                    lblPendientes.ForeColor = Color.Red;
                    notifyIcon.Icon = SystemIcons.Warning;
                }
                else if (tareasPendientes > 5)
                {
                    lblPendientes.ForeColor = Color.Orange;
                    notifyIcon.Icon = SystemIcons.Warning;
                }
                else
                {
                    lblPendientes.ForeColor = Color.Green;
                    notifyIcon.Icon = SystemIcons.Information;
                }
            }
            catch (Exception ex)
            {
                lblTotalPlantas.Text = "🌱 Plantas Totales: [0]";
                lblPendientes.Text = "⏰ Tareas Pendientes: [0]";
            }
        }

        private void IniciarTimers()
        {
            timerNotificaciones = new Timer();
            timerNotificaciones.Interval = 30000;
            timerNotificaciones.Tick += TimerNotificaciones_Tick;
            timerNotificaciones.Start();

            timerActualizarContadores = new Timer();
            timerActualizarContadores.Interval = 30000;
            timerActualizarContadores.Tick += TimerActualizarContadores_Tick;
            timerActualizarContadores.Start();
        }

        private void TimerActualizarContadores_Tick(object sender, EventArgs e)
        {
            ActualizarContadores();
        }

        private void TimerNotificaciones_Tick(object sender, EventArgs e)
        {
            try
            {
                var ahora = DateTime.Now;
                var todasTareas = TareaDAL.ObtenerTareas();
                var tareasHoy = todasTareas.Where(t => !t.Completado && t.FechaInicio.Date == ahora.Date).ToList();

                foreach (var tarea in tareasHoy)
                {
                    TimeSpan horaTarea = tarea.HoraRecuerdo;
                    TimeSpan horaActual = ahora.TimeOfDay;
                    TimeSpan diferencia = horaTarea - horaActual;

                    if (diferencia.TotalSeconds > 0 && diferencia.TotalSeconds <= 90)
                    {
                        MostrarNotificacion(
                            "⏰ Recordatorio - 1 minuto antes",
                            $"📋 {tarea.TipoAccion} de {tarea.NombrePlanta}\n📍 {tarea.Ubicacion}\n⏰ En 1 minuto ({horaTarea:hh\\:mm})",
                            ToolTipIcon.Info
                        );
                    }
                    else if (Math.Abs(diferencia.TotalSeconds) <= 30)
                    {
                        MostrarNotificacion(
                            "🔔 Hora de la tarea",
                            $"📋 {tarea.TipoAccion} de {tarea.NombrePlanta}\n📍 {tarea.Ubicacion}\n⏰ {horaTarea:hh\\:mm} - ¡Es hora de realizarla!",
                            ToolTipIcon.Info
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en notificación: {ex.Message}");
            }
        }

        private void btnGestionar_Click(object sender, EventArgs e)
        {
            FormGestionTareas form = new FormGestionTareas();
            form.ShowDialog();
            CargarTareasProximas();
            ActualizarContadores();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarTarea form = new FormRegistrarTarea();
            form.ShowDialog();
            CargarTareasProximas();
            ActualizarContadores();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (timerNotificaciones != null)
                    timerNotificaciones.Stop();
                if (timerActualizarContadores != null)
                    timerActualizarContadores.Stop();
                if (notifyIcon != null)
                    notifyIcon.Visible = false;
                this.Close();
                Application.Exit();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (timerNotificaciones != null)
                timerNotificaciones.Stop();
            if (timerActualizarContadores != null)
                timerActualizarContadores.Stop();
            if (notifyIcon != null)
                notifyIcon.Visible = false;
            base.OnFormClosing(e);
        }
    }
}