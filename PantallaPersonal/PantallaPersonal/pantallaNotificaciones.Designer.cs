namespace PantallaPersonal
{
    partial class pantallaNotificaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarNotificacion = new System.Windows.Forms.Button();
            this.btnMarcarComoLeido = new System.Windows.Forms.Button();
            this.dgvNotificaciones = new System.Windows.Forms.DataGridView();
            this.Notificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarNotificacion = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.btnBorrarNotificacion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltrarPor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(861, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Administrar:";
            // 
            // btnEliminarNotificacion
            // 
            this.btnEliminarNotificacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarNotificacion.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEliminarNotificacion.Location = new System.Drawing.Point(904, 175);
            this.btnEliminarNotificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarNotificacion.Name = "btnEliminarNotificacion";
            this.btnEliminarNotificacion.Size = new System.Drawing.Size(285, 81);
            this.btnEliminarNotificacion.TabIndex = 28;
            this.btnEliminarNotificacion.Text = "Eliminar notificación";
            this.btnEliminarNotificacion.UseVisualStyleBackColor = false;
            // 
            // btnMarcarComoLeido
            // 
            this.btnMarcarComoLeido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMarcarComoLeido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarComoLeido.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMarcarComoLeido.Location = new System.Drawing.Point(904, 67);
            this.btnMarcarComoLeido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarcarComoLeido.Name = "btnMarcarComoLeido";
            this.btnMarcarComoLeido.Size = new System.Drawing.Size(285, 81);
            this.btnMarcarComoLeido.TabIndex = 27;
            this.btnMarcarComoLeido.Text = "Marcar como leído";
            this.btnMarcarComoLeido.UseVisualStyleBackColor = false;
            // 
            // dgvNotificaciones
            // 
            this.dgvNotificaciones.AllowUserToOrderColumns = true;
            this.dgvNotificaciones.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvNotificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Notificación,
            this.Fecha,
            this.Hora,
            this.Area});
            this.dgvNotificaciones.GridColor = System.Drawing.SystemColors.Window;
            this.dgvNotificaciones.Location = new System.Drawing.Point(38, 67);
            this.dgvNotificaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNotificaciones.Name = "dgvNotificaciones";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotificaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotificaciones.RowHeadersVisible = false;
            this.dgvNotificaciones.RowHeadersWidth = 51;
            this.dgvNotificaciones.RowTemplate.Height = 24;
            this.dgvNotificaciones.Size = new System.Drawing.Size(809, 579);
            this.dgvNotificaciones.TabIndex = 26;
            this.dgvNotificaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonal_CellContentClick);
            // 
            // Notificación
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notificación.DefaultCellStyle = dataGridViewCellStyle1;
            this.Notificación.HeaderText = "Información";
            this.Notificación.MinimumWidth = 6;
            this.Notificación.Name = "Notificación";
            this.Notificación.ReadOnly = true;
            this.Notificación.Width = 230;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 125;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.MinimumWidth = 6;
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Width = 130;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarNotificacion);
            this.groupBox1.Controls.Add(this.btnInformacion);
            this.groupBox1.Controls.Add(this.txtHora);
            this.groupBox1.Controls.Add(this.btnBorrarNotificacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(866, 328);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(367, 309);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregarNotificacion
            // 
            this.btnAgregarNotificacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNotificacion.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAgregarNotificacion.Location = new System.Drawing.Point(38, 116);
            this.btnAgregarNotificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarNotificacion.Name = "btnAgregarNotificacion";
            this.btnAgregarNotificacion.Size = new System.Drawing.Size(285, 81);
            this.btnAgregarNotificacion.TabIndex = 20;
            this.btnAgregarNotificacion.Text = "Agregar Notificación";
            this.btnAgregarNotificacion.UseVisualStyleBackColor = false;
            // 
            // btnInformacion
            // 
            this.btnInformacion.Enabled = false;
            this.btnInformacion.Location = new System.Drawing.Point(140, 34);
            this.btnInformacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(183, 22);
            this.btnInformacion.TabIndex = 18;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(140, 72);
            this.txtHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(183, 22);
            this.txtHora.TabIndex = 19;
            // 
            // btnBorrarNotificacion
            // 
            this.btnBorrarNotificacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrarNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarNotificacion.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBorrarNotificacion.Location = new System.Drawing.Point(38, 211);
            this.btnBorrarNotificacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrarNotificacion.Name = "btnBorrarNotificacion";
            this.btnBorrarNotificacion.Size = new System.Drawing.Size(285, 81);
            this.btnBorrarNotificacion.TabIndex = 21;
            this.btnBorrarNotificacion.Text = "Borrar Notificación";
            this.btnBorrarNotificacion.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(33, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(9, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Información:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Filtrar por:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbFiltrarPor
            // 
            this.cmbFiltrarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltrarPor.FormattingEnabled = true;
            this.cmbFiltrarPor.Items.AddRange(new object[] {
            "Codigo",
            "Nombre",
            "Apellido",
            "DNI",
            ""});
            this.cmbFiltrarPor.Location = new System.Drawing.Point(145, 34);
            this.cmbFiltrarPor.Name = "cmbFiltrarPor";
            this.cmbFiltrarPor.Size = new System.Drawing.Size(149, 28);
            this.cmbFiltrarPor.TabIndex = 32;
            this.cmbFiltrarPor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pantallaNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltrarPor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminarNotificacion);
            this.Controls.Add(this.btnMarcarComoLeido);
            this.Controls.Add(this.dgvNotificaciones);
            this.Controls.Add(this.groupBox1);
            this.Name = "pantallaNotificaciones";
            this.Size = new System.Drawing.Size(1284, 661);
            this.Load += new System.EventHandler(this.pantallaNotificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotificaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarNotificacion;
        private System.Windows.Forms.Button btnMarcarComoLeido;
        private System.Windows.Forms.DataGridView dgvNotificaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarNotificacion;
        private System.Windows.Forms.Button btnBorrarNotificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox btnInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltrarPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
    }
}
