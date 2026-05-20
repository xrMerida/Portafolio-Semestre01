class Program
{
    static void Main()
    {
        // Ejercicio # 01
        Console.WriteLine("==============\n=   EJERCICIO # 01");
        // Declaracion de variables
        string nombre = "Connor";
        int nivel = 1;
        float salud = 31.41F;
        bool esJefe = false;

        Console.WriteLine($"{nombre}, {nivel}, {salud}, {esJefe}");
        
        // Ejercicio # 02
        Console.WriteLine("\n==============\n=   EJERCICIO # 02");
        int numeroEntero = 1500;
        long numeroLargo;
        numeroLargo = numeroEntero;
        Console.WriteLine(numeroLargo);
        double numeroDecimal = numeroLargo;
        Console.WriteLine(numeroDecimal);


        // Ejercicio # 03
        Console.WriteLine("\n==============\n=   EJERCICIO # 03");
        double precioExacto = 45.89;
        int precioRedondeado;
        precioRedondeado = (int)precioExacto;
        Console.WriteLine($"Precio de {precioExacto}, aproximadamente {precioRedondeado}.");


        // Ejercicio # 04
        Console.WriteLine("\n==============\n=   EJERCICIO # 04");
        int numero;
        Console.Write("Ingrese un numero: ");
        string entradaUsuario = Console.ReadLine();
        numero = int.Parse(entradaUsuario) + 5;
        Console.WriteLine($"El numero + 5 es igual a {numero}");

        // Ejercicio # 05
        Console.WriteLine("\n==============\n=   EJERCICIO # 05");
        string valorTexto = "true";
        bool valorBooleano = Convert.ToBoolean(valorTexto);
        string valorDecimal = "25.5";
        double valorDouble = Convert.ToDouble(valorDecimal);
        Console.WriteLine($"El valor boleano es '{valorBooleano}', el valor decimal es '{valorDouble}'");


        // Ejercicio # 06
        Console.WriteLine("\n==============\n=   EJERCICIO # 06");
        double pi = 3.14159265;
        string cadena = pi.ToString("F2");
        Console.WriteLine($"Pi con los primeros dos decimales es {cadena}");


        // Ejercicio # 07
        Console.WriteLine("\n==============\n=   EJERCICIO # 07");
        Console.Write("Ingresa el precio de un producto: ");
        string precioString = Console.ReadLine();
        double precio = Convert.ToDouble(precioString);
        double precioIva = precio * 15/100;
        double precioTotal = precio + precioIva;
        Console.WriteLine($"El precio total sin decimales sera de {(int)precioTotal}");

        // EOF
        Console.ReadLine();
    }
}
