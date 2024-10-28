namespace PantallaPersonal
{
    partial class PantallaEmeregencai
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
            this.dgvEmergencia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDEmergencia = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtHoraVuelta = new System.Windows.Forms.TextBox();
            this.txtFechaVuelta = new System.Windows.Forms.TextBox();
            this.txtCodigosBomberos = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmergencia
            // 
            this.dgvEmergencia.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvEmergencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmergencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Observaciones});
            this.dgvEmergencia.Location = new System.Drawing.Point(35, 45);
            this.dgvEmergencia.Name = "dgvEmergencia";
            this.dgvEmergencia.RowHeadersVisible = false;
            this.dgvEmergencia.RowHeadersWidth = 51;
            this.dgvEmergencia.RowTemplate.Height = 24;
            this.dgvEmergencia.Size = new System.Drawing.Size(794, 159);
            this.dgvEmergencia.TabIndex = 0;
            this.dgvEmergencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID emergencia";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Hora";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hora de vuelta";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Código bombero";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 6;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(32, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID emergencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(32, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(32, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(32, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora Vuelta: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(32, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha Vuelta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(32, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Códigos Bomberos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(32, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Observaciones:";
            // 
            // txtIDEmergencia
            // 
            this.txtIDEmergencia.Location = new System.Drawing.Point(202, 230);
            this.txtIDEmergencia.Name = "txtIDEmergencia";
            this.txtIDEmergencia.Size = new System.Drawing.Size(100, 22);
            this.txtIDEmergencia.TabIndex = 8;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(202, 296);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 22);
            this.txtHora.TabIndex = 9;
            // 
            // txtHoraVuelta
            // 
            this.txtHoraVuelta.Location = new System.Drawing.Point(202, 332);
            this.txtHoraVuelta.Name = "txtHoraVuelta";
            this.txtHoraVuelta.Size = new System.Drawing.Size(100, 22);
            this.txtHoraVuelta.TabIndex = 10;
            // 
            // txtFechaVuelta
            // 
            this.txtFechaVuelta.Location = new System.Drawing.Point(202, 368);
            this.txtFechaVuelta.Name = "txtFechaVuelta";
            this.txtFechaVuelta.Size = new System.Drawing.Size(100, 22);
            this.txtFechaVuelta.TabIndex = 11;
            // 
            // txtCodigosBomberos
            // 
            this.txtCodigosBomberos.Location = new System.Drawing.Point(202, 404);
            this.txtCodigosBomberos.Name = "txtCodigosBomberos";
            this.txtCodigosBomberos.Size = new System.Drawing.Size(308, 22);
            this.txtCodigosBomberos.TabIndex = 12;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(202, 444);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(308, 22);
            this.txtObservaciones.TabIndex = 13;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(202, 263);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 22);
            this.txtFecha.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(731, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 49);
            this.button2.TabIndex = 65;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtGuardar
            // 
            this.txtGuardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGuardar.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardar.ForeColor = System.Drawing.Color.OrangeRed;
            this.txtGuardar.Location = new System.Drawing.Point(648, 385);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(170, 81);
            this.txtGuardar.TabIndex = 64;
            this.txtGuardar.Text = "Guardar";
            this.txtGuardar.UseVisualStyleBackColor = false;
            // 
            // PantallaEmeregencai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(956, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtCodigosBomberos);
            this.Controls.Add(this.txtFechaVuelta);
            this.Controls.Add(this.txtHoraVuelta);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtIDEmergencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmergencia);
            this.Name = "PantallaEmeregencai";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMERGENCIA";
            this.Load += new System.EventHandler(this.PantallaEmeregencai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmergencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDEmergencia;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtHoraVuelta;
        private System.Windows.Forms.TextBox txtFechaVuelta;
        private System.Windows.Forms.TextBox txtCodigosBomberos;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txtGuardar;
    }
}