using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.Models;

namespace VendasConsole
{
    class Venda
    {
        public Venda()
        {
            CriadoEm = DateTime.Now;
            Cliente = new Cliente();
            Vendedor = new Vendedor();
            Produto = new Produto();
        }
        public Cliente Cliente { get; set; }
        public DateTime CriadoEm { get; set; }
        public Vendedor Vendedor { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
