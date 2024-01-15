using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Test
{
    /* 주어진 문자열 중 찾는 문자가 있는 인덱스를 구하는 함수 ( 단, 없을 경우 -1을 출력 ) */

    class Test01
    {
        public static int FindKeyIndex(string text, char key)
        {
            int index = text.IndexOf(key, 0);
            return index;
        }

        static void Main0(string[] args)
        {
            Console.Write("문자열 입력 : ");
            string inputStr = Console.ReadLine();

            Console.Write("찾을 문자 입력 : ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            char inputChar = keyInfo.KeyChar;

            Console.WriteLine();

            Console.WriteLine(FindKeyIndex(inputStr, inputChar));
        }
    }
}
