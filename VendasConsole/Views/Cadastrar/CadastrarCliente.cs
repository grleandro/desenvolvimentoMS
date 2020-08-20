using System;
using System.Collections.Generic;
using System.Text;
using VendasConsole.DAL;
using VendasConsole.Models;
using VendasConsole.Utils;

namespace VendasConsole.Views.Cadastrar
{
    class CadastrarCliente
    {
        public static void Renderizar()
        {
            Cliente c = new Cliente();
            Console.WriteLine(" ---- CADASTRAR CLIENTE ---- ");
            Console.WriteLine("Digite o nome do cliente: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente: ");
            c.Cpf = Console.ReadLine();

            if (Validacao.ValidarCpf(c.Cpf))
            {
                if (ClienteDAO.Cadastrar(c))
                {
                    Console.WriteLine("Cliente cadastrado!");
                }
            }
            else
            {
                Console.WriteLine("Não foi possível cadastrar. Cliente já existente!");
            }
        }
    }
}
