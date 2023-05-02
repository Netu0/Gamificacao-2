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

                Console.WriteLine("/// Menu Inicial ///");
                Console.WriteLine("1 - Log In");
                Console.WriteLine("0 - Sair");

                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 0)
                {
                    break;
                }

                Console.WriteLine("/// Log In ///");
                Console.WriteLine("Nome: ");
                string? nome = Console.ReadLine();
                Console.WriteLine("Senha: ");
                string? senha = Console.ReadLine();
                Console.WriteLine("Informe numero da conta ou cargo");
                string? NumeroConta = Console.ReadLine();

                Pessoa pessoa = new Cliente(nome, senha, 25112002);

                //Console.WriteLine("1 - continuar");
                //Console.WriteLine("0 - Sair");

                //menu = Convert.ToInt32(Console.ReadLine());

                if (pessoa.Autenticar("123") == true)
                {
                    menu = 1;
                }
                else
                {
                    menu = 2;
                }

                switch(menu){
                    case 1:
                        funcionario.submenu();
                        break;
                    case 2:
                        cliente.submenu();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }while(menu != 0);
        }
    }
}