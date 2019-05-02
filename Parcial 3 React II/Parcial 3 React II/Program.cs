using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial_3_React_II.Class;

namespace Parcial_3_React_II
{
    class Program
    {
        static void Main(string[] args)
        {
            pal[] arr = { new pal("larga"), new pal("trousers"), new pal("melon"), new pal("hey"), new pal("girl"), new pal("m"), new pal("word"), new pal("word") };



            SortGeneric.insertionSort(arr);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "\n ");
        }


            public class pal : IComparable
            {
            string pala;
            public pal(string pala)
            {
                this.pala = pala;
            }

            public int CompareTo(object obj)
            {
                if ((((pal)obj).pala.Length) - (pala.Length) < 0)
                {
                    return 1;
                }
                if ((((pal)obj).pala.Length) - (pala.Length) == 0)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            public override string ToString()
            {
                return pala;
            }
            }


    
            
    }
}





             
      
    

