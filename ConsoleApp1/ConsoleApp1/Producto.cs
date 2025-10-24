using System;

namespace ConsoleApp1
{
    class Producto
    {
        public string Nombre;
        public int Cantidad;
        public double Precio;

        public Producto(string nombre, int cantidad, double precio)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }

        public double ValorTotal()
        {
            return Cantidad * Precio;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"Producto: {Nombre} | Cantidad: {Cantidad} | Precio: ${Precio:N0} | Valor total: ${ValorTotal():N0}");
        }
    }
}
