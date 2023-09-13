using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno){
            Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            Console.Clear();
            Console.WriteLine($"Alunos do curso de {Nome}");
            
            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = "Nº " + (count + 1) + " " + Alunos[count].NomeCompleto;
                Console.WriteLine(texto);
            }
        }
    }
}