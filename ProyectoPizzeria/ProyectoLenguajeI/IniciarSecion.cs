using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;


namespace ProyectoLenguajeI {

    public partial class IniciarSecion : Form
    {
        public IniciarSecion()
        {
            InitializeComponent();
        }

        Usuario user;
        string codigoUsuario = "PIZZAS";
        string contraseniaUsuario = "12345";

        private void AccederButton_Click(object sender, EventArgs e)
        {
            if (UsuarioTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(UsuarioTextBox, "Ingrese su usuario");
                UsuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            if (ContraseniaTextBox.Text == String.Empty)
            {
                errorProvider1.SetError(ContraseniaTextBox, "Ingrese su contraseña");
                ContraseniaTextBox.Focus();
                return;
            }
            errorProvider1.Clear();


            user = new Usuario(UsuarioTextBox.Text, ContraseniaTextBox.Text);

            if (user.usuario.ToUpper() == codigoUsuario && user.clave == contraseniaUsuario)
            {
                Menu miMenu = new Menu();
                this.Hide();
                miMenu.Show();
            }
            else
            {
                MessageBox.Show("Datos de usuario son incorrectos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

