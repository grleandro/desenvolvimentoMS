using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;

namespace VendasConsole.Views.Listar
{
    class ListarProduto
    {
        public static void Renderizar()
        {
            Console.WriteLine("---------LISTAR PRODUTOS---------\n\n");
            foreach (Produto produtoCadastrado in ProdutoDAO.Listar())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}
