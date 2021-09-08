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
    public partial class FrmSaludo : Form
    {
        public FrmSaludo(string titulo, string mensaje)
        {
            InitializeComponent();
            this.lblTitulo.Text = titulo;
            this.lblMensaje.Text = mensaje;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreApellido_Click(object sender, EventArgs e)
        {

        }
    }
}
