using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice8.Domain
{
    public class House
    {
        /*Створіть клас «Будинок», в якому має міститися інформація про квартири в цьому будинку. Створіть клас 
        «Квартира» з інформацією про мешканців квартир. Реалізуйте підтримку ітератора для класів «Будинок» і «Квартира». Протестуйте можливість використання foreach для 
        класів «Будинок» і «Квартира»*/
        public List<Apartment> Apartments { get; set; }
        public House()
        {
            Apartments = new List<Apartment>();
        }
        /*public void AddApartment(Apartment apartment)
        {
            Apartments.Add(apartment);
        }
        public void RemoveApartment(Apartment apartment)
        {
            Apartments.Remove(apartment);
        }*/
        public void ShowApartments()
        {
            foreach (var apartment in Apartments)
            {
                Console.WriteLine(apartment);
            }
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
