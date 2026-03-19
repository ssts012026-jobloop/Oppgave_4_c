global using System;
global using System.Linq;
global using System.Collections.Generic;

namespace Program
{
    class Oppgave {
        public void Main()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine();

                string input = Console.ReadLine();

                switch (input)
                {
                    
                
                case 1:

                    break;

                case 2:
                    running = false;
                    break;

                default:
                    Stupidbaka();
                    break;
                }
            }
        }
        public static void Stupidbaka()
    {
        Console.WriteLine("You stupid baka sandwitch, come one v one me in Kansans city with that additude! You stupid baka!!");
        Console.WriteLine("You stupid baka, press a key");
        Console.ReadLine();
    }
    }
}