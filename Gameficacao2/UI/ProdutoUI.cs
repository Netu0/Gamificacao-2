using System;
using System.Collections.Generic;
using eRoupas.Model;

namespace eRoupas.UI
{
    class ProdutoUI
    {
        public void submenu()
        {

            int menu;

            do{

                Console.WriteLine("/// Produtos ///");
                Console.WriteLine("1 - Novo produto");
                Console.WriteLine("2 - Novo acessorio");
                Console.WriteLine("3 - Listar produtos");
                Console.WriteLine("0 - Log out");

                menu = Convert.ToInt32(Console.ReadLine());

                switch(menu){
                    case 1:
                        CadastrarProduto();
                        break;
                    case 2:
                        //CadastrarAcessorio();
                        break;
                    case 3:
                        ListarProduto();
                        break;
                    case 0:
                        Console.WriteLine("Retornando ...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }while(menu != 0);
        }
        private List<ProdutoModel> _produtos;
        public ProdutoUI(List<ProdutoModel> produtos)
        {
            _produtos = produtos;
        }
        private void CadastrarProduto()
        {
            Console.Clear();
            Console.WriteLine("Registro de produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            string preco = Console.ReadLine();
            Console.Write("Cor: ");
            string cor = Console.ReadLine();
            Console.Write("Tamanho: ");
            string tamanho = Console.ReadLine();
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            
            Console.WriteLine("Qual o tipo de produto?");
            Console.WriteLine("1 - Camisa");
            Console.WriteLine("2 - Calça");
            Console.WriteLine("3 - Vestido");

            int tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 1){
                _produtos.Add(new Camisa { Nome = nome, Preco = Convert.ToDouble(preco), Cor = cor, Tamanho = tamanho, Marca = marca });
            }
            else if (tipo == 2){
                _produtos.Add(new Calca { Nome = nome, Preco = Convert.ToDouble(preco), Cor = cor, Tamanho = tamanho, Marca = marca });
            }
            else if (tipo == 3){
                _produtos.Add(new Vestido { Nome = nome, Preco = Convert.ToDouble(preco), Cor = cor, Tamanho = tamanho, Marca = marca });
            }
            else{
                Console.WriteLine("Opção inválida");
            }

            Console.WriteLine();
        }

        private void ListarProduto()
        {
            Console.Clear();
            Console.WriteLine("Lista de categorias:");
            foreach (var produto in _produtos)
            {
                Console.WriteLine($"Nome: {produto.Nome} | Preco: {produto.Preco} ");
            }
        }
    }
}