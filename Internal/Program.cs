using ConsoleApp_Practice8.Domain;
namespace ConsoleApp_Practice8.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Garage> garages = new List<Garage>();

            Garage garage1 = new Garage(1);
            garage1.Cars.Add(new Car("BMW", "Black", 2010));
            garage1.Cars.Add(new Car("Audi", "White", 2015));
            garage1.Cars.Add(new Car("Mercedes", "Red", 2018));

            Garage garage2 = new Garage(2);
            garage2.Cars.Add(new Car("Toyota", "Black", 2010));
            garage2.Cars.Add(new Car("Mazda", "White", 2015));
            garage2.Cars.Add(new Car("Honda", "Red", 2018));

            garages.Add(garage1);
            garages.Add(garage2);

            foreach (Garage garage in garages)
            {
                Console.WriteLine(garage.ToString());
                foreach (Car car in garage)
                {
                    Console.WriteLine(car.ToString());
                }
            }
        }
    }
}