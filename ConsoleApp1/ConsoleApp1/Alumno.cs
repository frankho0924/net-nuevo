using System;

namespace ConsoleApp1
{
    class Alumno
    {
        public string Nombre;
        public double Nota;

        public Alumno(string nombre, double nota)
        {
            Nombre = nombre;
            Nota = nota;
        }

        public bool EstaAprobado()
        {
            return Nota >= 3.0;
        }
    }
}
