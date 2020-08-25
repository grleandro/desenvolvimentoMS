using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;

namespace VendasConsole.Views.Listar
{
    class ListarVendas
    {
        public static void Renderizar()
        {
            double totalGeral = 0, totalVendas = 0, totalItem = 0;
            Console.WriteLine("--------- LISTAR VENDAS ---------\n\n");
            foreach (Venda vendaCadastrado in VendasDAO.Listar())
            {
                Console.WriteLine($"Cliente : {vendaCadastrado.Cliente.Nome}");
                Console.WriteLine($"Vendedor : {vendaCadastrado.Vendedor.Nome}");
                Console.WriteLine("\n\n--------- ITENS VENDAS ---------\n\n");
                Console.WriteLine($"\t Produto: {vendaCadastrado.Produto.Nome}");
                totalItem = vendaCadastrado.Produto.Preco * vendaCadastrado.Quantidade;
                Console.WriteLine($"\t Preço: {vendaCadastrado.Produto.Preco:C2} x {vendaCadastrado.Quantidade} = {totalItem:C2}");
                totalVendas += totalItem;
                Console.WriteLine($"Total da venda: {totalVendas:C2}");
                totalGeral += totalVendas;
            }
            Console.WriteLine($"Total geral: {totalGeral:C2}");
        }
    }
}
