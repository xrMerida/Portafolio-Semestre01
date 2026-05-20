class Program
{
    static void Main()
    {
        double capital = 1006;
        double tasa = 0.05;
        double intereses = 0;
        double abonos = 0;

        for (int mes = 1; mes <= 12 && capital > 6; mes++)
        {
            // Cálculo de intereses del mes
            intereses = capital * tasa;

            // Abono realizado cada mes
            abonos = 100 + (mes * 10);

            // Actualización del capital
            capital = capital + intereses - abonos;
        }
    }
}
