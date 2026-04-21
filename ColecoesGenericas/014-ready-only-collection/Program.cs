using System.Collections.ObjectModel;

Console.WriteLine("## ReadOnlyCollection  ##");

List<string> planetas = ["Mercúrio", "Vênus", "Terra", "Marte"];

ReadOnlyCollection<string> listaPlanetas = new(planetas);

//ReadOnlyCollection<string> novaList = planetas.AsReadOnly();

Console.WriteLine("\nPlanetas não gasosos do sistema solar");
foreach(var planeta in planetas)
{
    Console.WriteLine($"{planeta} ");
}

Console.WriteLine($"\n\nPlanetas na coleção: {listaPlanetas.Count}");
Console.WriteLine(listaPlanetas.Contains("Júpiter") ? "Sim" : "Não");
Console.WriteLine($"\nPlaneta de índice 3: { listaPlanetas[3]}");
Console.WriteLine($"\nIndice do planeta Terra: {listaPlanetas.IndexOf("Terra")}");

Console.ReadKey();