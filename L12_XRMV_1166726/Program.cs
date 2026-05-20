namespace ArreglosBidimensionales
{
    static class Program
    {
        static void Main()
        {
            SiguienteEjercicio(1);
            ////////// EJERCICO 01 //////////
            int[,] matriz = new int[5, 5];

            LlenarMatriz(ref matriz);
            MostrarMatriz(matriz);
            Console.WriteLine($"La suma de la diagonal principal es: {SumaDiagonalPrincipal(matriz)}");
            Console.WriteLine($"La suma de la diagonal secundaria es: {SumaDiagonalSecundaria(matriz)}");


            ////////// EJERCICO 02 //////////
            SiguienteEjercicio(2);
            /* int[,] */ matriz = new int[4, 6];

            LlenarMatriz(ref matriz);
            MostrarMatriz(matriz);
            Console.WriteLine($"Hay {ContarPares(matriz)} pares");
            Console.WriteLine($"Hay {ContarImpares(matriz)} impares");


            ////////// EJERCICO 03 //////////
            SiguienteEjercicio(3);
            double[,] notas = new double[5, 4];

            Console.Write("Saltar ejercicio (debug): [y/N] ");
            if (Console.ReadLine() is not ("y" or "Y"))
            {
                IngrearNotas(ref notas);
                MostrarMatriz(notas);
            }


            ////////// EJERCICO 04 //////////
            SiguienteEjercicio(4);
            /* int[,] */ matriz = new int[3,3];

            Console.Write("Llenar matriz simetricamente? [Y/n] ");
            if (Console.ReadLine() is not ("n" or "N"))
                 LlenarMatrizSimetrico(ref matriz);
            else
                 LlenarMatriz(ref matriz);

            MostrarMatriz(matriz);
            if (EsSimetrica(matriz))
                Console.WriteLine("Es simetrica");
            else
                Console.WriteLine("No es simetrica");
        }

        static void LlenarMatrizSimetrico(ref int[,] matriz)
        {
            // Se crea un objeto aleatorio
            Random random = new();
            // i seran las filas, solo se ejecutara la mitad de veces ya que se
            // llenara de izquierda a derecha y de derecha a izquierda en la misma
            // iteración
            //
            // Se le suma 1 para que llene el centro
            for (int i = 0; i < (matriz.GetLength(1) / 2) + 1; i++)
            {
                // j seran las columnas (de izquierda a derecha)
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    // k seran las columnas (de derecha a izquierda)
                    int k = matriz.GetLength(1) - 1 - i;

                    matriz[j,i] = random.Next(1, 11);
                    matriz[j,k] = matriz[j,i];
                }
            }
        }
        static bool EsSimetrica (int[,] matriz)
        {
            // i seran las filas, solo se ejecutara la mitad de veces ya que se
            // comprobara de izquierda a derecha y de derecha a izquierda en 
            // la misma iteración
            //
            // No se suma 1 para que no compare el centro
            for (int i = 0; i < (matriz.GetLength(1) / 2); i++)
            {
                // j seran las columnas (de izquierda a derecha)
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    // k seran las columnas (de derecha a izquierda)
                    int k = matriz.GetLength(1) - 1 - i;

                    // Retorna inmediatamente cuando encuentra una discrepancia
                    if (matriz[j,i] != matriz[j,k]) return false;
                }
            }
            // Si no retorna antes si existe la simetria
            return true;
        }
        static bool EsAprobado (double promedio)
        {
            return promedio >= 61;
        }
        static double CalcularPromedio (double[,] matriz, int estudiante)
        {
            double promedio = 0;
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                promedio += matriz[estudiante, i];
            }

            return promedio / matriz.GetLength(1);
        }
        static void IngrearNotas (ref double[,] matriz)
        {
            // i seran filas (estudiantes)
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine($"---- Estudiante {i+1:0} -----");
                // j seran las columnas (notas)
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // Bucle para prevenir errores
                    while (true)
                    {
                        Console.Write($"Nota Clase {j+1:0}: ");
                        // Mostrar error si la nota esta fuera de rango o, si la
                        // entrada no es un numero
                        if (!double.TryParse(Console.ReadLine(), out double nota)
                                || nota is < 0 or > 100)
                        {
                            Console.Write(" :: Ingrese un numero entre 0 y 100");
                            Console.Write("\eM\r\e[K");
                        }

                        else
                        {
                            matriz[i,j] += nota;
                            break;
                        }
                    }
                    Console.Write("\e[J");
                }
                double promedio = CalcularPromedio(matriz, i);
                if (EsAprobado(promedio))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Aprobado");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Reprobado");
                }
                Console.WriteLine($" con {promedio:.00}\n");
                Console.ResetColor();
            }
        }

        static int ContarImpares (int[,] matriz)
        {
            return matriz.Length - ContarPares(matriz);
        }
        static int ContarPares (int[,] matriz)
        {
            int pares = 0;
            // i seran las columnas
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // j seran las filas
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] % 2 == 0)
                        pares++;
                }
            }
            return pares;
        }

        static void LlenarMatriz (ref int[,] matriz)
        {
            Random random = new();
            // i seran las columnas
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // j seran las filas
                for (int j = 0; j < matriz.GetLength(1); j++)
                    matriz[i,j] = random.Next(0, 11);
            }
        }

        static int SumaDiagonalSecundaria (int[,] matriz)
        {
            int suma = 0;
            // j seran las filas (arriba a abajo)
            int j = 0;
            // i seran las columnas (derecha a izquierda)
            for (int i = matriz.GetLength(0) - 1; i >= 0; i--)
            {
                suma += matriz[i, j];
                j++;
            }
            return suma;
        }

        static int SumaDiagonalPrincipal (int[,] matriz)
        {
            int suma = 0;
            // i seran las columnas
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // Si las dimensiones del arreglo son asimetricas
                // - Previene errores
                if (i > matriz.GetLength(1)) break;

                suma += matriz[i, i];
            }
            return suma;
        }

        static void MostrarMatriz (int[,] matriz)
        {
            // i seran las columnas
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // j seran las filas
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // En interpolacion, colocar ':00' al final permite que seimpre
                    // se muestren 2 digitos del numero
                    Console.Write($"{matriz[i,j]:00}  ");
                }
                Console.WriteLine();
            }
        }

        // Sobrecarga permite mostrar una matriz int o una matriz double
        static void MostrarMatriz (double[,] matriz)
        {
            // i seran las columnas
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // j seran las filas
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // En interpolacion, colocar ':00.0' al final permite que seimpre
                    // se muestren 2 digitos del numero y 1 decimal
                    Console.Write($"{matriz[i,j]:00.0}  ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Muestra el ejercicio actual y un mensaje al usuario para
        /// para continuar al siguiente
        /// </summary>
        static void SiguienteEjercicio (int numeroEjercicio)
        {
            if (numeroEjercicio > 1)
            {
                Console.Write("\n :: Ejercicio terminado, presione una tecla");
                Console.ReadKey();
                // Reutiliza la linea anterior
                Console.Write("\eM\r\e[J");
            }
            Console.WriteLine($"\n//////// EJERCICO {numeroEjercicio:00} ////////");
        }
    }
}
