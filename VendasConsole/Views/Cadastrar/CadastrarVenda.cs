using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views.Cadastrar
{
    class CadastrarVenda
    {
        public static void Renderizar()
        {
            Venda venda = new Venda();
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();
            Produto pq = new Produto();
            ItemVenda iv = new ItemVenda();

            Console.WriteLine(" ---- CADASTRAR VENDA ---- ");
            Console.WriteLine("Insira o CPF do cliente: ");
            c.Cpf = Console.ReadLine();
            c = ClienteDAO.BuscarCliente(c.Cpf);

            if (c != null)
            {
                venda.Cliente = c;
            }
            else
            {
                Console.WriteLine("Cliente não econtrado!");
            }

            Console.WriteLine("Insira o CPF do vendedor: ");
            v.Cpf = Console.ReadLine();
            v = VendedorDAO.BuscarVendedor(v.Cpf);
            if (v != null)
            {
                venda.Vendedor = v;
            }
            else
            {
                Console.WriteLine("Vendedor não econtrado!");
            }

            do
            {
                iv = new ItemVenda();
                p = new Produto();
                Console.Clear();
                Console.WriteLine(" ---- ADICONAR PRODUTO ---- ");

                Console.WriteLine("Insira o nome do produto: ");
                p.Nome = Console.ReadLine();
                p = ProdutoDAO.BuscarProduto(p.Nome);

                if (p != null)
                {
                    iv.Produto = p;
                    Console.WriteLine("Insira a quantidade de produtos: ");
                    iv.Quantidade = Convert.ToInt32(Console.ReadLine());
                    iv.Preco = p.Preco;
                    venda.Itens.Add(iv);
                }
                else
                {
                    Console.WriteLine("Produto não econtrado!");
                }

                Console.WriteLine("\nDeseja adiconar mais produtos? (S/N)?");

            } while (Console.ReadLine().ToUpper().Equals("S"));

            //Cadastrar Venda
            VendasDAO.CadastrarVenda(venda);
            Console.WriteLine("Venda cadastrada com sucesso!!!");
        }
    }
}
