namespace PantallaPersonal
{
    partial class pantallaPersonal
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnModificarPersonal = new System.Windows.Forms.Button();
            this.btnAgregarPersonal = new System.Windows.Forms.Button();
            this.txtJerarquia = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFiltrarPor = new System.Windows.Forms.ComboBox();
            this.txtFiltrarPor = new System.Windows.Forms.TextBox();
            this.btnCargarBomberos = new System.Windows.Forms.Button();
            this.btnCargarSubOficiales = new System.Windows.Forms.Button();
            this.btnCargarOficiales = new System.Windows.Forms.Button();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModificarPersonal
            // 
            this.btnModificarPersonal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPersonal.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnModificarPersonal.Location = new System.Drawing.Point(54, 457);
            this.btnModificarPersonal.Name = "btnModificarPersonal";
            this.btnModificarPersonal.Size = new System.Drawing.Size(256, 91);
            this.btnModificarPersonal.TabIndex = 35;
            this.btnModificarPersonal.Text = "Modificar Personal";
            this.btnModificarPersonal.UseVisualStyleBackColor = false;
            // 
            // btnAgregarPersonal
            // 
            this.btnAgregarPersonal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPersonal.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAgregarPersonal.Location = new System.Drawing.Point(54, 331);
            this.btnAgregarPersonal.Name = "btnAgregarPersonal";
            this.btnAgregarPersonal.Size = new System.Drawing.Size(256, 89);
            this.btnAgregarPersonal.TabIndex = 34;
            this.btnAgregarPersonal.Text = "Agregar Personal";
            this.btnAgregarPersonal.UseVisualStyleBackColor = false;
            // 
            // txtJerarquia
            // 
            this.txtJerarquia.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJerarquia.Location = new System.Drawing.Point(174, 195);
            this.txtJerarquia.Name = "txtJerarquia";
            this.txtJerarquia.Size = new System.Drawing.Size(179, 31);
            this.txtJerarquia.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(175, 150);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 31);
            this.txtNombre.TabIndex = 32;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(175, 65);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(178, 31);
            this.txtDNI.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(21, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 37);
            this.label6.TabIndex = 30;
            this.label6.Text = "Jerarquía";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(21, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 37);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(21, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 37);
            this.label4.TabIndex = 28;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Buscando por:";
            // 
            // cmbFiltrarPor
            // 
            this.cmbFiltrarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarPor.FormattingEnabled = true;
            this.cmbFiltrarPor.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Apellido",
            "DNI",
            ""});
            this.cmbFiltrarPor.Location = new System.Drawing.Point(682, 111);
            this.cmbFiltrarPor.Name = "cmbFiltrarPor";
            this.cmbFiltrarPor.Size = new System.Drawing.Size(170, 37);
            this.cmbFiltrarPor.TabIndex = 25;
            this.cmbFiltrarPor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtFiltrarPor
            // 
            this.txtFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarPor.Location = new System.Drawing.Point(6, 114);
            this.txtFiltrarPor.Name = "txtFiltrarPor";
            this.txtFiltrarPor.Size = new System.Drawing.Size(315, 34);
            this.txtFiltrarPor.TabIndex = 24;
            // 
            // btnCargarBomberos
            // 
            this.btnCargarBomberos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarBomberos.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarBomberos.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCargarBomberos.Location = new System.Drawing.Point(6, 27);
            this.btnCargarBomberos.Name = "btnCargarBomberos";
            this.btnCargarBomberos.Size = new System.Drawing.Size(266, 76);
            this.btnCargarBomberos.TabIndex = 23;
            this.btnCargarBomberos.Text = "Cargar Bomberos/Cadetes";
            this.btnCargarBomberos.UseVisualStyleBackColor = false;
            // 
            // btnCargarSubOficiales
            // 
            this.btnCargarSubOficiales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarSubOficiales.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarSubOficiales.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCargarSubOficiales.Location = new System.Drawing.Point(340, 25);
            this.btnCargarSubOficiales.Name = "btnCargarSubOficiales";
            this.btnCargarSubOficiales.Size = new System.Drawing.Size(220, 78);
            this.btnCargarSubOficiales.TabIndex = 22;
            this.btnCargarSubOficiales.Text = "Cargar SubOficiales";
            this.btnCargarSubOficiales.UseVisualStyleBackColor = false;
            // 
            // btnCargarOficiales
            // 
            this.btnCargarOficiales.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCargarOficiales.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarOficiales.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCargarOficiales.Location = new System.Drawing.Point(637, 25);
            this.btnCargarOficiales.Name = "btnCargarOficiales";
            this.btnCargarOficiales.Size = new System.Drawing.Size(215, 80);
            this.btnCargarOficiales.TabIndex = 21;
            this.btnCargarOficiales.Text = "Cargar Oficiales";
            this.btnCargarOficiales.UseVisualStyleBackColor = false;
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column6});
            this.dgvPersonal.Location = new System.Drawing.Point(6, 167);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.RowHeadersVisible = false;
            this.dgvPersonal.RowHeadersWidth = 51;
            this.dgvPersonal.RowTemplate.Height = 24;
            this.dgvPersonal.Size = new System.Drawing.Size(846, 462);
            this.dgvPersonal.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DNI";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Apellido";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jerarquía";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Condición";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(174, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(179, 31);
            this.txtCodigo.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPersonal);
            this.groupBox1.Controls.Add(this.btnCargarBomberos);
            this.groupBox1.Controls.Add(this.txtFiltrarPor);
            this.groupBox1.Controls.Add(this.btnCargarSubOficiales);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCargarOficiales);
            this.groupBox1.Controls.Add(this.cmbFiltrarPor);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 635);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(263, 270);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(136, 28);
            this.textBox7.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCondicion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtJerarquia);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtDNI);
            this.groupBox2.Controls.Add(this.btnAgregarPersonal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnModificarPersonal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(896, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 635);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mantenimiento";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCondicion.Location = new System.Drawing.Point(174, 238);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(179, 31);
            this.txtCondicion.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(21, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 37);
            this.label8.TabIndex = 39;
            this.label8.Text = "Condición";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(175, 105);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(178, 31);
            this.txtApellido.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "Apellido";
            // 
            // pantallaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "pantallaPersonal";
            this.Size = new System.Drawing.Size(1284, 661);
            this.Load += new System.EventHandler(this.pantallaPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModificarPersonal;
        private System.Windows.Forms.Button btnAgregarPersonal;
        private System.Windows.Forms.TextBox txtJerarquia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFiltrarPor;
        private System.Windows.Forms.TextBox txtFiltrarPor;
        private System.Windows.Forms.Button btnCargarBomberos;
        private System.Windows.Forms.Button btnCargarSubOficiales;
        private System.Windows.Forms.Button btnCargarOficiales;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
