using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_3_React_II.Class
{
    class SortGeneric
    {
        public static void insertionSort<T>(T[] arr) where T : IComparable
        {
            for (int i = 1; i<arr.Length; i++)
            {
                int j;
                for (i = 1; i < arr.Length; i++)
                {
                    T key = arr[i];
                    j = i - 1;

                    while (j >= 0 && (arr[j].CompareTo(key) > 0))
                    {
                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = key;
                }
                }
        }
        

    }
}
