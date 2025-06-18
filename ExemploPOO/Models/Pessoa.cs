using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        // Propriedades
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Métodos
        public virtual void Apresentar()                    // Polimorfismo -> Método virtual que pode ser sobrescrito
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
        
    }
}