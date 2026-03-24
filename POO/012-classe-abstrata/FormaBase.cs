public abstract class FormaBase
{
    public string? Cor { get; set; }
    public double Area { get; set; }
    public double Perimetro { get; set; }

    public abstract void CalcularArea();
    public abstract void CalcularPerimetro();

    public string Descricao()
    {
        return $"Cor: {Cor}, Área: {Area}, Perímetro: {Perimetro}";
    }
}
