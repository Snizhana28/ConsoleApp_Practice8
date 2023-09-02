using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice8.Domain
{
    public class Apartment : Person
    {
        Person person { get; set; }
        public int ApartmentNumber { get; set; }
        
        public Apartment() { }
        public Apartment(string firstName, string lastName, int apartmentNumber) : base(firstName, lastName)
        {
            ApartmentNumber = apartmentNumber;
        }        
        public override string ToString()
        {
            return $"Apartment {ApartmentNumber}, owner {FirstName} {LastName}";
        }   
    }
}
