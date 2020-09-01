using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views.Listar
{
    class ListarVendas
    {
        public static void Renderizar(List<Venda> vendas)
        {
            double totalGeral = 0, totalVendas = 0, totalItem = 0;
            Console.WriteLine("--------- LISTAR VENDAS ---------\n\n");
            foreach (Venda vendaCadastrado in vendas)
            {
                totalVendas = 0;
                Console.WriteLine($"Cliente : {vendaCadastrado.Cliente.Nome}");
                Console.WriteLine($"Vendedor : {vendaCadastrado.Vendedor.Nome}");
                Console.WriteLine("\n\n--------- ITENS VENDAS ---------\n\n");

                foreach (ItemVenda itemCadastrado in vendaCadastrado.Itens)
                {
                    Console.WriteLine($"\t Produto: {itemCadastrado.Produto.Nome}");
                    totalItem = itemCadastrado.Produto.Preco * itemCadastrado.Quantidade;
                    Console.WriteLine($"\t Preço: {itemCadastrado.Produto.Preco:C2} x {itemCadastrado.Quantidade} = {totalItem:C2}");
                    totalVendas += totalItem;
                }

                Console.WriteLine($"Total da venda: {totalVendas:C2}\n");
                totalGeral += totalVendas;

            }
            Console.WriteLine($"Total geral: {totalGeral:C2}");
        }
    }
}
