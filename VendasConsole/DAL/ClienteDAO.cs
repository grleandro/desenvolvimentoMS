using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole.DAL
{
    class ClienteDAO
    {
        private static List<Cliente> clientes = new List<Cliente>();

        public static List<Cliente> Listar() => clientes;

        public static bool Cadastrar (Cliente c)
        {
            if(BuscarCliente(c.Cpf) == null)
            {
                clientes.Add(c);
                return true;
            }
            return false;
        }

        public static Cliente BuscarCliente(String cpf)
        {
            foreach (Cliente clientesCadastrado in clientes)
            {
                if (clientesCadastrado.Cpf == cpf)
                {
                    return clientesCadastrado;
                }
            }
            return null;
        }
    }
}
