using System;
using System.Collections.Generic;
using eRoupas.Model;
using eRoupas.UI;

namespace eRoupas.Model
{
    class FuncionarioUI
    {
        public void submenu()
        {

            List<ProdutoModel> produtos = new List<ProdutoModel>();
            ProdutoUI produto = new ProdutoUI(produtos);

            int menu;

            do{

                Console.WriteLine("/// Menu Funcionario ///");
                Console.WriteLine("1 - Registrar produto");
                Console.WriteLine("0 - Log out");

                menu = Convert.ToInt32(Console.ReadLine());

                switch(menu){
                    case 1:
                        produto.submenu();
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
    }
}