using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MillerTrucking.Data.Entities
{
    public class Truck
    {
        public string Name { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public int MinWidth { get; set; }
        public int MaxWidth { get; set; }
        public int MinHeight { get; set; }
        public int MaxHeight { get; set; }
        public int MinWeight { get; set; }
        public int MaxWeight { get; set; }
    }
}
