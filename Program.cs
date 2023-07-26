// See https://aka.ms/new-console-template for more information
using Aula13ClassesPOO;

Console.WriteLine("Hello, World!");

Console.WriteLine("\n\n");


Pessoa LuisFelipe = new Pessoa("Luis", 18, "Rua grécia", "São Carlos");

Pessoa Isaque = new Pessoa("Isaque", 18, "Avenida São Carlos", "Londrina");

Pessoa William = new Pessoa("William", 18, "rua Bruno Ruggiero", "São Paulo");

Pessoa Nathan = new Pessoa("Nathan", 19, "Marginal Pinheiro", " São Paulo");



List<Pessoa> pessoas = new List<Pessoa>();

pessoas.Add(LuisFelipe);
pessoas.Add(Isaque);
pessoas.Add(William);
pessoas.Add(Nathan);


for (int i = 0;i < pessoas.Count; i++)
{

    pessoas[i].Mostra();

    //Console.WriteLine(pessoas[i].nome);


}





Console.ReadKey();






