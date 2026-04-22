Console.WriteLine("## Exercícios ##");

//public class Generic<T>
//{
//    public T Campo;
//    public void TesteSub()
//    {
//        T i = Campo + 1;
//    }
//}
//class MeuPrograma
//{
//    static void Main(string[] args)
//    {
//        Generic<int> gen = new Generic<int>();
//        gen.TesteSub();
//    }
//}

//Teste teste = new Teste();
//teste.MetodoTeste<string>("Usando Generics -> ");
//teste.MetodoTeste<float>(4.2f);
//Console.ReadKey();
//public class Teste
//{
//    public void MetodoTeste<T>(T arg)
//    {
//        Console.Write(arg);
//    }
//}

//Generic<String> g = new();
//g.Campo = "Exercício Generics";
//Console.WriteLine(g.Campo);
//Console.ReadKey();
//public class Generic<T>
//{
//    public T? Campo;
//}

//List<Aluno> listaAlunos = new List<Aluno>();

//listaAlunos.Add(new Aluno("João", 22, 'M'));
//listaAlunos.Add(new Aluno("Maria", 21, 'F'));
//listaAlunos.Add(new Aluno("Pedro", 23, 'M'));
//listaAlunos.Add(new Aluno("Ana", 20, 'F'));
//listaAlunos.Add(new Aluno("Lucas", 24, 'M'));

//Console.WriteLine("Lista de Alunos:\n");

//foreach (Aluno aluno in listaAlunos)
//{
//    Console.WriteLine($"Nome: {aluno.Nome} Idade: {aluno.Idade} Sexo: {aluno.Sexo}");
//}

//Console.ReadKey();
//public class Aluno
//{
//    public string Nome { get; set; }
//    public int Idade { get; set; }
//    public char Sexo { get; set; }

//    public Aluno(string nome, int idade, char sexo)
//    {
//        Nome = nome;
//        Idade = idade;
//        Sexo = sexo;
//    }
//}

//string expression = "(1 + 2) * 3) - 4";

//bool balenceada = EstaBalanceada(expression);

//Console.WriteLine($"A expressão matemática {expression} é {(balenceada ?
//                   "esta balanceada" : "não esta balanceada")}.");

//static bool EstaBalanceada(string expression)
//{
//    var pares = new Dictionary<char, char>
//    {
//        { ')', '(' },
//        { '}', '{' },
//        { ']', '[' }
//    };

//    Stack<char> stack = new();

//    foreach (char c in expression)
//    {
//        if (pares.ContainsKey(c))
//        {
//            if (stack.Count == 0 || stack.Pop() != pares[c]) return false;
//        }

//        if (pares.ContainsValue(c)) 
//        {
//            stack.Push(c);
//        }
//    }
//    return stack.Count == 0;
//}

//Queue<string> printQueue = new Queue<string>();
//printQueue.Enqueue("Arquivo1.pdf");
//printQueue.Enqueue("Arquivo2.docx");
//printQueue.Enqueue("Arquivo3.ppt");

//while (printQueue.Count > 0)
//{
//    string file = printQueue.Dequeue();
//    Console.WriteLine($"\nO arquivo \"{file}\" está sendo impresso...");
//    Thread.Sleep(new Random().Next(1000, 5000));
//    Console.WriteLine($"O arquivo \"{file}\" foi impresso com sucesso.");
//}

int[] intArray = { 1, 2, 3, 4, 5 };
string[] stringArray = { "Lucas", "Rafael", "Larissa", "João" };
double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };
Console.WriteLine("-Array de Inteiros:");
Exemplo.ReverterEImprimir<int>(intArray);
Exemplo.ReverterEImprimir(intArray);
Console.WriteLine("\n -Array de Strings:");
Exemplo.ReverterEImprimir<string>(stringArray);
Exemplo.ReverterEImprimir(stringArray);
Console.WriteLine("\n-Array de Doubles:");
Exemplo.ReverterEImprimir<double>(doubleArray);
Exemplo.ReverterEImprimir(doubleArray);
Console.ReadKey();
class Exemplo
{
    public static void ReverterEImprimir<T>(T[] array)
    {
        Array.Reverse(array);
        Console.WriteLine("Array Revertido:");
        foreach (T item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

}