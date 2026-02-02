Console.WriteLine("Saida de dados: Usando sequencia de escapes");

string local = "c:\\dados\\arquivos";

string frase = "Ele disse: \"Não fui eu\"";

string pizza = "\nPizza\nde\nCalabresa";

string bolo = "\nBolo\tde\tChocolate";

Console.WriteLine($"{local} {frase} {bolo} {pizza}");



Console.ReadLine();