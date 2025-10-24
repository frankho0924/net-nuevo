using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Universidad
    {
        public List<Estudiante> estudiantes = new List<Estudiante>();

        public void AgregarEstudiante(Estudiante e)
        {
            estudiantes.Add(e);
        }

        public void MostrarResultados()
        {
            int totalCreditos = 0;
            double totalSinDescuento = 0;
            double totalDescuentos = 0;
            double totalNeto = 0;

            foreach (var e in estudiantes)
            {
                totalCreditos += e.Creditos;
                totalSinDescuento += e.CalcularValorSinDescuento();
                totalDescuentos += e.CalcularDescuento();
                totalNeto += e.CalcularValorFinal();
            }

            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine($"Total de estudiantes: {estudiantes.Count}");
            Console.WriteLine($"Total de créditos: {totalCreditos}");
            Console.WriteLine($"Valor sin descuento: ${totalSinDescuento:N0}");
            Console.WriteLine($"Valor de descuentos: ${totalDescuentos:N0}");
            Console.WriteLine($"Valor neto pagado: ${totalNeto:N0}");
        }
    }
}
