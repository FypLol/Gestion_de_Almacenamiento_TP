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
            this.btnDeshacer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblTitulo.Location = new System.Drawing.Point(257, 27);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(424, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "📦   Historial de Movimientos";
            // 
            // lblUltimos
            // 
            this.lblUltimos.AutoSize = true;
            this.lblUltimos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimos.ForeColor = System.Drawing.Color.Salmon;
            this.lblUltimos.Location = new System.Drawing.Point(59, 82);
            this.lblUltimos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUltimos.Name = "lblUltimos";
            this.lblUltimos.Size = new System.Drawing.Size(139, 22);
            this.lblUltimos.TabIndex = 2;
            this.lblUltimos.Text = "Últimos Retiros:";
            // 
            // dgvHistorialMovimiento
            // 
            this.dgvHistorialMovimiento.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvHistorialMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialMovimiento.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvHistorialMovimiento.Location = new System.Drawing.Point(35, 113);
            this.dgvHistorialMovimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHistorialMovimiento.Name = "dgvHistorialMovimiento";
            this.dgvHistorialMovimiento.RowHeadersWidth = 51;
            this.dgvHistorialMovimiento.Size = new System.Drawing.Size(995, 428);
            this.dgvHistorialMovimiento.TabIndex = 3;
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDeshacer.FlatAppearance.BorderSize = 0;
            this.btnDeshacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeshacer.Location = new System.Drawing.Point(717, 76);
            this.btnDeshacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(312, 28);
            this.btnDeshacer.TabIndex = 4;
            this.btnDeshacer.Text = "Deshacer último movimiento";
            this.btnDeshacer.UseVisualStyleBackColor = false;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // frmHistorialMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.dgvHistorialMovimiento);
            this.Controls.Add(this.lblUltimos);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnDeshacer;
    }
}