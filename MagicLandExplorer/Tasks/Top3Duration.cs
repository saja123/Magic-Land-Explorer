using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class Top3Duration
    {
        public static void ShowTop3Durations(List<Category> categories)
        {
            var top3Durations = categories
               .SelectMany(c => c.Destinations)
               .Where(d =>
               {
                   if (string.IsNullOrEmpty(d.Duration)) return false;
                   return d.GetIntValue() > 0;
               })
               .OrderByDescending(d => d.GetIntValue())
               .Take(3)
               .ToList();
            Console.WriteLine("Top 3 longest durations:");
            foreach (var destination in top3Durations)
            {
                Console.WriteLine($"{destination.Name} - {destination.Duration} minutes");
            }
        }
    }
}


