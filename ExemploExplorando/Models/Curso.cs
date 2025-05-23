using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        // Propriedade Nome
        public string Nome { get; set; }

        // Propriedade Alunos   
        public List<Pessoa> Alunos { get; set; }

        // Método para adicionar um aluno
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        // Método para verificar a quantidade de alunos matriculados
        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        // Método para remover um aluno
        // Retorna true se o aluno foi removido com sucesso
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        // Método para listar os alunos
        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }

    }
}