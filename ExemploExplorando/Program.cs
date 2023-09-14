using System;
using System.Globalization;
using ExemploExplorando.Models;

DateTime data = DateTime.Now;

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
System.Console.WriteLine(date0);







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