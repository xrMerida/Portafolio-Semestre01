namespace Arreglos
{
    static class Program
    {
        static void Main()
        {
            int ejercicio = 0;
            string textoUsuario;
            bool esPalindromo;

            ////////// EJERCICO 01 //////////
            SiguienteEjercicio(ref ejercicio);

            do
            {

                Console.Write("Ingrese una frase o palabra: ");
                textoUsuario = (Console.ReadLine() ?? "").ToLower();
                if (textoUsuario.Length == 0)
                {
                    Console.Write(" :: La palabra no puede estar vacia");
                    Console.Write("\eM\r\e[K");
                }
            } while (textoUsuario.Length == 0);
            Console.Write("\e[J");

            esPalindromo = false;
            for (int i = 0; i < textoUsuario.Length; i++)
            {
                // [IDE0056] El operador [^n] es una simplificación del siguiente
                // codigo: cadena[cadena.Length - n]
                //
                // Compara el primer elemento del string [i] con el ultimo [^(i+1)]
                // Se coloca i+1 para evitar que en la primer itración (i = 0), el
                // indice sea mayor al limite del string
                esPalindromo = textoUsuario[i] == textoUsuario[^(i+1)];
                if (!esPalindromo) break;
            }
            if (esPalindromo) Console.WriteLine(" +  Es un palindromo");
            else Console.WriteLine(" -  No es palindromo");

            ////////// EJERCICO 02 //////////
            SiguienteEjercicio(ref ejercicio);

            string[] español = ["rojo",   "azul", "amarillo", "blanco", "verde"];
            string[] ingles =  ["red",    "blue", "yellow",   "white",  "green"];
            string[] italiano = ["rosso", "blu",  "giallo",   "bianco", "verde"];

            string respuesta;
            Console.WriteLine("\eM");
            while (true)
            {

                Console.Write("""

                        [1] Practicar Leccion
                        [2] Terminar Leccion
                         > 
                        """);
                respuesta = Console.ReadLine() ?? "";

                switch (respuesta)
                {
                    case "1":
                        Console.Write("Ingrese la palabra en español: ");
                        string palabra = (Console.ReadLine() ?? "").ToLower();
                        bool existe = false;
                        for (int i = 0; i < español.Length; i++)
                        {
                            existe = palabra == español[i];
                            if (existe)
                            {
                                Console.WriteLine($" +  Traduccion a italiano: {italiano[i]}");
                                Console.WriteLine($" +  Traduccion a ingles: {ingles[i]}");
                                break;
                            }
                        }
                        if (!existe) Console.WriteLine(" -  No se encuentra en el diccionario");
                        break;

                    case "2":
                        Console.WriteLine(" +  Leccion Termiada");
                        break;

                    default:
                        Console.WriteLine(" -  Opcion Invalida");
                        break;
                }

                if (respuesta == "2") break;

                Console.Write(" :: Presione enter para continuar");
                Console.ReadLine();
            }


            ////////// EJERCICO 03 //////////
            SiguienteEjercicio(ref ejercicio);
            Random random = new();
            int[] numeros = new int[10];

            // Rellenar el arreglo de 10 numeros aleatorios
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next(50, 101);
            }

            while (true)
            {

                Console.Write("""

                        [1] Reporte de Rendimiento
                        [2] Estadisticas
                        [3] Salir
                         > 
                        """);
                respuesta = Console.ReadLine() ?? "";

                switch (respuesta)
                {
                    case "1":
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            if (numeros[i] >= 80)
                                Console.ForegroundColor = ConsoleColor.Green;
                            else if (numeros[i] >= 65)
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            else // if (numeros[i] >= 50)
                                Console.ForegroundColor = ConsoleColor.Magenta;

                            Console.WriteLine($"Rendimiento {i+1:D2}: {numeros[i]}");
                        }
                        Console.ResetColor();
                        break;

                    case "2":
                        int mayor = numeros[0];
                        int menor = numeros[0];
                        int promedio = 0;
                        foreach (int numero in numeros)
                        {
                            if (mayor < numero)
                                mayor = numero;

                            if (menor > numero)
                                menor = numero;

                            promedio += numero;
                        }
                        promedio /= numeros.Length;

                        Console.WriteLine($"""
                                 +  Estadisticas:
                                    Calificacion Mayor   : {mayor}
                                    Calificacion Menor   : {menor}
                                    Calificacion Promedio: {promedio}
                                """);
                        break;

                    case "3":
                        Console.WriteLine(" -  Resumen Terminado");
                        break;

                    default:
                        Console.WriteLine(" -  Opcion Invalida");
                        break;
                }

                if (respuesta == "3") break;
                Console.Write(" :: Presione enter para continuar");
                Console.ReadLine();
            }

            ////////// EJERCICO 04 //////////
            SiguienteEjercicio(ref ejercicio);
            string[] nombres     = ["Ana", "Mario", "Saúl", "Karla", "María", "José"];
            double[] salarioHora = [100,   125.50,  98.65,  125,     132.50,  102.50];
            double[] totalHoras = new double[nombres.Length];

            for (int i = 0; i < nombres.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Horas que {nombres[i]} trabajo: ");
                    if (!double.TryParse(Console.ReadLine(), out totalHoras[i])
                            || totalHoras[i] < 0)
                    {
                        Console.Write(" -  Debe ingresar un numero positivo");
                        Console.Write("\eM\r\e[K");
                    }
                    else { break; }
                }
                Console.Write("\e[J");

                double pago = 0;
                Console.WriteLine($"El salario por hora es de {salarioHora[i]}");
                if (totalHoras[i] > 40)
                {
                    pago = totalHoras[i] * ((salarioHora[i] - 40) * 1.5);
                }
                pago += totalHoras[i] * salarioHora[i];

                Console.WriteLine($" +  El pago semanal sera de {pago}\n");
            }
        }

        /// <summary>
        /// Muestra el ejercicio actual y un mensaje al usuario como
        /// para continuar al siguiente
        /// </summary>
        static void SiguienteEjercicio (ref int numeroEjercicio)
        {
            numeroEjercicio++;
            if (numeroEjercicio != 1)
            {
                Console.Write("\n :: Ejercicio terminado, presione una tecla");
                Console.ReadKey();
                // Reutiliza la linea anterior
                Console.Write("\eM\r\e[J");
            }
            Console.WriteLine($"\n//////// EJERCICO {numeroEjercicio:D2} ////////");
        }
    }
}
