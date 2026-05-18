namespace viviro_final
{
    partial class FormGestionPlantas
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
            this.dgvPlantas = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblTituloForm = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombrePlanta = new System.Windows.Forms.TextBox();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).BeginInit();
            this.pnlFormulario.SuspendLayout();
            this.SuspendLayout();
   
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Green;
            this.lblTitulo.Location = new System.Drawing.Point(280, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(326, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🌿 Gestor de Plantas";
     
            this.dgvPlantas.ColumnHeadersHeight = 29;
            this.dgvPlantas.Location = new System.Drawing.Point(30, 70);
            this.dgvPlantas.Name = "dgvPlantas";
            this.dgvPlantas.RowHeadersWidth = 51;
            this.dgvPlantas.Size = new System.Drawing.Size(720, 350);
            this.dgvPlantas.TabIndex = 1;
    
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEditar.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnEditar.Location = new System.Drawing.Point(200, 440);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(150, 40);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "✏️ Editar Planta";
            this.btnEditar.UseVisualStyleBackColor = false;
      
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(382, 440);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "🗑️ Eliminar Planta";
            this.btnEliminar.UseVisualStyleBackColor = false;
   
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(630, 440);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 40);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "❌ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;

            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(30, 500);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(165, 21);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "📊 Total: 0 plantas";

            this.pnlFormulario.BackColor = System.Drawing.Color.LightGray;
            this.pnlFormulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormulario.Controls.Add(this.lblTituloForm);
            this.pnlFormulario.Controls.Add(this.lblNombre);
            this.pnlFormulario.Controls.Add(this.txtNombrePlanta);
            this.pnlFormulario.Controls.Add(this.lblEspecie);
            this.pnlFormulario.Controls.Add(this.txtEspecie);
            this.pnlFormulario.Controls.Add(this.btnGuardar);
            this.pnlFormulario.Controls.Add(this.btnCancelar);
            this.pnlFormulario.Location = new System.Drawing.Point(770, 70);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(300, 300);
            this.pnlFormulario.TabIndex = 7;
            this.pnlFormulario.Visible = false;
 
            this.lblTituloForm.AutoSize = true;
            this.lblTituloForm.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloForm.Location = new System.Drawing.Point(50, 24);
            this.lblTituloForm.Name = "lblTituloForm";
            this.lblTituloForm.Size = new System.Drawing.Size(204, 29);
            this.lblTituloForm.TabIndex = 0;
            this.lblTituloForm.Text = "✏️ Editar Planta";
       
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblNombre.Location = new System.Drawing.Point(30, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(154, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "🌿 Nombre Planta *";
     
            this.txtNombrePlanta.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtNombrePlanta.Location = new System.Drawing.Point(30, 110);
            this.txtNombrePlanta.Name = "txtNombrePlanta";
            this.txtNombrePlanta.Size = new System.Drawing.Size(240, 28);
            this.txtNombrePlanta.TabIndex = 2;
    
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblEspecie.Location = new System.Drawing.Point(30, 160);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(88, 21);
            this.lblEspecie.TabIndex = 3;
            this.lblEspecie.Text = "🔬 Especie";
       
            this.txtEspecie.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtEspecie.Location = new System.Drawing.Point(30, 190);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(240, 28);
            this.txtEspecie.TabIndex = 4;

            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(30, 240);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 40);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "💾 Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
   
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(160, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 40);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "❌ Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvPlantas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormGestionPlantas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Gestor de Plantas - Vivero Shalom";
            this.Load += new System.EventHandler(this.FormGestionPlantas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantas)).EndInit();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvPlantas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblTituloForm;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombrePlanta;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}