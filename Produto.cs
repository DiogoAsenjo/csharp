using System;

namespace PrimeiroProjeto
{
    class Produto
    {
        //PRIVATE SIGNIFICA QUE OS VALORES NÂO PODE SER ACESSADOS OU ALTERADOS
        private string _nome;
        public double Preco { get; private set; }
        public int QuantidadeEmEstoque { get; private set; }

        //CONSTRUTOR
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            QuantidadeEmEstoque = quantidade;
        }

        //PROPRIEDADES. FUNCIONA COMO UM GETTER E SETTER NO JAVA
        public string Nome
        {
            get { return _nome; }
            set 
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                } else 
                {
                    Console.WriteLine("Nome inválido");
                };
            }
        }
        
        
        //MÉTODOS
        public double ValorTotalEmEstoque()
        {
            return Preco * QuantidadeEmEstoque;
        }

        public void AdicionarProduto(int quantidade)
        {
            QuantidadeEmEstoque += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            QuantidadeEmEstoque -= quantidade;
        }

        public override string ToString()
        {
            return $"Nome: {_nome}, Preço: {Preco}";
        }

    }
}