using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice8.Domain
{
    public class Apartment
    {
        /*Створіть клас «Будинок», в якому має міститися інформація про квартири в цьому будинку. Створіть клас 
        «Квартира» з інформацією про мешканців квартир. Реалізуйте підтримку ітератора для класів «Будинок» і «Квартира». Протестуйте можливість використання foreach для 
        класів «Будинок» і «Квартира»*/
        public Dictionary<string, string> Persons { get; } = new Dictionary<string, string>();

        public Apartment()
        {
        }



        public void AddPerson(string name, string surname)
        {
            Persons.Add(name, surname);
        }
        public void ShowPersons()
        {
            foreach (var person in Persons)
            {
                Console.WriteLine(person);
            }
        }
        public override string ToString()
        {
            return $"Apartment with {Persons.Count} persons";
        }
        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return Persons.GetEnumerator();
        }
    }
}
