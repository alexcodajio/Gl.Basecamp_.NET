using System;

namespace ConsoleApp1
{
    class First_a
    {
        public static double otl = 10;
        public static double hor = 14;
        public static double tro = 4;
        public static double Asum(double a, double b, double c)
        {
            return otl + hor + tro;
        }

        public static double a_sum = Asum(otl, hor, tro);
        public static double devide(double a, double b, double c) 
        {
            var devidedpersent = (a / (a + b + c)) * 100;
            return Math.Round(devidedpersent, 2);
                }
        double otlpers = devide(First_a.otl, First_a.hor, First_a.tro);
        double horpers = devide(First_a.hor, First_a.otl, First_a.tro);
        double tropers = devide(First_a.tro, First_a.hor, First_a.otl);

        public void GetInfo()
        {
            Console.WriteLine($"В 1-А класса: {otl} отличников, {hor} хорошистов, {tro} - троечников");
            Console.WriteLine($"Всего в А классе {a_sum} человек");
            Console.WriteLine($"В 1-А классе {otlpers} процент отличников,{horpers} процент хорошистов,{tropers}процент троечников" );
        }

    }

    public class First_b
    {
        public static int otl = 12;
        public static int hor = 7;
        public static int tro = 8;
        public static int Bsum(int a, int b, int c)
        {
            return otl + hor + tro;
        }

        public static int b_sum = Bsum(otl, hor, tro);
        public static double devide(double a, double b, double c)
        {
            var devidedpersent = (a / (a + b + c)) * 100;
            return Math.Round(devidedpersent, 2);
        }
        double otlpers = devide(First_b.otl, First_b.hor, First_b.tro);
        double horpers = devide(First_b.hor, First_b.otl, First_b.tro);
        double tropers = devide(First_b.tro, First_b.hor, First_a.otl);
        public void GetInfo()
        {
            Console.WriteLine($"В 1-Б класса: {otl} отличников, {hor} хорошистов, {tro} - троечников");
            Console.WriteLine($"Всего в Б классе {b_sum} человек");
            Console.WriteLine($"В 1-Б классе {otlpers} процент отличников,{horpers} процент хорошистов,{tropers}процент троечников");
        }

        public static int Asum(int a, int b)
        {
            return a + b;
        }

    }
    public class stats
    {
        int total = (int)First_a.a_sum + (int)First_b.b_sum;
        double otlsum = First_a.otl + First_b.otl;
        double horsum = First_a.hor + First_b.hor;
        double trosum = First_a.tro + First_b.tro;
        public void GetInfo2()
        {
            Console.WriteLine($"Всего на паралели {total} человек");
            Console.WriteLine($"Из которых {otlsum}отличников,{horsum} хорошистов, {trosum} троечников ");
            Console.WriteLine($"Всего  на паралели {(otlsum/total)*100} %-ов отличников,{Math.Round((horsum/total)*100,2)}  %-ов хорошистов, {Math.Round((trosum / total) * 100, 2)} %-ов троечников ");
        }
    }
}

