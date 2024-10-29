namespace PantallaPersonal
{
    partial class pantallaAA
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
            this.dgvAsistenciaArea = new System.Windows.Forms.DataGridView();
            this.Jerarquia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columns1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.txtFiltrarPor = new System.Windows.Forms.TextBox();
            this.txtTotalDePuntos = new System.Windows.Forms.TextBox();
            this.txtTotalDeHoras = new System.Windows.Forms.TextBox();
            this.lblTotalDePuntos = new System.Windows.Forms.Label();
            this.lblTotalDeHoras = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtJerarquia = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblJerarquia = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaArea)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAsistenciaArea
            // 
            this.dgvAsistenciaArea.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvAsistenciaArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistenciaArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jerarquia,
            this.Nombre,
            this.columns1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvAsistenciaArea.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvAsistenciaArea.Location = new System.Drawing.Point(6, 49);
            this.dgvAsistenciaArea.Name = "dgvAsistenciaArea";
            this.dgvAsistenciaArea.RowHeadersVisible = false;
            this.dgvAsistenciaArea.RowHeadersWidth = 51;
            this.dgvAsistenciaArea.RowTemplate.Height = 24;
            this.dgvAsistenciaArea.Size = new System.Drawing.Size(1217, 368);
            this.dgvAsistenciaArea.TabIndex = 9;
            this.dgvAsistenciaArea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistenciaArea_CellContentClick);
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
            // Column4
            // 
            this.Column4.HeaderText = "T.Pnts";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "ASISTENCIA A AREA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnGuardarCambios);
            this.groupBox1.Controls.Add(this.txtFiltrarPor);
            this.groupBox1.Controls.Add(this.txtTotalDePuntos);
            this.groupBox1.Controls.Add(this.txtTotalDeHoras);
            this.groupBox1.Controls.Add(this.lblTotalDePuntos);
            this.groupBox1.Controls.Add(this.lblTotalDeHoras);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtJerarquia);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblJerarquia);
            this.groupBox1.Controls.Add(this.dgvAsistenciaArea);
            this.groupBox1.Location = new System.Drawing.Point(15, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1248, 613);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnImprimir.Location = new System.Drawing.Point(1046, 528);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(196, 73);
            this.btnImprimir.TabIndex = 76;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnGuardarCambios.Location = new System.Drawing.Point(1046, 436);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(196, 86);
            this.btnGuardarCambios.TabIndex = 75;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // txtFiltrarPor
            // 
            this.txtFiltrarPor.Location = new System.Drawing.Point(6, 21);
            this.txtFiltrarPor.Name = "txtFiltrarPor";
            this.txtFiltrarPor.Size = new System.Drawing.Size(253, 22);
            this.txtFiltrarPor.TabIndex = 51;
            // 
            // txtTotalDePuntos
            // 
            this.txtTotalDePuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotalDePuntos.Location = new System.Drawing.Point(709, 551);
            this.txtTotalDePuntos.Name = "txtTotalDePuntos";
            this.txtTotalDePuntos.Size = new System.Drawing.Size(289, 30);
            this.txtTotalDePuntos.TabIndex = 74;
            // 
            // txtTotalDeHoras
            // 
            this.txtTotalDeHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTotalDeHoras.Location = new System.Drawing.Point(709, 450);
            this.txtTotalDeHoras.Name = "txtTotalDeHoras";
            this.txtTotalDeHoras.Size = new System.Drawing.Size(289, 30);
            this.txtTotalDeHoras.TabIndex = 73;
            // 
            // lblTotalDePuntos
            // 
            this.lblTotalDePuntos.AutoSize = true;
            this.lblTotalDePuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblTotalDePuntos.Location = new System.Drawing.Point(504, 553);
            this.lblTotalDePuntos.Name = "lblTotalDePuntos";
            this.lblTotalDePuntos.Size = new System.Drawing.Size(186, 29);
            this.lblTotalDePuntos.TabIndex = 72;
            this.lblTotalDePuntos.Text = "Total de puntos:";
            // 
            // lblTotalDeHoras
            // 
            this.lblTotalDeHoras.AutoSize = true;
            this.lblTotalDeHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblTotalDeHoras.Location = new System.Drawing.Point(504, 449);
            this.lblTotalDeHoras.Name = "lblTotalDeHoras";
            this.lblTotalDeHoras.Size = new System.Drawing.Size(174, 29);
            this.lblTotalDeHoras.TabIndex = 71;
            this.lblTotalDeHoras.Text = "Total de horas:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(183, 553);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(299, 30);
            this.txtNombre.TabIndex = 69;
            // 
            // txtJerarquia
            // 
            this.txtJerarquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtJerarquia.Location = new System.Drawing.Point(183, 451);
            this.txtJerarquia.Name = "txtJerarquia";
            this.txtJerarquia.Size = new System.Drawing.Size(299, 30);
            this.txtJerarquia.TabIndex = 68;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblNombre.Location = new System.Drawing.Point(12, 553);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 29);
            this.lblNombre.TabIndex = 66;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblJerarquia
            // 
            this.lblJerarquia.AutoSize = true;
            this.lblJerarquia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.lblJerarquia.Location = new System.Drawing.Point(12, 451);
            this.lblJerarquia.Name = "lblJerarquia";
            this.lblJerarquia.Size = new System.Drawing.Size(120, 29);
            this.lblJerarquia.TabIndex = 65;
            this.lblJerarquia.Text = "Jerarquía:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(183, 503);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 30);
            this.textBox1.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label1.Location = new System.Drawing.Point(12, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 77;
            this.label1.Text = "Apellido:";
            // 
            // pantallaAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "pantallaAA";
            this.Size = new System.Drawing.Size(1284, 661);
            this.Load += new System.EventHandler(this.pantallaAA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistenciaArea)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAsistenciaArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTotalDePuntos;
        private System.Windows.Forms.TextBox txtTotalDeHoras;
        private System.Windows.Forms.Label lblTotalDePuntos;
        private System.Windows.Forms.Label lblTotalDeHoras;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtJerarquia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblJerarquia;
        private System.Windows.Forms.TextBox txtFiltrarPor;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jerarquia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columns1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}
