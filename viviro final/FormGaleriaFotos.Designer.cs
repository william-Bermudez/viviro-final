namespace viviro_final
{
    partial class FormGaleriaFotos
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
            this.pbFotoGrande = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGrande)).BeginInit();
            this.SuspendLayout();
      
            this.pbFotoGrande.BackColor = System.Drawing.Color.Black;
            this.pbFotoGrande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFotoGrande.Location = new System.Drawing.Point(0, 0);
            this.pbFotoGrande.Name = "pbFotoGrande";
            this.pbFotoGrande.Size = new System.Drawing.Size(800, 500);
            this.pbFotoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFotoGrande.TabIndex = 0;
            this.pbFotoGrande.TabStop = false;
   
            this.btnAnterior.BackColor = System.Drawing.Color.Black;
            this.btnAnterior.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Location = new System.Drawing.Point(20, 220);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(60, 60);
            this.btnAnterior.TabIndex = 1;
            this.btnAnterior.Text = "◀";
            this.btnAnterior.UseVisualStyleBackColor = false;
     
            this.btnSiguiente.BackColor = System.Drawing.Color.Black;
            this.btnSiguiente.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(720, 220);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(60, 60);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "▶";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(700, 10);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 30);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "❌ Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
       
            this.lblInfo.BackColor = System.Drawing.Color.Black;
            this.lblInfo.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(20, 10);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(300, 30);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "📷 Foto 1 de 10";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.pbFotoGrande);
            this.KeyPreview = true;
            this.Name = "FormGaleriaFotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galería de Fotos";
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoGrande)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pbFotoGrande;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblInfo;
    }
}