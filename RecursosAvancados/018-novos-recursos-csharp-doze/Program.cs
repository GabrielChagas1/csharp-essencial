using ListaDeItens = System.Collections.Generic.List<string>;

using Transacao = (decimal Valor, System.DateTime Data, TipoTransacao Tipo);
List<Transacao> transacoes = new()
{
    (100.0m, DateTime.Now, TipoTransacao.Credito),
    (50.0m, DateTime.Now, TipoTransacao.Debito),
    (200.0m, DateTime.Now, TipoTransacao.Credito)
};

Console.WriteLine("Lista de Transações: \n");
foreach (var transacao in transacoes)
{
    Console.WriteLine($"Valor: {transacao.Valor}, Data: {transacao.Data}, Tipo: {transacao.Tipo}");
}

//ListaDeItens lista = new()
//{
//    "item 1",
//    "item 2",
//    "item 3"
//};

//foreach (var item in lista)
//{
//    Console.WriteLine(item);
//}



Console.ReadKey();


public enum TipoTransacao
{
    Credito,
    Debito
}