using System;
using eRoupas.Model;

namespace eRoupas.UI
{
    class ClienteUI
    {
        public void submenu()
        {

            CarroUI carro = new CarroUI();

            int menu;

            do{

                Console.WriteLine("/// Menu cliente ///");
                Console.WriteLine("1 - Carrinho de compras");
                Console.WriteLine("2 - Finalizar compra");
                Console.WriteLine("0 - Sair");

                menu = Convert.ToInt32(Console.ReadLine());

                switch(menu){
                    case 1:
                        carro.submenu();
                        break;
                    case 2:
                        
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