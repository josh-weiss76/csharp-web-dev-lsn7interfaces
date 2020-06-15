using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            if (x.Cost == 0 || y.Cost == 0)
            {
                return 0;
            }
            return x.Cost.CompareTo(y.Cost);
        }
    }
}
