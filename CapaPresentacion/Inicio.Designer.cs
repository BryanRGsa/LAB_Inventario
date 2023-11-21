namespace CapaPresentacion
{
    partial class Inicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menuprestamo = new FontAwesome.Sharp.IconMenuItem();
            this.menuinventario = new FontAwesome.Sharp.IconMenuItem();
            this.menuinforme = new FontAwesome.Sharp.IconMenuItem();
            this.menuhistorial = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuprestamo,
            this.menuinventario,
            this.menuinforme,
            this.menuhistorial});
            this.Menu.Location = new System.Drawing.Point(0, 55);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(86, 500);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // menuprestamo
            // 
            this.menuprestamo.AutoSize = false;
            this.menuprestamo.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.menuprestamo.IconColor = System.Drawing.Color.Black;
            this.menuprestamo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuprestamo.IconSize = 50;
            this.menuprestamo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuprestamo.Name = "menuprestamo";
            this.menuprestamo.Size = new System.Drawing.Size(80, 69);
            this.menuprestamo.Text = "Prestamo";
            this.menuprestamo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuprestamo.Click += new System.EventHandler(this.menuprestamo_Click);
            // 
            // menuinventario
            // 
            this.menuinventario.AutoSize = false;
            this.menuinventario.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuinventario.IconColor = System.Drawing.Color.Black;
            this.menuinventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuinventario.IconSize = 50;
            this.menuinventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuinventario.Name = "menuinventario";
            this.menuinventario.Size = new System.Drawing.Size(80, 69);
            this.menuinventario.Text = "Inventario";
            this.menuinventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuinventario.Click += new System.EventHandler(this.menuinventario_Click);
            // 
            // menuinforme
            // 
            this.menuinforme.AutoSize = false;
            this.menuinforme.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.menuinforme.IconColor = System.Drawing.Color.Black;
            this.menuinforme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuinforme.IconSize = 50;
            this.menuinforme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuinforme.Name = "menuinforme";
            this.menuinforme.Size = new System.Drawing.Size(80, 69);
            this.menuinforme.Text = "Informe";
            this.menuinforme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuinforme.Click += new System.EventHandler(this.menuinforme_Click);
            // 
            // menuhistorial
            // 
            this.menuhistorial.AutoSize = false;
            this.menuhistorial.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.menuhistorial.IconColor = System.Drawing.Color.Black;
            this.menuhistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuhistorial.IconSize = 50;
            this.menuhistorial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuhistorial.Name = "menuhistorial";
            this.menuhistorial.Size = new System.Drawing.Size(80, 69);
            this.menuhistorial.Text = "Historial";
            this.menuhistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuhistorial.Click += new System.EventHandler(this.menuhistorial_Click);
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(978, 55);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inventario Laboratorio";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(89, 55);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1075, 500);
            this.panelContenedor.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 555);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuTitulo);
            this.MainMenuStrip = this.Menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        private System.Windows.Forms.MenuStrip Menu;
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuinventario;
        private FontAwesome.Sharp.IconMenuItem menuinforme;
        private FontAwesome.Sharp.IconMenuItem menuhistorial;
        private FontAwesome.Sharp.IconMenuItem menuprestamo;
        private System.Windows.Forms.Panel panelContenedor;
    }
}
