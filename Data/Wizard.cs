using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSDay01.Data
{

    public class Wizard
    {   
        public Wizard() //constructor: giving object value or stuff
        {
            SpiritAnimal = new Dragon();
        }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Level { get; set; }
        public string Skills {get; set;}
        public int Age { get; set; }
        public Dragon SpiritAnimal { get; set;}
        public double Height { get; set; }
    }
}
