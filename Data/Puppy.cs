using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSDay01.Data
{
    public enum PuppySize
    {
        Unknown = -1,
        Small = 2, 
        Medium = 4,
        Large = 6
    }

    public class Puppy
    {   
        public string Name { get; set; }
        public string Breed { get; set; }
        public PuppySize Weight { get; set; }
        public string Gender { get; set; }
        public string Where { get; set; }
        public bool HasChip { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public decimal Cost { get; set; }
    }
}
