namespace PantallaPersonal
{
    partial class pantallaAI
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPunto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtFiltrarPor = new System.Windows.Forms.TextBox();
            this.txtTotalDePuntos = new System.Windows.Forms.TextBox();
            this.txtTotalDeHoras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtJerarquia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsistenciaInstitucion = new System.Windows.Forms.DataGridView();
            this.Jerarquia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columns1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaInstitucion)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "ASISTENCIA A INSTITUCION";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPunto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnGuardarCambios);
            this.groupBox1.Controls.Add(this.txtFiltrarPor);
            this.groupBox1.Controls.Add(this.txtTotalDePuntos);
            this.groupBox1.Controls.Add(this.txtTotalDeHoras);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtJerarquia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvAsistenciaInstitucion);
            this.groupBox1.Location = new System.Drawing.Point(15, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 612);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPunto
            // 
            this.txtPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPunto.Location = new System.Drawing.Point(143, 565);
            this.txtPunto.Name = "txtPunto";
            this.txtPunto.Size = new System.Drawing.Size(271, 30);
            this.txtPunto.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.Location = new System.Drawing.Point(6, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 77;
            this.label3.Text = "Punto:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnImprimir.Location = new System.Drawing.Point(1065, 535);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(176, 71);
            this.btnImprimir.TabIndex = 76;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnGuardarCambios.Location = new System.Drawing.Point(1065, 459);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(176, 71);
            this.btnGuardarCambios.TabIndex = 75;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // txtFiltrarPor
            // 
            this.txtFiltrarPor.Location = new System.Drawing.Point(6, 16);
            this.txtFiltrarPor.Name = "txtFiltrarPor";
            this.txtFiltrarPor.Size = new System.Drawing.Size(253, 22);
            this.txtFiltrarPor.TabIndex = 51;
            // 
            // txtTotalDePuntos
            // 
            this.txtTotalDePuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotalDePuntos.Location = new System.Drawing.Point(623, 555);
            this.txtTotalDePuntos.Name = "txtTotalDePuntos";
            this.txtTotalDePuntos.Size = new System.Drawing.Size(268, 30);
            this.txtTotalDePuntos.TabIndex = 74;
            // 
            // txtTotalDeHoras
            // 
            this.txtTotalDeHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotalDeHoras.Location = new System.Drawing.Point(623, 479);
            this.txtTotalDeHoras.Name = "txtTotalDeHoras";
            this.txtTotalDeHoras.Size = new System.Drawing.Size(268, 30);
            this.txtTotalDeHoras.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label4.Location = new System.Drawing.Point(431, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 72;
            this.label4.Text = "Total de puntos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label5.Location = new System.Drawing.Point(431, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 29);
            this.label5.TabIndex = 71;
            this.label5.Text = "Total de horas:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(143, 513);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(271, 30);
            this.txtNombre.TabIndex = 69;
            // 
            // txtJerarquia
            // 
            this.txtJerarquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJerarquia.Location = new System.Drawing.Point(143, 459);
            this.txtJerarquia.Name = "txtJerarquia";
            this.txtJerarquia.Size = new System.Drawing.Size(271, 30);
            this.txtJerarquia.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label2.Location = new System.Drawing.Point(6, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 66;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(6, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 65;
            this.label1.Text = "Jerarquía:";
            // 
            // dgvAsistenciaInstitucion
            // 
            this.dgvAsistenciaInstitucion.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvAsistenciaInstitucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistenciaInstitucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jerarquia,
            this.Nombre,
            this.columns1,
            this.Column2,
            this.Column3,
            this.Column1,
            this.Column4});
            this.dgvAsistenciaInstitucion.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvAsistenciaInstitucion.Location = new System.Drawing.Point(6, 44);
            this.dgvAsistenciaInstitucion.Name = "dgvAsistenciaInstitucion";
            this.dgvAsistenciaInstitucion.RowHeadersVisible = false;
            this.dgvAsistenciaInstitucion.RowHeadersWidth = 51;
            this.dgvAsistenciaInstitucion.RowTemplate.Height = 24;
            this.dgvAsistenciaInstitucion.Size = new System.Drawing.Size(1235, 395);
            this.dgvAsistenciaInstitucion.TabIndex = 9;
            // 
            // Jerarquia
            // 
            this.Jerarquia.HeaderText = "Jerarquia";
            this.Jerarquia.MinimumWidth = 6;
            this.Jerarquia.Name = "Jerarquia";
            this.Jerarquia.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // columns1
            // 
            this.columns1.HeaderText = "1";
            this.columns1.MinimumWidth = 6;
            this.columns1.Name = "columns1";
            this.columns1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "T.HS";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "T.Pnts";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // pantallaAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "pantallaAI";
            this.Size = new System.Drawing.Size(1284, 661);
            this.Load += new System.EventHandler(this.pantallaAI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaInstitucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFiltrarPor;
        private System.Windows.Forms.TextBox txtTotalDePuntos;
        private System.Windows.Forms.TextBox txtTotalDeHoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtJerarquia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAsistenciaInstitucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jerarquia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columns1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TextBox txtPunto;
        private System.Windows.Forms.Label label3;
    }
}
