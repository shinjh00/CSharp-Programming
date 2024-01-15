namespace _04._Loop
{
    class Loop
    {
        static void Main(string[] args)
        {
            /* while 반복문 */

            int money = 400;
            while (money > 0)
            {
                Console.WriteLine("100원 동전을 꺼냅니다.");
                money -= 100;
                Console.WriteLine($"잔액은 {money}입니다.");
            }

            Console.WriteLine("");


            /* do while 반복문 */

            int num;
            do
            {
                Console.WriteLine("1에서 9사이의 수를 입력하세요 : ");
                string input = Console.ReadLine();
                int.TryParse(input, out num);
            } while (num < 1 || 9 < num);

            Console.WriteLine("");


            /* for 반복문 */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i}번 반복");
            }

            Console.WriteLine("");

            // 위의 코드와 똑같음
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine($"{n}번 반복");
                n++;
            }

            Console.WriteLine("");


            /* foreach 반복문 */

            int[] intArray = { 1, 3, 5, 7, 9 };
            foreach (int element in intArray)
            {
                Console.WriteLine($"foreach 반복문의 현재 요소 : {element}");
            }

            Console.WriteLine();


            /* 제어문 */

            int number = 35;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{number}을 나눌 수 있는 가장 작은 수는 {i}입니다.");
                    break;  // 이거 없으면 계속 도는데 break 걸면 답 찾는 순간 루프문 끝남
                }
            }

            Console.WriteLine("");


            /* continue 제어문 */

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;  // 0, 2, 4, 6, 8 일 때 조건 만족하니까 밑에꺼 안하고 다음 반복문 수행
                if (i % 3 == 0)
                    continue;  // 3, (6), 9
                Console.WriteLine($"{i}은 2의 배수와 3의 배수가 아닙니다.");  // 1, 5, 7
            }
        }
    }
}
