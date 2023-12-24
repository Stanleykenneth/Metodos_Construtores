using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos  { get; set; }

        public void Adicionaraluno(Pessoa aluno){
            
            Alunos.Add(aluno);
        }

        public int QuantidadeAlunosMatriculados(){

            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno){

           return Alunos.Remove(aluno);
        }
        
        public void ListarAlunos(){

            foreach(Pessoa aluno in Alunos){

                Console.WriteLine($"Os alunos são: {aluno.NomeCompleto}");
            }
        }
    }
}