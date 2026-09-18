using System.Threading;

Semaphore threadPool = new(3, 5);

Console.WriteLine("Threads Semáfores");

for (int i = 0; i < 10; i++)
{
    Thread threadObject = new(() => ProcessarOperacao(threadPool))
    {
        Name = $"Thread {i + 1}"
    };
    threadObject.Start();
}

Console.ReadLine();


static void ProcessarOperacao(Semaphore threadPool)
{
    threadPool.WaitOne(); // Aguarda até que haja uma vaga no semáforo
    Console.WriteLine($"{Thread.CurrentThread.Name} iniciando operação...");
    Thread.Sleep(2000); // Simula uma operação demorada
    threadPool.Release(); // Libera a vaga no semáforo para outra thread
    Console.WriteLine($"{Thread.CurrentThread.Name} finalizando operação...");
}