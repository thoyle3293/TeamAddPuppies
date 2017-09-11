using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CSDay01.Data
{
    public class PuppyOwner
    {
        public PuppyOwner() //constructor: giving object value or stuff
        {
            Puppy = new Puppy();
        }
        public Puppy Puppy { get; set; } //object composition; default for object is null
        public string OwnerName { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
    }
}