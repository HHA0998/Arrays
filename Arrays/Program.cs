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

            intList.Add(74);
            intList.Add(333);
            intList.Add(2);
            intList.Add(98);
            Console.WriteLine(intList[0]);
            Console.WriteLine(intList[1]);
            Console.WriteLine(intList[2]);
            Console.WriteLine(intList[3] + "\n");
            intList.Sort();
            Console.WriteLine(intList[0]);
            Console.WriteLine(intList[1]);
            Console.WriteLine(intList[2]);
            Console.WriteLine(intList[3] + "\n");
            intList.Reverse();
            Console.WriteLine(intList[0]);
            Console.WriteLine(intList[1]);
            Console.WriteLine(intList[2]);
            Console.WriteLine(intList[3] + "\n");
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
