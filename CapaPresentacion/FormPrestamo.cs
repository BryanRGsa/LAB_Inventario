using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormPrestamo : Form
    {
        public FormPrestamo()
        {
            InitializeComponent();
        }

        private void FormPrestamo_Load(object sender, EventArgs e)
        {
            // Cargar los materiales disponibles en el ComboBox de materiales
            CargarMateriales();
        }

        private void CargarMateriales()
        {
            // Lógica para cargar los materiales en el ComboBox de materiales
            // (Esta lógica dependerá de cómo obtienes los datos de materiales)
            cmbMateriales.Items.Add("Material 1");
            cmbMateriales.Items.Add("Material 2");
            // Agregar más materiales si es necesario
        }

        private void cmbMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para cargar la cantidad disponible del material seleccionado
            ActualizarCantidadDisponible();
        }

        private void ActualizarCantidadDisponible()
        {
            string materialSeleccionado = cmbMateriales.SelectedItem?.ToString();

            // Lógica para obtener la cantidad disponible del material seleccionado
            int cantidadDisponible = ObtenerCantidadDisponible(materialSeleccionado);

            // Llenar el ComboBox de cantidad disponible con la cantidad obtenida
            LlenarComboBoxCantidadDisponible(cantidadDisponible);
        }

        private int ObtenerCantidadDisponible(string nombreMaterial)
        {
            int cantidadDisponible = 0;

            // Lógica para obtener la cantidad disponible del material desde la base de datos SQLite
            string query = "SELECT Cantidad FROM Materiales WHERE Nombre = @Nombre";

            using (SQLiteConnection conn = new SQLiteConnection("ruta_a_tu_base_de_datos.sqlite"))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombreMaterial);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        cantidadDisponible = Convert.ToInt32(result);
                    }
                }
            }

            return cantidadDisponible;
        }

        private void LlenarComboBoxCantidadDisponible(int cantidad)
        {
            cmbCantidadDisponibleMaterial.Items.Clear();

            for (int i = 1; i <= cantidad; i++)
            {
                cmbCantidadDisponibleMaterial.Items.Add(i);
            }

            // Si quieres seleccionar la primera cantidad disponible automáticamente, descomenta la siguiente línea:
            // cmbCantidadDisponibleMaterial.SelectedIndex = 0;
        }

        private void FormPrestamo_Load_1(object sender, EventArgs e)
        {
            // Código para el evento FormPrestamo_Load_1
        }

        private void cmbCantidadDisponibleMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para el evento cmbCantidadDisponibleMaterial_SelectedIndexChanged
        }
    }
}

