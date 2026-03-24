namespace _014_interfaces
{
    public interface ISalvar
    {
        void Salvar();
        void Compactar() 
        {
            Console.WriteLine("Compactando arquivos");
        }
    }
}
