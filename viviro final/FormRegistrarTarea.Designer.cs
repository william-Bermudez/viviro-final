namespace viviro_final
{
    partial class FormRegistrarTarea
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombrePlanta = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.lblTipoAccion = new System.Windows.Forms.Label();
            this.cmbTipoAccion = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblRepeticion = new System.Windows.Forms.Label();
            this.cmbRepeticion = new System.Windows.Forms.ComboBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFotos = new System.Windows.Forms.Label();
            this.txtFotos = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSeleccionarFotos = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblInfoFotos = new System.Windows.Forms.Label();
            this.lblTotalFotos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
    
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(280, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(281, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📝 Registra Tarea";
  
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNombre.Location = new System.Drawing.Point(50, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(195, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "🌿 Nombre de la Planta *";

            this.txtNombrePlanta.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNombrePlanta.Location = new System.Drawing.Point(300, 77);
            this.txtNombrePlanta.Name = "txtNombrePlanta";
            this.txtNombrePlanta.Size = new System.Drawing.Size(400, 28);
            this.txtNombrePlanta.TabIndex = 2;

            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEspecie.Location = new System.Drawing.Point(50, 120);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(171, 21);
            this.lblEspecie.TabIndex = 3;
            this.lblEspecie.Text = "🔬 Especie (Opcional)";

            this.txtEspecie.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtEspecie.Location = new System.Drawing.Point(300, 117);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(400, 28);
            this.txtEspecie.TabIndex = 4;

            this.lblTipoAccion.AutoSize = true;
            this.lblTipoAccion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblTipoAccion.Location = new System.Drawing.Point(50, 160);
            this.lblTipoAccion.Name = "lblTipoAccion";
            this.lblTipoAccion.Size = new System.Drawing.Size(154, 21);
            this.lblTipoAccion.TabIndex = 5;
            this.lblTipoAccion.Text = "⚡ Tipo de Acción *";
  
            this.cmbTipoAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAccion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbTipoAccion.Location = new System.Drawing.Point(300, 157);
            this.cmbTipoAccion.Name = "cmbTipoAccion";
            this.cmbTipoAccion.Size = new System.Drawing.Size(400, 29);
            this.cmbTipoAccion.TabIndex = 6;
 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPrioridad.Location = new System.Drawing.Point(50, 200);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(110, 21);
            this.lblPrioridad.TabIndex = 7;
            this.lblPrioridad.Text = "🎯 Prioridad *";
 
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbPrioridad.Location = new System.Drawing.Point(300, 197);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(400, 29);
            this.cmbPrioridad.TabIndex = 8;
 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblUbicacion.Location = new System.Drawing.Point(50, 240);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(116, 21);
            this.lblUbicacion.TabIndex = 9;
            this.lblUbicacion.Text = "📍 Ubicación *";
    
            this.txtUbicacion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUbicacion.Location = new System.Drawing.Point(300, 237);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(400, 28);
            this.txtUbicacion.TabIndex = 10;
     
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFechaInicio.Location = new System.Drawing.Point(50, 280);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(134, 21);
            this.lblFechaInicio.TabIndex = 11;
            this.lblFechaInicio.Text = "📅 Fecha Inicio *";
   
            this.dtpFechaInicio.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(300, 277);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 28);
            this.dtpFechaInicio.TabIndex = 12;
     
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFechaFin.Location = new System.Drawing.Point(50, 320);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(180, 21);
            this.lblFechaFin.TabIndex = 13;
            this.lblFechaFin.Text = "📅 Fecha Finalización *";
     
            this.dtpFechaFin.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(300, 317);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 28);
            this.dtpFechaFin.TabIndex = 14;
      
            this.lblRepeticion.AutoSize = true;
            this.lblRepeticion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblRepeticion.Location = new System.Drawing.Point(50, 360);
            this.lblRepeticion.Name = "lblRepeticion";
            this.lblRepeticion.Size = new System.Drawing.Size(125, 21);
            this.lblRepeticion.TabIndex = 15;
            this.lblRepeticion.Text = "🔄 Frecuencia *";
     
            this.cmbRepeticion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepeticion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbRepeticion.Location = new System.Drawing.Point(300, 357);
            this.cmbRepeticion.Name = "cmbRepeticion";
            this.cmbRepeticion.Size = new System.Drawing.Size(400, 29);
            this.cmbRepeticion.TabIndex = 16;
      
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblHora.Location = new System.Drawing.Point(50, 400);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(80, 21);
            this.lblHora.TabIndex = 17;
            this.lblHora.Text = "⏰ Hora *";
     
            this.dtpHora.Font = new System.Drawing.Font("Tahoma", 10F);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(300, 397);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(150, 28);
            this.dtpHora.TabIndex = 18;
     
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDescripcion.Location = new System.Drawing.Point(50, 440);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(117, 21);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "📝 Descripción";
       
            this.txtDescripcion.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(300, 437);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(400, 60);
            this.txtDescripcion.TabIndex = 20;
      
            this.lblFotos.AutoSize = true;
            this.lblFotos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblFotos.Location = new System.Drawing.Point(50, 515);
            this.lblFotos.Name = "lblFotos";
            this.lblFotos.Size = new System.Drawing.Size(155, 21);
            this.lblFotos.TabIndex = 21;
            this.lblFotos.Text = "🖼️ Fotos (Opcional)";
    
            this.txtFotos.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFotos.Location = new System.Drawing.Point(300, 512);
            this.txtFotos.Name = "txtFotos";
            this.txtFotos.ReadOnly = true;
            this.txtFotos.Size = new System.Drawing.Size(200, 28);
            this.txtFotos.TabIndex = 22;
     
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(300, 580);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(200, 45);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "💾 Guardar Tarea";
            this.btnGuardar.UseVisualStyleBackColor = false;
     
            this.btnSeleccionarFotos.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSeleccionarFotos.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnSeleccionarFotos.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarFotos.Location = new System.Drawing.Point(510, 510);
            this.btnSeleccionarFotos.Name = "btnSeleccionarFotos";
            this.btnSeleccionarFotos.Size = new System.Drawing.Size(100, 30);
            this.btnSeleccionarFotos.TabIndex = 23;
            this.btnSeleccionarFotos.Text = "📁 Seleccionar";
            this.btnSeleccionarFotos.UseVisualStyleBackColor = false;
      
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPreview.Location = new System.Drawing.Point(588, 546);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(150, 60);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 24;
            this.pbPreview.TabStop = false;
      
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblPreview.Location = new System.Drawing.Point(618, 523);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(82, 17);
            this.lblPreview.TabIndex = 25;
            this.lblPreview.Text = "Vista previa:";
            this.lblPreview.Click += new System.EventHandler(this.lblPreview_Click);
       
            this.btnAnterior.BackColor = System.Drawing.Color.Gray;
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(542, 645);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(40, 30);
            this.btnAnterior.TabIndex = 26;
            this.btnAnterior.Text = "◀";
            this.btnAnterior.UseVisualStyleBackColor = false;
      
            this.btnSiguiente.BackColor = System.Drawing.Color.Gray;
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(698, 645);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(40, 30);
            this.btnSiguiente.TabIndex = 27;
            this.btnSiguiente.Text = "▶";
            this.btnSiguiente.UseVisualStyleBackColor = false;
     
            this.lblInfoFotos.AutoSize = true;
            this.lblInfoFotos.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblInfoFotos.Location = new System.Drawing.Point(571, 625);
            this.lblInfoFotos.Name = "lblInfoFotos";
            this.lblInfoFotos.Size = new System.Drawing.Size(167, 17);
            this.lblInfoFotos.TabIndex = 28;
            this.lblInfoFotos.Text = "📷 Sin fotos seleccionadas";
     
            this.lblTotalFotos.AutoSize = true;
            this.lblTotalFotos.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblTotalFotos.Location = new System.Drawing.Point(588, 652);
            this.lblTotalFotos.Name = "lblTotalFotos";
            this.lblTotalFotos.Size = new System.Drawing.Size(90, 17);
            this.lblTotalFotos.TabIndex = 29;
            this.lblTotalFotos.Text = "Total: 0 fotos";
 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 687);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTotalFotos);
            this.Controls.Add(this.lblInfoFotos);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.btnSeleccionarFotos);
            this.Controls.Add(this.txtFotos);
            this.Controls.Add(this.lblFotos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.cmbRepeticion);
            this.Controls.Add(this.lblRepeticion);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.cmbTipoAccion);
            this.Controls.Add(this.lblTipoAccion);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.txtNombrePlanta);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormRegistrarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Tarea";
            this.Load += new System.EventHandler(this.FormRegistrarTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombrePlanta;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label lblTipoAccion;
        private System.Windows.Forms.ComboBox cmbTipoAccion;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblRepeticion;
        private System.Windows.Forms.ComboBox cmbRepeticion;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFotos;
        private System.Windows.Forms.TextBox txtFotos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSeleccionarFotos;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lblInfoFotos;
        private System.Windows.Forms.Label lblTotalFotos;
    }
}