using _014_interfaces;

Console.WriteLine("Exercícios");

SalvarJson salvarJson = new();
SalvarXml salvarXml = new();

salvarXml.Salvar();
salvarXml.Nome();

salvarJson.Salvar();
salvarJson.Nome();

//precisa converter a interface para poder acessar métodos que estão definidos nela 
ISalvar salvar = new SalvarJson();
salvar.Compactar();


Console.ReadKey();
