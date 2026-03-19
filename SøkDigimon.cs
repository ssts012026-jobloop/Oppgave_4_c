public class SøkDigimonService
{
    
public static void SøkDigimon(List<Digimon> alle)
{
        Console.WriteLine("Kva digimon leitar du etter? Du kan søke etter navn som Kuramon for eksempel");
        string input = Console.ReadLine();

        var resultat = alle
            .Where(d => d.Name.Equals(input, StringComparison.OrdinalIgnoreCase))
            .ToList();
        
        if (resultat.Count < 0)
        {
        foreach (var d in resultat)
        {
            Console.WriteLine($"{d.Name} -- {d.Stage} -- {d.Type} -- {d.Attribute}");
        }
        }
        else
        {
            Error.Stupidbaka();
        }
       
}
}