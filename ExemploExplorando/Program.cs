using System;
using System.Globalization;
using ExemploExplorando.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    System.Console.WriteLine($"Id: {venda.Id}, " +
                             $"Produto: {venda.Produto}, " +
                             $"Preço: {venda.Preco}, "+
                             $"Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm:ss")}");
}















/*List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Mouse", 45.99M, DateTime.Now);
Venda v2 = new Venda(1, "Teclado", 67.99M, DateTime.Now);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);*/






















/*Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
estados.Add("PA", "Pará");
foreach (var item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados["SP"] = "SÃO PAULO";
estados.Remove("BA");
System.Console.WriteLine("--------------------");

foreach (var item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
// Verificando se a chave já existe
if (estados.ContainsKey(chave))
{
    System.Console.WriteLine($"Valor existente: {chave}");
}
else
{
    System.Console.WriteLine($"Valor não existe. É seguro adicionar a chave.");
}*/






/*Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

pilha.Pop();

pilha.Push(20);
foreach (int item in pilha)
{
    Console.WriteLine(item);
}*/












/*Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

fila.Dequeue();
fila.Enqueue(10);
foreach (int item in fila)
{
    Console.WriteLine(item);
}*/


// new ExemploExcecao().Metodo1();
















/*try
{
string[] linhas = File.ReadAllLines(@"..\Arquivos\arquivoLeitura.txt");
Console.WriteLine();
foreach(string linha in linhas)
{
    Console.WriteLine(linha);
}
Console.WriteLine();
}
catch (FileNotFoundException e)
{
    Console.WriteLine("Ocorreu um erro na leitura do arquivo. Arquivo não encontrado: " + e.Message);
}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine("Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado: " + e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu uma exceção genérica: " + e.Message);
}
finally
{
    Console.WriteLine("Chegou até aqui.");
}*/
























/*DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

DateTime data2 = DateTime.Parse("17/04/2022 18:00");
Console.WriteLine(data2);

string dataString = "2023-09-13 21:08";
bool sucesso = DateTime.TryParseExact(dataString, 
                       "yyyy-MM-dd HH:mm", 
                       CultureInfo.InvariantCulture, DateTimeStyles.None, 
                       out DateTime date0);

if (sucesso)
{
    System.Console.WriteLine($"Conversão com sucesso {date0}");
}
else
{
    System.Console.WriteLine($"{dataString} não é uma data válida");
}
System.Console.WriteLine(date0);*/







/*CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
decimal valorMonetario = 82.40M;

System.Console.WriteLine($"{valorMonetario:C}");
System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

double porcentagem = .3421;

System.Console.WriteLine(porcentagem.ToString("P2"));

int numero = 123456;
System.Console.WriteLine(numero.ToString("##-##-##"));*/















/*int numero1 = 10;
string numero2 = "20";

string resultado = numero1 + numero2;

Console.WriteLine(resultado);*/




















/*Pessoa p1 = new Pessoa("Jonas", "da Silva Rabelo");
Pessoa p2 = new Pessoa(nome: "Estefânia", sobrenome: "da Conceição de Souza Rabelo");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();*/