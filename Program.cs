using System;


namespace ConsoleApp1
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Task#1");
            First_a firsta = new First_a();
            firsta.GetInfo();
            First_b firstb = new First_b();
            firstb.GetInfo();
            Console.WriteLine(First_a.otl);
            stats stat = new stats();
            stat.GetInfo2();
            Console.WriteLine("Task#2");
            Odd_Even odeven = new Odd_Even();
            Console.WriteLine("Проверям на четность число 5");
            odeven.odd_even_check(5);
            Console.WriteLine("Task#3");
            Three_integers three = new Three_integers();
            three.searchmid();
            Console.WriteLine("Task4");
            Find_unique find = new Find_unique();
            int[] nums2 = new int[6] { 1, 2, 3, 5, 5, 1 };
            find._unique(nums2);
            Console.WriteLine("Task5");
            Matrix_transpose asd = new Matrix_transpose();
            asd.Matrixtransposed();

            Console.WriteLine("Task6");
            int value = 0;
            double c = 23.2342343;
            double stream = c.ToFixed(value);

            Console.WriteLine($"the number is {c}");
            Console.WriteLine($"fixed the {c} to the {value} digits after point is {stream}");

            Console.WriteLine("Task7");
            Math_calculations jjj = new Math_calculations();
            Console.WriteLine($"100 * tg(x) * √x / x =  {jjj.firsteq(1)}");
            Console.WriteLine($"2 * sin(x) - 4 =  {jjj.secondeq(1)}");
            
            Console.WriteLine("\n");
            Console.WriteLine("Task8");
            
            Stringmatch match = new Stringmatch();
            match.findmatchinside( "я-нехочу-делать-дз", "-");

            Console.WriteLine("Task9");

            Stringindex index = new Stringindex();
            index.indexes("Lorem ipsum dolor sit amet", "ipsum");
            Console.ReadLine();
        }
    }

    public static class IntExtension
    {
        public static double ToFixed(this double number, int precision)
        {
            double b = Math.Pow(10, precision);
            return (Math.Round(number * b) / b);
        }

    }
}

