using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _13._Exception
{
    class ExceptionTest
    {
        static void Main1()
        {
            try
            {
                Console.WriteLine("나눗셈을 할 숫자를 입력하세요.");

                Console.Write("> 숫자1 : ");
                string input1 = Console.ReadLine();
                int num1 = int.Parse(input1);

                Console.Write("> 숫자2 : ");
                string input2 = Console.ReadLine();
                int num2 = int.Parse(input2);

                if (num2 != 0)
                {
                    double result = num1 / (double)num2;
                    Console.WriteLine($"결과는 {result}입니다.");
                }
                else
                {
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("입력값이 정수로 변환이 불가한 경우 예외 발생");
            }
        }
    }
}
