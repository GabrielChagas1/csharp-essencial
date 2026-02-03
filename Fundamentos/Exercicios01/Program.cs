Console.WriteLine("Exercícios Fundamentos 01");

//1. Defina uma variável inteira chamada "idade" e atribua a ela o valor 35. Em seguida, imprima o valor da variável no console.
int idade = 35;
Console.WriteLine(idade);

//2. Crie uma variável chamada nome e  atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine(nome);

//3. Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura = 3.45;
Console.WriteLine(altura);

//4. Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.
DateTime data = new DateTime(1999, 9, 4);
Console.WriteLine(data);

//5. Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor;
const int ANO = 12;
Console.WriteLine(ANO);

//6. Crie uma variável chamada nota do tipo double e atribua a ela o valor 7.80 e exiba o seu valor.
double? nota = 7.80;
Console.WriteLine(nota);

//7. Quais as diferenças entre os tipos por valor e os tipos por referência 
//R: tipos por valor armazenam diretamento o valor na memória, tipos de referêncnia armazenam o endereço de memória onde o valor está armazenado.

//8. Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
//(int) x = 10;
//double numero = 7.99;
//char letra = 'C';
//float temperatura = 36.6f;
//bool ativo = true;
//string nome = "João";
//decimal salario = 950.50m;
//DateTime hoje = DateTime.Now;

//9.Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência(R)
//V
//R
//V
//V
//V
//V
//R

//10. O que é um nullable type e qual a sua utilidade em C#?
//R: Nullable type é um tipo que permite que uma variável de um tipo de valor possa armazenar um valor nulo. Útil para representar a ausência de valor.

//11. O que é Camel Case ? Dê um exemplo de sua aplicação
//R: Camel Case é uma convenção de nomenclatura onde a primeira letra da primeira palavra é minúscula e a primeira letra de cada palavra subsequente é maiúscula. Exemplo: minhaVariavelExemplo.

//12. O que é Pascal Case ? Dê um exemplo de sua aplicação
//R: Pascal Case é uma convenção de nomenclatura onde a primeira letra de cada palavra é maiúscula. Exemplo: MinhaClasseExemplo.

//13. Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a operação de soma
int x = 77, y = 66;
Console.WriteLine(x + y);

//14. Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string
//R: bool = false, char = '\0', int = 0, double = 0.0, float = 0.0f, decimal = 0.0m, string = null

//15. Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando a nomenclatura usada
//F
//F
//V
//F
//F
//F
//V
//V
//V
//V



Console.ReadLine();