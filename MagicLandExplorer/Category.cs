using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using MagicLandExplorer.Tasks;

namespace MagicLandExplorer
{
    public class Category
    {
        public string CategoryName { get; set; }
        public List<Destination> Destinations { get; set; }
    }
}
