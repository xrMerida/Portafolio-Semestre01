/* 
 * Se deshabilito la notificación
 * de reasignación de variables ya que
 * se repitiron variables en los ejercicios
*/
#pragma warning disable IDE0059
namespace Estructuras_Repetitivas
{
    static class Program
    {
        static void Main()
        {
            ////////// EJERCICIO 01 //////////
            Console.WriteLine("=== EJERCICIO 01 ===");
            // Entrada de datos
            const string nombre = "Xavier Mérida";
            const int carne = 1166726;
            int indice = 1;

            // Salida de datos
            Console.WriteLine($"Nombre: {nombre}, carne: {carne}");
            while (indice <= 20)
            {
                if (indice % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(indice);
                indice++;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Read();


            ////////// EJERCICIO 02 //////////
            Console.WriteLine("\n\n=== EJERCICIO 02 ===");
            // Entrada de datos
            int numero,
                residuo;
                indice = 0;
            Console.Write("Ingrese un numero entero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Salida de datos
            indice = 1;
            do
            {
                residuo = numero % indice;
                if (residuo == 0)
                {
                    Console.WriteLine(indice);
                }
                indice++;
            } while (indice <= numero);
            Console.ReadLine();


            ////////// EJERCICIO 03 //////////
            Console.WriteLine("\n\n=== EJERCICIO 03 ===");
            // Entrada de datos
            int actual = 1,
                anterior = 0;
                numero = 0;
                indice = 0;
            Console.Write("Ingrese un numero entero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            // Salida de datos
            for (indice = 0; indice < numero; indice ++)
            {
                Console.WriteLine(anterior);
                actual += anterior;
                anterior = actual - anterior;
            }
            Console.ReadLine();


            ////////// EJERCICIO 04 //////////
            Console.WriteLine("\n\n=== EJERCICIO 04 ===");
            // Entrada de datos
            int tabla;
                indice = 0;

            // Salida de datos
            for (tabla = 1; tabla <= 12; tabla++)
            {
                Console.WriteLine($"\nTabla del {tabla}");
                for (indice = 0; indice <= 10; indice++)
                {
                    Console.WriteLine($"{tabla} * {indice} = {tabla * indice}");
                }
            }
        }
    }
}
