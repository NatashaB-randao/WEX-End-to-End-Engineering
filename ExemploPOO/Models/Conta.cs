using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        // Propriedades
        protected decimal saldo;


        // Métodos

        public abstract void Creditar(decimal valor);           // Método abstrato para creditar valor na conta

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo:C}");
        }
    }
}