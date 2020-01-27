using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  1. Program to read an int array of odd length,compare 1st,middle,last in array and return largest.If there is 1 element ,return same element....*/
               
               
             
            /* Console.WriteLine("Enter array size : ");
             int size = int.Parse(Console.ReadLine());
             int[] a = new int[size];
             if (size % 2 == 0)
                 Console.WriteLine("Array accepts only odd size");
             else
             {
                 Console.WriteLine("Enter array values : ");
                 for (int i = 0; i < size; i++)
                 {
                     a[i] = int.Parse(Console.ReadLine());
                 }
                int first = a[0];
                 int mid= a[(a.Length) / 2];
                 int last=a[size - 1];
                 if ((first > mid) && (first > last))
                 {
                     Console.WriteLine(first + " is largest");
                 }
                 else if (mid > last)
                 {
                     Console.WriteLine(mid + " is largest");
                 }
                 else
                     Console.WriteLine(last + " is largest");


             }
             */

            /*Program to fin out sum of common elements in a given jagged array having 2 rows.If no common elements are found print "No common elements".......*/

            int[][] jagged = new int[2][];
            int sum = 0, flag = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter size of " + (i + 1) + " row : ");
                int size = int.Parse(Console.ReadLine());
                jagged[i] = new int[size];
            }
            Console.WriteLine("Enter array values :");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("1 row done");
            }
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < jagged[x].Length; y++)
                {
                    int a = jagged[x][y];
                    for (int z = 0; z < jagged[x].Length; z++)
                    {
                        if (z == y)
                            break;
                        else
                        {
                            if (a == jagged[x][z])
                            {
                                flag = 1;
                                sum = sum + a + jagged[x][z];
                            }



                        }
                    }

                }

            }
            if (flag == 0)
                Console.WriteLine("No Common Elements");
            else
                Console.WriteLine("Sum is : " + sum);
            Console.ReadKey();
        }


    }
}
        
  


