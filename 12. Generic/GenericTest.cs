using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._Generic
{
    class GenericTest
    {
        /*
        일반화를 이용하여 어떤 자료형의 배열이더라도 복사가능한 함수를 구현
        void ArrayCopy(배열원본, 복사할배열);
        */

        public static void ArrayCopy<T>(T[] source, T[] output)
        {
            for (int i = 0; i < source.Length; i++)
            {
                output[i] = source[i];
            }
        }

        static void Main()
        {
            int[] iSrc = { 1, 2, 3, 4, 5 };
            int[] iDst = new int[iSrc.Length];
            ArrayCopy<int>(iSrc, iDst);

            foreach (int element in iDst)
            {
                Console.Write($"{{{element}}} ");
            }
            Console.WriteLine();

            float[] fSrc = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };
            float[] fDst = new float[fSrc.Length];
            ArrayCopy<float>(fSrc, fDst);

            foreach (float element in fDst)
            {
                Console.Write($"{{{element}}} ");
            }
            Console.WriteLine();

            double[] dSrc = { 1.1d, 2.2d, 3.3d, 4.4d, 5.5d };
            double[] dDst = new double[dSrc.Length];
            ArrayCopy<double>(dSrc, dDst);

            foreach (double element in dDst)
            {
                Console.Write($"{{{element}}} ");
            }
            Console.WriteLine();

            char[] cSrc = { 'a', 'b', 'c', 'd', 'e' };
            char[] cDst = new char[cSrc.Length];
            ArrayCopy(cSrc, cDst);

            foreach (char element in cDst)
            {
                Console.Write($"{{{element}}} ");
            }
            Console.WriteLine();

            string[] sSrc = { "하나", "둘", "셋", "넷", "다섯" };
            string[] sDst = new string[sSrc.Length];
            ArrayCopy(sSrc, sDst);

            foreach (string element in sDst)
            {
                Console.Write($"{{{element}}} ");
            }
            Console.WriteLine();

        }
    }
}
