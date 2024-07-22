using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class FilterDestinations
    {
        public static void ShowFilteredDestinations(List<Category> categories)
        {
            var filteredDestinations = categories
                .SelectMany(c => c.Destinations)
                .Where(d =>
                {
                    if (string.IsNullOrEmpty(d.Duration)) return false;
                    return d.GetIntValue() < 100;
                })
                .ToList();

            Console.WriteLine("\nFiltered destinations (less than 100 minutes):");
            foreach (var destination in filteredDestinations)
            {
                Console.WriteLine($"{destination.Name}, {destination.Duration}");
            }
            Console.WriteLine();
        }
    }
}

