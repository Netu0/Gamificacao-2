using System;
using System.Collections.Generic;
using eRoupas.Model;
using eRoupas.UI;

namespace eRoupas
{
    public class Program
    {
        static void Main(string[] args)
        {
            int menu;

            do{

                Console.WriteLine("/// Menu Principal ///");
                Console.WriteLine("1 - Adicionar ao carrinho");
                Console.WriteLine("2 - Carrinho de compras");
                Console.WriteLine("3 - Adicionar cupom");
                Console.WriteLine("4 - Pagamento");
                Console.WriteLine("0 - Sair");

                menu = Convert.ToInt32(Console.ReadLine());

                switch(menu){
                    case 1:
                        Console.WriteLine("/// Adicionar ao carrinho ///");
                        break;
                    case 2:
                        Console.WriteLine("/// Carrinho de compras ///");
                        break;
                    case 3:
                        Console.WriteLine("/// Adicionar cupom ///");
                        break;
                    case 4:
                        Console.WriteLine("/// Pagamento ///");
                        break;
                    case 0:
                        Console.WriteLine("/// Sair ///");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }while(menu != 0);
        }
    }
}