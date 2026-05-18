namespace viviro_final
{
    partial class FormResumenTarea
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblNombreValor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEspecieValor = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblAccionValor = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblPrioridadValor = new System.Windows.Forms.Label();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.lblUbicacionValor = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblFechaInicioValor = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFinValor = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblHoraValor = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblRepeticionValor = new System.Windows.Forms.Label();
            this.lblRepeticion = new System.Windows.Forms.Label();
            this.lblDescripcionValor = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstadoValor = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblInfoFotos = new System.Windows.Forms.Label();
            this.lblTotalFotos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(250, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(278, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📋 Detalle de Tarea";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(387, 550);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "❌ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFoto.Location = new System.Drawing.Point(550, 400);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(180, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 5;
            this.pbFoto.TabStop = false;
            // 
            // lblNombreValor
            // 
            this.lblNombreValor.AutoSize = true;
            this.lblNombreValor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNombreValor.Location = new System.Drawing.Point(180, 70);
            this.lblNombreValor.Name = "lblNombreValor";
            this.lblNombreValor.Size = new System.Drawing.Size(68, 21);
            this.lblNombreValor.TabIndex = 1;
            this.lblNombreValor.Text = "Azaleas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNombre.Location = new System.Drawing.Point(50, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "🌿 Nombre:";
            // 
            // lblEspecieValor
            // 
            this.lblEspecieValor.AutoSize = true;
            this.lblEspecieValor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEspecieValor.Location = new System.Drawing.Point(180, 110);
            this.lblEspecieValor.Name = "lblEspecieValor";
            this.lblEspecieValor.Size = new System.Drawing.Size(117, 21);
            this.lblEspecieValor.TabIndex = 3;
            this.lblEspecieValor.Text = "Rhododendron";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEspecie.Location = new System.Drawing.Point(50, 110);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(94, 21);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "🔬 Especie:";
            // 
            // lblAccionValor
            // 
            this.lblAccionValor.AutoSize = true;
            this.lblAccionValor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblAccionValor.Location = new System.Drawing.Point(180, 150);
            this.lblAccionValor.Name = "lblAccionValor";
            this.lblAccionValor.Size = new System.Drawing.Size(52, 21);
            this.lblAccionValor.TabIndex = 5;
            this.lblAccionValor.Text = "Riego";
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblAccion.Location = new System.Drawing.Point(50, 150);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(86, 21);
            this.lblAccion.TabIndex = 4;
            this.lblAccion.Text = "⚡ Acción:";
            // 
            // lblPrioridadValor
            // 
            this.lblPrioridadValor.AutoSize = true;
            this.lblPrioridadValor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPrioridadValor.Location = new System.Drawing.Point(180, 190);
            this.lblPrioridadValor.Name = "lblPrioridadValor";
            this.lblPrioridadValor.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.lblPrioridadValor.Size = new System.Drawing.Size(64, 25);
            this.lblPrioridadValor.TabIndex = 7;
            this.lblPrioridadValor.Text = "Media";
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPrioridad.Location = new System.Drawing.Point(50, 190);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(102, 21);
            this.lblPrioridad.TabIndex = 6;
            this.lblPrioridad.Text = "🎯 Prioridad:";
            // 
            // lblUbicacionValor
            // 
            this.lblUbicacionValor.AutoSize = true;
            this.lblUbicacionValor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblUbicacionValor.Location = new System.Drawing.Point(180, 240);
            this.lblUbicacionValor.Name = "lblUbicacionValor";
            this.lblUbicacionValor.Size = new System.Drawing.Size(153, 21);
            this.lblUbicacionValor.TabIndex = 9;
            this.lblUbicacionValor.Text = "Maceta 12 Sector 2";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblUbicacion.Location = new System.Drawing.Point(50, 240);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(78, 21);
            this.lblUbicacion.TabIndex = 8;
            this.lblUbicacion.Text = "📍 Lugar:";
            // 
            // lblFechaInicioValor
            // 
            this.lblFechaInicioValor.AutoSize = true;
            this.lblFechaInicioValor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFechaInicioValor.Location = new System.Drawing.Point(180, 290);
            this.lblFechaInicioValor.Name = "lblFechaInicioValor";
            this.lblFechaInicioValor.Size = new System.Drawing.Size(156, 21);
            this.lblFechaInicioValor.TabIndex = 11;
            this.lblFechaInicioValor.Text = "23 de junio de 2026";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFechaInicio.Location = new System.Drawing.Point(50, 290);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(77, 21);
            this.lblFechaInicio.TabIndex = 10;
            this.lblFechaInicio.Text = "📅 Inicia:";
            // 
            // lblFechaFinValor
            // 
            this.lblFechaFinValor.AutoSize = true;
            this.lblFechaFinValor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFechaFinValor.Location = new System.Drawing.Point(180, 330);
            this.lblFechaFinValor.Name = "lblFechaFinValor";
            this.lblFechaFinValor.Size = new System.Drawing.Size(156, 21);
            this.lblFechaFinValor.TabIndex = 13;
            this.lblFechaFinValor.Text = "23 de junio de 2026";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFechaFin.Location = new System.Drawing.Point(50, 330);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(93, 21);
            this.lblFechaFin.TabIndex = 12;
            this.lblFechaFin.Text = "📅 Finaliza:";
            // 
            // lblHoraValor
            // 
            this.lblHoraValor.AutoSize = true;
            this.lblHoraValor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblHoraValor.Location = new System.Drawing.Point(180, 370);
            this.lblHoraValor.Name = "lblHoraValor";
            this.lblHoraValor.Size = new System.Drawing.Size(81, 21);
            this.lblHoraValor.TabIndex = 15;
            this.lblHoraValor.Text = "07:00 AM";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblHora.Location = new System.Drawing.Point(50, 370);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(72, 21);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "⏰ Hora:";
            // 
            // lblRepeticionValor
            // 
            this.lblRepeticionValor.AutoSize = true;
            this.lblRepeticionValor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblRepeticionValor.Location = new System.Drawing.Point(180, 410);
            this.lblRepeticionValor.Name = "lblRepeticionValor";
            this.lblRepeticionValor.Size = new System.Drawing.Size(84, 21);
            this.lblRepeticionValor.TabIndex = 17;
            this.lblRepeticionValor.Text = "No repetir";
            // 
            // lblRepeticion
            // 
            this.lblRepeticion.AutoSize = true;
            this.lblRepeticion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblRepeticion.Location = new System.Drawing.Point(50, 410);
            this.lblRepeticion.Name = "lblRepeticion";
            this.lblRepeticion.Size = new System.Drawing.Size(85, 21);
            this.lblRepeticion.TabIndex = 16;
            this.lblRepeticion.Text = "🔄 Repite:";
            // 
            // lblDescripcionValor
            // 
            this.lblDescripcionValor.AutoSize = true;
            this.lblDescripcionValor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDescripcionValor.Location = new System.Drawing.Point(180, 460);
            this.lblDescripcionValor.MaximumSize = new System.Drawing.Size(350, 0);
            this.lblDescripcionValor.Name = "lblDescripcionValor";
            this.lblDescripcionValor.Size = new System.Drawing.Size(262, 21);
            this.lblDescripcionValor.TabIndex = 19;
            this.lblDescripcionValor.Text = "Riego abundante por las mañanas";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(50, 460);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 21);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "📝 Detalles:";
            // 
            // lblEstadoValor
            // 
            this.lblEstadoValor.AutoSize = true;
            this.lblEstadoValor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstadoValor.Location = new System.Drawing.Point(180, 510);
            this.lblEstadoValor.Name = "lblEstadoValor";
            this.lblEstadoValor.Size = new System.Drawing.Size(142, 24);
            this.lblEstadoValor.TabIndex = 21;
            this.lblEstadoValor.Text = "⏳ Pendiente";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEstado.Location = new System.Drawing.Point(50, 510);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(67, 21);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado:";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.Gray;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(550, 555);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(40, 30);
            this.btnAnterior.TabIndex = 26;
            this.btnAnterior.Text = "◀";
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.Gray;
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(690, 555);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 30);
            this.btnSiguiente.TabIndex = 27;
            this.btnSiguiente.Text = "▶";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // lblInfoFotos
            // 
            this.lblInfoFotos.AutoSize = true;
            this.lblInfoFotos.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblInfoFotos.Location = new System.Drawing.Point(550, 385);
            this.lblInfoFotos.Name = "lblInfoFotos";
            this.lblInfoFotos.Size = new System.Drawing.Size(150, 17);
            this.lblInfoFotos.TabIndex = 28;
            this.lblInfoFotos.Text = "📷 Sin fotos disponibles";
            // 
            // lblTotalFotos
            // 
            this.lblTotalFotos.AutoSize = true;
            this.lblTotalFotos.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblTotalFotos.Location = new System.Drawing.Point(586, 368);
            this.lblTotalFotos.Name = "lblTotalFotos";
            this.lblTotalFotos.Size = new System.Drawing.Size(90, 17);
            this.lblTotalFotos.TabIndex = 29;
            this.lblTotalFotos.Text = "Total: 0 fotos";
            // 
            // FormResumenTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblTotalFotos);
            this.Controls.Add(this.lblInfoFotos);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblEstadoValor);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcionValor);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblRepeticionValor);
            this.Controls.Add(this.lblRepeticion);
            this.Controls.Add(this.lblHoraValor);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFechaFinValor);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicioValor);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblUbicacionValor);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.lblPrioridadValor);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.lblAccionValor);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblEspecieValor);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblNombreValor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormResumenTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "📋 Resumen de Tarea - Vivero Shalom";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblNombreValor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEspecieValor;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblAccionValor;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblPrioridadValor;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.Label lblUbicacionValor;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblFechaInicioValor;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFinValor;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblHoraValor;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblRepeticionValor;
        private System.Windows.Forms.Label lblRepeticion;
        private System.Windows.Forms.Label lblDescripcionValor;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblEstadoValor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblInfoFotos;
        private System.Windows.Forms.Label lblTotalFotos;
    }
}