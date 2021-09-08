using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_WindowsForms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string materia = cmbMateriaFav.Text;
            string titulo = "¡Hola, Windows Forms!";
            string mensaje = $"Soy {nombre} {apellido} y mi materia favorita es {materia}";
            FrmSaludo frmSaludo = new FrmSaludo(titulo, mensaje);

            if (!String.IsNullOrWhiteSpace(txtNombre.Text) && !String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                frmSaludo.ShowDialog();
            }
            else if (String.IsNullOrWhiteSpace(txtNombre.Text) && String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.cmbMateriaFav.Text = "Matemática";
        }
    }
}
