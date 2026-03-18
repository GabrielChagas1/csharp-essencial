using System.Collections;

Console.WriteLine("## ArrayList ##");

ArrayList list2 = [5, 8, 1, 3, 2];


ArrayList list =
[
    "Maria",
    5,
    true,
    " ",
    null,
];

list.Add(3.5);
list.Insert(2, "Paulo");

int[] array = [1, 2, 3];

list.AddRange(array);
list.InsertRange(1, array);

//remove apenas a primeira ocorrência do item
list.Remove(null);

//remove o item do índice especificado
list.RemoveAt(0);

//remove uma quantidade de itens a partir do índice especificado
list.RemoveRange(0, 2);

//verificar se o item existe na lista
bool isConstains = list.Contains("Paulo");
Console.WriteLine(isConstains);

//Ordena a lista, mas só funciona se os itens forem do mesmo tipo e comparáveis
list2.Sort();

//Remove todos os itens da lista
list.Clear();


Console.ReadKey();