Console.Write("Ejercicio a ejecutar [1,2,3,4] : ");
switch (Convert.ToInt16(Console.ReadLine())) {
    case 1:
        Ejercicio01();
    break;
    case 2:
        Ejercicio02();
    break;
    case 3:
        Ejercicio03();
    break;
    case 4:
        Ejercicio04();
    break;
    default:
        Console.WriteLine("Opcion Invalida");
    break;
}

static void Ejercicio01 () {
    int numero;
    Console.Write("Ingrese un numero: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero == 0) {
        Console.WriteLine("El numero es igual a 0");
    } else if (numero > 0) {
        Console.WriteLine("El numero es Positivo");
    } else {
        Console.WriteLine("El numero es Negativo");
    }
}

static void Ejercicio02 () {
    int year;
    Console.Write("Ingrese un año: ");
    year = Convert.ToInt32(Console.ReadLine());
    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
        Console.WriteLine("Es bisiesto");
    } else {
        Console.WriteLine("No es bisiesto");
    }
}

static void Ejercicio03 () {
    int salario,
        arbitro = 0;
    string esMultadoStr;
    bool esMultado = false;
    Console.Write("Ingresar su salario mensual: ");
    salario = Convert.ToInt32(Console.ReadLine());
    Console.Write("Tiene alguna multa [S/N]: ");
    esMultadoStr = Console.ReadLine();

    if (esMultadoStr == "s" || esMultadoStr == "S") {
        esMultado = true;
    } else if (esMultadoStr == "n" || esMultadoStr == "N") {
        esMultado = false;
    } else {
        Console.WriteLine($"ERROR: \"{esMultadoStr}\" es invalido");
        Environment.Exit(1);
    }

    if (salario > 12000) {
        arbitro = 150;
    } else if (salario > 9000) {
        arbitro = 100;
    } else if (salario > 6000) {
        arbitro = 75;
    } else if (salario > 3000) {
        arbitro = 50;
    } else if (salario > 1000) {
        arbitro = 15;
    } else if (salario > 500) {
        arbitro = 10;
    } else {
        Console.WriteLine("Salario Invalido");
        Environment.Exit(1);
    }
    
    if (esMultado) {
        arbitro *= 2;
    }

    Console.WriteLine($"Su pago sera de {arbitro}");
} 

static void Ejercicio04 () {
    int cobro,
        pago,
        cambio,
        cambioDisplay;

    Console.Write("Ingrese el tiempo de su estadia en horas: ");
    cobro = 10 * Convert.ToInt32(Console.ReadLine());
    Console.Write($"Debe pagar {cobro}\nIngrese el/los billete/s: ");
    pago = Convert.ToInt32(Console.ReadLine());

    if (pago < cobro) {
        Console.WriteLine("ERROR: El pago es incompleto");
        Environment.Exit(1);

    } else if (pago == cobro) {
        Console.WriteLine("Pago completado, sin cambio");

    } else {
        cambio = pago - cobro;
        Console.WriteLine("Cambio de ");
        if (cambio >= 100) {
            cambioDisplay = cambio / 100;
            cambio %= 100;
            Console.WriteLine($"  {cambioDisplay} billete/s de Q.100"); 
        }
        if (cambio >= 50) {
            cambioDisplay = cambio / 50;
            cambio %= 50;
            Console.WriteLine($"  {cambioDisplay} billete/s de Q.50"); 
        }
        if (cambio >= 20) {
            cambioDisplay = cambio / 20;
            cambio %= 20;
            Console.WriteLine($"  {cambioDisplay} billete/s de Q.20"); 
        }
        if (cambio >= 10) {
            cambioDisplay = cambio / 10;
            cambio %= 10;
            Console.WriteLine($"  {cambioDisplay} billete/s de Q.10"); 
        }
        if (cambio >= 5) {
            cambioDisplay = cambio / 5;
            cambio %= 5;
            Console.WriteLine($"  {cambioDisplay} billete/s de Q.5"); 
        }
        if (cambio >= 1) {
            Console.WriteLine($"  {cambio} billete/s de Q.1"); 
        }
    }
}
