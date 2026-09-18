using _001_records;

Console.WriteLine("## Records ##");

var usuario = new UsuarioClass 
{
    Nome = "João",
    Sobrenome = "Silva",
    Idade = 30,
    Email = "testes@teste.com"
};

var usuarioRecord = new UsuarioRecord("João", "testes@teste.com", 30);
Console.WriteLine($"Usuario original: {usuario}");


var usuarioRecordCopia = usuarioRecord with { Email = "joao@teste.com" };
Console.WriteLine($"\nUsuario cópia: {usuarioRecordCopia}");

Console.WriteLine("\nApós alteração:");
Console.WriteLine($"\nUsuario original: {usuario}");

Console.ReadKey();