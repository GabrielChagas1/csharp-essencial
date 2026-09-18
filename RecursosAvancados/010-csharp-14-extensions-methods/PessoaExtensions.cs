namespace _010_csharp_14_extensions_methods
{
    public static class PessoaExtensions
    {
        extension(Pessoa pessoa)
        {
            public bool IsAdult() => pessoa.Idade >= 18;

            public string Describe() => $"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}";
        }

        extension(Pessoa)
        {
            public static Pessoa Default => new("Desconhecido", 0);
        }
    }
}
