using System;

namespace RegresoPractica
{
    internal class Crepa : Postre
    {
        private string tipoMasa;

        public Crepa(string nombre, double tamanio, int precio, string tipoMasa) : base(nombre,tamanio,precio)
        { 
            this.tipoMasa = tipoMasa;
        }

        public override void Preparar()
        {
            Console.WriteLine("Se ha comenzado a preparar la: "+ getNombre() +" con el tipo de masa: " + getTipoMasa());

        }

        public override void Servir()
        {
            Console.WriteLine("se ha servido la: "+ getNombre() + " del tamaño de: "+ getTamanio() + " y el precio de: " + getPrecio());
        }

        public string getTipoMasa()
        {
            return tipoMasa;
        }

        public void setTipoMasa(string tipoMasa)
        {
            this.tipoMasa = tipoMasa;
        }
    }
}

