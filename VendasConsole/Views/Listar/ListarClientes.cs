using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;

namespace VendasConsole.Views.Listar
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine("---------LISTAR CLIENTES---------\n\n");
            foreach (Cliente clienteCadastrado in ClienteDAO.Listar())
            {
                Console.WriteLine(clienteCadastrado);
            }
        }

    }
}
