using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice8.Domain
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int YearOfIssue { get; set; }
        public Car(string model, string color, int yearOfIssue)
        {
            Model = model;
            Color = color;
            YearOfIssue = yearOfIssue;
        }
        public override string ToString()
        {
            return $"Model: {Model}, Color: {Color}, Year of issue: {YearOfIssue}";
        }
    }
}
