Console.WriteLine("Delegate Pré Definidos");

//predicate é um delegate que recebe um parâmetro e retorna um booleano

//action é um delegate que recebe um ou mais parâmetros e não retorna nada

//func é um delegate que recebe um ou mais parâmetros e retorna um valor

Console.Write("Informe um número inteiro: ");
int numero = int.Parse(Console.ReadLine()!);

Predicate<int> verificaPar = x => x % 2 == 0;

if(VerificaPar(numero)) Console.WriteLine("O número {numero} é PAR");
else Console.WriteLine($"O número {numero} é IMPAR");

Console.WriteLine($"O número {numero} é {(numero % 2 == 0 ? "PAR" : "IMPAR")}");

Console.ReadKey();

static bool VerificaPar(int numero)
{
    return numero % 2 == 0;
}

