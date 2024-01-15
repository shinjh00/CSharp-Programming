namespace _06._UserDefineType_Test
{
    class RPSGame
    {
        /* 가위바위보 게임 */

        enum RPS { Rock, Paper, Scissors }

        static RPS PlayerInput()
        {
            RPS result = RPS.Rock;

            // 1:가위, 2:바위, 3:보
            Console.WriteLine("가위, 바위, 보 중에 하나를 선택하세요.");
            Console.WriteLine("[ 1- 가위, 2- 바위, 3- 보 ]\n");
            Console.Write(">> 플레이어 : ");

            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    // 가위
                    result = RPS.Scissors;
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    // 바위
                    result = RPS.Rock;
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    // 보
                    result = RPS.Paper;
                    break;
            }
            return result;
        }

        static RPS ComRandom()
        {
            Random rand = new Random();
            int value = rand.Next(0, 3);

            RPS result = (RPS)value;
            return result;
        }

        enum WinOrLose { Win, Draw, Lose }

        static WinOrLose CalcGrade(RPS player, RPS com)
        {
            // 가위 vs 가위 : 무승부
            // 가위 vs 바위 : 패
            // 가위 vs 보 : 승
            if (player == RPS.Scissors && com == RPS.Rock)
            {
                return WinOrLose.Lose;
            }
            else if (player == RPS.Scissors && com == RPS.Paper)
            {
                return WinOrLose.Win;
            }
            else if (player == RPS.Rock && com == RPS.Scissors)
            {
                return WinOrLose.Win;
            }
            else if (player == RPS.Rock && com == RPS.Paper)
            {
                return WinOrLose.Lose;
            }
            else if (player == RPS.Paper && com == RPS.Rock)
            {
                return WinOrLose.Win;
            }
            else if (player == RPS.Paper && com == RPS.Scissors)
            {
                return WinOrLose.Lose;
            }
            else
            {
                return WinOrLose.Draw;
            }
        }

        static void PrintResult(RPS player, RPS com, WinOrLose result, int playerWin, int comWin)
        {
            // 결과
            Console.WriteLine();
            Console.WriteLine($"player : {player}");
            Console.WriteLine($"com : {com}");
            Console.WriteLine($"result : {result}");
            Console.WriteLine($"score : player({playerWin}) vs com({comWin})");
            Console.WriteLine();
        }

        static void PrintGameEnd(int playerWin, int comWin)
        {
            if (playerWin == 3)
            {
                Console.WriteLine("플레이어 승리");
            }
            else if (comWin == 3)
            {
                Console.WriteLine("컴퓨터 승리");
            }
        }

        static void Main(string[] args)
        {
            int playerWin = 0;
            int comWin = 0;

            while (playerWin < 3 && comWin < 3)
            {
                // 1. 플레이어한테 가위, 바위, 보 중에서 하나를 입력받도록 함
                RPS player = PlayerInput();

                // 2. 컴퓨터는 랜덤으로 선택
                RPS com = ComRandom();

                // 3. 가위, 바위, 보의 승패 계산
                WinOrLose result = CalcGrade(player, com);

                // 점수 계산
                if (result == WinOrLose.Win)
                {
                    playerWin++;
                }
                else if (result == WinOrLose.Lose)
                {
                    comWin++;
                }
                PrintResult(player, com, result, playerWin, comWin);
            }

            PrintGameEnd(playerWin, comWin);

        }
    }
}
