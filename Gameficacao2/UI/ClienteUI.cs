using System;

namespace eRoupas.Model
{
    class ClienteUI
    {
        private void submenu()
        {
            int menu;

            do{

                Console.WriteLine("/// Menu cliente ///");
                Console.WriteLine("1 - Exibir catálogo");
                Console.WriteLine("2 - Adicionar ao carrinho");
                Console.WriteLine("3 - Exibir carrinho");
                Console.WriteLine("4 - Finalizar compra");
                Console.WriteLine("0 - Log out");

                menu = Convert.ToInt32(Console.ReadLine());

                switch(menu){
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
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