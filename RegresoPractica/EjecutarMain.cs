using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RegresoPractica.Program;

namespace RegresoPractica
{
    internal class EjecutarMain
    {
        static void Main(String[] args)
        {
            var animal1 = new Animal("Alcon", 1.32, 10);
            animal1.MostrarInformacion();

            Console.WriteLine();
            // creando instancia de Crepa
            var crepa1 = new Crepa("Crepa", 2.22, 40, "Harina");
            crepa1.Preparar();
            crepa1.Servir();

            Console.WriteLine();
            // creando instancia de pastel
            var pastel1 = new Pastel("Pastel", 2.1, 200, "vainilla");
            pastel1.Preparar();
            pastel1.Servir();

            Console.WriteLine();

            var cobertura = new Cobertura("Chocolate blanco", 3);
            cobertura.ObtenerNombre();
            cobertura.ObtenerCantidad();
           
            Console.WriteLine();

            var relleno = new Relleno("Fresas Crema", 4);
            relleno.ObtenerNombre();
            relleno.ObtenerCantidad(); 

            Console.ReadLine();

        }
    }
}
