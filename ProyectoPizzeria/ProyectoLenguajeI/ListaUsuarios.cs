using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLenguajeI
{
    public partial class ListaUsuarios : Form
    {
        public ListaUsuarios()
        {
            InitializeComponent();
        }

        private void HabilitarControles()
        {
            NombreUsuarioTextBox.Enabled = true;
            CodigoUsuarioTextBox.Enabled = true;
            ContrasenaTextBox.Enabled = true;
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            HabilitarControles();
        }
    }
}
