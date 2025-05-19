using System;
using System.Collections.Generic;

namespace ExemploFundamentos.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Nome: {Nome} | Email: {Email} | Telefone: {Telefone}";
        }
    }

    class Program
    {
        static List<Cliente> clientes = new List<Cliente>();

        static void Main(string[] args)
        {
            string opcao;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua opção:");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Buscar cliente");
                Console.WriteLine("3 - Apagar cliente");
                Console.WriteLine("4 - Encerrar");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastro de cliente");
                        CadastrarCliente();
                        break;

                    case "2":
                        Console.WriteLine("Busca de cliente");
                        BuscarCliente();
                        break;

                    case "3":
                        Console.WriteLine("Apagar cliente");
                        ApagarCliente();
                        break;

                    case "4":
                        Console.WriteLine("Encerrar");
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                if (exibirMenu)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("O programa se encerrou");
        }

        static void CadastrarCliente()
        {
            Console.WriteLine("\nDigite o nome do cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o email do cliente:");
            string email = Console.ReadLine();

            Console.WriteLine("Digite o telefone do cliente:");
            string telefone = Console.ReadLine();

            Cliente novoCliente = new Cliente(nome, email, telefone);
            clientes.Add(novoCliente);

            Console.WriteLine("\nCliente cadastrado com sucesso!");
        }

        static void BuscarCliente()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("\nNão há clientes cadastrados.");
                return;
            }

            Console.WriteLine("\nDigite o nome do cliente que deseja buscar:");
            string nomeBusca = Console.ReadLine();

            bool encontrado = false;
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Nome.ToLower().Contains(nomeBusca.ToLower()))
                {
                    Console.WriteLine(cliente);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("\nNenhum cliente encontrado com esse nome.");
            }
        }

        static void ApagarCliente()
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("\nNão há clientes cadastrados.");
                return;
            }

            Console.WriteLine("\nLista de clientes:");
            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {clientes[i].Nome}");
            }

            Console.WriteLine("\nDigite o número do cliente que deseja apagar:");
            if (int.TryParse(Console.ReadLine(), out int indice) && indice > 0 && indice <= clientes.Count)
            {
                string nomeCliente = clientes[indice - 1].Nome;
                clientes.RemoveAt(indice - 1);
                Console.WriteLine($"\nCliente {nomeCliente} removido com sucesso!");
            }
            else
            {
                Console.WriteLine("\nNúmero inválido!");
            }
        }
    }
}