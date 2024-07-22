using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicLandExplorer.Tasks
{
    public static class LongestDuration
    {
        public static void ShowLongestDuration(List<Category> categories)
        {
            var longestDurationDestination = categories
                 .SelectMany(c => c.Destinations)
                 .Where(d =>
                 {
                     if (string.IsNullOrEmpty(d.Duration)) return false;
                     return d.GetIntValue() > 0;
                 })
                 .OrderByDescending(d => d.GetIntValue())
                 .FirstOrDefault();

            if (longestDurationDestination != null)
            {
                Console.WriteLine("Longest duration destination:");
                Console.WriteLine($"{longestDurationDestination.Name}, {longestDurationDestination.Duration}");
            }
            else
            {
                Console.WriteLine("No destinations found with valid durations.");
            }
        }

    }
}

