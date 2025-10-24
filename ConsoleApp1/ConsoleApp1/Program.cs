using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Persona
    {
        //static void Main(string[] args)
        //{
        //    Console.Write("Ingrese el monto del préstamo: ");
        //    double monto = double.Parse(Console.ReadLine());

        //    Prestamo p = new Prestamo();
        //    p.monto = monto;

        //    Console.WriteLine("Interés en un año: " + p.InteresAnual());
        //    Console.WriteLine("Interés en el tercer trimestre: " + p.InteresTrimestre());
        //    Console.WriteLine("Interés en el primer mes: " + p.InteresMensual());
        //    Console.WriteLine("Total a pagar con intereses: " + p.TotalPagar());

        //    Console.ReadKey();
        //}



        ////segudo ejercicio
        //static void Main(string[] args)
        //{
        //    Console.Write("Ingrese el salario del empleado: ");
        //    double salario = double.Parse(Console.ReadLine());

        //    Console.Write("Ingrese el valor del ahorro mensual: ");
        //    double ahorro = double.Parse(Console.ReadLine());

        //    Empleado e = new Empleado();
        //    e.salario = salario;
        //    e.ahorro = ahorro;

        //    Console.WriteLine("\n--- COLILLA DE PAGO ---");
        //    Console.WriteLine("Salario: " + e.salario);
        //    Console.WriteLine("Ahorro mensual: " + e.ahorro);
        //    Console.WriteLine("Descuento por EPS (12.5%): " + e.AporteSalud());
        //    Console.WriteLine("Descuento por Pensión (16%): " + e.AportePension());
        //    Console.WriteLine("Total a recibir: " + e.TotalRecibir());

        //    Console.ReadKey();
        //}


        //// tercer ejercicio
        //static void Main(string[] args)
        //{
        //    Console.Write("Ingrese el nombre: ");
        //    string nombre = Console.ReadLine();

        //    Console.Write("Ingrese la edad: ");
        //    int edad = int.Parse(Console.ReadLine());

        //    Console.Write("Ingrese el género (F/M): ");
        //    char genero = char.Parse(Console.ReadLine().ToUpper());

        //    Console.Write("Ingrese el teléfono: ");
        //    string telefono = Console.ReadLine();

        //    Personas p = new Personas(nombre, edad, genero, telefono);

        //    Console.WriteLine("\nElija una opción:");
        //    Console.WriteLine("1. Imprimir detalles");
        //    Console.WriteLine("2. Calcular edad en días");
        //    Console.Write("Opción: ");
        //    int opcion = int.Parse(Console.ReadLine());

        //    if (opcion == 1)
        //    {
        //        p.ImprimirDetalles();
        //    }
        //    else if (opcion == 2)
        //    {
        //        p.CalcularEdadEnDias();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Opción no válida.");
        //    }

        //    Console.ReadKey();
        //}






        //static void Main(string[] args)
        //{
        //    Biblioteca biblioteca = new Biblioteca();
        //    int opcion;

        //    do
        //    {
        //        Console.WriteLine("\n--- MENÚ BIBLIOTECA ---");
        //        Console.WriteLine("1. Agregar libro");
        //        Console.WriteLine("2. Listar libros");
        //        Console.WriteLine("3. Buscar libro por título");
        //        Console.WriteLine("4. Salir");
        //        Console.Write("Elija una opción: ");
        //        opcion = int.Parse(Console.ReadLine());

        //        if (opcion == 1)
        //        {
        //            Console.Write("Ingrese el título: ");
        //            string titulo = Console.ReadLine();

        //            Console.Write("Ingrese el autor: ");
        //            string autor = Console.ReadLine();

        //            Console.Write("Ingrese la editorial: ");
        //            string editorial = Console.ReadLine();

        //            Console.Write("Ingrese el año de publicación: ");
        //            int anio = int.Parse(Console.ReadLine());

        //            Libro nuevoLibro = new Libro(titulo, autor, editorial, anio);
        //            biblioteca.AgregarLibro(nuevoLibro);
        //        }
        //        else if (opcion == 2)
        //        {
        //            biblioteca.ListarLibros();
        //        }
        //        else if (opcion == 3)
        //        {
        //            Console.Write("Ingrese el título del libro a buscar: ");
        //            string buscarTitulo = Console.ReadLine();
        //            biblioteca.BuscarLibro(buscarTitulo);
        //        }
        //        else if (opcion != 4)
        //        {
        //            Console.WriteLine("Opción no válida.");
        //        }

        //    } while (opcion != 4);

        //    Console.WriteLine("Programa finalizado.");
        //}





        class Program
        {
            static void Main(string[] args)
            {
                Universidad universidad = new Universidad();

                string[] programas = { "Ingeniería de Sistemas", "Psicología", "Economía", "Comunicación Social", "Administración de Empresas" };
                int[] creditos = { 20, 16, 18, 18, 20 };
                double[] descuentos = { 0.18, 0.12, 0.10, 0.05, 0.15 };

                Console.Write("Ingrese el número de estudiantes a matricular: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n--- Estudiante #{i + 1} ---");

                    for (int j = 0; j < programas.Length; j++)
                    {
                        Console.WriteLine($"{j + 1}. {programas[j]}");
                    }

                    Console.Write("Seleccione el programa: ");
                    int opcion = int.Parse(Console.ReadLine()) - 1;

                    Estudiante e = new Estudiante();
                    e.Programa = programas[opcion];
                    e.Creditos = creditos[opcion];
                    e.Descuento = descuentos[opcion];

                    Console.Write("Forma de pago (efectivo / linea): ");
                    e.FormaPago = Console.ReadLine();

                    universidad.AgregarEstudiante(e);
                }

                universidad.MostrarResultados();

                Console.WriteLine("\n Proceso finalizado.");
            }

        }
}
