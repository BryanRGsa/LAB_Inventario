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
    public partial class FormInventario : Form
    {
        int cantidad = 0; // Declaración de la variable cantidad

        public FormInventario()
        {
            InitializeComponent();
        }


        private void dateTimePickerFechaRegistro_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtCantidadMaterial_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnagregarmaterial_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCantidadMaterial.Text))
            {
                if (int.TryParse(txtCantidadMaterial.Text, out cantidad))
                {
                    // Lógica para agregar el material
                    // Llama a tu capa de lógica de negocios o gestor de inventario
                    // GestorInventario.AgregarMaterial(nombreMaterial, gabineteSeleccionado, fechaRegistro, cantidad);

                    // Ejemplo de mostrar un mensaje
                    MessageBox.Show("Material agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ingrese un número válido para la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese la cantidad del material.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnmodificarmaterial_Click(object sender, EventArgs e)
        {
            // Lógica para modificar el material seleccionado en el DataGridView
            // Puedes obtener el material seleccionado en el DataGridView y modificarlo

            // Ejemplo de mostrar un mensaje
            MessageBox.Show("Material modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btneliminarmaterial_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar el material seleccionado en el DataGridView
            // Puedes obtener el material seleccionado en el DataGridView y eliminarlo

            // Ejemplo de mostrar un mensaje
            MessageBox.Show("Material eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void datosmaterial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Crear la columna de ComboBox
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.HeaderText = "Número de Gabinete";
            comboBoxColumn.Name = "NumeroGabinete"; // Nombre de la columna
            comboBoxColumn.Items.AddRange("Gabinete 1", "Gabinete 2", "Gabinete 3", "Gabinete 4", "Gabinete 5");
            datagriddatosmaterial.Columns.Add(comboBoxColumn);


        }

        private void comboBoxNumeroGabinete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
