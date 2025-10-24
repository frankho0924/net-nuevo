ususing System;

namespace ConsoleApp1
{
    class Vehiculo
    {
        public string Placa;
        public string Tipo;
        public DateTime HoraEntrada;
        public DateTime HoraSalida;
        public double TarifaHora;

        public Vehiculo(string placa, string tipo, double tarifaHora)
        {
            Placa = placa;
            Tipo = tipo;
            TarifaHora = tarifaHora;
            HoraEntrada = DateTime.Now;
        }

        public void RegistrarSalida()
        {
            HoraSalida = DateTime.Now;
        }

        public double CalcularValorPagar()
        {
            TimeSpan tiempo = HoraSalida - HoraEntrada;
            double horas = tiempo.TotalHours;
            if (horas < 1) horas = 1;
            return horas * TarifaHora;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Placa: {Placa} | Tipo: {Tipo} | Entrada: {HoraEntrada} | Salida: {HoraSalida} | Tarifa: ${TarifaHora:N0}");
        }
    }
}
