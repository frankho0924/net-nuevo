using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Personas

    {
        public string nombre;
        public int edad;
        public char genero;
        public string telefono;

        // Constructor básico
        public Personas(string nombre, int edad, char genero, string telefono)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
            this.telefono = telefono;
        }

        // Método para imprimir los detalles
        public void ImprimirDetalles()
        {
            Console.WriteLine("\n--- Detalles de la Persona ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Género: " + genero);
            Console.WriteLine("Teléfono: " + telefono);
        }

        // Método para calcular la edad en días
        public void CalcularEdadEnDias()
        {
            int edadDias = edad * 365;
            Console.WriteLine("\nLa edad en días es: " + edadDias);
        }
    }
}
