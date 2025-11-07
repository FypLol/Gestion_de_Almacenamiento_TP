namespace Gestion_de_Almacenamiento_TP
{
    partial class frmGestionInventario
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
            this.btn_Editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.tbox_celular = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.lbl_tipodemerca = new System.Windows.Forms.Label();
            this.tbox_dni = new System.Windows.Forms.TextBox();
            this.lbl_origen = new System.Windows.Forms.Label();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.tbox_nombre = new System.Windows.Forms.TextBox();
            this.tbox_tamaño = new System.Windows.Forms.TextBox();
            this.tbox_origen = new System.Windows.Forms.TextBox();
            this.lbl_tamaño = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_GestionInventario = new System.Windows.Forms.DataGridView();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.tbox_Codigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_buscarCodigo = new System.Windows.Forms.Button();
            this.btn_mostrarTodo = new System.Windows.Forms.Button();
            this.tbox_codigoBuscar = new System.Windows.Forms.TextBox();
            this.lbl_dniBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GestionInventario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.Tan;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Editar.Location = new System.Drawing.Point(277, 144);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(183, 37);
            this.btn_Editar.TabIndex = 31;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 55);
            this.label1.TabIndex = 30;
            this.label1.Text = "Registrar Paquetes";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(315, 33);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(123, 13);
            this.lbl_nombre.TabIndex = 29;
            this.lbl_nombre.Text = "Nombre del Destinatario:";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Agregar.Location = new System.Drawing.Point(78, 144);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(183, 37);
            this.btn_Agregar.TabIndex = 17;
            this.btn_Agregar.Text = "AGREGAR";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // tbox_celular
            // 
            this.tbox_celular.Location = new System.Drawing.Point(466, 109);
            this.tbox_celular.Name = "tbox_celular";
            this.tbox_celular.Size = new System.Drawing.Size(266, 20);
            this.tbox_celular.TabIndex = 28;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(-118, 167);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.lbl_peso.TabIndex = 18;
            this.lbl_peso.Text = "Peso";
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Location = new System.Drawing.Point(331, 109);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(42, 13);
            this.lbl_celular.TabIndex = 27;
            this.lbl_celular.Text = "Celular:";
            // 
            // lbl_tipodemerca
            // 
            this.lbl_tipodemerca.AutoSize = true;
            this.lbl_tipodemerca.Location = new System.Drawing.Point(-150, 206);
            this.lbl_tipodemerca.Name = "lbl_tipodemerca";
            this.lbl_tipodemerca.Size = new System.Drawing.Size(100, 13);
            this.lbl_tipodemerca.TabIndex = 19;
            this.lbl_tipodemerca.Text = "Tipo de mercadería";
            // 
            // tbox_dni
            // 
            this.tbox_dni.Location = new System.Drawing.Point(466, 69);
            this.tbox_dni.Name = "tbox_dni";
            this.tbox_dni.Size = new System.Drawing.Size(266, 20);
            this.tbox_dni.TabIndex = 26;
            // 
            // lbl_origen
            // 
            this.lbl_origen.AutoSize = true;
            this.lbl_origen.Location = new System.Drawing.Point(-128, 248);
            this.lbl_origen.Name = "lbl_origen";
            this.lbl_origen.Size = new System.Drawing.Size(41, 13);
            this.lbl_origen.TabIndex = 20;
            this.lbl_origen.Text = "Origen:";
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(344, 76);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(29, 13);
            this.lbl_dni.TabIndex = 25;
            this.lbl_dni.Text = "DNI:";
            this.lbl_dni.Click += new System.EventHandler(this.lbl_dni_Click);
            // 
            // tbox_nombre
            // 
            this.tbox_nombre.Location = new System.Drawing.Point(466, 30);
            this.tbox_nombre.Name = "tbox_nombre";
            this.tbox_nombre.Size = new System.Drawing.Size(266, 20);
            this.tbox_nombre.TabIndex = 21;
            // 
            // tbox_tamaño
            // 
            this.tbox_tamaño.Location = new System.Drawing.Point(58, 67);
            this.tbox_tamaño.Name = "tbox_tamaño";
            this.tbox_tamaño.Size = new System.Drawing.Size(247, 20);
            this.tbox_tamaño.TabIndex = 24;
            // 
            // tbox_origen
            // 
            this.tbox_origen.Location = new System.Drawing.Point(59, 109);
            this.tbox_origen.Name = "tbox_origen";
            this.tbox_origen.Size = new System.Drawing.Size(247, 20);
            this.tbox_origen.TabIndex = 22;
            // 
            // lbl_tamaño
            // 
            this.lbl_tamaño.AutoSize = true;
            this.lbl_tamaño.Location = new System.Drawing.Point(9, 67);
            this.lbl_tamaño.Name = "lbl_tamaño";
            this.lbl_tamaño.Size = new System.Drawing.Size(47, 13);
            this.lbl_tamaño.TabIndex = 34;
            this.lbl_tamaño.Text = "Tanaño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Origen:";
            // 
            // dgv_GestionInventario
            // 
            this.dgv_GestionInventario.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgv_GestionInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GestionInventario.Location = new System.Drawing.Point(20, 298);
            this.dgv_GestionInventario.Name = "dgv_GestionInventario";
            this.dgv_GestionInventario.Size = new System.Drawing.Size(1014, 359);
            this.dgv_GestionInventario.TabIndex = 36;
            this.dgv_GestionInventario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GestionInventario_CellClick);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Eliminar.Location = new System.Drawing.Point(476, 144);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(183, 37);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Location = new System.Drawing.Point(12, 28);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_Codigo.TabIndex = 38;
            this.lbl_Codigo.Text = "Código";
            // 
            // tbox_Codigo
            // 
            this.tbox_Codigo.Location = new System.Drawing.Point(58, 28);
            this.tbox_Codigo.Name = "tbox_Codigo";
            this.tbox_Codigo.Size = new System.Drawing.Size(247, 20);
            this.tbox_Codigo.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbox_Codigo);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.tbox_origen);
            this.groupBox1.Controls.Add(this.lbl_Codigo);
            this.groupBox1.Controls.Add(this.btn_Editar);
            this.groupBox1.Controls.Add(this.tbox_tamaño);
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.lbl_nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbox_celular);
            this.groupBox1.Controls.Add(this.lbl_tamaño);
            this.groupBox1.Controls.Add(this.lbl_celular);
            this.groupBox1.Controls.Add(this.tbox_nombre);
            this.groupBox1.Controls.Add(this.lbl_dni);
            this.groupBox1.Controls.Add(this.tbox_dni);
            this.groupBox1.Location = new System.Drawing.Point(3, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 194);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_dniBuscar);
            this.groupBox2.Controls.Add(this.tbox_codigoBuscar);
            this.groupBox2.Controls.Add(this.btn_mostrarTodo);
            this.groupBox2.Controls.Add(this.btn_buscarCodigo);
            this.groupBox2.Location = new System.Drawing.Point(747, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 194);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btn_buscarCodigo
            // 
            this.btn_buscarCodigo.BackColor = System.Drawing.Color.Olive;
            this.btn_buscarCodigo.FlatAppearance.BorderSize = 0;
            this.btn_buscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarCodigo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_buscarCodigo.Location = new System.Drawing.Point(70, 94);
            this.btn_buscarCodigo.Name = "btn_buscarCodigo";
            this.btn_buscarCodigo.Size = new System.Drawing.Size(160, 37);
            this.btn_buscarCodigo.TabIndex = 40;
            this.btn_buscarCodigo.Text = "Buscar";
            this.btn_buscarCodigo.UseVisualStyleBackColor = false;
            this.btn_buscarCodigo.Click += new System.EventHandler(this.btn_buscarCodigo_Click);
            // 
            // btn_mostrarTodo
            // 
            this.btn_mostrarTodo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_mostrarTodo.FlatAppearance.BorderSize = 0;
            this.btn_mostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarTodo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mostrarTodo.Location = new System.Drawing.Point(70, 140);
            this.btn_mostrarTodo.Name = "btn_mostrarTodo";
            this.btn_mostrarTodo.Size = new System.Drawing.Size(160, 37);
            this.btn_mostrarTodo.TabIndex = 41;
            this.btn_mostrarTodo.Text = "Mostrar todo";
            this.btn_mostrarTodo.UseVisualStyleBackColor = false;
            this.btn_mostrarTodo.Click += new System.EventHandler(this.btn_mostrarTodo_Click);
            // 
            // tbox_codigoBuscar
            // 
            this.tbox_codigoBuscar.Location = new System.Drawing.Point(21, 60);
            this.tbox_codigoBuscar.Name = "tbox_codigoBuscar";
            this.tbox_codigoBuscar.Size = new System.Drawing.Size(266, 20);
            this.tbox_codigoBuscar.TabIndex = 40;
            // 
            // lbl_dniBuscar
            // 
            this.lbl_dniBuscar.AutoSize = true;
            this.lbl_dniBuscar.Location = new System.Drawing.Point(115, 33);
            this.lbl_dniBuscar.Name = "lbl_dniBuscar";
            this.lbl_dniBuscar.Size = new System.Drawing.Size(85, 13);
            this.lbl_dniBuscar.TabIndex = 40;
            this.lbl_dniBuscar.Text = "Código a Buscar";
            // 
            // frmGestionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 669);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_GestionInventario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_tipodemerca);
            this.Controls.Add(this.lbl_origen);
            this.Name = "frmGestionInventario";
            this.Text = "frmGestionInventario";
            this.Load += new System.EventHandler(this.frmGestionInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GestionInventario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox tbox_celular;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.Label lbl_tipodemerca;
        private System.Windows.Forms.TextBox tbox_dni;
        private System.Windows.Forms.Label lbl_origen;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox tbox_nombre;
        private System.Windows.Forms.TextBox tbox_tamaño;
        private System.Windows.Forms.TextBox tbox_origen;
        private System.Windows.Forms.Label lbl_tamaño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_GestionInventario;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.TextBox tbox_Codigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_mostrarTodo;
        private System.Windows.Forms.Button btn_buscarCodigo;
        private System.Windows.Forms.Label lbl_dniBuscar;
        private System.Windows.Forms.TextBox tbox_codigoBuscar;
    }
}