using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace viviro_final
{
    public partial class FormGaleriaFotos : Form
    {
        private List<string> listaFotos;
        private int indiceActual;

        public FormGaleriaFotos(List<string> fotos, int indiceInicial = 0)
        {
            InitializeComponent();
            this.listaFotos = fotos;
            this.indiceActual = indiceInicial;
            ConfigurarEventos();
            MostrarFotoActual();
            ActualizarInfo();
        }

        private void ConfigurarEventos()
        {
            this.btnAnterior.Click += new EventHandler(btnAnterior_Click);
            this.btnSiguiente.Click += new EventHandler(btnSiguiente_Click);
            this.btnCerrar.Click += new EventHandler(btnCerrar_Click);

            // Navegación con teclado
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormGaleriaFotos_KeyDown);
        }

        private void MostrarFotoActual()
        {
            if (listaFotos != null && listaFotos.Count > 0 && indiceActual >= 0 && indiceActual < listaFotos.Count)
            {
                try
                {
                    pbFotoGrande.Image = Image.FromFile(listaFotos[indiceActual]);
                    pbFotoGrande.SizeMode = PictureBoxSizeMode.Zoom;

                    btnAnterior.Enabled = (indiceActual > 0);
                    btnSiguiente.Enabled = (indiceActual < listaFotos.Count - 1);

                    lblInfo.Text = $"📷 Foto {indiceActual + 1} de {listaFotos.Count}";
                }
                catch (Exception ex)
                {
                    pbFotoGrande.Image = null;
                    lblInfo.Text = $"Error: {ex.Message}";
                }
            }
        }

        private void ActualizarInfo()
        {
            this.Text = $"Galería de Fotos - {indiceActual + 1} de {listaFotos.Count}";
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                MostrarFotoActual();
                ActualizarInfo();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceActual < listaFotos.Count - 1)
            {
                indiceActual++;
                MostrarFotoActual();
                ActualizarInfo();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormGaleriaFotos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                btnAnterior.PerformClick();
            }
            else if (e.KeyCode == Keys.Right)
            {
                btnSiguiente.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}