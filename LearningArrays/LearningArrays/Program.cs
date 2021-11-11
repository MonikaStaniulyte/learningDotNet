using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArray = new string[] { "a", "b", "c", "d", "e"};

            for (var i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            Console.WriteLine();

            var intArray = Enumerable.Range(0, 20).ToArray();

            for (var i = intArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }

            // to prevent console from closing
            Console.ReadLine();
        }
    }
}
