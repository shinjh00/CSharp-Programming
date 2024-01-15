using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional_Test
{
    class Parameter
    {
        static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        static void Main1()
        {
            int left = 10;
            int right = 20;
            Swap(ref left, ref right);
            Console.WriteLine($"left: {left}, right: {right}");
        }
    }
}
