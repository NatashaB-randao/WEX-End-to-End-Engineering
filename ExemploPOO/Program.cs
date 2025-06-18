using ExemploPOO.Models;


// Instnaciar Conta Corrente -> Intanciar uma classe é criar um objeto a partir dela
ContaCorrente c1 = new ContaCorrente(12345, 1000);

c1.ExibirSaldo();       // Exibe o saldo inicial
c1.Sacar(500);          // Tenta sacar 500
c1.ExibirSaldo();       // Exibe o saldo após o saque














/*
// Início do programa
// Criação de uma instância da classe Pessoa
Pessoa p1 = new Pessoa();           // Criação de um objeto do tipo Pessoa
p1.Nome = "João";                   // Atribuição de valor à propriedade Nome
p1.Idade = 30;                      // Atribuição de valor à propriedade Idade
p1.Apresentar();                    // Chamada do método Apresentar
*/