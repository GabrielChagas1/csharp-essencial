Console.WriteLine("Pattern Matching");

//var entregas = new Entrega[]
//{
//    new RetiradaNaLoja(),
//    new EntregaExpressa(15),
//    new EntregaExpressa(35),
//    new EntregaAgendada(DateTime.Today.AddDays(1)),
//    new EntregaAgendada(new DateTime(2025, 5, 25))
//};

//foreach(var entrega in entregas)
//{
//    var valor = CalcularFrete(entrega);
//    Console.WriteLine($"{entrega, -60} -> Frete: R$ {valor:N2}");
//}

//Console.ReadKey();

//static decimal CalcularFrete(Entrega entrega) =>
//    entrega switch
//    {
//        RetiradaNaLoja => 0m,
//        EntregaExpressa(var km) when km < 20 => 15m,
//        EntregaExpressa(var Km) => 25m + (decimal)(Km - 20) * 1.5m,
//        EntregaAgendada { DataAgendada: var data} when data.DayOfWeek == DayOfWeek.Sunday => 50m,
//        EntregaAgendada => 20m,
//        _ => throw new ArgumentException("Tipo de entrega desconhecido")
//    };

//public abstract record Entrega;
//public record RetiradaNaLoja() : Entrega;
//public record EntregaExpressa(double DistanciaKm) : Entrega;
//public record EntregaAgendada(DateTime DataAgendada) : Entrega 
//{
//    public override string ToString() => $"Entrega agendada para {DataAgendada:dddd, dd/MM/yyyy}";
//};



int getDiscount(Product p, Customer c)
{
    var discount = (p, c) switch
    {
        (_, Customer { IsNew: true }) or
        (Product { Availability: Availability.Medium }, _) => 5,
        (_, Customer { Age: >= 12 and <= 18 }) or 
        (Product { Availability: Availability.High}, _) => 10,
        (_, _) => 0
    };

    //if (c.IsNew || p.Availability >= Availability.Medium) discount = 5;

    //if(c.Age >= 12 && c.Age <= 18) discount = 10;

    ////pattern matching
    //if(c.Age is >= 12 and <=18 || p.Availability == Availability.High) discount = 10;

    return discount;
}


class Customer
{
    public bool IsNew { get; set; }
    public int Age { get; set; }
}

class Product
{
    public int Price { get; set; }
    public Availability Availability { get; set; }
}

enum Availability
{
    Low,
    Medium,
    High,
}