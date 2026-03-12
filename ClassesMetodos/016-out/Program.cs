Console.WriteLine("## OUT ##");

Console.Write("Informe o raio do círculo: ");
double raio = double.Parse(Console.ReadLine());

Circulo circulo = new Circulo();


double circunferencia = circulo.CalculaArea(raio, out double area);


Console.WriteLine($"Área do círculo: {area}");
Console.WriteLine($"Perímetro do círculo: {circunferencia}");

Console.ReadKey();


public class Circulo
{
    //public double CalculaArea(double raio)
    //{
    //    return Math.PI * Math.Pow(raio, 2);
    //}

    //public double CalculaPerimetro(double raio)
    //{
    //    return 2 * Math.PI * raio;
    //}

    public double CalculaArea(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        return 2 * Math.PI * raio;
    }

}