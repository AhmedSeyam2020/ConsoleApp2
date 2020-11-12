using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please insert number of row ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("please insert number of col ");
            int col = int.Parse(Console.ReadLine());
            int[,] arr1 = new int[row,col];
            int[,] arr2 = new int[row, col];
            int[,] arr3 = new int[row, col];
            Console.WriteLine("Fill the First array ");
            fill(arr1);
            Console.WriteLine("Fill the second array ");
            fill(arr2);
            arr3=SuM(arr1, arr2);
            print(arr3);


          
          

        }
        public static void fill (int [,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("please insert elemnt no" + (i, j));
                    arr[i, j] = int.Parse(Console.ReadLine());

                }
            }
        }
        public static int[,] SuM(int [,]arr1,int[,]arr2)
        {
            int[,] arr3 = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return arr3;

        }
        public static void print(int [,]arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+ "       ");

                }
                Console.WriteLine();

            }
        }

    }
}
