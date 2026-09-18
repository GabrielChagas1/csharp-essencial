//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _003_ranges_indices
//{
//    internal class exercicios
//    {
//        //string[] dias =
//        //{
//        //    "Domingo",
//        //    "Segunda",
//        //    "Terça",
//        //    "Quarta",
//        //    "Quinta",
//        //    "Sexta",
//        //    "Sábado"
//        //};

//        //var ultimoDia = dias[^1];
//        //Console.WriteLine(ultimoDia);

//        //var penultimoDia = dias[^2];
//        //Console.WriteLine(penultimoDia);

//        //var quartaDia = dias[^4];
//        //Console.WriteLine(quartaDia);

//        //var primeiros3dias = dias[..3];
//        //Console.WriteLine("\nPrimeiro 3 dias");
//        //foreach (var dia in primeiros3dias)
//        //{
//        //    Console.WriteLine(dia);
//        //}

//        //var ultimos3Dias = dias[^3..];
//        //Console.WriteLine("\nÚltimos 3 dias");
//        //foreach (var dia in ultimos3Dias)
//        //{
//        //    Console.WriteLine(dia);
//        //}

//        //var todosExcetoUltimo = dias[..^1];
//        //Console.WriteLine("\nTodos os dias exceto o último");
//        //foreach (var dia in todosExcetoUltimo)
//        //{
//        //    Console.WriteLine(dia);
//        //}

//        //var todosExcectoOs2Ultimos = dias[..^2];
//        //Console.WriteLine("\nTodos os dias exceto os dois ultimos");
//        //foreach (var dia in todosExcectoOs2Ultimos)
//        //{
//        //    Console.WriteLine(dia);
//        //}

//        //var apenasMeio = dias[2..^2];
//        //Console.WriteLine("\nApenas o meio");
//        //foreach (var dia in apenasMeio)
//        //{
//        //    Console.WriteLine(dia);
//        //}

//        ////9) vai pegar os ultimos 3 dias
//        ////10) vai pegar os 3 primeiros dias
//        ////11) vai retornar vazio ??
//        ////12) quarta e quinta

//        ////var resultado = dias[^3..];
//        ////var resultado = dias[..^3];
//        //var resultado = dias[^5..^2];
//        ////var resultado = dias[2..^2];
//        //Console.WriteLine("\nCorreção");
//        //foreach (var dia in resultado)
//        //{
//        //    Console.WriteLine(dia);
//        //}

//        //string[] frutas =
//        //{
//        //    "Maçã",
//        //    "Banana",
//        //    "Laranja",
//        //    "Uva",
//        //    "Morango",
//        //    "Abacaxi",
//        //    "Manga",
//        //    "Melancia"
//        //};

//        //var teste = frutas[^1];
//        //var teste2 = frutas[^2..];
//        //var teste3 = frutas[..4];
//        //var teste4 = frutas[..^3];
//        //var teste5 = frutas[2..^3];
//        //var teste6 = frutas[3..^1];
//        //var teste7 = frutas[^3];

//        //Console.WriteLine("\n13");
//        //Console.WriteLine(teste);

//        //Console.WriteLine("\n14");
//        //ImprimirArray(teste2);

//        //Console.WriteLine("\n15");
//        //ImprimirArray(teste3);

//        //Console.WriteLine("\n16");
//        //ImprimirArray(teste4);

//        //Console.WriteLine("\n17");
//        //ImprimirArray(teste5);

//        //Console.WriteLine("\n18");
//        //ImprimirArray(teste6);

//        //Console.WriteLine("\n19");
//        //Console.WriteLine(teste7);

//        //var numeros = new[] { 10, 20, 30, 40, 50, 60, 70, 80 };

//        //var a = numeros[^1]; //80
//        //var b = numeros[^3]; //60
//        //var c = numeros[..3]; //10, 20, 30
//        //var d = numeros[^3..]; //60, 70, 80
//        //var e = numeros[..^3]; //10, 20, 30, 40, 50
//        //var f = numeros[2..6]; //30, 40,50, 60
//        //var g = numeros[^6..^2]; //60, 50, 40, 30

//        var nomes = new[]
//        {
//    "Ana",
//    "Bruno",
//    "Carlos",
//    "Daniel",
//    "Eduardo",
//    "Fernanda",
//    "Gabriel",
//    "Helena"
//};  

//        var teste1 = nomes[^1];
//        var teste2 = nomes[^3];
//        var teste3 = nomes[^5];
//        var teste4 = nomes[..3];
//        var teste5 = nomes[^3..];
//        var teste6 = nomes[..^2];
//        var teste7 = nomes[3..];
//        var resultado = nomes[2..^2];

//        Console.WriteLine("\n1");
//Console.WriteLine(teste1);

//Console.WriteLine("\n2");
//Console.WriteLine(teste2);

//Console.WriteLine("\n3");
//Console.WriteLine(teste3);

//Console.WriteLine("\n4");
//ImprimirArray(teste4);

//        Console.WriteLine("\n5");
//ImprimirArray(teste5);

//        Console.WriteLine("\n6");
//ImprimirArray(teste6);

//        Console.WriteLine("\n7");
//ImprimirArray(teste7);


//        Console.WriteLine("\nteste");
//ImprimirArray(resultado);

//        //inicio entra, fim não

//        //8) Carlos, Daniel, Eduardo, Fernanda
//        //9) Daniel, Eduardo, Fernanda, Gabriel, Helena
//        //10) Ana, Bruno, Carlos, Daniel
//        //11) Carlos, Daniel, Eduardo, Fernanda
//        //12) Carlos, Daniel, Eduardo, Fernanda

//        //13) 100
//        //14) 70
//        //15) 40, 50, 60, 70
//        //16) 60, 70, 80, 90, 100
//        //17) 10, 20, 30, 40, 50, 60
//        //18) 30, 40, 50, 60, 70
//        //19) 30, 40, 50, 60, 70, 80


//        //Desafio) 40,50, 60, 70
//    }
//}
