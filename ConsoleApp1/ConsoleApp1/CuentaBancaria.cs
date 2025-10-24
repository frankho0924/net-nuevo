using System;

namespace ConsoleApp1
{
    class CuentaBancaria
    {
        public string Titular;
        public double Saldo;

        public CuentaBancaria(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void ConsultarSaldo()
        {
            Console.WriteLine($"\nSaldo actual de {Titular}: ${Saldo:N0}");
        }

        public void Depositar(double monto)
        {
            if (monto > 0)
            {
                Saldo += monto;
                Console.WriteLine($"Depósito exitoso. Nuevo saldo: ${Saldo:N0}");
            }
            else
            {
                Console.WriteLine("El monto debe ser mayor que cero.");
            }
        }

        public void Retirar(double monto)
        {
            if (monto > 0 && monto <= Saldo)
            {
                Saldo -= monto;
                Console.WriteLine($"Retiro exitoso. Nuevo saldo: ${Saldo:N0}");
            }
            else
            {
                Console.WriteLine("❌ No se puede retirar ese monto (saldo insuficiente o valor inválido).");
            }
        }
    }
}
