using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQPOS
{
    public class Spirit
    {
        public string Name;
        public string Brand;
        public string Code;
        public float Cost;
        public float Price;
        public int Size;
        public int Stock;

        public Spirit(string name, string brand, string code, float cost, float price, int size)
        {
            Name = name;
            Brand = brand;
            Code = code;
            Cost = cost;
            Price = price;
            Size = size;
            Stock = 0;
        }
    }
}
