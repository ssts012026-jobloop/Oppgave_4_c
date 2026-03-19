global using System;
global using System.Linq;
global using System.Collections.Generic;
global using System.IO;

namespace Program
{
    public class Oppgave {
        public static void Main()
        {
            var alleDigimons = GetDigimon.HentDigimon();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Året er 2005");
                Console.WriteLine("Velkomen til den digitale verden!");
                Console.WriteLine("Trykk på knapper for å gå videre");
                Console.WriteLine("1. for å søke etter Digimons");
                Console.WriteLine("2. for å få 10 random digimons");
                Console.WriteLine("3. for å få random Digimon facts");
                Console.WriteLine("4. for å avslutte");

                string input = Console.ReadLine();

                switch (input)
                {
                
                case "1":
                    SøkDigimonService.SøkDigimon(alleDigimons);
                    Console.WriteLine("Trykk ein tast for å gå videre");
                    Console.ReadLine();
                    break;

                case "2":
                    RandomDigimon.VisRandomDigimon(alleDigimons);
                    Console.WriteLine("Trykk ein tast for å gå videre");
                    Console.ReadLine();
                    break;

                case "3":
                    DigimonInfo.VisTilfeldigFakta();
                    Console.WriteLine("Trykk ein tast for å gå videre");
                    Console.ReadLine();
                    break;

                case "4":
                    running = false;
                    break;


                default:
                    Error.Stupidbaka();
                    break;
                }
            }
        }

    }
}