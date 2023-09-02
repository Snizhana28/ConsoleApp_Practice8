using System;
using ConsoleApp_Practice8.Domain;
namespace ConsoleApp_Practice8.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<House> houses = new List<House>();
            House house_1 = new House(12);
            house_1.Apartments.Add(new Apartment("Snizhana", "Kostiuk", 1));
            house_1.Apartments.Add(new Apartment("Mriy", "Mykola", 2));
            houses.Add(house_1);

            foreach (var apartment in houses)
            {
                Console.WriteLine(apartment.ToString());
                foreach (var person in apartment)
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}