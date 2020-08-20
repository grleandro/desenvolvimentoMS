using System;
using System.Collections.Generic;
using System.Text;

namespace VendasConsole.DAL
{
    class VendedorDAO
    {
        private static List<Vendedor> vendedores = new List<Vendedor>();
        public static List<Vendedor> Listar() => vendedores;
        public static bool Cadastrar(Vendedor v)
        {
            if (BuscarVendedor(v.Cpf) == null)
            {
                vendedores.Add(v);
                return true;
            }
            return false;
        }

        public static Vendedor BuscarVendedor(String cpf)
        {
            foreach (Vendedor vendedorCadastrado in vendedores)
            {
                if (vendedorCadastrado.Cpf == cpf)
                {
                    return vendedorCadastrado;
                }
            }
            return null;
        }

    }
}
