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
    }
}
