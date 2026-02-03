Console.WriteLine("## Inferência Tipos (var) ##\n");

int idade = 30;
string nome = "João Silva";
decimal salario = 2500.75m;

var idadeVar = 30;
var nomeVar = "João Silva";
var salarioVar = 2500.75m;

//var limitações
//var salario = null; //erro: não é possível inferir o tipo
//var titulo; //erro: é necessário inicializar a variável para inferir o tipo
//var salario, imposto; //erro: não é possível declarar múltiplas variáveis com var na mesma linha

//var num = 10;
//num = num + 20;
//num = "Teste"; //erro: não é possível alterar o tipo inferido

var teste = new Teste();
teste.Metodo();

Console.WriteLine($"{nome} tem {idade} e ganha {salario.ToString("c")}");
Console.WriteLine($"{nomeVar} tem {idadeVar} e ganha {salarioVar.ToString("c")}");

Console.ReadKey();

class Teste {
    public void Metodo()
    {
        var mensagem = "Olá Mundo";
        Console.WriteLine(mensagem);
    }
}