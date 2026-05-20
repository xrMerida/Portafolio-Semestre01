using System;

namespace Clases;

public class Estudiante
{
    public int Carnet { get; }
    public string Nombre { get; }
    public string Carrera { get; }
    public double Promedio { get; private set; }
    public int Semestre { get; }
    public bool EsMatriculado { get; private set; }
    private double Mensualidad { get; }

    public Estudiante (string nombre, string carrera)
    {
        Random random = new();
        Carnet = random.Next(1000000, 10000000);
        Nombre = nombre;
        Carrera = carrera;
        Semestre = 1;
        Mensualidad = random.Next(1000, 6000);
    }
    public void MatricularEstudiante (int pagoMensualidad)
    {
        EsMatriculado = pagoMensualidad >= Mensualidad;
    }

    public void Detalles ()
    {
        Console.WriteLine($"""
                Carnet:  {Carnet}
                Nombre: {Nombre}
                Carrera: {Carrera}
                Matriculado: {EsMatriculado}
                """);
    }
}
