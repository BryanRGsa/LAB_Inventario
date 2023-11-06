using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private Form formularioActivo = null;

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando el formulario se carga.
        }


        private void menuprestamo_Click(object sender, EventArgs e)
        {
            FormPrestamo formPrestamo = new FormPrestamo();
            AbrirFormularioEnContenedor(formPrestamo);
        }

        private void menuinventario_Click(object sender, EventArgs e)
        {
            FormInventario formInventario = new FormInventario();
            AbrirFormularioEnContenedor(formInventario);
        }

        private void menuinforme_Click(object sender, EventArgs e)
        {
            FormInforme formInforme = new FormInforme();
            AbrirFormularioEnContenedor(formInforme);
        }

        private void menuhistorial_Click(object sender, EventArgs e)
        {
            FormHistorial formHistorial = new FormHistorial();
            AbrirFormularioEnContenedor(formHistorial);
        }

        private void menumaterialdañado_Click(object sender, EventArgs e)
        {
            FormMaterialdañado formMaterialDañado = new FormMaterialdañado();
            AbrirFormularioEnContenedor(formMaterialDañado);
        }

        private void AbrirFormularioEnContenedor(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close(); // Cierra el formulario activo anterior si existe.
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            panelContenedor.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }
    }
}