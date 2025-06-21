using ExemploPOO.Interfaces;
using ExemploPOO.Models;







ICalculadora calculadora = new Calculadora();       // Instanciando a classe Calculadora
Console.WriteLine(calculadora.Somar(10, 20));      // Exibindo o resultado da soma de 10 e 20













// Computador c = new Computador(); // Instanciando a classe Computador
// Console.WriteLine(c.ToString());          // Exibindo o resultado do método ToString da classe Computador













// Pessoa p1 = new Pessoa("João");             // Instanciando a classe Pessoa com o nome "João"
// Aluno a1 = new Aluno("Maria");              // Instanciando a classe Aluno com o nome "Maria"
// Professor prof1 = new Professor("Carlos");  // Instanciando a classe Professor com o nome "Carlos"

// a1.Apresentar();                // Chamada do método Apresentar da classe Aluno
















// Conta c = new Corrente();       // Instanciando a classe Corrente que herda de Conta
// c.Creditar(1000);               // Chamando o método Creditar para adicionar 1000 ao saldo
// c.ExibirSaldo();                // Exibindo o saldo atual da conta corrente





















/*
Aluno a1 = new Aluno();
a1.Nome = "Ralph Fiennes";
a1.Idade = 60;
a1.Nota = 10;              // Atribuindo valor à propriedade Nota
a1.Apresentar();            // Chamada do método Apresentar


Professor p1 = new Professor();
p1.Nome = "Eduard";
p1.Idade = 30;
p1.Salario = 5000;         // Atribuindo valor à propriedade Salario
p1.Apresentar();            // Chamada do método Apresentar


*/











/*
// Instnaciar Conta Corrente -> Intanciar uma classe é criar um objeto a partir dela
ContaCorrente c1 = new ContaCorrente(12345, 1000);

c1.ExibirSaldo();       // Exibe o saldo inicial
c1.Sacar(500);          // Tenta sacar 500
c1.ExibirSaldo();       // Exibe o saldo após o saque

*/












/*
// Início do programa
// Criação de uma instância da classe Pessoa
Pessoa p1 = new Pessoa();           // Criação de um objeto do tipo Pessoa
p1.Nome = "João";                   // Atribuição de valor à propriedade Nome
p1.Idade = 30;                      // Atribuição de valor à propriedade Idade
p1.Apresentar();                    // Chamada do método Apresentar
*/