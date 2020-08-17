using System;
using System.Collections.Generic;

namespace VendasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Cliente c = new Cliente();
            Vendedor v = new Vendedor();
            Produto p = new Produto();
            List<Cliente> clientes = new List<Cliente>();
            List<Vendedor> vendedores = new List<Vendedor>();
            List<Produto> produtos = new List<Produto>();

            do
            {
                Console.Clear();
                Console.WriteLine("\n ---- APLICAÇÃO DE VENDAS ----" +
                  "\n1 - Cadastrar Cliente" +
                  "\n2 - Listar Clientes" +
                  "\n3 - Cadastrar Vendedor" +
                  "\n4 - Listar Vendedores" +
                  "\n5 - Cadastrar Produto" +
                  "\n6 - Listar Produtos" +
                  "\n0 - Sair");
                Console.WriteLine("\n Digite a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        c = new Cliente();
                        Console.WriteLine(" ---- CADASTRAR CLIENTE ---- ");
                        Console.WriteLine("Digite o nome do cliente: ");
                        c.Nome = Console.ReadLine();
                        Console.WriteLine("Digite o CPF do cliente: ");
                        c.Cpf = Console.ReadLine();
                        if (ValidarCpf(c.Cpf))
                        {

                            if (clientes.Count == 0)
                            {
                                clientes.Add(c);
                                Console.WriteLine("Cliente salvo com sucesso!");
                            }
                            else
                            {
                                bool encontrado = false;
                                foreach (Cliente clientesCadastrado in clientes)
                                {
                                    if (clientesCadastrado.Cpf == c.Cpf)
                                    {
                                        encontrado = true;
                                    }

                                }
                                if (!encontrado)
                                {
                                    clientes.Add(c);
                                    Console.WriteLine("Cliente salvo com sucesso!");
                                }
                                else
                                {
                                    Console.WriteLine("CPF Já cadastrado!");
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível cadastrar!");
                        }
                        break;
                    case 2:
                        Console.WriteLine(" ---- LISTAR CLIENTES ---- ");
                        foreach (Cliente clienteCadastrado in clientes)
                        {
                            Console.WriteLine(clienteCadastrado);
                        }
                        break;
                    case 3:
                        v = new Vendedor();
                        Console.WriteLine(" ---- Cadastrar Vendedor ---- \n\n");

                        Console.WriteLine("Insira o nome do vendedor: ");
                        v.Nome = Console.ReadLine();
                        Console.WriteLine("\nInsira o CPF do vendedor: ");
                        v.Cpf = Console.ReadLine();

                        if (vendedores.Count == 0)
                        {
                            vendedores.Add(v);
                            Console.WriteLine("\n\n ---- Vendedor cadastrado com sucesso! ----\n\n");

                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Vendedor vendedorCadastrado in vendedores)
                            {
                                if (vendedorCadastrado.Cpf == v.Cpf)
                                {
                                    encontrado = true;
                                }

                            }
                            if (!encontrado)
                            {
                                vendedores.Add(v);
                                Console.WriteLine("\n\n ---- Vendedor cadastrado com sucesso! ----\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\n\nNão foi possível cadastrar!\n\n");
                            }

                        }
                        break;
                    case 4:

                        Console.WriteLine(" ---- Listar Vendedores ---- \n\n");
                        foreach (Vendedor vendedorCadastrado in vendedores)
                        {
                            Console.WriteLine(vendedorCadastrado);
                        }
                        break;
                    case 5:
                        p = new Produto();
                        Console.WriteLine(" ---- Cadastrar Produto ---- \n\n");

                        Console.WriteLine("Insira o nome do produto: ");
                        p.Nome = Console.ReadLine();
                        Console.WriteLine("\nInsira o preço do produto: ");
                        p.Preco = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nInsira a quantidade do produto: ");
                        p.Quantidade = Convert.ToInt32(Console.ReadLine());

                        if (produtos.Count == 0)
                        {
                            produtos.Add(p);
                            Console.WriteLine("\n\n ---- Produto cadastrado com sucesso! ----\n\n");

                        }
                        else
                        {
                            bool encontrado = false;
                            foreach (Produto produtoCadastrado in produtos)
                            {
                                if (produtoCadastrado.Nome == p.Nome)
                                {
                                    encontrado = true;
                                }

                            }
                            if (!encontrado)
                            {
                                produtos.Add(p);
                                Console.WriteLine("\n\n ---- Produto cadastrado com sucesso! ----\n\n");
                            }
                            else
                            {
                                Console.WriteLine("\n\nNão foi possível cadastrar!\n\n");
                            }

                        }
                        break;
                    case 6:

                        Console.WriteLine(" ---- Listar Produtos ---- \n\n");
                        foreach (Produto produtoCadastrado in produtos)
                        {
                            Console.WriteLine(produtoCadastrado);
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saindo...\n");
                        break;
                    default:
                        Console.WriteLine(" ----- OPÇÃO INVÁLIDA!!! ---- \n");
                        break;
                }
                Console.WriteLine("\n Pressione uma tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        private static bool ValidarCpf(string cpf)
        {
            int peso = 10, soma = 0, resto, digito1, digito2;
            if (cpf.Length != 11)
            {
                return false;
            }
            switch (cpf)
            {
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
                case "00000000000": return false;
            }
            //Digito 1.
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            resto = soma % 11;
            if (resto > 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[9].ToString()) != digito1)
            {
                return false;
            }
            //Digito 2.
            peso = 11;
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            resto = soma % 11;
            if (resto > 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }
            if (Convert.ToInt32(cpf[10].ToString()) != digito2)
            {
                return false;
            }

            return true;
        }
    }
}
