Console.WriteLine("## List ##");

List<string> list = ["Maria", "João", "Paulo"];

list.Add("Ana");
list.Insert(1, "Carlos");

string[] array = ["Maysa", "Marcorrati"];
list.AddRange(array);
list.InsertRange(2, ["Calleri", "Juvenal"]);

ExibirLista(list);

list.Remove("João");
list.RemoveAt(0);
list.RemoveRange(0, 2);

Console.WriteLine(list[0]);
list[0] = "Maria Clara";
Console.WriteLine(list[0]);

Console.WriteLine(list.Contains("Paulo"));

list.Sort();

ExibirLista(list);

list.Clear();
ExibirLista(list);

static void ExibirLista(List<string> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}