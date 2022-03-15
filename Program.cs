using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab_2._2
{
    internal class Program
    {
        static void Create(int[] b)
        {
            Random x = new Random();

            for (int i = 0; i < b.Length; i++)
                b[i] = Convert.ToInt32(x.Next(-40, 50));
        }
        static void Create2(int[] b, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"b[{i}] = ");
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

        }

        static int SearchMin(int[] b)
        {
            int min = 0;
            int imin = -1;
            for (int i = 0; i < b.Length; i++)
                if (b[i] % 2 == 0)
                {
                    min = b[i];
                    imin = i;
                    break;
                }
           
                    
        

            if (imin == -1)
                return -1;
            else
            {
                for (int i = imin + 1; i < b.Length; i++)
                    if (b[i] < min && b[i] % 2 == 0)
                    {
                        min = b[i];
                        imin = i;
                    }
                      
                return imin;
            }
            
        }
        static void Castling(int[] b)
        {
            int first = b[0];
            int imin = SearchMin(b);
            if(imin != -1)
            {
                b[0] = b[imin];
                b[imin] = first;
                Print(b);
            }
            else
                Console.WriteLine("There are no paired elements");

        }
        static void Print(int[] b)
        {
            Console.WriteLine("Array : [{0}]", string.Join(", ", b));
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[n];
            Create(b);
            Print(b);
            Castling(b);
        

            Console.ReadKey();
        }
    }
}
