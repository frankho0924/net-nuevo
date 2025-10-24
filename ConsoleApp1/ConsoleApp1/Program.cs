using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Vehiculo
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





        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        Universidad universidad = new Universidad();

        //        string[] programas = { "Ingeniería de Sistemas", "Psicología", "Economía", "Comunicación Social", "Administración de Empresas" };
        //        int[] creditos = { 20, 16, 18, 18, 20 };
        //        double[] descuentos = { 0.18, 0.12, 0.10, 0.05, 0.15 };

        //        Console.Write("Ingrese el número de estudiantes a matricular: ");
        //        int n = int.Parse(Console.ReadLine());

        //        for (int i = 0; i < n; i++)
        //        {
        //            Console.WriteLine($"\n--- Estudiante #{i + 1} ---");

        //            for (int j = 0; j < programas.Length; j++)
        //            {
        //                Console.WriteLine($"{j + 1}. {programas[j]}");
        //            }

        //            Console.Write("Seleccione el programa: ");
        //            int opcion = int.Parse(Console.ReadLine()) - 1;

        //            Estudiante e = new Estudiante();
        //            e.Programa = programas[opcion];
        //            e.Creditos = creditos[opcion];
        //            e.Descuento = descuentos[opcion];

        //            Console.Write("Forma de pago (efectivo / linea): ");
        //            e.FormaPago = Console.ReadLine();

        //            universidad.AgregarEstudiante(e);
        //        }

        //        universidad.MostrarResultados();

        //        Console.WriteLine("\n Proceso finalizado.");
        //    }










        //static void Main(string[] args)
        //{
        //    List<Alumno> alumnos = new List<Alumno>();

        //    Console.Write("Ingrese la cantidad de alumnos: ");
        //    int cantidad = int.Parse(Console.ReadLine());

        //    for (int i = 0; i < cantidad; i++)
        //    {
        //        Console.WriteLine($"\n--- Alumno #{i + 1} ---");
        //        Console.Write("Nombre: ");
        //        string nombre = Console.ReadLine();

        //        Console.Write("Nota (0 a 5): ");
        //        double nota = double.Parse(Console.ReadLine());

        //        alumnos.Add(new Alumno(nombre, nota));
        //    }

        //    double sumaNotas = 0;
        //    int aprobados = 0, reprobados = 0;

        //    Console.WriteLine("\n--- LISTA DE ALUMNOS ---");
        //    foreach (var a in alumnos)
        //    {
        //        Console.WriteLine($"Nombre: {a.Nombre} - Nota: {a.Nota}");

        //        sumaNotas += a.Nota;
        //        if (a.EstaAprobado())
        //            aprobados++;
        //        else
        //            reprobados++;
        //    }

        //    double promedio = sumaNotas / cantidad;

        //    Console.WriteLine("\n--- RESULTADOS ---");
        //    Console.WriteLine($"Promedio general: {promedio:F2}");
        //    Console.WriteLine($"Alumnos aprobados: {aprobados}");
        //    Console.WriteLine($"Alumnos reprobados: {reprobados}");

        //    Console.WriteLine("\n✅ Fin del programa.");
        //}









        //static void Main(string[] args)
        //{
        //    Console.Write("Ingrese el nombre del titular: ");
        //    string nombre = Console.ReadLine();

        //    Console.Write("Ingrese el saldo inicial: ");
        //    double saldoInicial = double.Parse(Console.ReadLine());

        //    CuentaBancaria cuenta = new CuentaBancaria(nombre, saldoInicial);

        //    int opcion;
        //    do
        //    {
        //        Console.WriteLine("\n--- MENÚ CUENTA BANCARIA ---");
        //        Console.WriteLine("1. Consultar saldo");
        //        Console.WriteLine("2. Depositar dinero");
        //        Console.WriteLine("3. Retirar dinero");
        //        Console.WriteLine("4. Salir");
        //        Console.Write("Seleccione una opción: ");
        //        opcion = int.Parse(Console.ReadLine());

        //        if (opcion == 1)
        //        {
        //            cuenta.ConsultarSaldo();
        //        }
        //        else if (opcion == 2)
        //        {
        //            Console.Write("Ingrese el monto a depositar: ");
        //            double monto = double.Parse(Console.ReadLine());
        //            cuenta.Depositar(monto);
        //        }
        //        else if (opcion == 3)
        //        {
        //            Console.Write("Ingrese el monto a retirar: ");
        //            double monto = double.Parse(Console.ReadLine());
        //            cuenta.Retirar(monto);
        //        }
        //        else if (opcion != 4)
        //        {
        //            Console.WriteLine("Opción no válida.");
        //        }

        //    } while (opcion != 4);

        //    Console.WriteLine("\n👋 Programa finalizado. ¡Gracias por usar el sistema!");
        //}



















        //static void Main(string[] args)
        //{
        //    List<Producto> inventario = new List<Producto>();
        //    int opcion;

        //    do
        //    {
        //        Console.WriteLine("\n--- MENÚ DE INVENTARIO ---");
        //        Console.WriteLine("1. Agregar producto");
        //        Console.WriteLine("2. Listar productos");
        //        Console.WriteLine("3. Mostrar valor total del inventario");
        //        Console.WriteLine("4. Salir");
        //        Console.Write("Seleccione una opción: ");
        //        opcion = int.Parse(Console.ReadLine());

        //        if (opcion == 1)
        //        {
        //            Console.Write("Nombre del producto: ");
        //            string nombre = Console.ReadLine();

        //            Console.Write("Cantidad: ");
        //            int cantidad = int.Parse(Console.ReadLine());

        //            Console.Write("Precio unitario: ");
        //            double precio = double.Parse(Console.ReadLine());

        //            Producto nuevo = new Producto(nombre, cantidad, precio);
        //            inventario.Add(nuevo);

        //            Console.WriteLine("Producto agregado con éxito.");
        //        }
        //        else if (opcion == 2)
        //        {
        //            Console.WriteLine("\n--- LISTA DE PRODUCTOS ---");
        //            if (inventario.Count == 0)
        //            {
        //                Console.WriteLine("No hay productos registrados.");
        //            }
        //            else
        //            {
        //                foreach (var p in inventario)
        //                {
        //                    p.MostrarInfo();
        //                }
        //            }
        //        }
        //        else if (opcion == 3)
        //        {
        //            double total = 0;
        //            foreach (var p in inventario)
        //            {
        //                total += p.ValorTotal();
        //            }
        //            Console.WriteLine($"\nValor total del inventario: ${total:N0}");
        //        }
        //        else if (opcion != 4)
        //        {
        //            Console.WriteLine("Opción no válida.");
        //        }

        //    } while (opcion != 4);

        //    Console.WriteLine("\nPrograma finalizado.");
        //}
        // noveno ejercicio
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            int opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ PARQUEADERO ---");
                Console.WriteLine("1. Registrar ingreso de vehículo");
                Console.WriteLine("2. Registrar salida y calcular valor");
                Console.WriteLine("3. Listar vehículos registrados");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Placa del vehículo: ");
                    string placa = Console.ReadLine();

                    Console.Write("Tipo de vehículo (carro/moto): ");
                    string tipo = Console.ReadLine();

                    Console.Write("Tarifa por hora: ");
                    double tarifa = double.Parse(Console.ReadLine());

                    Vehiculo nuevo = new Vehiculo(placa, tipo, tarifa);
                    vehiculos.Add(nuevo);

                    Console.WriteLine("Vehículo registrado con éxito.");
                }
                else if (opcion == 2)
                {
                    Console.Write("Ingrese la placa del vehículo: ");
                    string placa = Console.ReadLine();

                    Vehiculo encontrado = vehiculos.Find(v => v.Placa == placa);

                    if (encontrado != null)
                    {
                        encontrado.RegistrarSalida();
                        double valor = encontrado.CalcularValorPagar();
                        Console.WriteLine($"El valor a pagar por {encontrado.Placa} es: ${valor:N0}");
                    }
                    else
                    {
                        Console.WriteLine("Vehículo no encontrado.");
                    }
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("\n--- LISTA DE VEHÍCULOS ---");
                    if (vehiculos.Count == 0)
                    {
                        Console.WriteLine("No hay vehículos registrados.");
                    }
                    else
                    {
                        foreach (var v in vehiculos)
                        {
                            v.MostrarDatos();
                        }
                    }
                }
                else if (opcion != 4)
                {
                    Console.WriteLine("Opción no válida.");
                }

            } while (opcion != 4);

            Console.WriteLine("\nPrograma finalizado.");
        }
    }
}
