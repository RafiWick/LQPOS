using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQPOS
{
    public class Wine
    {
        public string Name;
        public string Brand;
        public string Code;
        public float Cost;
        public float Price;
        public int Stock;
        public int Size;

        public Wine(string name, string brand, string code, float cost, float price, int size)
        {
            Name = name;
            Brand = brand;
            Code = code;
            Cost = cost;
            Price = price;
            Stock = 0;
            Size = size;
        }

        public void AddStock(int count)
        {
            Stock += count;
        }
    }
}
