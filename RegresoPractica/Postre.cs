using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegresoPractica
{
    internal abstract class Postre
    {
        private string nombre;
        private double tamanio;
        private int precio;

        public Postre(string nombre, double tamanio, int precio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
            this.precio = precio; 
        }

        public abstract void Preparar();
        public abstract void Servir();

        public string getNombre ()
        {
            return nombre;
        }
        public double getTamanio()
        {
            return tamanio;
        }
        public int getPrecio()
        {
            return precio;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setTamanio(double tamanio)
        {
            this.tamanio = tamanio;
        }
        public void setPrecio(int precio)
        {
            this.precio = precio;
        }



    }
}
