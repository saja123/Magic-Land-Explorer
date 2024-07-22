using System;
using System.Collections.Generic;
using System.IO;
using MagicLandExplorer.Tasks;
using MagicLandExplorer;
using Newtonsoft.Json;

public class Program
{
    static void Main(string[] args)
    {
        var path = "../../../data/MagicLandData.json";
        try
        {
            var json = File.ReadAllText(path);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Show filtered destinations (less than 100 minutes)");
                Console.WriteLine("2 - Show longest duration destination");
                Console.WriteLine("3 - Sort destinations by name");
                Console.WriteLine("4 - Show top 3 longest durations");
                Console.WriteLine("5 - Exit");
                Console.Write("Enter your answer here: ");
                string choose = Console.ReadLine();
                switch (choose) 
                {
                    case "1":
                        FilterDestinations.ShowFilteredDestinations(categories);
                        break;
                    case "2":
                        LongestDuration.ShowLongestDuration(categories);
                        break;
                    case "3":
                        SortByName.ShowSortedDestinations(categories);
                        break;
                    case "4":
                        Top3Duration.ShowTop3Durations(categories);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalide option");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}


