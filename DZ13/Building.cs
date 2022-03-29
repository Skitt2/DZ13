using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ13
{
    class Building
    {
        public string Adress { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Building(string adress, int length, int width, int height)
        {
            this.Adress = adress;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"Адрес {Adress} Длина {Length} Ширина {Width} Высота {Height}";
        }

    }
}
