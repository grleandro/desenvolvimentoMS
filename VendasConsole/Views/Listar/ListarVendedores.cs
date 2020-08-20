using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;

namespace VendasConsole.Views.Listar
{
    class ListarVendedores
    {
        public static void Renderizar()
        {
            Console.WriteLine("---------LISTAR VENDEDORES---------\n\n");
            foreach (Vendedor vendedorCadastrado in VendedorDAO.Listar())
            {
                Console.WriteLine(vendedorCadastrado);
            }
        }
    }
}
