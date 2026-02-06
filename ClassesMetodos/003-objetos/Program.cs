Console.WriteLine("## Objetos ##");

Cachorro bilu = new Cachorro
{
    nome = "Gabriel",
    cor = "marrom",
    sexo = "macho"
};

Cachorro pipoca = new Cachorro
{
    nome = "Pipoca",
    cor = "preto",
    sexo = "macho"
};



class Cachorro
{
    public string? nome;
    public string cor;
    public string? sexo;
    //public void Comer();
    //public void Respirar();
    //public void Latir();
}