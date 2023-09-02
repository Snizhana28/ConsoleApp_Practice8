using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Practice8.Domain
{
    public class Garage
    {
        public List<Car> Cars { get; set; }

        public int GarageNumber { get; set; }
        public Garage()
        { }

        public Garage(int garageNumber)
        {
            GarageNumber = garageNumber;
            Cars = new List<Car>();
        }
        public IEnumerator<Car> GetEnumerator()
        {
            return Cars.GetEnumerator();
        }
        public override string ToString()
        {
            return $"Garage number: {GarageNumber}";
        }
    }
}
