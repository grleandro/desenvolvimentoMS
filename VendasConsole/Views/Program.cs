using System;
using System.Collections.Generic;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Views.Cadastrar;
using VendasConsole.Views.Listar;

namespace VendasConsole.Views
{
    class Program
    {
        public static object ClienteDao { get; private set; }

        static void Main(string[] args)
        {
            Dados.Inicializar();
            int opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("\n ---- APLICAÇÃO DE VENDAS ----" +
                  "\n1 - Cadastrar Cliente" +
                  "\n2 - Listar Clientes" +
                  "\n3 - Cadastrar Vendedor" +
                  "\n4 - Listar Vendedores" +
                  "\n5 - Cadastrar Produto" +
                  "\n6 - Listar Produtos" +
                  "\n7 - Cadastrar Venda" +
                  "\n8 - Listar Vendas" +
                  "\n9 - Listar Vendas por Cliente" +
                  "\n0 - Sair");
                Console.WriteLine("\n Digite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        CadastrarCliente.Renderizar();
                        break;
                    case 2:
                        ListarClientes.Renderizar();
                        break;
                    case 3:
                        CadastrarVendedor.Renderizar();
                        break;
                    case 4:
                        ListarVendedores.Renderizar();
                        break;
                    case 5:
                        CadastrarProduto.Renderizar();
                        break;
                    case 6:
                        ListarProduto.Renderizar();
                        break;
                    case 7:
                        CadastrarVenda.Renderizar();
                        break;
                    case 8:
                        ListarVendas.Renderizar(VendasDAO.Listar());
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Digite o CPF do cliente: ");
                        string cpf = Console.ReadLine();
                        ListarVendas.Renderizar(VendasDAO.ListarPorCliente(cpf));
                        break;
                }
                Console.WriteLine("\n Pressione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
