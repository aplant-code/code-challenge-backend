using System;
using System.Linq;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Output
{
    public class RaceOutputter
    {
        public static void OutputByHorsePrice(Race race)
        {
            Console.WriteLine($"=== Race: {race.Name} ===");
            var horses = race.Horses.OrderBy(h => h.Price);

            var number = 1;
            
            foreach (var horse in horses)
            {
                Console.WriteLine($"{number} {horse.Name, 0} ${horse.Price:f2}");
                number++;
            }
        }
    }
}