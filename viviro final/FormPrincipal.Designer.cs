namespace viviro_final
{
    partial class FormPrincipal
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnGestionar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblProximas = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalPlantas = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(400, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(310, 48);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Vivero Shalom";

            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(80, 160);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 40);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "➕ Registrar Tareas";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnGestionar
            // 
            this.btnGestionar.Location = new System.Drawing.Point(80, 100);
            this.btnGestionar.Name = "btnGestionar";
            this.btnGestionar.Size = new System.Drawing.Size(150, 40);
            this.btnGestionar.TabIndex = 1;
            this.btnGestionar.Text = "📋 Gestionar Tareas";
            this.btnGestionar.UseVisualStyleBackColor = true;
            this.btnGestionar.Click += new System.EventHandler(this.btnGestionar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(80, 220);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "🚪 Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblProximas
            // 
            this.lblProximas.AutoSize = true;
            this.lblProximas.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblProximas.Location = new System.Drawing.Point(400, 100);
            this.lblProximas.Name = "lblProximas";
            this.lblProximas.Size = new System.Drawing.Size(206, 24);
            this.lblProximas.TabIndex = 4;
            this.lblProximas.Text = "📅 Próximas Tareas";
            // 
            // dgvTareas
            // 
            this.dgvTareas.AccessibleName = "dgvTareas";
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Accion,
            this.Ubicacion,
            this.Prioridad,
            this.Fecha,
            this.Hora});
            this.dgvTareas.Location = new System.Drawing.Point(260, 127);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 30;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(950, 250);
            this.dgvTareas.TabIndex = 5;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 60;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Acción";
            this.Accion.MinimumWidth = 6;
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Width = 180;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicación";
            this.Ubicacion.MinimumWidth = 6;
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            this.Ubicacion.Width = 160;
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.MinimumWidth = 6;
            this.Prioridad.Name = "Prioridad";
            this.Prioridad.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 220;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 80;
            // 
            // lblTotalPlantas
            // 
            this.lblTotalPlantas.AutoSize = true;
            this.lblTotalPlantas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPlantas.Location = new System.Drawing.Point(400, 410);
            this.lblTotalPlantas.Name = "lblTotalPlantas";
            this.lblTotalPlantas.Size = new System.Drawing.Size(200, 21);
            this.lblTotalPlantas.TabIndex = 6;
            this.lblTotalPlantas.Text = "🌱 Plantas Totales: [0]";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPendientes.Location = new System.Drawing.Point(680, 410);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(226, 21);
            this.lblPendientes.TabIndex = 7;
            this.lblPendientes.Text = "⏰ Tareas Pendientes: [0]";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 584);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lblTotalPlantas);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.lblProximas);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnGestionar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGestionar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblProximas;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Label lblTotalPlantas;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
    }
}