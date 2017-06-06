

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowIndex;
            int highIndex;

            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 0.5 };
            int[] intArray = { 1, 2, 3, 4, 5, 6, 11, 14, 15, 19 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O', 'P', 'R', 'F' };


            Console.WriteLine("Length of double Array is = " + doubleArray.Length + "\n");
            Console.WriteLine("Length of char Array is =" + charArray.Length + "\n");
            Console.WriteLine("Length of integer Array is =" + intArray.Length+"\n");


            Console.WriteLine("Enter the low index");
            
            string input1 = Console.ReadLine();
            Console.WriteLine("\n Low index entered =" + input1);
            lowIndex = Int32.Parse(input1);

            Console.WriteLine("Enter the high index");
            string input2 = Console.ReadLine();
            Console.WriteLine("\n High index entered ="+input2);
            highIndex = Int32.Parse(input2);

           


            
            var intArr = DisplayArray(intArray, lowIndex, highIndex); // pass an int array argument

            Console.WriteLine("\n Displaying int array \n");
            foreach (var item in intArr)
            {
                Console.Write(item + ",");
            }


            Console.WriteLine("\n Displaying double array \n");
            

            var doubleArr = DisplayArray(doubleArray, lowIndex, highIndex); // pass an int doubleArray argument
            foreach (var item in doubleArr)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("\n Displaying char array \n");
            

            var charArr = DisplayArray(charArray, lowIndex, highIndex); // pass an int doubleArray argument

            foreach (var item in charArr)
            {
                Console.Write(item + ",");
            }
        }

        private static T[] DisplayArray<T>(T[] inputArray, int y, int z) where T : IComparable<T>
        {

            var length = (z - y);
            T[] tmp = new T[length];

            if (y >= z || y < -1 || z > inputArray.Length)

            {
                throw new Exception("Low and High index must be within array's size");

            }
            else {
                for (var i = 0; i < length; i++)
                {
                    tmp[i] = inputArray[y];
                    //    Console.Write(tmp[i]);
                    y++;
                }
            }
            return (tmp);      
            Console.WriteLine();
        }
        
    }
}
