using Microsoft.VisualBasic;

Console.WriteLine("Exercícios Fundamentos 02");

//1. Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato :  Aluno<nome> tem<idade> anos e nota<nota> usando a concatenação e a interpolação de strings
string nome = "Paulo";
int idade = 17;
decimal nota = 7.5m;

Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");
Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
Console.WriteLine("Aluno {0} tem {1} anos e nota {2}", nome, idade, nota);

//2.  Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes.
//Console.WriteLine($"{nome}\n{idade}\n{nota}\n");

//3. Para qual tipo de dados você pode converter um float implicitamente ?
//R: double e decimal

//4. Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
//R: ( X ) double para long, (X)double para float, ( X ) decimal para float, ( X ) long para int, ( X ) double para decimal

//5.  Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando a concatenação e também a interpolação de strings
//char letraA, letraB, letraC;
//Console.Write("Digite a primeira letra: ");
//letraA = Convert.ToChar(Console.ReadLine());
//Console.Write("Digite a segunda letra: ");
//letraB = Convert.ToChar(Console.ReadLine());
//Console.Write("Digite a terceira letra: ");
//letraC = Convert.ToChar(Console.ReadLine());

//Console.WriteLine($"As letras digitadas foram: {letraC}, {letraB}, {letraA}");
//Console.WriteLine("As letras digitadas foram: " + letraC + ", " + letraB + ", " + letraA);

//6. Marque verdadeiro(V) ou falso(F) para os códigos abaixo
//R: F, V, V, V, F, V, F, V, V, F

//7.Escreva um programa para receber dois valores via teclado do tipo double e a seguir realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo exibindo o resultado
//Console.Write("Informe o valor de X: ");
//double x = Convert.ToDouble(Console.ReadLine());

//Console.Write("Informe o valor de Y: ");
//double y = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"Soma de x + y = {x + y}");
//Console.WriteLine($"Subtração de x - y = {x - y}");
//Console.WriteLine($"Multiplicação de x * y = {x * y}");
//double divisao = (double)x / y;
//Console.WriteLine($"Divisão de x / y = {divisao}");
//Console.WriteLine($"Módulo de x % y = {x % y}");

//8.Faça um programa para calcular o resultado da fórmula de baskara dados os valores de a b e c 
//int a = 1, b = 2, c = -13;

//double delta = (Math.Pow(b, 2)) - (4 * a * c);

//double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
//double x2 = (-b - Math.Sqrt(delta)) / (2 * a); 

//Console.WriteLine($"O valor de x1 é: {x1}");
//Console.WriteLine($"O valor de x2 é: {x2}");
//Console.WriteLine($"O valor de delta é: {delta} ");

//9. Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e Senha é um inteiro
//Console.Write("Nome: ");
//string nome = Console.ReadLine();
//Console.Write("Senha: ");
//int senha = Convert.ToInt32(Console.ReadLine());
//string mensagem = (nome == "admin" || nome == "Maria") ? (senha.ToString() == "123" ? "Login Feito com sucesso" : "Senha incorreta") : "Login Inválido";
//Console.WriteLine(mensagem);

//10. Indique verdadeiro(V) ou falso (F) para as seguintes declarações
//V
//F
//F
//V
//F
//V
//F
//F
//V
//V

//11. Escreva um programa que recebe via teclado dois números inteiros x e y 
//Console.WriteLine("Digite o valor de x: ");
//int x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite o valor de y: ");
//int y = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(x % 2 == 0 ? "X é par" : "X não é par");
//Console.WriteLine(y % 2 == 0 ? "Y é par" : "Y não é par");

//12.Crie um programa que receba um numero inteiro x via teclado
//Console.Write("Digite o valor de x: ");
//int x = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(-6 + x * 5);
//Console.WriteLine((13-2) * x );
//Console.WriteLine((x + -2) * (20 / x));
//Console.WriteLine((12 + x) / (x - 4));
//Console.WriteLine(3 * Math.Pow(x, 2) + x + 10);
//Console.WriteLine(Math.PI * Math.Pow(x, 2));

//13.  Considere o seguinte trecho de código
//R: 5 + 6 + 7 = 18

//14. Escreva um programa que solicite a temperatura em graus Celsius
//Console.Write("Digite a temperatura em °C: ");
//double celsius = Convert.ToDouble(Console.ReadLine());

//double fahrenheit = (celsius * 9 / 5) + 32;
//double kelvin = celsius + 273.15;

//Console.WriteLine($"Fahrenheit: {fahrenheit}");
//Console.WriteLine($"Kelvin: {kelvin}");

//15. Escolha a opção que representa a  exibição do resultado para o código usando
//R: 5 - 2 - 2 - 2