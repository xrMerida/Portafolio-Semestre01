///////// EJERCICIO 03 /////////
Console.WriteLine("== EJERCICIO 03 ==");

double puntuacion;
double bonificacion = 2400;

Console.Write("Ingrese su puntuacion: ");
puntuacion = Convert.ToDouble(Console.ReadLine());

switch (puntuacion) {
    case 0:
        Console.Write("Inaceptable,");
        bonificacion *= puntuacion;
    break;
    case 0.4:
        Console.Write("Aceptable, ");
        bonificacion *= puntuacion;
    break;
    case > 0.6:
        Console.Write("Meritorio, ");
        bonificacion *= puntuacion;
    break;
    default:
        Console.WriteLine("ERROR: Puntuacion Invalida");
        Environment.Exit(1);
    break;
}

Console.WriteLine($"su bonificacion sera de {bonificacion}");


///////// EJERCICIO 04 /////////
Console.WriteLine("\n\n== EJERCICIO 04 ==");

int    seleccion;
double magnitud,
       conversion = 0;

Console.Write(
@"[1] Celsius -> Farenheit
[2] Farenheit -> Celsius
[3] Celsius -> Kelvin
Conversion: ");
seleccion = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese la magnitud: ");
magnitud = Convert.ToDouble(Console.ReadLine());

switch (seleccion) {
    case 1:
        conversion = magnitud * 9/5 + 32;
    break;
    case 2:
        conversion = (magnitud - 32) * 5/9;
    break;
    case 3:
        conversion = magnitud + 273.15;
    break;
    default:
        Console.WriteLine("ERROR: Opcion Invalida");
        Environment.Exit(1);
    break;
}

Console.WriteLine($"Resultado: {conversion}");
