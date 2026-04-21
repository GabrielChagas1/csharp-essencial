using System.Collections.ObjectModel;

Console.WriteLine("## ReadOnlyCollection ##");

var exoPlanetas = new ReadOnlyCollection<ExoPlaneta>(ExoPlaneta.GetExoPlanetas());

Console.ReadKey();

public class GerenciaExoPlanetas
{
    private List<ExoPlaneta> exoPlanetas = ExoPlaneta.GetExoPlanetas() ?? [];

    public ReadOnlyCollection<ExoPlaneta> ExoPlanetas
    {
        get { return exoPlanetas.AsReadOnly(); }
    }

    public void AdicionarPlaneta(ExoPlaneta planeta)
    {
        exoPlanetas.Add(planeta);
    }
}

public class ExoPlaneta(string? nome)
{
    public string? Nome { get; set; } = nome;   
    public static List<ExoPlaneta> GetExoPlanetas()
    {
        return new List<ExoPlaneta>()
        {
            new ExoPlaneta("Proxima Centauri b"),
            new ExoPlaneta("Kleper 186-f"),
            new ExoPlaneta("Gliesi 1061-c")
        };
    }
}
