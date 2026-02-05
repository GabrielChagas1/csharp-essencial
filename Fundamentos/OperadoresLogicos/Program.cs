Console.WriteLine("## Operadores lógicos ##\n");

bool c1 = 5 >= 7;
bool c2 = 9 != 8;
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}\n");

// AND lógico
resultado = c1 && c2;
Console.WriteLine($"Operador And(&&): {resultado}");

// OR lógico
resultado = c1 || c2;
Console.WriteLine($"Operador Or(||): {resultado}");

// NOT lógico
resultado = !c1;
Console.WriteLine($"Operador Not(!) C1: {!c1}");
Console.WriteLine($"Operador Not(!) C2: {!c2}");


Console.ReadKey();