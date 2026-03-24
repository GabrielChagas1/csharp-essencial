Console.WriteLine("Classes Abstratas");

Quadrado quadrado = new();

Console.Write("Informe a cor da figura: ");
quadrado.Cor = Console.ReadLine();

Console.Write("Informe o valor do lado do quadrado: ");
quadrado.Lado = Convert.ToInt32(Console.ReadLine());

quadrado.CalcularArea();
quadrado.CalcularPerimetro();

Console.WriteLine(quadrado.Descricao());

Console.ReadKey();
