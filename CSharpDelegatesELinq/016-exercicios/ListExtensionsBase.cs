namespace _016_exercicios
{
    public static class ListExtensionsBase
    {
        public static int SomaPares(this List<int> numeros)
        {
            int soma = 0;
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                   soma += numero;
                }
            }
            return soma;
        }
    }
}
