using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRoupas.Model;
using eRoupas.UI;
//falta dos a using enums

/*
namespace CarrinhoCompras
{
        public class CarrinhoCompras
    {
        
    public long CompraProdutoID { get; set; }
    public ProdutoModel? Produto { get; set; }
    public double Quantidade { get; set; }
    public double PrecoUnitario { get; set; }

    public double Subtotal
    {
        get { return Quantidade * PrecoUnitario; }
    }
        


        public List<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>();

        public List<Promocao> Promocoes { get; set; } = new List<Promocao>();

        public void addProduto(ProdutoModel produto)
        {
            Produtos.Add(produto);
        }

        public void exibirProduto()
        {
            foreach (var produto in Produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome} | Preco: {produto.Preco} ");
            }
        }

        public decimal valorTotal()
        {
            double valorTotal = Produtos.Sum(produto => produto.Preco);
            foreach (var promocao in Promocao)
            {
                if (promocao.desconto == desconto.%)
                {
                    valorTotal -= (promocao.desconto / 100 * valorTotal);
                }
                else
                {
                    valorTotal -= promocao.desconto;

                }
            }

            return valorTotal;

            public void AplicarPromocao(Promocao promocao)
            {
                Console.WriteLine("contador = ");
                foreach (var produto in Produtos)
                {

                    Console.WriteLine("entrou");
                    if (promocao.Produtos.Contains(produto))
                    {
                        Console.WriteLine("val desc=" + promocao.ValorDesconto);
                        produto.Desconto = promocao.ValorDesconto;
                    }
                }
            }


        }

    }
}
*/