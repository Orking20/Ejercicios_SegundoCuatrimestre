using System;

namespace BibliotecaDeClases
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"Titular: {this.titular}\nMonto actual: {this.cantidad}";
        }

        public void Ingresar(double monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(double monto)
        {
            this.cantidad -= monto;
        }
    }
}
