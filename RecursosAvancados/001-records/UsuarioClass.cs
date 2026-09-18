public class UsuarioClass
{
    public string Nome { get; set; } = "";
    public string Sobrenome { get; set; } = "";
    public int Idade { get; set; }
    public string Email { get; set; } = "";

    public override string ToString()
    {
        return $"Nome: {Nome}, Sobrenome: {Sobrenome}, Idade: {Idade}, Email: {Email}";
    }
}