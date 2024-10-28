namespace PantallaPersonal
{
    partial class TareasRealizadas
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
            this.dgvTareasRealizadas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltrarPor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasRealizadas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTareasRealizadas
            // 
            this.dgvTareasRealizadas.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvTareasRealizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareasRealizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTareasRealizadas.Location = new System.Drawing.Point(60, 90);
            this.dgvTareasRealizadas.Name = "dgvTareasRealizadas";
            this.dgvTareasRealizadas.RowHeadersVisible = false;
            this.dgvTareasRealizadas.RowHeadersWidth = 51;
            this.dgvTareasRealizadas.RowTemplate.Height = 24;
            this.dgvTareasRealizadas.Size = new System.Drawing.Size(846, 288);
            this.dgvTareasRealizadas.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tarea Realizada";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cargada por";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // txtFiltrarPor
            // 
            this.txtFiltrarPor.Location = new System.Drawing.Point(60, 62);
            this.txtFiltrarPor.Name = "txtFiltrarPor";
            this.txtFiltrarPor.Size = new System.Drawing.Size(181, 22);
            this.txtFiltrarPor.TabIndex = 1;
            // 
            // TareasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(956, 482);
            this.Controls.Add(this.txtFiltrarPor);
            this.Controls.Add(this.dgvTareasRealizadas);
            this.Name = "TareasRealizadas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas Realizadas recientemente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasRealizadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTareasRealizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtFiltrarPor;
    }
}