using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CSDay01.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
// using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CSDay01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var puppy = new Puppy 
            {
                Name = "Max",
                Breed = "Mutt",
                Weight = PuppySize.Medium,
                Gender = "Guy",
                Where = "Breeder",
                HasChip = false,
                Age = 0,
                Height = 2.2,
                Cost = 5.99m,
            };
            Console.WriteLine($"Name: {puppy.Name}\n Breed: {puppy.Breed}\n Weight: {puppy.Weight}");         
            // BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
