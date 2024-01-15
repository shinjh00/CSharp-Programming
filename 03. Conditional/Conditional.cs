namespace _03._Conditional
{
    class Conditional
    {
        static void Main(string[] args)
        {
            /* if 문 */

            int playerHp = 100;
            int monsterAtk = 20;

            if (playerHp > monsterAtk)
            {
                // 살아있음
                Console.WriteLine("플레이어가 데미지를 받는다.");
                playerHp -= monsterAtk;
            }
            else
            {
                // playerHp < monsterAtk
                // 죽음
                Console.WriteLine("플레이어가 쓰러진다.");
                playerHp = 0;
            }

            Console.WriteLine();


            int score = 0;
            Console.Write("점수를 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out score);
            Console.WriteLine($">> 점수 : {score}");

            if ((0 < score) && (score <= 30))
            {
                Console.WriteLine(">> 등급 : 하");
            }
            else if ((30 < score) && (score <= 60))
            {
                Console.WriteLine(">> 등급 : 중");
            }
            else if ((60 < score) && (score <= 90))
            {
                Console.WriteLine(">> 등급 : 상");
            }
            else if ((90 < score) && (score <= 100))
            {
                Console.WriteLine(">> 등급 : 최상");
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

            Console.WriteLine();


            /* switch 문 */

            string str = "B";
            switch (str)
            {
                case "A":
                    Console.WriteLine("A가 일치하는 경우");
                    break;
                case "B":
                    Console.WriteLine("B가 일치하는 경우");
                    break;  // switch 블록을 빠져나감
                case "C":
                    Console.WriteLine("C가 일치하는 경우");
                    break;
            }

            Console.WriteLine();


            // 조건값에 따라 동일한 실행이 필요한 경우 묶어서 사용 가능
            char key = 'w';
            switch (key)
            {
                case 'w':
                case 'W':
                case 'ㅈ':
                    Console.WriteLine("위쪽으로 이동");
                    break;
                case 'a':
                case 'A':
                case 'ㅁ':
                    Console.WriteLine("왼쪽으로 이동");
                    break;
                case 's':
                case 'S':
                case 'ㄴ':
                    Console.WriteLine("아래쪽으로 이동");
                    break;
                case 'd':
                case 'D':
                case 'ㅇ':
                    Console.WriteLine("오른쪽으로 이동");
                    break;
                default:
                    Console.WriteLine("이동하지 않음");
                    break;
            }

            Console.WriteLine();


            /* 삼항 연산자 */

            int big = 20 > 10 ? 20 : 10;  // 20
            int small = 20 < 10 ? 20 : 10;  // 10
            Console.WriteLine($"big : {big}, small : {small}");
        }
    }
}
