using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new Exception("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }


        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                if (value < 0)
                {
                    throw new Exception("A idade não pode ser negativa");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}