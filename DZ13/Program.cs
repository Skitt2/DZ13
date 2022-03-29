using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Журавлева 2", 10, 12, 6);
            Console.WriteLine(building.Print());
            Building multibuilding = new MultiBuilding("Ленина 2", 3, 4, 3, 1);
            Console.WriteLine(multibuilding.Print());
            Console.ReadKey();
        }
    }

}
