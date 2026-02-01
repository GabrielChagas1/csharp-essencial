Console.WriteLine("Data e hora struct");

DateTime now = DateTime.Now;

Console.WriteLine(now.Year);
Console.WriteLine(now.Month);
Console.WriteLine(now.Day);
Console.WriteLine(now.Hour);
Console.WriteLine(now.Second);
Console.WriteLine(now.Millisecond);

//adicionando valores
Console.WriteLine(now.AddDays(30));
Console.WriteLine(now.AddMonths(1));
Console.WriteLine(now.AddHours(2));
Console.WriteLine(now.AddYears(5));

//obter o dia da semana e do ano
Console.WriteLine(now.DayOfWeek);
Console.WriteLine(now.DayOfYear);

//data no formato curto e longo
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongDateString());



Console.ReadLine();