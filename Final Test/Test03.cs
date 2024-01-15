using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /* 주어진 숫자의 각 자리수의 합을 구하는 함수를 작성 */

    class Test03
    {
        public static int SumOfDigits(int number)
        {
            int sum = 0;

            if (number > 0)
            {
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
            }
            else
            {
                Console.WriteLine("양수를 입력해주세요.");
            }

            return sum;
        }

        static void Main0(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요.");
            string input = Console.ReadLine();
            int number;
            int.TryParse(input, out number);

            Console.WriteLine(SumOfDigits(number));
        }
    }
}
