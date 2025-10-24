
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Biblioteca
    {
        public List<Libro> listaLibros = new List<Libro>();


        public void AgregarLibro(Libro libro)
        {
            listaLibros.Add(libro);
            Console.WriteLine("📚 Libro agregado correctamente.\n");
        }

        public void ListarLibros()
        {
            if (listaLibros.Count == 0)
            {
                Console.WriteLine("No hay libros en la biblioteca.\n");
            }
            else
            {
                Console.WriteLine("\n--- Lista de Libros ---");
                foreach (Libro libro in listaLibros)
                {
                    libro.MostrarInfo();
                }
            }
        }


        public void BuscarLibro(string titulo)
        {
            bool encontrado = false;

            foreach (Libro libro in listaLibros)
            {
                if (libro.titulo.ToLower() == titulo.ToLower())
                {
                    Console.WriteLine("\nLibro encontrado:");
                    libro.MostrarInfo();
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("❌ No se encontró un libro con ese título.\n");
            }
        }
    }
}
