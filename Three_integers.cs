using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Three_integers
    {
        public void searchmid() { 
        int[] findmid = new int[3];
            for(int i = 0; i< 3; i++)
            {
                Console.Write($" {i+1}-ое число = " );
                findmid[i] = int.Parse(Console.ReadLine());
            }
             Array.Sort(findmid);
            Console.Write($" mid integer is = {findmid[1]}" + "\n");
        }

    }
}
