namespace viviro_final
{
    partial class FormGestionTareas
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.btnCompletado = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(330, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(319, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📋 Gestor De Tareas";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBuscar.Location = new System.Drawing.Point(30, 80);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 28);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "🔍 Buscar tarea...";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(290, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "🔍 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbFiltrar.Items.AddRange(new object[] {
            "Todas",
            "Alta",
            "Media",
            "Baja"});
            this.cmbFiltrar.Location = new System.Drawing.Point(550, 80);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(150, 29);
            this.cmbFiltrar.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Orange;
            this.btnFiltrar.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(710, 77);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 35);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "📊 Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTareas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTareas.ColumnHeadersHeight = 35;
            this.dgvTareas.Location = new System.Drawing.Point(30, 130);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersVisible = false;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(920, 350);
            this.dgvTareas.TabIndex = 5;
          
            // btnCompletado
            // 
            this.btnCompletado.BackColor = System.Drawing.Color.Green;
            this.btnCompletado.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCompletado.ForeColor = System.Drawing.Color.White;
            this.btnCompletado.Location = new System.Drawing.Point(30, 500);
            this.btnCompletado.Name = "btnCompletado";
            this.btnCompletado.Size = new System.Drawing.Size(180, 40);
            this.btnCompletado.TabIndex = 6;
            this.btnCompletado.Text = "✅ Marcar Completado";
            this.btnCompletado.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(400, 500);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 40);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "✏️ Editar Tarea";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(770, 500);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(180, 40);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "🗑️ Eliminar Tarea";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(830, 560);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 35);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "❌ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(30, 565);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(155, 21);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "📊 Total: 0 tareas";
            // 
            // FormGestionTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 610);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCompletado);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbFiltrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormGestionTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vivero Shalom - Gestor de Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Button btnCompletado;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTotal;
    }
}