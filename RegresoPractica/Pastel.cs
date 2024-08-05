using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegresoPractica
{
    internal class Pastel: Postre
    {
        private string sabor;

        public Pastel(string nombre, double tamanio, int precio, string sabor) : base(nombre, tamanio, precio)
        {
            this.sabor = sabor;
        }

        public override void Preparar()
        {
            Console.WriteLine("Se ha comenzado a preparar el: " + getNombre() + " con el sabor de: " + getSabor());
        }
        public override void Servir()
        {
            Console.WriteLine("se ha servido el: " + getNombre() + " del tamaño de: " + getTamanio() + " y el precio de: " + getPrecio());
        }

        public string getSabor()
        {
            return sabor;
        }
        public void setSabor (string sabor)
        {
            this.sabor = sabor;
        }
    }
}
