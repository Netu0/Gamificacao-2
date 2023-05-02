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

            FuncionarioUI funcionario = new FuncionarioUI();
            ClienteUI cliente = new ClienteUI();

            int menu;

            do{

                Console.WriteLine("/// Log In ///");
                Console.WriteLine("1 - Cliente");
                Console.WriteLine("2 - Funcionário");
                Console.WriteLine("0 - Sair");

                menu = Convert.ToInt32(Console.ReadLine());

                switch(menu){
                    case 1:
                        cliente.submenu();
                        break;
                    case 2:
                        funcionario.submenu();
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