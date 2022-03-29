using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ13
{
    sealed class MultiBuilding : Building
    {
        public int Floor { get; set; }

        public MultiBuilding(string adress, int length, int width, int height, int floor)
            :base(adress, length, width, height)
        {
            this.Floor = floor;
        }

        public string Print()
        {
            string result = base.Print();
            result += $"{Floor}";
            return result;
        }
    }
}
