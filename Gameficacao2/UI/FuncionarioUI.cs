using System;

namespace eRoupas.Model
{
    class FuncionarioUI
    {
        private void submenu()
        {
            int menu;

            do{

                Console.WriteLine("/// Menu Funcioanrio ///");
                Console.WriteLine("1 - Registrar produto");
                Console.WriteLine("0 - Log out");

                menu = Convert.ToInt32(Console.ReadLine());

                switch(menu){
                    case 1:
                        
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