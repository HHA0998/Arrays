using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();

            intList.Add(20);
            intList.Add(30);
            intList.Add(23);
            intList.Add(33);
            Console.WriteLine(intList[0]);
            Console.WriteLine(intList[1]);
            Console.WriteLine(intList[2]);
            Console.WriteLine(intList[3]);
            intList.Remove(30);
            Console.WriteLine("\n" + intList[0]);
            Console.WriteLine(intList[1]);
            Console.WriteLine(intList[2]);
            // error! Console.WriteLine(intList[3]);
            Console.ReadKey();

            /*
            int[] myArray = new int[5];
            myArray[0] = 45;
            myArray[1] = 34;
            myArray[2] = 56;
            myArray[3] = 22;

            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[1]);
            Console.WriteLine(myArray[2]);
            Console.WriteLine(myArray[3]);
            Console.WriteLine(myArray[4]);
            Console.ReadKey();
            */

        }
    }
}
