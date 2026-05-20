namespace Estructuras_Repetitivas02
{
    static class Program
    {
        static void Main()
        {
            //////// EJERCICIO 01 ////////
            Console.WriteLine("\n=== EJERCICIO 01 ===");
            int numeroActual;
            int numeroMayor = 0;
            int numeroMenor = 0;
            int promedio = 0;
            string temp;

            for (int i = 0; i < 10; i++)
            {
                // Entrada de usuario
                Console.Write($"Ingrese el numero [{(i+1).ToString("00")}]: ");
                // Proceso
                temp = Console.ReadLine() ?? "0";
                numeroActual = temp.Length == 0 ? 0: int.Parse(temp);
                if (i == 0){ // Evitar ambiguedades (ej. Todos numeros negativos)
                    numeroMayor = numeroActual;
                    numeroMenor = numeroActual;
                    promedio    = numeroActual;
                    continue; // Optimización
                }

                if (numeroActual > numeroMayor) {
                    numeroMayor = numeroActual;
                }
                if (numeroActual < numeroMenor) {
                    numeroMenor = numeroActual;
                }

                promedio += numeroActual;
            }

            Console.WriteLine();
            promedio /= 10;

            // Salida de datos 
            Console.WriteLine($"El numero mayor es {numeroMayor}");
            Console.WriteLine($"El numero menor es {numeroMenor}");
            Console.WriteLine($"El promedio es {promedio}");

            //////// EJERCICIO 02 ////////
            Console.WriteLine("\n=== EJERCICIO 02 ===");
            Console.ReadLine();
            for (int i = 1; i <= 100; i++)
            {
                // Salida de datos
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"[{i.ToString("000")}] ");
                Console.ResetColor();
                if (i % 2 == 0) {
                    Console.Write("Par");
                }
                if (i % 7 == 0) {
                    Console.Write("Siete");
                }
                Console.WriteLine();
            }

            //////// EJERCICIO 03 ////////
            Console.WriteLine("\n=== EJERCICIO 03 ===");
            Console.ReadLine();

            int monto;
            int clientesDescuento = 0;
            int ventas = 0;

            for (int i = 0; i < 10; i++)
            {
                // Entrada de datos
                Console.Write("Ingrese el monto de la compra: ");
                temp = Console.ReadLine() ?? "0";
                monto = temp.Length == 0 ? 0 : int.Parse(temp);
                Console.Write("Debe pagar ");

                // Proceso
                if (monto > 700) {
                    clientesDescuento++;
                    Console.Write(monto * 0.88);
                } else if (monto > 300) {
                    clientesDescuento++;
                    Console.Write(monto * 0.95);
                } else {
                    Console.Write(monto);
                }
                ventas++;
                Console.WriteLine();
            }
            Console.WriteLine();

            // Salida
            Console.WriteLine($"En total se atendieron {ventas} clientes");
            Console.WriteLine($"{clientesDescuento} tenian descuento");

            //////// EJERCICIO 04 ////////
            Console.WriteLine("\n=== EJERCICIO 04 ===");
            Console.ReadLine();
            int numero;
            // string temp;

            // Entrada de usuario
            Console.Write("Ingrese un numero: ");
            temp = Console.ReadLine() ?? "0";
            numero = temp.Length == 0 ? 0 : int.Parse(temp);
            Console.WriteLine("""
                [1] Mostrar los números desde el número ingresado hasta 1
                [2] Mostrar los múltiplos de 3 hasta el número ingresado
                [3] Mostrar los múltiplos de 5 hasta el número ingresado
            """);
            Console.Write(":: ");
            temp = Console.ReadLine() ?? "";
            Console.WriteLine();
            switch (temp) {
                case "1":
                    Console.WriteLine(numero);
                    for (int i = numero; i != 0;)
                    {
                        i = numero < 0 ? i+1 : i-1;

                        Console.WriteLine(i);
                    }
                    break;
                case "2":
                    for (int i = numero; i != 0;)
                    {
                        if (i % 3 == 0) Console.WriteLine(i);

                        i = numero < 0 ? i+1 : i-1;
                    }
                    break;
                case "3":
                    for (int i = numero; i != 0;)
                    {
                        if (i % 5 == 0) Console.WriteLine(i);

                        i = numero < 0 ? i+1 : i-1;
                    }
                    break;
                default:
                    Console.WriteLine("La opcion es invalida!");
                    break;
            }

            //////// EJERCICIO 05 ////////
            Console.WriteLine("\n=== EJERCICIO 05 ===");
            Console.ReadLine();
            int filas;

            Console.Write("Ingrese el numero de filas: ");
            temp = Console.ReadLine() ?? "0";
            filas = temp.Length == 0 ? 0 : int.Parse(temp);

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
