namespace Gestion_de_Almacenamiento_TP
{
    partial class frmHistorialMovimientos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUltimos = new System.Windows.Forms.Label();
            this.dgvHistorialMovimiento = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblTitulo.Location = new System.Drawing.Point(193, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(339, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "📦   Historial de MovimientoS";
            // 
            // lblUltimos
            // 
            this.lblUltimos.AutoSize = true;
            this.lblUltimos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimos.ForeColor = System.Drawing.Color.Salmon;
            this.lblUltimos.Location = new System.Drawing.Point(44, 67);
            this.lblUltimos.Name = "lblUltimos";
            this.lblUltimos.Size = new System.Drawing.Size(116, 18);
            this.lblUltimos.TabIndex = 2;
            this.lblUltimos.Text = "Últimos Retiros:";
            // 
            // dgvHistorialMovimiento
            // 
            this.dgvHistorialMovimiento.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvHistorialMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialMovimiento.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvHistorialMovimiento.Location = new System.Drawing.Point(26, 92);
            this.dgvHistorialMovimiento.Name = "dgvHistorialMovimiento";
            this.dgvHistorialMovimiento.Size = new System.Drawing.Size(746, 348);
            this.dgvHistorialMovimiento.TabIndex = 3;
            // 
            // frmHistorialMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHistorialMovimiento);
            this.Controls.Add(this.lblUltimos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmHistorialMovimientos";
            this.Text = "frmHistorialMovimientos";
            this.Load += new System.EventHandler(this.frmHistorialMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMovimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUltimos;
        private System.Windows.Forms.DataGridView dgvHistorialMovimiento;
    }
}