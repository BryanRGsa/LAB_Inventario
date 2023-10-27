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
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void menudevolucion_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormDevolucion
            FormDevolucion formDevolucion = new FormDevolucion();

            // Mostrar el formulario FormDevolucion
            formDevolucion.ShowDialog(); // O puedes usar formDevolucion.Show() si no quieres que sea modal.
        }


        private void menuprestamo_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormPrestamo
            FormPrestamo formPrestamo = new FormPrestamo();

            // Mostrar el formulario FormPrestamo
            formPrestamo.ShowDialog(); // O puedes usar formPrestamo.Show() si no quieres que sea modal.
        }

        private void menuinventario_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormInventario
            FormInventario formInventario = new FormInventario();

            // Mostrar el formulario FormInventario
            formInventario.ShowDialog(); // O puedes usar formInventario.Show() si no quieres que sea modal.
        }


        private void menuinforme_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormInforme
            FormInforme formInforme = new FormInforme();

            // Mostrar el formulario FormInforme
            formInforme.ShowDialog(); // O puedes usar formInforme.Show() si no quieres que sea modal.
        }


        private void menuhistorial_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormHistorial
            FormHistorial formHistorial = new FormHistorial();

            // Mostrar el formulario FormHistorial
            formHistorial.ShowDialog(); // O puedes usar formHistorial.Show() si no quieres que sea modal.
        }


        private void menumaterialdañado_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FormMaterialDañado
            FormMaterialdañado formMaterialdañado = new FormMaterialdañado();

            // Mostrar el formulario FormMaterialDañado
            formMaterialdañado.ShowDialog(); // O puedes usar formMaterialdañado.Show() si no quieres que sea modal.
        }


    }
}
