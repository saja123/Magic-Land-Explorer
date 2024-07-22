using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using MagicLandExplorer.Tasks;

namespace MagicLandExplorer
{
    public class Destination
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }


        public int GetIntValue()
        {
            if (int.TryParse(Duration.Split(' ')[0], out var minutes)) return minutes;
            return 0;
        }

    }
}
