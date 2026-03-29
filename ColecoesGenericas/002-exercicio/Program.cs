Console.WriteLine("Exercício");

ClasseGenerica<int> objInt = new();
objInt.Adicionar(10);
objInt.Adicionar(20);
objInt.Adicionar(30);
objInt.Adicionar(40);
objInt.Adicionar(50);

ClasseGenerica<string> objString = new();
objString.Adicionar("Gabriel");


Console.WriteLine($"Classe Generica<T> de objetos int\n");
for (int i = 0; i < objInt.Length; i++)
{
    Console.WriteLine(objInt[i]);
}

Console.ReadKey();

public class ClasseGenerica<T>
{
    T[] obj = new T[5];
    int contador = 0;

    public int Length { get { return obj.Length; } private set { } }

    public void Adicionar(T item)
    {
        if(contador <  obj.Length)
        {
            obj[contador] = item;
        }
        contador++;
    }


    public T this[int index]
    {
        get { return obj[index]; }
        set { obj[index] = value; }
    }
}