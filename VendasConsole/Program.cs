using System;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c = new Cliente();
            do
            {
                Console.Clear();
                Console.WriteLine("---- APLICAÇÃO DE VENDAS ----\n");
                Console.WriteLine("1- Cadastrar cliente");
                Console.WriteLine("2- Listar cliente");
                Console.WriteLine("0- Sair");
                Console.WriteLine("\n Digite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine(" ---- CADASTRAR CLIENTE ---- ");
                        Console.WriteLine("Digite o nome do cliente: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();
                        Console.WriteLine($"Nome: { c.Nome} e CPF: { c.Cpf}");

                        break;
                    case 2:
                        Console.WriteLine(" ---- LISTAR CLIENTES ---- ");
                        break;
                    case 0:
                        Console.WriteLine("Saindo...\n");
                        break;
                    default:
                        Console.WriteLine(" ----- OPÇÃO INVÁLIDA!!! ---- \n");
                        break;
                }
                Console.WriteLine("\n Pressione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
