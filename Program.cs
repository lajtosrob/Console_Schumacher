using Console_Schumacher.DataSource;

namespace Console_Schumacher
{
    internal class Program
    {
        static List<Eredmeny> eredmenyek = new List<Eredmeny>();   
        static void Main(string[] args)

            // 2. feladat
        {
            StreamReader sr = new StreamReader(".\\DataSource\\schumacher.csv");

            sr.ReadLine();

            while(!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(";");

                Eredmeny adatsor = new Eredmeny(
                    line[0],
                    line[1],
                    int.Parse(line[2]),
                    int.Parse(line[3]),
                    int.Parse(line[4]),
                    line[5],
                    line[6]
                    ) ;

                eredmenyek.Add(adatsor);
            }

            sr.Close();

            // 3. feladat

            Console.WriteLine($"3. feladat: {eredmenyek.Count()}");

            // 4. feladat

            Console.WriteLine($"4. feadat: Magyar nagydíj helyezései: ");
            eredmenyek.Where(x => x.Grandprix == "Hungarian Grand Prix" && x.Status == "Finished").ToList().ForEach(x => Console.WriteLine($"{x.Date} : {x.Position}. hely"));

            // 5. feladat

            Dictionary<string, int> statisztika = eredmenyek.Where(x => x.Status != "Finished" && x.Status != "+1 Lap" && x.Status != "+2 Lap").GroupBy(x => x.Status).ToDictionary(x => x.Key, x => x.Count());

            Console.WriteLine("5. feladat");

            foreach (var item in statisztika)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}