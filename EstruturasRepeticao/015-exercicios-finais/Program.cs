using System.Collections;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Exercícios Finais");

//string[] frutas = ["Maçã", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"];

////a - Exibir frutas
//ExibirFrutas(frutas);

//ExibirFrutas([frutas[1], frutas[frutas.Length - 2]]);

//frutas[1] = "Kiwi";
//frutas[frutas.Length - 1] = "Caqui";
//ExibirFrutas(frutas);

//frutas = frutas.OrderBy(f => f).ToArray();
//ExibirFrutas(frutas);

//Console.ReadKey();

//static void ExibirFrutas(string[] frutas)
//{
//    Console.WriteLine("Frutas:");
//    foreach (string fruta in frutas)
//    {
//        Console.WriteLine(fruta);
//    }
//    Console.WriteLine();
//}

//bool sair = false;
//Console.Write("Qual o valor do array: ");
//int tamanho = int.Parse(Console.ReadLine()!);

//int[] numeros = new int[tamanho];

//for (int i = 0; i < numeros.Length; i++)
//{
//    Console.Write($"Digite o valor para a posição {i} do array: ");
//    numeros[i] = int.Parse(Console.ReadLine()!);
//}
//Console.WriteLine();

//do
//{
//    Console.Write("Digite um número para procurar ou 'fim' para sair:");
//    string input = Console.ReadLine()!;


//    if (int.TryParse(input, out int numeroProcurado))
//    {
//        int indice = Array.IndexOf(numeros, numeroProcurado);
//        if (indice != -1)
//        {
//            Console.WriteLine($"Número encontrado na posição {indice} do array.");
//        }
//        else
//        {
//            Console.WriteLine("Número não encontrado no array.");
//        }
//    }
//    else if (input.Equals("fim", StringComparison.OrdinalIgnoreCase))
//    {
//        Console.WriteLine("Encerrando o programa.");
//        sair = true;
//    }
//    else
//    {
//        Console.WriteLine("Entrada inválida. Por favor, digite um número ou 'fim'.");
//    }

//} 
//while (!sair);


//float[,] notas = new float[2, 5];

//int grupos = notas.GetLength(0);
//int alunosPorGrupo = notas.GetLength(1);

//for (int i = 0; i < grupos; i++)
//{
//    for (int j = 0; j < alunosPorGrupo; j++)
//    {
//        Console.Write($"Digite a nota do aluno {j + 1} para a disciplina {i + 1}: ");
//        notas[i, j] = float.Parse(Console.ReadLine()!);
//    }
//}

//for (int i = 0; i < grupos; i++)
//{
//    float soma = 0;
//    for (int j = 0; j < alunosPorGrupo; j++)
//    {
//        soma += notas[i, j];
//    }
//    float media = soma / alunosPorGrupo;
//    Console.WriteLine($"Média do grupo {i + 1}: {media}");
//}


//ArrayList pessoas = new();

//for (int i = 0; i < 3; i++)
//{
//    Console.Write($"Digite o nome da pessoa {i + 1}: ");
//    string nome = Console.ReadLine()!;
//    Console.Write($"Digite a idade da pessoa {i + 1}: ");
//    int idade = int.Parse(Console.ReadLine()!);
//    pessoas.Add(new Pessoa(nome, idade));
//}

//ExibirPessoas(pessoas);

//pessoas.AddRange(new[]
//{
//    new Pessoa("Jaime", 20),
//    new Pessoa("Tânia", 18)
//});

//pessoas.RemoveAt(pessoas.Count - 1);

//ExibirPessoas(pessoas);

//static void ExibirPessoas(ArrayList pessoas)
//{
//    foreach (Pessoa pessoa in pessoas)
//    {
//        pessoa.ExibirInformacoes();
//    }
//}

//public class Pessoa(string nome, int idade)
//{
//    public string Nome { get; set; } = nome;
//    public int Idade { get; set; } = idade;

//    public void ExibirInformacoes()
//    {
//        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
//    }
////}

//List<Produto> produtos = new()
//{
//    new("Clips", 3.95m),
//    new("Caneta", 5.99m),
//    new("Lápis", 4.15m),
//    new("Estojo", 6.99m),
//    new("Caderno", 7.55m)
//};

//ExibirProdutos(produtos);

//produtos.Add(new Produto("Mochila", 22.44m));
//ExibirProdutos(produtos);

//produtos = produtos.OrderBy(p => p.Nome).ToList();
//ExibirProdutos(produtos);

//List<Produto> produtosAbaixoDeCinco = produtos.FindAll(x => x.Preco < 5);
//ExibirProdutos(produtosAbaixoDeCinco);

//Produto? estojo = produtos.FirstOrDefault(x => x.Nome == "Estojo");
//if(estojo != null) ExibirProdutos([estojo]);

//static void ExibirProdutos(List<Produto> produtos)
//{
//    foreach (var produto in produtos)
//    {
//        Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco:C}");
//    }
//    decimal soma = produtos.Sum(x => x.Preco);
//    int quantidade = produtos.Count;
//    Console.WriteLine($"A soma dos produtos é: {soma}");
//    Console.WriteLine($"A quantidade de produtos da lista é: {quantidade}\n");
//}


//public class Produto(string nome, decimal preco)
//{
//    public string Nome { get; set; } = nome;
//    public decimal Preco { get; set; } = preco;
//}

//ProcessaObjetos(1, "Maria", 3.45m, new Random(), null);

//static void ProcessaObjetos(params object[] objetos)
//{
//    foreach (var obj in objetos)
//    {
//        if (obj == null)
//        {
//            Console.WriteLine("Valor nulo");
//            continue;
//        }
//        Console.WriteLine($"Tipo: {obj.GetType().Name}, Valor: {obj}");
//    }
//}

Aluno alunos = new Aluno();

alunos[0] = "Ana";
alunos[1] = "Carlos";
alunos[2] = "Maria";

Console.WriteLine(alunos[0]);
Console.WriteLine(alunos[1]);
Console.WriteLine(alunos[2]);

public class Aluno
{
    private string[] nomes = new string[10];

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= nomes.Length)
                throw new IndexOutOfRangeException();

            return nomes[index];
        }
        set
        {
            if (index < 0 || index >= nomes.Length)
                throw new IndexOutOfRangeException();

            nomes[index] = value;
        }
    }
}
