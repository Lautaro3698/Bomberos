namespace PantallaPersonal
{
    partial class Áreas
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
            this.dgvAreas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReuniones = new System.Windows.Forms.Button();
            this.btnGuardias = new System.Windows.Forms.Button();
            this.btnRoperia = new System.Windows.Forms.Button();
            this.btnEdificio = new System.Windows.Forms.Button();
            this.btnAgregarArea = new System.Windows.Forms.Button();
            this.btnAutomotor = new System.Windows.Forms.Button();
            this.btnTaller = new System.Windows.Forms.Button();
            this.btnCapacitacion = new System.Windows.Forms.Button();
            this.btnFurrieles = new System.Windows.Forms.Button();
            this.txtFiltrarPor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtIdentidad = new System.Windows.Forms.TextBox();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtPunto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFiltrarPor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAreas
            // 
            this.dgvAreas.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvAreas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAreas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dgvAreas.Location = new System.Drawing.Point(29, 189);
            this.dgvAreas.Name = "dgvAreas";
            this.dgvAreas.RowHeadersVisible = false;
            this.dgvAreas.RowHeadersWidth = 51;
            this.dgvAreas.RowTemplate.Height = 24;
            this.dgvAreas.Size = new System.Drawing.Size(1225, 280);
            this.dgvAreas.TabIndex = 41;
            this.dgvAreas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAreas_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Identificacion";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nombre";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tareas Realizadas";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Observación";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReuniones);
            this.groupBox1.Controls.Add(this.btnGuardias);
            this.groupBox1.Controls.Add(this.btnRoperia);
            this.groupBox1.Controls.Add(this.btnEdificio);
            this.groupBox1.Controls.Add(this.btnAgregarArea);
            this.groupBox1.Controls.Add(this.btnAutomotor);
            this.groupBox1.Controls.Add(this.btnTaller);
            this.groupBox1.Controls.Add(this.btnCapacitacion);
            this.groupBox1.Controls.Add(this.btnFurrieles);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1255, 137);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Areas";
            // 
            // btnReuniones
            // 
            this.btnReuniones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReuniones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReuniones.ForeColor = System.Drawing.SystemColors.Info;
            this.btnReuniones.Location = new System.Drawing.Point(890, 34);
            this.btnReuniones.Name = "btnReuniones";
            this.btnReuniones.Size = new System.Drawing.Size(125, 84);
            this.btnReuniones.TabIndex = 43;
            this.btnReuniones.Text = "Reuniones";
            this.btnReuniones.UseVisualStyleBackColor = false;
            this.btnReuniones.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnGuardias
            // 
            this.btnGuardias.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardias.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGuardias.Location = new System.Drawing.Point(766, 34);
            this.btnGuardias.Name = "btnGuardias";
            this.btnGuardias.Size = new System.Drawing.Size(125, 84);
            this.btnGuardias.TabIndex = 44;
            this.btnGuardias.Text = "Guardias";
            this.btnGuardias.UseVisualStyleBackColor = false;
            this.btnGuardias.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnRoperia
            // 
            this.btnRoperia.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRoperia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoperia.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRoperia.Location = new System.Drawing.Point(643, 34);
            this.btnRoperia.Name = "btnRoperia";
            this.btnRoperia.Size = new System.Drawing.Size(125, 84);
            this.btnRoperia.TabIndex = 45;
            this.btnRoperia.Text = "Roperia";
            this.btnRoperia.UseVisualStyleBackColor = false;
            this.btnRoperia.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnEdificio
            // 
            this.btnEdificio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdificio.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEdificio.Location = new System.Drawing.Point(519, 34);
            this.btnEdificio.Name = "btnEdificio";
            this.btnEdificio.Size = new System.Drawing.Size(125, 84);
            this.btnEdificio.TabIndex = 46;
            this.btnEdificio.Text = "Edificio";
            this.btnEdificio.UseVisualStyleBackColor = false;
            this.btnEdificio.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnAgregarArea
            // 
            this.btnAgregarArea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarArea.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArea.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAgregarArea.Location = new System.Drawing.Point(1013, 34);
            this.btnAgregarArea.Name = "btnAgregarArea";
            this.btnAgregarArea.Size = new System.Drawing.Size(120, 84);
            this.btnAgregarArea.TabIndex = 63;
            this.btnAgregarArea.Text = "Agregar área nueva";
            this.btnAgregarArea.UseVisualStyleBackColor = false;
            // 
            // btnAutomotor
            // 
            this.btnAutomotor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAutomotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomotor.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAutomotor.Location = new System.Drawing.Point(393, 34);
            this.btnAutomotor.Name = "btnAutomotor";
            this.btnAutomotor.Size = new System.Drawing.Size(125, 84);
            this.btnAutomotor.TabIndex = 47;
            this.btnAutomotor.Text = "Automotor";
            this.btnAutomotor.UseVisualStyleBackColor = false;
            // 
            // btnTaller
            // 
            this.btnTaller.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTaller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaller.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTaller.Location = new System.Drawing.Point(268, 34);
            this.btnTaller.Name = "btnTaller";
            this.btnTaller.Size = new System.Drawing.Size(125, 84);
            this.btnTaller.TabIndex = 48;
            this.btnTaller.Text = "Taller";
            this.btnTaller.UseVisualStyleBackColor = false;
            // 
            // btnCapacitacion
            // 
            this.btnCapacitacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapacitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapacitacion.ForeColor = System.Drawing.SystemColors.Info;
            this.btnCapacitacion.Location = new System.Drawing.Point(131, 34);
            this.btnCapacitacion.Name = "btnCapacitacion";
            this.btnCapacitacion.Size = new System.Drawing.Size(138, 84);
            this.btnCapacitacion.TabIndex = 49;
            this.btnCapacitacion.Text = "Capacitación";
            this.btnCapacitacion.UseVisualStyleBackColor = false;
            // 
            // btnFurrieles
            // 
            this.btnFurrieles.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFurrieles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFurrieles.ForeColor = System.Drawing.SystemColors.Info;
            this.btnFurrieles.Location = new System.Drawing.Point(6, 34);
            this.btnFurrieles.Name = "btnFurrieles";
            this.btnFurrieles.Size = new System.Drawing.Size(125, 84);
            this.btnFurrieles.TabIndex = 4;
            this.btnFurrieles.Text = "Furrieles";
            this.btnFurrieles.UseVisualStyleBackColor = false;
            // 
            // txtFiltrarPor
            // 
            this.txtFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarPor.Location = new System.Drawing.Point(29, 149);
            this.txtFiltrarPor.Name = "txtFiltrarPor";
            this.txtFiltrarPor.Size = new System.Drawing.Size(253, 34);
            this.txtFiltrarPor.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ident.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 47);
            this.label4.TabIndex = 54;
            this.label4.Text = "Tarea Realizada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(510, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 29);
            this.label5.TabIndex = 55;
            this.label5.Text = "Observación";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(126, 490);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(340, 30);
            this.txtFecha.TabIndex = 56;
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(126, 542);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(340, 30);
            this.txtHora.TabIndex = 57;
            // 
            // txtIdentidad
            // 
            this.txtIdentidad.Enabled = false;
            this.txtIdentidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentidad.Location = new System.Drawing.Point(126, 594);
            this.txtIdentidad.Name = "txtIdentidad";
            this.txtIdentidad.Size = new System.Drawing.Size(340, 30);
            this.txtIdentidad.TabIndex = 58;
            // 
            // txtTarea
            // 
            this.txtTarea.Enabled = false;
            this.txtTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarea.Location = new System.Drawing.Point(714, 489);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(268, 30);
            this.txtTarea.TabIndex = 59;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(714, 593);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(268, 30);
            this.txtObservacion.TabIndex = 60;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnGuardarCambios.Location = new System.Drawing.Point(1084, 475);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(176, 71);
            this.btnGuardarCambios.TabIndex = 61;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnImprimir.Location = new System.Drawing.Point(1084, 559);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(176, 72);
            this.btnImprimir.TabIndex = 62;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // txtPunto
            // 
            this.txtPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPunto.Location = new System.Drawing.Point(714, 541);
            this.txtPunto.Name = "txtPunto";
            this.txtPunto.Size = new System.Drawing.Size(268, 30);
            this.txtPunto.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(510, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 29);
            this.label7.TabIndex = 64;
            this.label7.Text = "Punto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(883, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 29);
            this.label6.TabIndex = 67;
            this.label6.Text = "Buscando por:";
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
            this.cmbFiltrarPor.Location = new System.Drawing.Point(1084, 146);
            this.cmbFiltrarPor.Name = "cmbFiltrarPor";
            this.cmbFiltrarPor.Size = new System.Drawing.Size(170, 37);
            this.cmbFiltrarPor.TabIndex = 66;
            // 
            // Áreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbFiltrarPor);
            this.Controls.Add(this.txtPunto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.txtIdentidad);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltrarPor);
            this.Controls.Add(this.dgvAreas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Áreas";
            this.Size = new System.Drawing.Size(1284, 661);
            this.Load += new System.EventHandler(this.Áreas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAreas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAreas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReuniones;
        private System.Windows.Forms.Button btnGuardias;
        private System.Windows.Forms.Button btnRoperia;
        private System.Windows.Forms.Button btnEdificio;
        private System.Windows.Forms.Button btnAutomotor;
        private System.Windows.Forms.Button btnTaller;
        private System.Windows.Forms.Button btnCapacitacion;
        private System.Windows.Forms.Button btnFurrieles;
        private System.Windows.Forms.TextBox txtFiltrarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtIdentidad;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtPunto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFiltrarPor;
        private System.Windows.Forms.Button btnAgregarArea;
    }
}
