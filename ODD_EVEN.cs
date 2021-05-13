using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Odd_Even
    {
        public void odd_even_check(int num) {
            if (num % 2 == 0)
            {
                Console.WriteLine($"Число{num} четное" + "\n");
            }
            else
            {
                Console.WriteLine($"Число {num} нечетное" + "\n");
            }
        }
        
    }
}
