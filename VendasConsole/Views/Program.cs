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
                }
                Console.WriteLine("\n Pressione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
