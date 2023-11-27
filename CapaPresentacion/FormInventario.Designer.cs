namespace CapaPresentacion
{
    partial class FormInventario
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
            this.label8 = new System.Windows.Forms.Label();
            this.btneliminarmaterial = new FontAwesome.Sharp.IconButton();
            this.btnmodificarmaterial = new FontAwesome.Sharp.IconButton();
            this.btnagregarmaterial = new FontAwesome.Sharp.IconButton();
            this.txtcantidadmaterial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxañadirgabinete = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datagriddatosmaterial = new System.Windows.Forms.DataGridView();
            this.NombreMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroGabinete = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateTimePickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreMaterial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagriddatosmaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 26);
            this.label8.TabIndex = 32;
            this.label8.Text = "Agregar material";
            // 
            // btneliminarmaterial
            // 
            this.btneliminarmaterial.BackColor = System.Drawing.Color.LightCoral;
            this.btneliminarmaterial.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btneliminarmaterial.IconColor = System.Drawing.Color.Black;
            this.btneliminarmaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminarmaterial.Location = new System.Drawing.Point(12, 390);
            this.btneliminarmaterial.Name = "btneliminarmaterial";
            this.btneliminarmaterial.Size = new System.Drawing.Size(165, 31);
            this.btneliminarmaterial.TabIndex = 33;
            this.btneliminarmaterial.Text = "Eliminar";
            this.btneliminarmaterial.UseVisualStyleBackColor = false;
            this.btneliminarmaterial.Click += new System.EventHandler(this.btneliminarmaterial_Click);
            // 
            // btnmodificarmaterial
            // 
            this.btnmodificarmaterial.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnmodificarmaterial.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnmodificarmaterial.IconColor = System.Drawing.Color.Black;
            this.btnmodificarmaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmodificarmaterial.Location = new System.Drawing.Point(12, 338);
            this.btnmodificarmaterial.Name = "btnmodificarmaterial";
            this.btnmodificarmaterial.Size = new System.Drawing.Size(165, 31);
            this.btnmodificarmaterial.TabIndex = 31;
            this.btnmodificarmaterial.Text = "Modificar";
            this.btnmodificarmaterial.UseVisualStyleBackColor = false;
            this.btnmodificarmaterial.Click += new System.EventHandler(this.btnmodificarmaterial_Click);
            // 
            // btnagregarmaterial
            // 
            this.btnagregarmaterial.BackColor = System.Drawing.Color.LightGreen;
            this.btnagregarmaterial.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnagregarmaterial.IconColor = System.Drawing.Color.Black;
            this.btnagregarmaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnagregarmaterial.Location = new System.Drawing.Point(12, 292);
            this.btnagregarmaterial.Name = "btnagregarmaterial";
            this.btnagregarmaterial.Size = new System.Drawing.Size(165, 31);
            this.btnagregarmaterial.TabIndex = 30;
            this.btnagregarmaterial.Text = "Agregar";
            this.btnagregarmaterial.UseVisualStyleBackColor = false;
            this.btnagregarmaterial.Click += new System.EventHandler(this.btnagregarmaterial_Click);
            // 
            // txtcantidadmaterial
            // 
            this.txtcantidadmaterial.Location = new System.Drawing.Point(12, 240);
            this.txtcantidadmaterial.Name = "txtcantidadmaterial";
            this.txtcantidadmaterial.Size = new System.Drawing.Size(165, 20);
            this.txtcantidadmaterial.TabIndex = 29;
            this.txtcantidadmaterial.TextChanged += new System.EventHandler(this.txtcantidadmaterial_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad del  material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha";
            // 
            // comboBoxañadirgabinete
            // 
            this.comboBoxañadirgabinete.FormattingEnabled = true;
            this.comboBoxañadirgabinete.Location = new System.Drawing.Point(12, 131);
            this.comboBoxañadirgabinete.Name = "comboBoxañadirgabinete";
            this.comboBoxañadirgabinete.Size = new System.Drawing.Size(165, 21);
            this.comboBoxañadirgabinete.TabIndex = 25;
            this.comboBoxañadirgabinete.SelectedIndexChanged += new System.EventHandler(this.comboBoxañadirgabinete_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Numero Gabinete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "nombre Materiales";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 450);
            this.label9.TabIndex = 17;
            // 
            // datagriddatosmaterial
            // 
            this.datagriddatosmaterial.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.datagriddatosmaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreMaterial,
            this.NumeroGabinete,
            this.FechaRegistro,
            this.CantidadDisponible});
            this.datagriddatosmaterial.Location = new System.Drawing.Point(242, 35);
            this.datagriddatosmaterial.Name = "datagriddatosmaterial";
            this.datagriddatosmaterial.Size = new System.Drawing.Size(449, 343);
            this.datagriddatosmaterial.TabIndex = 0;
            this.datagriddatosmaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datosmaterial_CellContentClick);
            // 
            // NombreMaterial
            // 
            this.NombreMaterial.HeaderText = "Nombre del Material:";
            this.NombreMaterial.Name = "NombreMaterial";
            // 
            // NumeroGabinete
            // 
            this.NumeroGabinete.HeaderText = "Número de Gabinete ";
            this.NumeroGabinete.Name = "NumeroGabinete";
            // 
            // dateTimePickerFechaRegistro
            // 
            this.dateTimePickerFechaRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerFechaRegistro.Location = new System.Drawing.Point(12, 185);
            this.dateTimePickerFechaRegistro.Name = "dateTimePickerFechaRegistro";
            this.dateTimePickerFechaRegistro.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerFechaRegistro.TabIndex = 34;
            this.dateTimePickerFechaRegistro.ValueChanged += new System.EventHandler(this.dateTimePickerFechaRegistro_ValueChanged);
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            // 
            // CantidadDisponible
            // 
            this.CantidadDisponible.HeaderText = "Cantidad Disponible";
            this.CantidadDisponible.Name = "CantidadDisponible";
            // 
            // txtNombreMaterial
            // 
            this.txtNombreMaterial.Location = new System.Drawing.Point(11, 78);
            this.txtNombreMaterial.Name = "txtNombreMaterial";
            this.txtNombreMaterial.Size = new System.Drawing.Size(165, 20);
            this.txtNombreMaterial.TabIndex = 35;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.txtNombreMaterial);
            this.Controls.Add(this.dateTimePickerFechaRegistro);
            this.Controls.Add(this.datagriddatosmaterial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btneliminarmaterial);
            this.Controls.Add(this.btnmodificarmaterial);
            this.Controls.Add(this.btnagregarmaterial);
            this.Controls.Add(this.txtcantidadmaterial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxañadirgabinete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInventario";
            ((System.ComponentModel.ISupportInitialize)(this.datagriddatosmaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btneliminarmaterial;
        private FontAwesome.Sharp.IconButton btnmodificarmaterial;
        private FontAwesome.Sharp.IconButton btnagregarmaterial;
        private System.Windows.Forms.TextBox txtcantidadmaterial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxañadirgabinete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView datagriddatosmaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMaterial;
        private System.Windows.Forms.DataGridViewComboBoxColumn NumeroGabinete;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDisponible;
        private System.Windows.Forms.TextBox txtNombreMaterial;
    }
}