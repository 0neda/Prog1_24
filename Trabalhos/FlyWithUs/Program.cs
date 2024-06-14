using System;
using FlyWithUs.Utils;

namespace FlyWithUs
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseAux.ConnectDatabase();

            bool isRunning = true;

            do {
                Console.WriteLine(PadAux.PadBoth("", 90, '='));
                Console.WriteLine(PadAux.PadBoth(" FlyWithUs - Menu Principal ", 90, '='));
                Console.WriteLine(PadAux.PadBoth("", 90, '='));
                Console.WriteLine($"{"=".PadRight(89)}=");

                Console.WriteLine($"{"= [1] AERONAVES ".PadRight(90, '=')}");
                Console.WriteLine($"{"= [2] VÔOS ".PadRight(90, '=')}");
                Console.WriteLine($"{"= [3] PASSAGENS ".PadRight(90, '=')}");
                Console.WriteLine($"{"= [0] SAIR ".PadRight(90, '=')}");
                
                int menuChoice = 0;


                try {
                    menuChoice = Convert.ToInt16(Console.ReadLine());
                    switch(menuChoice)
                    {
                        case 1:
                            Console.WriteLine("Aeronaves.");
                            break;
                        case 2:
                            Console.WriteLine("Vôos.");
                            break;
                        case 3:
                            Console.WriteLine("Passagens.");
                            break;
                        case 0:
                            isRunning = false;
                            Console.WriteLine("Sistema encerrado!");
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            isRunning = true;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Opção inválida");
                    isRunning = true;
                    menuChoice = -1;
                }

            } while (isRunning);      
        }
    }
}
