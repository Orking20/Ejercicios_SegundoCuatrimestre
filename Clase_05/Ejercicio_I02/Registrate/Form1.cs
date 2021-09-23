using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace Registrate
{
    public partial class Form1 : Form
    {
        string[] cursos = new string[3];
        string nombre;
        string direccion;
        string edadStr;
        int edad;
        string genero;
        string pais;
        Ingresante ingresante1;

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            cursos[0] = "";
            cursos[1] = "";
            cursos[2] = "";
            if (chkCSharp.Checked)
            {
                cursos[0] = "C#";
            }
            if (chkCPlusPlus.Checked)
            {
                cursos[1] = "C++";
            }
            if (chkJavaScript.Checked)
            {
                cursos[2] = "JavaScript";
            }

            if (rdoMasculino.Checked)
            {
                genero = "Masculino";
            }
            if (rdoFemenino.Checked)
            {
                genero = "Femenino";
            }
            if (rdoNoBinario.Checked)
            {
                genero = "No binario";
            }

            this.nombre = this.txtNombre.Text;
            this.direccion = this.txtDireccion.Text;
            this.edadStr = this.nudEdad.Text;
            if(!int.TryParse(edadStr, out edad))
            {
                edad = 0;
            }
            this.pais = this.lstPais.Text;

            ingresante1 = new Ingresante(cursos, direccion, edad, genero, nombre, pais);
            MessageBox.Show(ingresante1.Mostrar());
        }
    }
}
