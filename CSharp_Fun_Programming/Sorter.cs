using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fun_Programming
{
    /**
     * Qualifying the type T in Generic Types
     * 
     * While making a sorting object, we can specify what criteria the T passed should
     * meet. Since we're sorting, we'd like to be able to compare values and know
     * which is greater than the other. The object passed should also be instantiable,
     * meaning we should be able to make an instance of it while swapping,
     * The object passed should also be a class
     * 
     * Examine the code below as the class object specifies in Syntax the criteria
     * requried for an object to be sorted by this Sorter
     * 
     * 
     * */
    public class Sorter<T> where T : class, IComparable<T>, new()
    {
        public void BeginSort(T[] items, string order="ascend")
        {
            if (items != null)
            {
                for (int i = 1; i < items.Length - 1; i++)
                {
                    T currentItem = items[i];
                    int j = i - 1;
                    while (j >= 0 && order == "ascend" ? currentItem.CompareTo(items[j]) > 0 : currentItem.CompareTo(items[j]) < 0)
                    {
                        GenericSwap(items, i, j);
                    }
                }
                Print(items, order == "ascend" ? "Ascending" : "Descending");
            }
            
        }

        static void GenericSwap(T[] items, int indexOne, int indexTwo)
        {
            (items[indexOne], items[indexTwo]) = (items[indexTwo], items[indexOne]);

        }

        static void Print(T[] items, string order="")
        {
            Console.WriteLine($"{order} Ordered List");
            for (int i = 0; i < items.Length - 1; i++)
            {
                Console.WriteLine($"Position {i} : {items[i]?.ToString()}");
            }
        }
    }
}
