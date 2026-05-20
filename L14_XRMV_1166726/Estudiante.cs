using System;

namespace Clases;
public class Estudiante
{
    private readonly string Nombre;
    private int Edad;
    private string Grado;
    private decimal[] Notas;

    public Estudiante (string nombre, int edad, string grado, decimal[] notas)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El estudiante debe tener nombre", nameof(nombre));
        if (edad < 0 || edad > 120)
            throw new ArgumentOutOfRangeException(nameof(edad), "Edad debe estar entre 0 y 80");
        if (string.IsNullOrWhiteSpace(grado))
            throw new ArgumentException("El estudiante debe cursar un grado", nameof(grado));
        if (notas == null || notas.Length == 0)
            throw new ArgumentException("El estudiante debe tener al menos una nota", nameof(notas));

        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] < 0 || notas[i] > 100)
                throw new ArgumentOutOfRangeException($"Nota {i} debe estar entre 0 y 100", nameof(notas));
        }

        Edad = edad;
        Nombre = nombre;
        Grado = grado;
        Notas = notas;
    }

    public decimal CalcularPromedio ()
    {
        decimal promedio = 0;
        foreach (var nota in Notas)
            promedio += nota;

        return promedio / Notas.Length;
    }

    public void MostrarInformacion ()
    {
        Console.Write($"""
                Nombre : {Nombre}
                Edad : {Edad}
                Grado : {Grado}
                Promedio : {CalcularPromedio()}
                Aprobado : {(EstaAprobado() ? "Si" : "No")}
                Notas : 
                """);
        foreach (var nota in Notas)
            Console.Write($"[{nota:00.00}]  ");
        Console.WriteLine();
    }

    public bool EstaAprobado ()
        { return CalcularPromedio() >= 61; }

    public decimal AgregarNota (decimal nuevaNota)
    {
        if (nuevaNota < 0 || nuevaNota > 100)
            throw new ArgumentOutOfRangeException(nameof(nuevaNota), "Nota debe estar entre 0 y 100");

        decimal[] tempNotas = new decimal[Notas.Length + 1];

        for (int i = 0; i < Notas.Length; i++)
            tempNotas[i] = Notas[i];

        tempNotas[^1] = nuevaNota;
        Notas = tempNotas;
        return CalcularPromedio();
    }

    public string GetNombre ()
        { return Nombre; }
}
