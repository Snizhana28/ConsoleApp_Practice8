using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice8.Domain
{
    public class House
    {
        public List<Apartment> Apartments { get; set; }
        public int HouseNumber { get; set; }
        public House()
        { }
        public House(int houseNumber)
        {
            Apartments = new List<Apartment>();
            HouseNumber = houseNumber;
        }
        public override string ToString()
        {
            return $"House with {Apartments.Count} apartments";
        }
        public IEnumerator<Apartment> GetEnumerator()
        {
            return Apartments.GetEnumerator();
        }
    }
}
