using System;

namespace VendasConsole
{
    class Vendedor
    {
        //Construtor
        public Vendedor(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }
        public Vendedor()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos, propriedades e característica
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}\n\n";
        }
    }
}