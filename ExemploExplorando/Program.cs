using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Jonas", "da Silva Rabelo");
Pessoa p2 = new Pessoa(nome: "Estefânia", sobrenome: "da Conceição de Souza Rabelo");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();