using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /* 주어진 숫자가 소수인지 판별하는 함수를 작성 */

    class Test02
    {
        public static bool IsPrime(int number)
        {
            bool isPrime = false;

            if (number == 2)
            {
                isPrime = true;
            }
            else if (number % 2 == 0)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }
            }

            return isPrime;
        }

        static void Main0(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요.");
            string input = Console.ReadLine();
            int number;
            int.TryParse(input, out number);

            Console.WriteLine(IsPrime(number));
        }
    }
}
