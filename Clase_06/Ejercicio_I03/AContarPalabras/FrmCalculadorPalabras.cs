using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AContarPalabras
{
    public partial class FrmCalculadorPalabras : Form
    {

        public FrmCalculadorPalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> diccionario = ObtenerPalabras();

            List<KeyValuePair<string, int>> lista = diccionario.ToList();
            lista.Sort(funcionCriterio);

            MostrarLista(lista);
        }

        private void MostrarLista(List<KeyValuePair<string, int>> lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, int> par in lista)
            {
                sb.AppendLine($"Palabra: {par.Key} - Contador: {par.Value}");
            }

            MessageBox.Show(sb.ToString(), "Lista");
        }

        private Dictionary<string, int> ObtenerPalabras()
        {
            Dictionary<string, int> diccionario = new Dictionary<string, int>();
            string texto;
            string[] palabras;
            int contador = 1;

            texto = rtxTexto.Text;
            palabras = texto.Split(' ');

            for (int i = 0; i < palabras.Length; i++)
            {
                if (diccionario.ContainsKey(palabras[i]))
                {
                    diccionario[palabras[i]]++;
                }
                else
                {
                    contador = 1;
                    diccionario.Add(palabras[i], contador);
                }
            }

            return diccionario;
        }

        private int funcionCriterio(KeyValuePair<string, int> primerElemento, KeyValuePair<string, int> segundoElemento)
        {
            return primerElemento.Value - segundoElemento.Value;
        }
    }
}
