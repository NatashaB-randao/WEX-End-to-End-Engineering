using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        // Construtor
        public Aluno(string nome) : base(nome)  // Chama o construtor da classe base Pessoa
        {
            
        }


        public double Nota { get; set; }

        public override void Apresentar()           // Sobrescrevendo o método Apresentar da classe Pessoa
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}.");
        }
    }
}