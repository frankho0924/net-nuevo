using System;

namespace ConsoleApp1
{
    class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AnioPublicacion { get; set; }

        public Libro(string titulo, string autor, string editorial, int anioPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            AnioPublicacion = anioPublicacion;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Editorial: {Editorial}, Año: {AnioPublicacion}");
        }
    }
}
