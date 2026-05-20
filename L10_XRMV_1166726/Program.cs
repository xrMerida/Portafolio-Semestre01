namespace ManipulacionDeStrings
{
    static class Program
    {
        static void Main()
        {
           /////// EJERCICIO 01 //////////
            Console.WriteLine("/////// EJERCICIO 01 //////////");
            int digitosSumados;

            Console.Write("Ingrese un numero: ");
            digitosSumados = SumaDigitos(Console.ReadLine() ?? "");
            if (digitosSumados == -1) Console.WriteLine("Debe ingresar un numero entero");
            else Console.WriteLine("La suma de los digitos es: " + digitosSumados);
            Console.Read();


            /////// EJERCICIO 02 //////////
            Console.WriteLine("/////// EJERCICIO 02 //////////");
            string[] nombre = new string[4];
            string correo;

            Console.Write("Ingrese su primer nombre: ");
            nombre[0] = Console.ReadLine() ?? "";
            Console.Write("Ingrese su segundo nombre: ");
            nombre[1] = Console.ReadLine() ?? "";
            Console.Write("Ingrese su primer apellido: ");
            nombre[2] = Console.ReadLine() ?? "";
            Console.Write("Ingrese su segundo apellido: ");
            nombre[3] = Console.ReadLine() ?? "";
            correo = EnsamblarCorreo(nombre[0], nombre[1], nombre[2], nombre[3]);

            if (correo == null) Console.WriteLine("Todos los campos son obligatorios");
            else Console.WriteLine($"Su correo sera: {correo}");
            Console.Read();


            /////// EJERCICIO 03 //////////
            Console.WriteLine("/////// EJERCICIO 03 //////////");
            string temperatura;
            int fahrenheit = 0;

            Console.WriteLine("Ingrese la temperatura en celsius: ");
            Console.Write("C = ");
            temperatura = $"C = {Console.ReadLine()}";

            temperatura = CelsiusFahrenheit(temperatura, ref fahrenheit);
            // Si la funcion falla (reotrna null), mostrar un mensaje de eror
            if (temperatura == null) Console.WriteLine("Debe ingresar un valor");
            else Console.WriteLine($"El resultado es {fahrenheit}\n{temperatura}");
            Console.Read();


            /////// EJERCICIO 04 //////////
            Console.WriteLine("/////// EJERCICIO 04 //////////");
            string seleccion;
            int puntos;
            string estado;

            while (true) {
                Console.Write("Ingrese los puntos del estudiante: ");
                // El ciclo reinicia cuando parse falla
                if (!int.TryParse(Console.ReadLine(), out puntos)) Console.WriteLine("Entrada Invalida");
                else if (puntos is <= 100 and >= 0) break;
                else Console.WriteLine("Solo se admiten valores entre 0 y 100");
            }

            estado = $"{puntos}";
            while (true) {
                Console.Clear();
                Console.Write($"""
                        Estado {estado}:

                        [1] Agregar Puntos (+10)
                        [2] Quitar Puntos (-7)
                        [3] Obtener Nivel
                        [4] Evaluar Estado
                        [5] Salir
                         >  
                        """);
                seleccion = Console.ReadLine() ?? "";
                switch (seleccion) {
                    case "1":
                        AgregarPuntos(ref puntos);
                        estado = $"{puntos}";
                        break;
                    case "2":
                        QuitarPuntos(ref puntos);
                        estado = $"{puntos}";
                        break;
                    case "3":
                        estado = ObtenerNivel(puntos);
                        break;
                    case "4":
                        estado = EvaluarEstado(puntos);
                        break;
                    case "5":
                        Console.WriteLine("Programa Termiado");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
            }
        }

        /// <summary>
        /// Devuelve la suma de los digitos del parametro string
        /// Si la cadena no es un numero devuelve -1
        /// </summary>
        static int SumaDigitos (string numero)
        {
            // La funcion retorna -1 cuando falla, nunca podra retornar
            // un valor negativo en operación normal

            // No permite que el texto este vacio
            if (numero.Length == 0) return -1;

            int suma = 0;
            // Bucle para ir por todos los digitos del numero
            for (int i = 0; i <= numero.Length - 1; i++)
            {
                // Cuando el caracter no es un numero, devuelve -1
                if (!int.TryParse(numero.Substring(i, 1), out int digito)) return -1;
                suma += digito;
            }
            return suma;
        }


        /// <summary>
        /// Recibe los 4 nombres de una persona, y los utiliza para ensamblar el correo
        /// institucional con @correo.url.edu.gt
        /// Devuelve null si alguno de los parametros esta vacio
        /// </summary>
        static string EnsamblarCorreo (string primerNombre, string segundoNombre,
                                       string primerApellido, string segundoApellido) {
            // Retornar null si algun parametro esta vacio
            if (primerNombre.Length == 0
                    || segundoNombre.Length == 0
                    || primerApellido.Length == 0
                    || segundoApellido.Length == 0) { return null; }

            return primerNombre.Substring(0, 1).ToLower()
                + segundoNombre.Substring(0, 1).ToLower()
                + primerApellido.ToLower()
                + segundoApellido.Substring(0, 1).ToLower()
                + "@correo.url.edu.gt";
        }

        /// <summary>
        /// Recibe un string formateado de temperatura en celsius "C = 25", y
        /// una variable por referencia donde se guarda la temperatura en fahrenheit.
        /// Devuelve un string formateado "F = 77", o null si falla
        /// </summary>
        static string CelsiusFahrenheit (string temperatura, ref int fahrenheit) {
            // Remplaza todos los espacios con nada
            temperatura = temperatura.Replace(" ", "");
            // Remplaza C= con nada
            temperatura = temperatura.Replace("C=", "");

            // Si lo que resta no es un numero, retornar null
            if (!int.TryParse(temperatura, out fahrenheit)) return null;

            fahrenheit = (fahrenheit * 9/5) + 32;
            return $"F = {fahrenheit}";
        }


        /// <summary>
        /// Aumenta los puntos del estudiante en 10, maximo de 100 puntos
        /// </summary>
        static void AgregarPuntos (ref int puntos) {
            if (puntos > 90) puntos = 100;
            else puntos += 10;
        }


        /// <summary>
        /// Disminuye los puntos del estudainte en 7, minimo de 0 puntos
        /// </summary>
        static void QuitarPuntos (ref int puntos) {
            if (puntos < 7) puntos = 0;
            else puntos -= 7;
        }

        /// <summary>
        /// Retorna el nivel del estudiante basandose en puntos
        /// </summary>
        static string ObtenerNivel (int puntos) {
            if (puntos >= 80) return "Avanzado";
            else if (puntos >= 50) return "Intermedio";
            else return "Basico";
        }


        /// <summary>
        /// Retorna el estado del estudiante basandose en puntos
        /// </summary>
        static string EvaluarEstado (int puntos) {
            if (puntos == 100) return "Excelente";
            else if (puntos >= 70) return "Aprobado";
            else return "Reprobado";
        }
    }
}
