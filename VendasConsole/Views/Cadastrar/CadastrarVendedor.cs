using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Utils;
using VendasConsole.Models;

namespace VendasConsole.Views.Cadastrar
{
    class CadastrarVendedor
    {
        public static void Renderizar()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine(" ---- CADASTRAR CLIENTE ---- ");
            Console.WriteLine("Digite o nome do vendedor: ");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do vendedor: ");
            v.Cpf = Console.ReadLine();

            if (Validacao.ValidarCpf(v.Cpf))
            {
                if (VendedorDAO.Cadastrar(v))
                {
                    Console.WriteLine("Vendedor cadastrado!");
                }
            }
            else
            {
                Console.WriteLine("Não foi possível cadastrar. Vendedor já existente!");
            }
        }
    }
}
