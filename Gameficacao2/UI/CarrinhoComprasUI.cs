using System;
using CarrinhoCompras;
using eRoupas.Model;

namespace eRoupas.UI
{
    class CarroUI
    {
        public void submenu()
        {
            
            List<ProdutoModel> produtos = new List<ProdutoModel>
            {
                new Camisa { Nome = "Camisa Azul", Preco = 50.00, Cor = "Azul", Tamanho = "M", Marca = "Marca A" },
                new Camisa { Nome = "Camisa Vermelha", Preco = 60.00, Cor = "Vermelho", Tamanho = "G", Marca = "Marca B" },
                new Calca { Nome = "Calça Jeans", Preco = 80.00, Cor = "Azul", Tamanho = "40", Marca = "Marca C" },
                new Vestido { Nome = "Vestido Preto", Preco = 100.00, Cor = "Preto", Tamanho = "P", Marca = "Marca D" }
            };

            CarrinhoComprar carrinho = new CarrinhoComprar(produtos);

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
                        carrinho.AdicionarAoCarrinho("Camisa Azul");
                        break;
                    case 2:
                        carrinho.MostrarCarrinho();
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
        
    }
}