namespace Gestion_de_Almacenamiento_TP
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btn_iniciarsesion = new System.Windows.Forms.Button();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_registrarUser = new System.Windows.Forms.Button();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnl_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciarsesion
            // 
            this.btn_iniciarsesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_iniciarsesion.BackColor = System.Drawing.Color.White;
            this.btn_iniciarsesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_iniciarsesion.FlatAppearance.BorderSize = 0;
            this.btn_iniciarsesion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_iniciarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarsesion.ForeColor = System.Drawing.Color.Black;
            this.btn_iniciarsesion.Location = new System.Drawing.Point(469, 352);
            this.btn_iniciarsesion.Name = "btn_iniciarsesion";
            this.btn_iniciarsesion.Size = new System.Drawing.Size(163, 39);
            this.btn_iniciarsesion.TabIndex = 17;
            this.btn_iniciarsesion.Text = "ENTRAR";
            this.btn_iniciarsesion.UseVisualStyleBackColor = false;
            this.btn_iniciarsesion.Click += new System.EventHandler(this.btn_iniciarsesion_Click);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_contraseña.Location = new System.Drawing.Point(452, 248);
            this.txt_contraseña.Multiline = true;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(234, 30);
            this.txt_contraseña.TabIndex = 19;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.txt_contraseña_TextChanged);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.White;
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(452, 146);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(234, 30);
            this.txt_usuario.TabIndex = 19;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Gadugi", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.ForeColor = System.Drawing.Color.White;
            this.lb_titulo.Location = new System.Drawing.Point(446, 53);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(244, 36);
            this.lb_titulo.TabIndex = 20;
            this.lb_titulo.Text = "INICIAR SESIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(510, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(501, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Contraseña";
            // 
            // btn_registrarUser
            // 
            this.btn_registrarUser.BackColor = System.Drawing.Color.Orange;
            this.btn_registrarUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_registrarUser.FlatAppearance.BorderSize = 0;
            this.btn_registrarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarUser.ForeColor = System.Drawing.Color.White;
            this.btn_registrarUser.Location = new System.Drawing.Point(484, 300);
            this.btn_registrarUser.Name = "btn_registrarUser";
            this.btn_registrarUser.Size = new System.Drawing.Size(136, 28);
            this.btn_registrarUser.TabIndex = 23;
            this.btn_registrarUser.Text = "Registrar Usuario";
            this.btn_registrarUser.UseVisualStyleBackColor = false;
            this.btn_registrarUser.Click += new System.EventHandler(this.btn_registrarUser_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.BackColor = System.Drawing.Color.White;
            this.pnl_logo.Controls.Add(this.pictureBox1);
            this.pnl_logo.Location = new System.Drawing.Point(-2, -3);
            this.pnl_logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(359, 458);
            this.pnl_logo.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_de_Almacenamiento_TP.Properties.Resources.logotipo_de_icono_camión_entrega_simple_vector_rápido_envío_imagen_colorido_logo_pictograma_aislado_en_fondo_blanco_203082949;
            this.pictureBox1.Location = new System.Drawing.Point(59, 145);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(394, 239);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(397, 137);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 37;
            this.pictureBox4.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(755, 453);
            this.Controls.Add(this.pnl_logo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_registrarUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.btn_iniciarsesion);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnl_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_iniciarsesion;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_registrarUser;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

