using System;
using System.Linq;
using dotnet_code_challenge.Models;

namespace dotnet_code_challenge.Output
{
    public class RaceOutputter
    {
        private const int HORSE_START_NUMBER = 1;
        
        public static void OutputByHorsePrice(Race race)
        {
            Console.WriteLine($"=== {race.Name} ===");
            var horses = race.Horses.OrderBy(h => h.Price);

            var number = HORSE_START_NUMBER;
            
            foreach (var horse in horses)
            {
                Console.WriteLine($"{number} {horse.Name, 0} ${horse.Price:f2}");
                number++;
            }
            
            Console.WriteLine();
        }
    }
}