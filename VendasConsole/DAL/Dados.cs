using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class Dados
    {
        public static void Inicializar()
        {
            Cliente cliente = new Cliente
            {
                Nome = "Pine",
                Cpf = "06457052924"
            };
            ClienteDAO.Cadastrar(cliente);
            Vendedor vendedor = new Vendedor
            {
                Nome = "Porco",
                Cpf = "06457052924"
            };
            VendedorDAO.Cadastrar(vendedor);
            Produto produto = new Produto
            {
                Nome = "Bolacha",
                Preco = 3.75,
                Quantidade = 150
            };
            ProdutoDAO.Cadastrar(produto);
        }
    }
}
