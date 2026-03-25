Console.WriteLine("Agrecação");

Professor prof1 = new("Carlos", "Química");
Professor prof2 = new("Maria", "Inglês");
Professor prof3 = new("Ana", "Literatura");
Professor prof4 = new("Paulo", "Matemática");

Departamento departamento = new("Exatas");
departamento.IncluirProfessor(prof1);
departamento.IncluirProfessor(prof4);

departamento.ListaProfessores();

Console.ReadKey();

class Professor(string nome, string disciplina)
{
    public string Nome { get; set; } = nome;
    public string? Disciplina { get; set; } = disciplina;
}

class Departamento(string? nome)
{
    public string? Nome { get; set; } = nome;
    private List<Professor> professores { get; set; } = [];

    public void IncluirProfessor(Professor professor)
    {
        professores.Add(professor);
    }

    public void ListaProfessores()
    {
        Console.WriteLine($"\nDepartamento de {Nome}");
        foreach(var professor in professores) Console.WriteLine(professor.Nome + " => " +professor.Disciplina);
    }

}
