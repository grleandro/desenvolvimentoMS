using System;

namespace VendasConsole
{
    class Produto
    {
        //Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto()
        {
            CriadoEm = DateTime.Now;
        }
        //Atributos, propriedades e característica
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Quantidade { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | Preço: {Preco} | Quantidade: {Quantidade} | Criado em: {CriadoEm}\n\n";
        }
    }
}