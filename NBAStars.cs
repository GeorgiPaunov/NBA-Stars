using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using Newtonsoft.Json;

namespace ReturnNBAStars
{
    class NBAStars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plese enter the path to the input file!");
            string inputFilePath = Console.ReadLine();

            Console.WriteLine("Please enter the maximum number of years played!");
            int maxYears = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the minimum player rating!");
            int minRating = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the path to the output file!");
            string outputFilePath = Console.ReadLine();

            string json = File.ReadAllText(inputFilePath);

            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(json);

            players = players
                .Where(p => p.Rating >= minRating)
                .Where(p => DateTime.Now.Year - p.PlayingSince <= maxYears)
                .OrderByDescending(p => p.Rating)
                .ToList();

            using(var textWriter = new StreamWriter(outputFilePath))
            {
                var writer = new CsvWriter(textWriter);
                writer.Configuration.Delimiter = ", ";

                foreach (var player in players)
                {
                    writer.WriteField(player.Name);
                    writer.WriteField(player.Rating);
                    writer.NextRecord();
                }
            }
        }
    }
}
