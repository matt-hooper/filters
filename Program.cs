using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace filters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OlympicWinner> winners;

            using (StreamReader file = File.OpenText(@".\data\olympicWinnersSmall.json"))
            {
                winners = JsonConvert.DeserializeObject<List<OlympicWinner>>(file.ReadToEnd());
            }
            
            Console.WriteLine($"Winners count: {winners.Count}.");

            foreach (var winner in winners.FindAll(w => w.Athlete == "Chris Hoy"))
            {
                Console.WriteLine(winner.Details());
            };

        }
    }
}
