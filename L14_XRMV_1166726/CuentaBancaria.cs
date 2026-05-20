using System;

namespace Clases;
public class CuentaBancaria
{
    private readonly string Titular;
    private readonly string NumeroCuenta;
    private decimal Saldo;

    public CuentaBancaria (string titular)
    {
        if (titular.Trim().Length == 0)
            throw new ArgumentException("Cuenta debe tener un titular", nameof(titular));

        Random random = new();

        Titular = titular;
        NumeroCuenta = random.Next(10000000, 100000000).ToString();
        Saldo = 0;
    }

    public void MostrarDatos ()
    {
        Console.WriteLine($"""
                Titular : {Titular}
                Numero : {NumeroCuenta}
                Saldo : Q {Saldo:0000.00}
                """);
    }

    public void Depositar (decimal monto)
    {
        if (monto < 0)
            throw new ArgumentOutOfRangeException(nameof(monto), "Monto debe ser mayor a 0");
        else
            Saldo += monto;
    }

    public void Retirar (decimal monto)
    {
        if (monto < 0)
            throw new ArgumentOutOfRangeException(nameof(monto), "Monto debe ser mayor a 0");

        else if (Saldo < monto)
            throw new InvalidOperationException("Monto supera el saldo disponible");

        else
            Saldo -= monto;
    }
}
