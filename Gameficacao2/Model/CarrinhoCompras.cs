using System;
using System.Collections.Generic;

namespace CarrinhoCompras
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public abstract decimal CalcularPreco();
    }

    public class ProdutoComDesconto : Produto
    {
        public decimal Desconto { get; set; }

        public override decimal CalcularPreco()
        {
            return Preco * (1 - Desconto);
        }
    }

        public class CarrinhoDeCompras
        {
        private List<Produto> produtos = new List<Produto>();

        public List<Produto> Produtos
        {
            get { return produtos; }
        }

        public decimal Total
        {
            get
            {
                decimal total = 0m;
                foreach (var produto in produtos)
                {
                    total += produto.CalcularPreco();
                }
                return total;
            }
        }

    }
}