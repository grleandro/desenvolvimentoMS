using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using VendasConsole.Views.Listar;

namespace VendasConsole.DAL
{
    class VendasDAO
    {
        private static List<Venda> vendas = new List<Venda>();

        public static void CadastrarVenda(Venda venda) => vendas.Add(venda);
        public static List<Venda> Listar() => vendas;


    }
}
