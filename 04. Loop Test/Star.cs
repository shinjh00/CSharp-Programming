namespace _04._Loop_Test
{
    class Star
    {
        /*** 별 찍기 ***/

        static void Main(string[] args)
        {
            int n;
            Console.Write("숫자를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("");


            /* 1 - 한 줄 */

            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.WriteLine("");


            /* 2 - 사각형 */

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");


            /* 3 - 삼각형 */

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");


            /* 4 - 역삼각형 */

            for (int i = 0; i < n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");


            /* 5 - 다이아몬드 */

            int m;
            Console.Write("숫자를 입력하세요 (홀수만) : ");
            int.TryParse(Console.ReadLine(), out m);
            Console.WriteLine("");

            for (int i = 0; i < m / 2 + 1; i++)
            {
                for (int j = 0; j < m / 2 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < m / 2; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (m / 2 - i) * 2 - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            /* 5 - 다이아몬드 (교수님 버전) */

            /*
            
             -4
            0
            4
            로 해서
            삼항 연산자로 i의 절대값 구해서
            -4, 4 부분 
            -3, 3 부분
            ~~~ 해주는 방법

             */
        }
    }
}
