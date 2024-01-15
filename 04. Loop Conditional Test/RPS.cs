namespace _04._Conditional_Loop_Test
{
    class RPS
    {
        /* 가위바위보 게임 */

        static void Main(string[] args)
        {
            Console.WriteLine("*** 가위바위보 게임 시작 ***");

            int myGrade = 0;
            int comGrade = 0;

            while (myGrade < 3 && comGrade < 3)
            {

                Console.WriteLine("[가위 / 바위 / 보] 중에 하나를 선택하세요.\n");

                Console.Write($">> 나 : ");
                string myRSP = Console.ReadLine();

                Random rand = new Random();
                int comRSP = rand.Next(0, 98);
                //Console.WriteLine(comRSP);

                if (myRSP == "가위")
                {
                    if (comRSP == 0 || comRSP % 3 == 0)
                    {
                        Console.WriteLine(">> 컴퓨터 : 가위\n");
                        Console.WriteLine("=> 결과 : 무승부");
                    }
                    else if (comRSP % 3 == 1)
                    {
                        Console.WriteLine(">> 컴퓨터 : 바위\n");
                        Console.WriteLine("=> 결과 : [컴퓨터] 승리");
                        comGrade += 1;
                    }
                    else if (comRSP % 3 == 2)
                    {
                        Console.WriteLine(">> 컴퓨터 : 보\n");
                        Console.WriteLine("=> 결과 : [나] 승리");
                        myGrade += 1;
                    }
                }
                else if (myRSP == "바위")
                {
                    if (comRSP == 0 || comRSP % 3 == 0)
                    {
                        Console.WriteLine(">> 컴퓨터 : 가위\n");
                        Console.WriteLine("=> 결과 : [나] 승리");
                        myGrade += 1;
                    }
                    else if (comRSP % 3 == 1)
                    {
                        Console.WriteLine(">> 컴퓨터 : 바위\n");
                        Console.WriteLine("=> 결과 : 무승부");
                    }
                    else if (comRSP % 3 == 2)
                    {
                        Console.WriteLine(">> 컴퓨터 : 보\n");
                        Console.WriteLine("=> 결과 : [컴퓨터] 승리");
                        comGrade += 1;
                    }
                }
                else if (myRSP == "보")
                {
                    if (comRSP == 0 || comRSP % 3 == 0)
                    {
                        Console.WriteLine(">> 컴퓨터 : 가위\n");
                        Console.WriteLine("=> 결과 : [컴퓨터] 승리");
                        comGrade += 1;
                    }
                    else if (comRSP % 3 == 1)
                    {
                        Console.WriteLine(">> 컴퓨터 : 바위\n");
                        Console.WriteLine("=> 결과 : [나] 승리");
                        myGrade += 1;
                    }
                    else if (comRSP % 3 == 2)
                    {
                        Console.WriteLine(">> 컴퓨터 : 보\n");
                        Console.WriteLine("=> 결과 : 무승부");
                    }
                }
                Console.WriteLine($"=> 현재 점수 : 나 {myGrade} vs 컴퓨터 {comGrade}");

            }
        }
    }
}
