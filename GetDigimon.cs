

public class GetDigimon
{
public static List<Digimon> HentDigimon()
{   
    var filsti = @"archive\DigiDB_digimonlist.csv";

    var alleDigimons = File.ReadAllLines(filsti)
        .Skip(1)
        .Select(line =>
         {
            var Kolloner = line.Split(",");
                return new Digimon
                {
                    Number = int.TryParse(Kolloner[0], out int n) ? n : null,
                    Name = Kolloner[1],
                    Stage = Kolloner[2],
                    Type = Kolloner[3],
                    Attribute = Kolloner[4]

                };
    })
    .ToList();

      return alleDigimons;
}
}