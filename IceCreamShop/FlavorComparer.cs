using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            if (x.Allergens.Count == 0 || y.Allergens.Count == 0)
            {
                return 0;
            }
            return x.Allergens.Count.CompareTo(y.Allergens.Count);
        }
    }
}
