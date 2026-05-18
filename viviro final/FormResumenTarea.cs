using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace viviro_final
{
    public partial class FormResumenTarea : Form
    {
        private Tarea tarea;
        private List<string> listaFotos = new List<string>();
        private int fotoActualIndex = 0;

        public FormResumenTarea(Tarea tarea)
        {
            InitializeComponent();
            this.tarea = tarea;
            ConfigurarEventos();
            CargarResumen();
        }

        private void ConfigurarEventos()
        {
     
            this.pbFoto.Click += new EventHandler(pbFoto_Click);
            this.btnAnterior.Click += new EventHandler(btnAnterior_Click);
            this.btnSiguiente.Click += new EventHandler(btnSiguiente_Click);
            this.btnCerrar.Click += new EventHandler(btnCerrar_Click);
        }

        private void CargarResumen()
        {
            try
            {
                lblTitulo.Text = $"📋 {tarea.TipoAccion} de {tarea.NombrePlanta}";

           
                lblNombreValor.Text = tarea.NombrePlanta;
                lblEspecieValor.Text = string.IsNullOrEmpty(tarea.Especie) ? "No especificada" : tarea.Especie;
                lblAccionValor.Text = tarea.TipoAccion;
                lblUbicacionValor.Text = tarea.Ubicacion;

            
                lblPrioridadValor.Text = tarea.Prioridad;
                switch (tarea.Prioridad.ToLower())
                {
                    case "alta":
                        lblPrioridadValor.BackColor = Color.Red;
                        lblPrioridadValor.ForeColor = Color.White;
                        break;
                    case "media":
                        lblPrioridadValor.BackColor = Color.Gold;
                        lblPrioridadValor.ForeColor = Color.Black;
                        break;
                    case "baja":
                        lblPrioridadValor.BackColor = Color.LightGreen;
                        lblPrioridadValor.ForeColor = Color.Black;
                        break;
                }

              
                try
                {
                    lblFechaInicioValor.Text = tarea.FechaInicio.ToString("dddd, dd 'de' MMMM 'de' yyyy");
                }
                catch
                {
                    lblFechaInicioValor.Text = "Fecha no válida";
                }

                try
                {
                    lblFechaFinValor.Text = tarea.FechaFinalizacion.ToString("dddd, dd 'de' MMMM 'de' yyyy");
                }
                catch
                {
                    lblFechaFinValor.Text = "Fecha no válida";
                }

                try
                {
                    lblHoraValor.Text = tarea.HoraRecuerdo.ToString(@"hh\:mm tt");
                }
                catch
                {
                    lblHoraValor.Text = "Hora no válida";
                }

                lblRepeticionValor.Text = tarea.Repeticion;

                lblDescripcionValor.Text = string.IsNullOrEmpty(tarea.Descripcion) ? "Sin descripción" : tarea.Descripcion;

               
                lblEstadoValor.Text = tarea.Completado ? "✅ Completada" : "⏳ Pendiente";
                lblEstadoValor.ForeColor = tarea.Completado ? Color.Green : Color.Orange;

             
                if (!string.IsNullOrEmpty(tarea.Fotos))
                {
                   
                    listaFotos = tarea.Fotos.Split(';').Where(f => File.Exists(f)).ToList();

                    if (listaFotos.Count > 0)
                    {
                        fotoActualIndex = 0;
                        MostrarFotoActual();
                        ActualizarInfoFotos();
                    }
                    else
                    {
                        pbFoto.Image = null;
                        lblInfoFotos.Text = "📷 Sin fotos disponibles";
                        lblInfoFotos.ForeColor = Color.Gray;
                        btnAnterior.Enabled = false;
                        btnSiguiente.Enabled = false;
                        lblTotalFotos.Text = "Total: 0 fotos";
                    }
                }
                else
                {
                    pbFoto.Image = null;
                    lblInfoFotos.Text = "📷 Sin fotos disponibles";
                    lblInfoFotos.ForeColor = Color.Gray;
                    btnAnterior.Enabled = false;
                    btnSiguiente.Enabled = false;
                    lblTotalFotos.Text = "Total: 0 fotos";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar resumen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarFotoActual()
        {
            if (listaFotos.Count > 0 && fotoActualIndex >= 0 && fotoActualIndex < listaFotos.Count)
            {
                try
                {
                    pbFoto.Image = Image.FromFile(listaFotos[fotoActualIndex]);
                    pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                    lblInfoFotos.Text = $"📷 Foto {fotoActualIndex + 1} de {listaFotos.Count}";
                    lblInfoFotos.ForeColor = Color.Green;

                    btnAnterior.Enabled = (fotoActualIndex > 0);
                    btnSiguiente.Enabled = (fotoActualIndex < listaFotos.Count - 1);
                }
                catch (Exception ex)
                {
                    pbFoto.Image = null;
                    lblInfoFotos.Text = $"❌ Error: {ex.Message}";
                    lblInfoFotos.ForeColor = Color.Red;
                }
            }
            else
            {
                pbFoto.Image = null;
                lblInfoFotos.Text = "📷 Sin fotos disponibles";
                lblInfoFotos.ForeColor = Color.Gray;
                btnAnterior.Enabled = false;
                btnSiguiente.Enabled = false;
            }
        }

        private void ActualizarInfoFotos()
        {
            lblTotalFotos.Text = $"Total: {listaFotos.Count} foto(s)";
        }

    
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


        private void pbFoto_Click(object sender, EventArgs e)
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {

        }

        private void FormResumenTarea_Load(object sender, EventArgs e)
        {

        }
    }
}