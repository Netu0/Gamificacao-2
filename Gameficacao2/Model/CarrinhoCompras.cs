using System;
using System.Collections.Generic;
using eRoupas.Model;

namespace CarrinhoCompras
{
    public class CarrinhoComprar
{
    private List<ProdutoModel> _produtos;
    private List<ProdutoModel> _carrinho;

    public CarrinhoComprar(List<ProdutoModel> produtos)
    {
        _produtos = produtos;
        _carrinho = new List<ProdutoModel>();
    }

    public void AdicionarAoCarrinho(string nomeProduto)
    {
        ProdutoModel produto = _produtos.Find(p => p.Nome.Equals(nomeProduto, StringComparison.OrdinalIgnoreCase));

        if (produto != null)
        {
            ProdutoModel produtoCarrinho = new Camisa
            {
                Nome = produto.Nome,
                Preco = produto.Preco
            };

            _carrinho.Add(produtoCarrinho);
            Console.WriteLine($"O produto {produto.Nome} foi adicionado ao carrinho.");
        }
        else
        {
            Console.WriteLine($"O produto {nomeProduto} não foi encontrado.");
        }
    }

    public void MostrarCarrinho()
    {
        Console.WriteLine("Produtos no carrinho:");

        foreach (var produto in _carrinho)
        {
            Console.WriteLine($"Nome: {produto.Nome} | Preço: {produto.Preco}");
        }
    }
}

}