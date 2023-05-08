using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQPOS
{
    public class Beer
    {
        string Name;
        string Brand;
        float Cost;
        float Price;
        int Stock;

        public Beer(string name, string brand, float cost, float price)
        {
            Name = name;
            Brand = brand;
            Cost = cost;
            Price = price;
            Stock = 0;
        }
    }
}
