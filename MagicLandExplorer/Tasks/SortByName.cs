using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class SortByName
    {
        public static void ShowSortedDestinations(List<Category> categories)
        {
            var sortedDestinations = categories.SelectMany(c => c.Destinations)
                                        .OrderBy(n => n.Name)
                                        .ToList();

            Console.WriteLine("Destinations sorted by name:");
            foreach (var destination in sortedDestinations)
            {
                Console.WriteLine(destination.Name);
            }
        }
    }
}


