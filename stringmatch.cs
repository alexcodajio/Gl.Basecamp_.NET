using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Stringmatch
    {
        public void  findmatchinside (string str, string s)
        {
            string result = str.Split(new string[] { s }, 3, StringSplitOptions.None)[1];
            Console.WriteLine(result + "\n");
        }
    }
}
