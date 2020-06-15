using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            for (int i = 0; i < availableFlavors.Count; i++)
            {
                Console.WriteLine(availableFlavors[i].Name);
            }
            Console.WriteLine();

            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);

            for (int i = 0; i < availableFlavors.Count; i++)
            {
                Console.WriteLine(availableFlavors[i]);
            }
            Console.WriteLine();

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            for (int i = 0; i < availableCones.Count; i++)
            {
                Console.WriteLine(availableCones[i].Name);
            }
            Console.WriteLine();

            ConeComparer comparer2 = new ConeComparer();
            availableCones.Sort(comparer2);
            
            for (int i = 0; i < availableCones.Count; i++)
            {
                Console.WriteLine(availableCones[i].Name + " Cost: " + availableCones[i].Cost);
            }
            Console.WriteLine();



            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
        }
    }
}
