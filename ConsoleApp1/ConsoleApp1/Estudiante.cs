using System;

namespace ConsoleApp1
{
    class Estudiante
    {
        public string Programa;
        public int Creditos;
        public double Descuento;
        public double ValorCredito = 200000;
        public string FormaPago;

        public double CalcularValorSinDescuento()
        {
            return Creditos * ValorCredito;
        }

        public double CalcularDescuento()
        {
            if (FormaPago.ToLower() == "efectivo")
                return CalcularValorSinDescuento() * Descuento;
            else
                return 0;
        }

        public double CalcularValorFinal()
        {
            return CalcularValorSinDescuento() - CalcularDescuento();
        }
    }
}
