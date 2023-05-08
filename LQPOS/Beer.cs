using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQPOS
{
    public class Beer
    {
        public string Name;
        public string Brand;
        public string Code;
        public float Cost;
        public float Price;
        public int Stock;
        public int Count;
        public int Size;

        public Beer(string name, string brand, string code, float cost, float price, int count, int size)
        {
            Name = name;
            Brand = brand;
            Code = code;
            Cost = cost;
            Price = price;
            Count = count;
            Size = size;
            Stock = 0;
        }

        public void AddStock(int count)
        {
            Stock += count;
        }
    }
}
