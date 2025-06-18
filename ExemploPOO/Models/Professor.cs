using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()           // Sobrescrevendo o método Apresentar da classe Pessoa
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou professor com salário de {Salario:C}.");
        }
    }
}