using System;

namespace Clases;

public class Producto
{
    private readonly string Nombre;
    private decimal Precio;
    private int Stock;

    public Producto (string nombre)
    {
        if (nombre.Length == 0)
            throw new ArgumentException("El producto debe tener un nombre", nameof(nombre));

        Nombre = nombre;
        Precio = 0.00M;
        Stock = 0;
    }

    public void MostrarDatos ()
    {
        Console.WriteLine($"""
                Nombre : {Nombre}
                Precio : Q {Precio:000.00}
                Cantidad : {Stock:00}
                """);
    }

    public void Vender (int cantidadVender)
    {
        if (cantidadVender < 0)
            throw new ArgumentOutOfRangeException(nameof(cantidadVender), "La cantidad a vender no puede ser negativa");

        else if (Stock < cantidadVender)
            throw new InvalidOperationException("La cantidad a vender supera el stock");

        else
            Stock -= cantidadVender;
    }

    public void Reabastecer (int cantidadSuministro)
    {
        if (cantidadSuministro < 0)
            throw new ArgumentOutOfRangeException("El suministro no puede ser negativo");

        else
            Stock += cantidadSuministro;
    }

    public void SetPrecio (decimal precio)
    {
        if (precio < 0)
            throw new ArgumentOutOfRangeException("El precio no puede ser negativo", nameof(precio));

        else
            Precio = precio;
    }

    public string GetNombre ()
        { return Nombre; }
}
