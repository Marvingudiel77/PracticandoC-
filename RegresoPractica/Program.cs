using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegresoPractica
{
    internal class Program
    {

        public class Animal
        {
            private string nombre;
            private double altura;
            private int edad; 

            public Animal(string nombre, double altura, int edad)
            {
                this.nombre = nombre;
                this.altura = altura;
                this.edad = edad;
            }

            public void MostrarInformacion()
            {
                Console.WriteLine("El animal es un: " + getNombre()+ " con la altura de: "+ getAltura() + " y la edad de: "+ getEdad());
            }


            public String getNombre()
            {
                return nombre;
            }
            public double getAltura()
            {
                return altura;
            }
            public int getEdad()
            {
                return edad;
            }

            public void setNombre(string nombre)
            {
                this.nombre = nombre;
            }
            public void setAltura(double altura)
            {
                this.altura = altura;
            }
            public void setEdad(int edad)
            {
                this.edad = edad;
            }


        }
        
    }
}
