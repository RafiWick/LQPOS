using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LQPOS
{
    public class Inventory
    {
        public List<Beer> Beers;
        public List<Wine> Wines;
        public List<Spirit> Spirits;
        public Inventory()
        {
            Beers = new List<Beer>();
            Wines = new List<Wine>();
            Spirits = new List<Spirit>();
        }

        public void AddStock(string code, int count)
        {
            foreach (Beer beer in Beers)
            {
                if (beer.Code == code)
                {
                    beer.AddStock(count);
                }
            }
            foreach (Wine wine in Wines)
            {
                if (wine.Code == code)
                {
                    wine.AddStock(count);
                }
            }
            foreach (Spirit spirit in Spirits)
            {
                if (spirit.Code == code)
                {
                    spirit.AddStock(count);
                }
            }
        }
    }
}
