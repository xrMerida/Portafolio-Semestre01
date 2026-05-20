namespace Metodos
{
    static class Program
    {
        static void Main(string[] args)
        {
            /////// EJERCICO 01 ///////
            Console.WriteLine("/////// EJERCICO 01 ///////");
            string texto;
            Console.Write("Ingrese un texto: ");
            texto = Console.ReadLine() ?? "";
            Console.Write("La longitud del texto es ");
            Longitud(texto);
            Console.WriteLine();


            /////// EJERCICO 02 ///////
            Console.WriteLine("\n/////// EJERCICO 02 ///////");
            Console.ReadKey();
            int varA;
            int varB;
            Console.Write("Ingrese la variable a: ");
            varA = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Ingrese la variable b: ");
            varB = int.Parse(Console.ReadLine() ?? "0");
            Intercambio(ref varA, ref varB);
            Console.WriteLine($"Variable a es: {varA}\nvariable b es: {varB}");


            /////// EJERCICO 03 ///////
            Console.WriteLine("\n/////// EJERCICO 03 ///////");
            Console.ReadKey();
            float precio;
            float descuento;
            Console.Write("Ingrese el precio del boleto: ");
            precio = float.Parse(Console.ReadLine() ?? "");
            Console.Write("Ingrese el descuento del boleto: ");
            descuento = float.Parse(Console.ReadLine() ?? "");
            Promocion(descuento, ref precio);
            Console.WriteLine($"El precio final sera de {precio}");


            /////// EJERCICO 04 ///////
            Console.WriteLine("\n/////// EJERCICO 04 ///////");
            Console.ReadKey();
            bool salida = false;
            int vida = 15;
            while (!salida) {
                Console.Clear();
                Console.WriteLine("""
                        /////// EJERCICO 04 ///////
                        [1] Recibir Daño
                        [2] Curar
                        [3] Mostrar Salud
                        [4] Calificar Despempeño y salir
                        """);
                Console.Write(" :: ");
                switch (Console.ReadLine()) {
                    case "1":
                        RecibirDaño(ref vida);
                        break;
                    case "2":
                        Curar(ref vida);
                        break;
                    case "4":
                        Desempeño(vida);
                        salida = true;
                        break;
                    default:
                        // Se muestra la vida actual si la opcion seleccionada
                        // es invalida intencionalmente
                        MostrarSalud(vida);
                        Console.ReadKey();
                        break;

                }
            }
        }

        static void Longitud(string Cadena)
        {
            Console.Write(Cadena.Length);
        }

        static void Intercambio(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Promocion(float descuento, ref float precio)
        {
            precio *= descuento;
        }

        static void RecibirDaño(ref int vida) {
            vida = vida < 5 ? 0 : vida - 5;
        }

        static void Curar(ref int vida) {
            vida = vida > 12 ? 15 : vida + 3;
        }

        static void MostrarSalud(int vida) {
            switch (vida) {
                case >10:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case >5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
            Console.WriteLine($"La vida salud acutal es de {vida}");
            Console.ResetColor();
        }

        static void Desempeño(int vida) {
            Console.Write("Calificación: ");
            switch (vida) {
                case 15:
                    Console.WriteLine("S");
                    break;
                case >10:
                    Console.WriteLine("A");
                    break;
                case >5:
                    Console.WriteLine("B");
                    break;
                default:
                    Console.WriteLine("C");
                    break;
            }
        }
    }
}
