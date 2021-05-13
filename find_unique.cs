using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Find_unique
    {
        public void _unique(int[] arr)
        {
            Console.WriteLine("Unique array elements: ");

            int[] uniquearray = new int[20];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int point = 0;

                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        point = 1;
                        break;
                    }
                }
                 
                if (point == 0)
                {
                    uniquearray[index] = arr[i];
                    index++;    
                }
            }
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(uniquearray[i] + " ");
            }
        }
    }
}
