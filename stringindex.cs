using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stringindex
    {
        public void indexes(string original_str, string substring)
        {
            Console.WriteLine("Task9");
            int begin = original_str.IndexOf(substring) + 1;
            if (begin > 0)
                Console.WriteLine($"{begin} - {begin + substring.Length - 1}" + "\n");
            else
                Console.WriteLine("нет совпадений");
        }
       
    }
}
