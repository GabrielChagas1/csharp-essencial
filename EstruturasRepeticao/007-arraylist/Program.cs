using System.Collections;

Console.WriteLine("## ArrayList ##");

ArrayList list = [];

list.Add("Hello");
list.Add("World");

ArrayList list2 = [5];
list2.Add("RWARW");
list2.Capacity.ToString();

ArrayList list3 = [5, "RWARW", 3.14];

foreach (var item in list)
{
    Console.Write($"{item} ");
}

Console.WriteLine();


foreach (var item in list2)
{
    Console.Write($"{item} ");
}

Console.WriteLine();


foreach (var item in list3)
{
    Console.Write($"{item} ");
}

Console.WriteLine();

Console.ReadKey();