using System;
using System.Text;

namespace BibliotecaDeClases
{
    public class Ingresante
    {
        string[] cursos;
        string direccion;
        int edad;
        string genero;
        string nombre;
        string pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Dirección: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Género: {this.genero}");
            sb.AppendLine($"País: {this.pais}");
            sb.AppendLine("Curso/s:");
            foreach (string curso in this.cursos)
            {
                if (curso != "")
                {
                    sb.AppendLine(curso);
                }
            }

            return sb.ToString();
        }
    }
}
