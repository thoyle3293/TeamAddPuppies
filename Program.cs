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
            // Console.WriteLine($"Name: {puppy.Name}\n Breed: {puppy.Breed}\n Weight: {puppy.Weight}");         
            // BuildWebHost(args).Run();

            var puppyOwner = new PuppyOwner
            {
                Puppy = puppy,
                OwnerName = "Scooby", 
                Location = "Mystery Machine", 
                PhoneNumber = "000-000-0000"
            };

            // Console.WriteLine($"Puppy: {puppyOwner.Puppy} \nLocation: {puppyOwner.Location}");
            var dragon = new Dragon
            {
                Color = "Rainbow",
                Element = "Fire AND Ice",
                Age = 1232,
                Wings = false
            };
            Console.WriteLine($"This is a {dragon.Age} year old Dragon. She breathes {dragon.Element}! She is a beatiful {dragon.Color} color.");
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
