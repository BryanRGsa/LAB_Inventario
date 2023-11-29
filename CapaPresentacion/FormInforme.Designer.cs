namespace CapaPresentacion
{
    partial class FormInforme
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCausanteDanio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarMaterialdanado = new FontAwesome.Sharp.IconButton();
            this.btnModificarMaterialdanado = new FontAwesome.Sharp.IconButton();
            this.btnAgregarMaterialdanado = new FontAwesome.Sharp.IconButton();
            this.comboBoxCantidadMaterialDanado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaDanio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxNombreMaterialDanado = new System.Windows.Forms.ComboBox();
            this.dgvMaterialDanado = new System.Windows.Forms.DataGridView();
            this.NombreMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Causante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIncidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDanada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialDanado)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Nombre del causante";
            // 
            // txtCausanteDanio
            // 
            this.txtCausanteDanio.Location = new System.Drawing.Point(12, 130);
            this.txtCausanteDanio.Name = "txtCausanteDanio";
            this.txtCausanteDanio.Size = new System.Drawing.Size(165, 20);
            this.txtCausanteDanio.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 26);
            this.label8.TabIndex = 58;
            this.label8.Text = "Añada incidencia";
            // 
            // btnEliminarMaterialdanado
            // 
            this.btnEliminarMaterialdanado.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarMaterialdanado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminarMaterialdanado.IconColor = System.Drawing.Color.Black;
            this.btnEliminarMaterialdanado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarMaterialdanado.Location = new System.Drawing.Point(12, 390);
            this.btnEliminarMaterialdanado.Name = "btnEliminarMaterialdanado";
            this.btnEliminarMaterialdanado.Size = new System.Drawing.Size(165, 31);
            this.btnEliminarMaterialdanado.TabIndex = 59;
            this.btnEliminarMaterialdanado.Text = "Eliminar";
            this.btnEliminarMaterialdanado.UseVisualStyleBackColor = false;
            // 
            // btnModificarMaterialdanado
            // 
            this.btnModificarMaterialdanado.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificarMaterialdanado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificarMaterialdanado.IconColor = System.Drawing.Color.Black;
            this.btnModificarMaterialdanado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificarMaterialdanado.Location = new System.Drawing.Point(12, 338);
            this.btnModificarMaterialdanado.Name = "btnModificarMaterialdanado";
            this.btnModificarMaterialdanado.Size = new System.Drawing.Size(165, 31);
            this.btnModificarMaterialdanado.TabIndex = 57;
            this.btnModificarMaterialdanado.Text = "Modificar";
            this.btnModificarMaterialdanado.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMaterialdanado
            // 
            this.btnAgregarMaterialdanado.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregarMaterialdanado.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarMaterialdanado.IconColor = System.Drawing.Color.Black;
            this.btnAgregarMaterialdanado.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarMaterialdanado.Location = new System.Drawing.Point(12, 292);
            this.btnAgregarMaterialdanado.Name = "btnAgregarMaterialdanado";
            this.btnAgregarMaterialdanado.Size = new System.Drawing.Size(165, 31);
            this.btnAgregarMaterialdanado.TabIndex = 56;
            this.btnAgregarMaterialdanado.Text = "Agregar";
            this.btnAgregarMaterialdanado.UseVisualStyleBackColor = false;
            // 
            // comboBoxCantidadMaterialDanado
            // 
            this.comboBoxCantidadMaterialDanado.Location = new System.Drawing.Point(12, 240);
            this.comboBoxCantidadMaterialDanado.Name = "comboBoxCantidadMaterialDanado";
            this.comboBoxCantidadMaterialDanado.Size = new System.Drawing.Size(165, 20);
            this.comboBoxCantidadMaterialDanado.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Cantidad del  material";
            // 
            // dateTimePickerFechaDanio
            // 
            this.dateTimePickerFechaDanio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerFechaDanio.Location = new System.Drawing.Point(12, 185);
            this.dateTimePickerFechaDanio.Name = "dateTimePickerFechaDanio";
            this.dateTimePickerFechaDanio.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerFechaDanio.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Fecha incidente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "nombre Materiales";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 450);
            this.label9.TabIndex = 49;
            // 
            // comboBoxNombreMaterialDanado
            // 
            this.comboBoxNombreMaterialDanado.FormattingEnabled = true;
            this.comboBoxNombreMaterialDanado.Location = new System.Drawing.Point(12, 78);
            this.comboBoxNombreMaterialDanado.Name = "comboBoxNombreMaterialDanado";
            this.comboBoxNombreMaterialDanado.Size = new System.Drawing.Size(165, 21);
            this.comboBoxNombreMaterialDanado.TabIndex = 62;
            // 
            // dgvMaterialDanado
            // 
            this.dgvMaterialDanado.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvMaterialDanado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialDanado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreMaterial,
            this.Causante,
            this.FechaIncidente,
            this.CantidadDanada});
            this.dgvMaterialDanado.Location = new System.Drawing.Point(277, 62);
            this.dgvMaterialDanado.Name = "dgvMaterialDanado";
            this.dgvMaterialDanado.Size = new System.Drawing.Size(444, 321);
            this.dgvMaterialDanado.TabIndex = 63;
            // 
            // NombreMaterial
            // 
            this.NombreMaterial.HeaderText = "Nombre del Material";
            this.NombreMaterial.Name = "NombreMaterial";
            // 
            // Causante
            // 
            this.Causante.HeaderText = "Causante del Daño";
            this.Causante.Name = "Causante";
            // 
            // FechaIncidente
            // 
            this.FechaIncidente.HeaderText = "Fecha del Incidente";
            this.FechaIncidente.Name = "FechaIncidente";
            // 
            // CantidadDanada
            // 
            this.CantidadDanada.HeaderText = "Cantidad Dañada";
            this.CantidadDanada.Name = "CantidadDanada";
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMaterialDanado);
            this.Controls.Add(this.comboBoxNombreMaterialDanado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCausanteDanio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminarMaterialdanado);
            this.Controls.Add(this.btnModificarMaterialdanado);
            this.Controls.Add(this.btnAgregarMaterialdanado);
            this.Controls.Add(this.comboBoxCantidadMaterialDanado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerFechaDanio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Name = "FormInforme";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInforme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialDanado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCausanteDanio;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnEliminarMaterialdanado;
        private FontAwesome.Sharp.IconButton btnModificarMaterialdanado;
        private FontAwesome.Sharp.IconButton btnAgregarMaterialdanado;
        private System.Windows.Forms.TextBox comboBoxCantidadMaterialDanado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDanio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxNombreMaterialDanado;
        private System.Windows.Forms.DataGridView dgvMaterialDanado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Causante;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIncidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDanada;
    }
}