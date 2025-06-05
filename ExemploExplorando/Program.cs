using System.Security.Cryptography.X509Certificates;
using ExemploExplorando.Models;
using System.Globalization;



// Obtém a data e hora atual
DateTime data = DateTime.Now; 

Console.WriteLine($"Data e hora atual: {data}");

// Exibir a data e hora atual sem os segundos
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));





















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// //Formatação personalizada
// decimal valorMonetario = 1582.40M;

// // Exibe o valor formatado como moeda
// Console.WriteLine(valorMonetario.ToString("C2"));

// // Representando porcentagem
// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));







// Alterando a localização da cultura
// decimal valorMonetario = 82.40M;

// // Exibe o valor formatado como moeda
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); 










// Formatando valores monetários
// decimal valorMonetario = 82.40M;

// Console.WriteLine($"{valorMonetario:C}");       // Exibe o valor formatado como moeda













// string numero1 = "10";
// string numero2 = "20";


// // Concatenação de strings
// string resultado = numero1 + numero2;  

// Console.WriteLine(resultado);  





























// Pessoa p1 = new Pessoa(nome: "Natasha",sobrenome: "Brandão");                       // Instanciação da classe Pessoa
// Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");                       // Instanciação da classe Pessoa


// Curso cursoDeIngles = new Curso();               // Instanciação da classe Curso
// cursoDeIngles.Nome = "Inglês";                   // Atribuição de valor à propriedade Nome
// cursoDeIngles.Alunos = new List<Pessoa>();       // Inicialização da lista de alunos

// cursoDeIngles.AdicionarAluno(p1);               // Adiciona o aluno p1 à lista de alunos
// cursoDeIngles.AdicionarAluno(p2);               // Adiciona o aluno p2 à lista de alunos
// cursoDeIngles.ListarAlunos();                   // Chama o método para listar os alunos







// Pessoa p1 = new Pessoa();               // Instanciação da classe Pessoa
// p1.Nome = "Natasha";                    // Atribuição de valor à propriedade Nome
// p1.Sobrenome = "Brandão";               // Atribuição de valor à propriedade Sobrenome
// p1.Idade = 26;                          // Atribuição de valor à propriedade Idade
// p1.Apresentar();                        // Chamada do método Apresentar
