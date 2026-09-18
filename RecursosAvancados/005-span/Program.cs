Console.WriteLine("## Span e ReadOnly Span ##");

string texto = "Gabriel Chagas";

ReadOnlySpan<char> nome = texto.AsSpan(0, 7);

Console.ReadKey();