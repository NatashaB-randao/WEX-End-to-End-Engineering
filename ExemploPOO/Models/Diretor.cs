using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nome) : base(nome)
        {
        }

        public override void Apresentar()           // Sobrescrevendo o método Apresentar da classe Pessoa
        {
            Console.WriteLine("Diretor");
        }
    }
}