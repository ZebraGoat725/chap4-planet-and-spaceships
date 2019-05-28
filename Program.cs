using System;
using System.Collections.Generic;

namespace planet_and_spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){
                "Mercury", "Mars"
                };
            planetList.Add("Jupitar");
            planetList.Add("Saturn");
            
            // foreach(string planet in planetList) {
            //     Console.WriteLine(planet);
            // }

            List <string> lastTwo = new List <string> () {
                "Uranus", "Neptune"
            };

            planetList.AddRange(lastTwo);
            
            planetList.Insert(1, "Venus");

            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(2, 4);

            planetList.Remove("Pluto");

            foreach(string planet in planetList) {
                Console.WriteLine(planet);
            }
        }
    }
}
