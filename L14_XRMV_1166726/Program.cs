using System;

namespace Clases;
static class Program
{
    static void Main()
    {
        WriteContinue(1);
        //////// EJERCICIO 01 ////////
        CuentaBancaria[] cuentas = new CuentaBancaria[2];

        for (int i = 0; i < cuentas.Length; i++)
        {
            Console.Write("Ingrese el nombre del titular: ");

            try { cuentas[i] = new(Console.ReadLine() ?? ""); }

            catch (ArgumentException)
            {
                WriteError("Titular invalido");
                continue;
            }

            CleanLine();


            while (true)
            {
                Console.Write("Ingrese el deposito inical: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal monto))
                {
                    WriteError("Ingrese un numero");
                    continue;
                }

                try { cuentas[i].Depositar(monto); }

                catch (ArgumentOutOfRangeException)
                {
                    WriteError("Monto fuera de rango");
                    continue;
                }

                CleanLine();
                break;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            cuentas[i].MostrarDatos();
            Console.ResetColor();

            while (true)
            {
                Console.Write("Ingrese la cantidad a retirar: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal monto))
                {
                    WriteError("Ingrese un numero");
                    continue;
                }

                try { cuentas[i].Retirar(monto); }

                catch (ArgumentOutOfRangeException)
                {
                    WriteError("Monto fuera de rango");
                    continue;
                }

                catch(InvalidOperationException)
                {
                    WriteError("Monto supera el saldo");
                    continue;
                }

                CleanLine();
                break;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            cuentas[i].MostrarDatos();
            Console.ResetColor();
            Console.WriteLine();
        }


        WriteContinue(2);
        //////// EJERCICIO 02 ////////
        Producto[] producto = new Producto[2];

        for (int i = 0; i < producto.Length; i++)
        {
            while (true)
            {
                Console.Write("Ingrese el nombre del producto: ");

                try { producto[i] = new(Console.ReadLine() ?? ""); }

                catch(ArgumentException)
                {
                    WriteError("Nombre invalido");
                    continue;
                }

                CleanLine();
                break;
            }

            while (true)
            {
                Console.Write($"Ingrese el precio de {producto[i].GetNombre()}: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
                {
                    WriteError("Ingrese un numero");
                    continue;
                }

                try { producto[i].SetPrecio(precio); }

                catch (ArgumentOutOfRangeException)
                {
                    WriteError("Precio fuera de rango");
                    continue;
                }

                CleanLine();
                break;
            }

            while (true)
            {
                Console.Write($"Ingrese la cantidad de {producto[i].GetNombre()} a suministrar: ");
                if (!int.TryParse(Console.ReadLine(), out int cantidad))
                {
                    WriteError("Ingrese un numero");
                    continue;
                }

                try { producto[i].Reabastecer(cantidad); }

                catch (ArgumentOutOfRangeException)
                {
                    WriteError("Cantidad fuera de rango");
                    continue;
                }

                CleanLine();
                break;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            producto[i].MostrarDatos();
            Console.ResetColor();

            while (true)
            {
                Console.Write($"Ingrese la cantidad de {producto[i].GetNombre()} a vender: ");
                if (!int.TryParse(Console.ReadLine(), out int cantidad))
                {
                    WriteError("Ingrese un numero");
                    continue;
                }

                try { producto[i].Vender(cantidad); }

                catch (ArgumentOutOfRangeException)
                {
                    WriteError("Cantidad fuera de rango");
                    continue;
                }

                catch (InvalidOperationException)
                {
                    WriteError("Cantidad supera el stock");
                    continue;
                }

                CleanLine();
                break;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            producto[i].MostrarDatos();
            Console.ResetColor();
            Console.WriteLine();
        }


        WriteContinue(3);
        //////// EJERCICIO 03 ////////
        Estudiante[] estudiantes = new Estudiante[2];

        (_, int cursor) = Console.GetCursorPosition();
        for (int i = 0; i < estudiantes.Length; i++)
        {
            string nombre;
            int edad;
            string grado;
            decimal[] notas;

            Console.Write($"Ingrese el nombre del estudiante {i}: ");
            nombre = Console.ReadLine() ?? "";
            CleanLine();

            while (true)
            {
                Console.Write($"Ingrese la edad de {nombre}: ");
                if (!int.TryParse(Console.ReadLine(), out edad))
                {
                    WriteError("Ingrese un numero");
                    continue;
                }

                CleanLine();
                break;
            }

            Console.Write($"Ingrese el grado de {nombre}: ");
            grado = Console.ReadLine() ?? "";

            while (true)
            {
                Console.Write($"Ingrese la cantidad de notas para {nombre}: ");
                try
                {
                    notas = new decimal[int.Parse(Console.ReadLine()!)];
                    if (notas.Length == 0)
                        throw new InvalidOperationException();
                }

                catch
                {
                    WriteError("Cantidad invalida");
                    continue;
                }

                CleanLine();
                break;
            }

            for (int j = 0; j < notas.Length; j++)
            {
                Console.Write($"Ingrese la nota {j}: ");
                if (!decimal.TryParse(Console.ReadLine(), out notas[j]))
                {
                    WriteError("Ingrese un numero");
                    j--;
                }

                CleanLine();
            }

            try { estudiantes[i] = new(nombre, edad, grado, notas); }

            catch (ArgumentException ex)
            {
                Console.SetCursorPosition(0, cursor + 1);
                WriteError($"\e[J{ex.Message}");
                i--;
                continue;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            estudiantes[i].MostrarInformacion();
            Console.WriteLine();
            Console.ResetColor();

            while (true)
            {
                Console.Write($"Ingrese una nueva nota para {estudiantes[i].GetNombre()}: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal nuevaNota))
                {
                    WriteError("Ingrese un numero valido");
                    continue;
                }

                try
                { decimal nuevoPromedio = estudiantes[i].AgregarNota(nuevaNota); }

                catch (ArgumentOutOfRangeException)
                {
                    WriteError("La nota debe estar entre 0 y 100");
                    continue;
                }

                CleanLine();
                break;
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            estudiantes[i].MostrarInformacion();
            Console.ResetColor();
            Console.WriteLine("\nSiguiente estudiante...");
            WriteContinue(3);
        }

    }

    // Muestra un mensaje para continuar con el ejercicio
    static void WriteContinue (int ejercicio)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        if (ejercicio > 1)
        {
            Console.Write("\n :: Presione una tecla para continuar");
            Console.ReadKey(true);
        }
        Console.Clear();
        Console.WriteLine($"////////// EJRCICIO {ejercicio:00} //////////");
        Console.ResetColor();
    }

    // Permite mostrar un error en consola sin cambiar el cursor de linea
    static void WriteError (string mensajeError)
    {
        CleanLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"  ERROR: {mensajeError} \eM");
        Console.ResetColor();
        CleanLine();
    }

    // Limpia el error escrito por WriteError()
    static void CleanLine ()
    {
        Console.Write("\r\e[K");
    }
}
