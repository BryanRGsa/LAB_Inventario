namespace CapaPresentacion
{
    partial class FormPrestamo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPersona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datosprestamo = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materiales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gabinete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            this.iconButtonModificar = new FontAwesome.Sharp.IconButton();
            this.iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            this.cmbMateriales = new System.Windows.Forms.ComboBox();
            this.cmbCantidadDisponibleMaterial = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datosprestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(836, 116);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Materiales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Persona";
            // 
            // txtPersona
            // 
            this.txtPersona.Location = new System.Drawing.Point(17, 74);
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(165, 20);
            this.txtPersona.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(217, 74);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(165, 20);
            this.txtDNI.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha";
            // 
            // dateTimePickerFechaPrestamo
            // 
            this.dateTimePickerFechaPrestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerFechaPrestamo.Location = new System.Drawing.Point(445, 25);
            this.dateTimePickerFechaPrestamo.Name = "dateTimePickerFechaPrestamo";
            this.dateTimePickerFechaPrestamo.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerFechaPrestamo.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(442, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Realizar prestamo";
            // 
            // datosprestamo
            // 
            this.datosprestamo.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.datosprestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosprestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.Materiales,
            this.gabinete,
            this.Persona,
            this.DNI,
            this.Fecha,
            this.Cantidad});
            this.datosprestamo.Location = new System.Drawing.Point(58, 119);
            this.datosprestamo.Name = "datosprestamo";
            this.datosprestamo.Size = new System.Drawing.Size(643, 325);
            this.datosprestamo.TabIndex = 18;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "IdUsuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 50;
            // 
            // Materiales
            // 
            this.Materiales.HeaderText = "Materiales";
            this.Materiales.Name = "Materiales";
            // 
            // gabinete
            // 
            this.gabinete.HeaderText = "Gabinete";
            this.gabinete.Name = "gabinete";
            // 
            // Persona
            // 
            this.Persona.HeaderText = "Nombre de persona";
            this.Persona.Name = "Persona";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha de prestamo";
            this.Fecha.Name = "Fecha";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // iconButtonEliminar
            // 
            this.iconButtonEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonEliminar.IconColor = System.Drawing.Color.Black;
            this.iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEliminar.Location = new System.Drawing.Point(642, 77);
            this.iconButtonEliminar.Name = "iconButtonEliminar";
            this.iconButtonEliminar.Size = new System.Drawing.Size(153, 31);
            this.iconButtonEliminar.TabIndex = 22;
            this.iconButtonEliminar.Text = "Eliminar";
            this.iconButtonEliminar.UseVisualStyleBackColor = false;
            // 
            // iconButtonModificar
            // 
            this.iconButtonModificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButtonModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonModificar.IconColor = System.Drawing.Color.Black;
            this.iconButtonModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonModificar.Location = new System.Drawing.Point(642, 40);
            this.iconButtonModificar.Name = "iconButtonModificar";
            this.iconButtonModificar.Size = new System.Drawing.Size(153, 31);
            this.iconButtonModificar.TabIndex = 21;
            this.iconButtonModificar.Text = "Modificar";
            this.iconButtonModificar.UseVisualStyleBackColor = false;
            // 
            // iconButtonAgregar
            // 
            this.iconButtonAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonAgregar.IconColor = System.Drawing.Color.Black;
            this.iconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAgregar.Location = new System.Drawing.Point(642, 3);
            this.iconButtonAgregar.Name = "iconButtonAgregar";
            this.iconButtonAgregar.Size = new System.Drawing.Size(153, 31);
            this.iconButtonAgregar.TabIndex = 20;
            this.iconButtonAgregar.Text = "Agregar";
            this.iconButtonAgregar.UseVisualStyleBackColor = false;
            // 
            // cmbMateriales
            // 
            this.cmbMateriales.FormattingEnabled = true;
            this.cmbMateriales.Location = new System.Drawing.Point(217, 25);
            this.cmbMateriales.Name = "cmbMateriales";
            this.cmbMateriales.Size = new System.Drawing.Size(165, 21);
            this.cmbMateriales.TabIndex = 23;
            // 
            // cmbCantidadDisponibleMaterial
            // 
            this.cmbCantidadDisponibleMaterial.FormattingEnabled = true;
            this.cmbCantidadDisponibleMaterial.Location = new System.Drawing.Point(445, 74);
            this.cmbCantidadDisponibleMaterial.Name = "cmbCantidadDisponibleMaterial";
            this.cmbCantidadDisponibleMaterial.Size = new System.Drawing.Size(165, 21);
            this.cmbCantidadDisponibleMaterial.TabIndex = 24;
            this.cmbCantidadDisponibleMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbCantidadDisponibleMaterial_SelectedIndexChanged);
            // 
            // FormPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(836, 456);
            this.Controls.Add(this.cmbCantidadDisponibleMaterial);
            this.Controls.Add(this.cmbMateriales);
            this.Controls.Add(this.iconButtonEliminar);
            this.Controls.Add(this.iconButtonModificar);
            this.Controls.Add(this.iconButtonAgregar);
            this.Controls.Add(this.datosprestamo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerFechaPrestamo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPersona);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrestamo";
            this.Load += new System.EventHandler(this.FormPrestamo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.datosprestamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPrestamo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView datosprestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materiales;
        private System.Windows.Forms.DataGridViewTextBoxColumn gabinete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtonModificar;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private System.Windows.Forms.ComboBox cmbMateriales;
        private System.Windows.Forms.ComboBox cmbCantidadDisponibleMaterial;
    }
}