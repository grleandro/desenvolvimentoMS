using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views.Cadastrar
{
    class CadastrarProduto
    {
        public static void Renderizar()
        {
            Produto p = new Produto();
            Console.WriteLine(" ---- Cadastrar Produto ---- \n\n");

            Console.WriteLine("Insira o nome do produto: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("\nInsira o preço do produto: ");
            p.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInsira a quantidade do produto: ");
            p.Quantidade = Convert.ToInt32(Console.ReadLine());

            if (Validacao.ValidarNome(p.Nome))
            {
                if (ProdutoDAO.Cadastrar(p))
                {
                    Console.WriteLine("Produto cadastrado!");
                }
            }
            else
            {
                Console.WriteLine("Não foi possível cadastrar. Produto já existente!");
            }
        }
    }
}
