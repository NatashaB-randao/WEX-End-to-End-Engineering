using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        // Construtor
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }


        // Propriedades
        public int NumeroConta { get; set; }


        // Atributo privado para o saldo
        // O saldo é privado para que não possa ser acessado diretamente de fora da classe
        private decimal saldo;



        // Método para sacar dinheiro da conta
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saldo realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }

        }
        
        // Método para exibir o saldo da conta
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo disponível é: {saldo}");
        }

    }
}