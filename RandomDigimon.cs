public class RandomDigimon
{
    public static void VisRandomDigimon(List<Digimon> alle)
    {
        Random rng = new Random();

        var tilfeldigDigimon = alle
            .OrderBy(x => rng.Next())
            .Take(10)
            .ToList();

    Console.WriteLine("--- 10 TILFELDIGE DIGIMONS ---");
    foreach (var d in tilfeldigDigimon)
    {
        Console.WriteLine($"{d.Name} -- {d.Stage} -- {d.Type} -- {d.Attribute}");
    }
    }
}