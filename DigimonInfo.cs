public class DigimonInfo
{
    // En liste med 10 fakta om Digimon
    private static List<string> faktaListe = new List<string>
    {
        "Digimon står for 'Digital Monsters'.",
        "Digimon bor i 'Digital World', en verden skapt av data fra jordens kommunikasjonsnettverk.",
        "I motsetning til Pokémon, kan Digimon snakke med menneskene sine.",
        "Digimon dør ikke permanent; de blir vanligvis reformatert til et 'Digitama' (egg) og født på nytt.",
        "Digivolution (utvikling) er vanligvis midlertidig; de går ofte tilbake til en mindre form etter en kamp.",
        "Den første Digimon-leken var faktisk en 'Digital Pet' (lik Tamagotchi) laget for gutter i 1997.",
        "Det finnes over 1400 forskjellige Digimon-arter i dag.",
        "Digimon er delt inn i typer som 'Data', 'Vaccine' og 'Virus'.",
        "Noen Digimon kan 'DNA-Digivolve', som betyr at to Digimon smelter sammen til én mektig skapning.",
        "De syv 'Great Demon Lords' er noen av de mektigste fiendene i Digimon-universet."
    };

    public static void VisTilfeldigFakta()
    {
        Random rnd = new Random();
        
        // Henter ut én tilfeldig indeks fra listen (0 til 9)
        int index = rnd.Next(faktaListe.Count);
        
        Console.WriteLine("\n--- VISSTE DU AT? ---");
        Console.WriteLine(faktaListe[index]);
        Console.WriteLine("----------------------\n");
    }
}