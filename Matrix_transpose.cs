using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Matrix_transpose
    {
        int[,] mas;
        int x;
        int y;
        public void Matrixtransposed()

        {
            Console.WriteLine("Введите размер матрицы");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int[,] mas = new int[x, y];
            Console.WriteLine("Ввести значения");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Вывожу матрицу");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("транспонированая матрица");
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine(" ");
            
        }
    }
}

        

    

