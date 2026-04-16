Console.WriteLine("Hash Set");

HashSet<string> timesSP = ["Santos", "Palmeiras", "São Paulo"];

HashSet<string> timesRJ = ["Vasco", "Flamengo", "Fluminense"];

HashSet<string> timesBA = ["Bahia", "Vitória", "Juazeiro"];

HashSet<string> timesMundiais = ["São Paulo", "Santos", "Flamengo"];

if (timesSP.Contains("Corinthians")) timesSP.Add("Corinthians");

if (timesSP.IsSubsetOf(timesMundiais)) Console.WriteLine("TimesSP é um subconjunto de timesMundiais\n");

if (timesMundiais.IsSupersetOf(timesSP)) Console.WriteLine("TimesMundiaais é um super conjunto de timesSP\n");

if (timesRJ.Overlaps(timesMundiais)) Console.WriteLine("Pelo menos um time do RJ tem título mundial");

if (!timesSP.SetEquals(timesBA)) Console.WriteLine("\ntimesSP e timesRJ não contém os mesmos elementos");

Console.WriteLine("\nIntersecão de dois HashSet timesSp e timesMudiais");
timesSP.IntersectWith(timesMundiais);
ExibirColecao(timesSP);


Console.WriteLine("\nJuntando os HashSet<T>: SP, RJ e BA");
timesSP.UnionWith(timesRJ);
timesSP.UnionWith(timesBA);

ExibirColecao(timesSP);

Console.WriteLine("\nJuntando os times de SP, RJ e BA ordenados");
var todosTimes = new SortedSet<string>(timesSP);
ExibirColecao(todosTimes);

Console.WriteLine("\nDiferença de dois HashSet: timesSP e timesMundiais");
timesMundiais.ExceptWith(timesSP);
ExibirColecao(timesMundiais);

Console.WriteLine("\nDiferença de dois HashSet: timesSP e TimesMundiais com SymmetricException");
timesMundiais.SymmetricExceptWith(timesSP);
ExibirColecao(timesMundiais);

timesMundiais.Clear();

Console.ReadKey();

static void ExibirColecao<T>(IEnumerable<T> colecao)
{
    Console.WriteLine();
    foreach (var item in colecao) Console.WriteLine($"{item}");
}