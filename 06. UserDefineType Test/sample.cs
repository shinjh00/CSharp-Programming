using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._UserDefineType_Test
{
    class sample
    {
        enum RSP { Rock = 1, Scissors, Paper }

        struct PlayRSP
        {

            public int playerGrade;
            public int comGrade;

            public PlayRSP()
            {
                this.playerGrade = 0;
                this.comGrade = 0;
            }

            public void playerTurn()
            {
                Console.WriteLine("[ 가위 -> 1, 바위 -> 2, 보 -> 3 ] 숫자를 입력하여 가위, 바위, 보 중에 하나를 내시오.\n");

                Console.Write($">> playerTurn : ");
                char keyChar = Console.ReadKey().KeyChar;

                RSP playerTurn;
                switch (keyChar)
                {
                    case '1':
                        playerTurn = RSP.Scissors;
                        Console.WriteLine($"{playerTurn}");
                        break;
                    case '2':
                        playerTurn = RSP.Rock;
                        Console.WriteLine($"{playerTurn}");
                        break;
                    case '3':
                        playerTurn = RSP.Paper;
                        Console.WriteLine($"{playerTurn}");
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }

            public void comTurn()
            {
                Console.Write($">> comTurn : ");
                Random rand = new Random();
                int comRSP = rand.Next(1, 99);

                RSP comTurn;
                if (comRSP % 3 == 1)
                {
                    comTurn = RSP.Rock;
                    Console.WriteLine($"{comRSP}{comTurn}");
                }
                else if (comRSP % 3 == 2)
                {
                    comTurn = RSP.Scissors;
                    Console.WriteLine($"{comRSP}{comTurn}");
                }
                else if (comRSP == 0 || comRSP % 3 == 0)
                {
                    comTurn = RSP.Paper;
                    Console.WriteLine($"{comRSP}{comTurn}");
                }
            }

            public void calcGrade()
            {
                Console.WriteLine(playerTurn);
                Console.WriteLine(comTurn);

                Console.WriteLine($"=> 현재 점수 : 나 {playerGrade} vs 컴퓨터 {comGrade}");

            }
        }

        static void Main0(string[] args)
        {
            Console.WriteLine("*** 가위바위보 게임 시작 ***\n");


            PlayRSP playRSP = new PlayRSP();

            playRSP.playerTurn();
            playRSP.comTurn();

            RSP nowRSP = new RSP();



            playRSP.calcGrade();

            /*
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine((int)RSP.Rock);
            Console.WriteLine((int)RSP.Scissors);
            Console.WriteLine((int)RSP.Paper);


            Console.WriteLine(playRSP.playerGrade);
            Console.WriteLine(playRSP.comGrade);
            */

            /*
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
            */

        }

    }
}
