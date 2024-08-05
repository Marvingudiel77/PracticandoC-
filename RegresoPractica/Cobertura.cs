using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RegresoPractica
{
    internal class Cobertura:Ingrediente 
    {
        private string tipo;
        private int cantidad; 

        public Cobertura(string tipo, int cantidad)
        {
            this.tipo = tipo;
            this.cantidad = cantidad;
        }

        public void ObtenerNombre()
        {

            Console.WriteLine("El tipo de Cobertura es: " + getTipo());
        }

        public void ObtenerCantidad()
        {
            Console.WriteLine("La cantidad de cobertura es: " + getCantidad());
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }
        public string getTipo()
        {
            return tipo;
        }
        public int getCantidad()
        {
            return cantidad;
        }
        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
    }
}
