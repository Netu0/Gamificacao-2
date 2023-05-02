/*using System;
using CarrinhoCompras;
using eRoupas.Model;

namespace Carrinho.UI
{

    class ClienteUI
    {
        public void submenu()
        {
            int menu;

            do
            {

                Console.WriteLine("/// Menu cliente ///");
                Console.WriteLine("1 - Adicionar produto no carrinho");
                Console.WriteLine("2 - Listar produtos no carrinho");
                Console.WriteLine("0 - Voltar");

                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        AdicionarProduto();
                        break;
                    case 2:
                        ListarProdutos();
                        break;

                    case 0:
                        Console.WriteLine("Retornando ...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (menu != 0);
        }
        public decimal Total
        {
            get
            {
                decimal total = 0m;
                foreach (var produto in Produtos)
                {
                    total += produto.CalcularPreco();
                }
                return total;
            }
        }

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void ListarProdutos()
        {
            Console.WriteLine("Produtos no carrinho:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"{produto.Nome}: R${produto.CalcularPreco()}");
            }
        }
    }
}*/