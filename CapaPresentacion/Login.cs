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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtcontraseña.UseSystemPasswordChar = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click_1(object sender, EventArgs e)
        {     
        string usuario = txtusuario.Text.Trim();
            string contraseña = txtcontraseña.Text.Trim();

            // Verifica las credenciales
            if (usuario == "HESSEN" && contraseña == "HESSENLAB")
            {
                Inicio form = new Inicio();
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
                txtcontraseña.Text = "";
                txtusuario.Focus();
            }
        }

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtusuario.Text = "";
            txtcontraseña.Text = "";
            this.Show();
        }


    }
}

