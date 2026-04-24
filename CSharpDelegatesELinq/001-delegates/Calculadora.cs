namespace _001_delegates
{
    public class Calculadora
    {
        public static float Somar(float a, float b)
        {
            return a + b;
        }

        public static float Subtrair(float a, float b)
        {
            return a - b;
        }

        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }

        public static float Dividir(float a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return a / b;
        }
    }
}
