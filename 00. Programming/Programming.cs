namespace _00._Programming
{
    class Programming
    {
        static void Main(string[] args)
        {
            Console.WriteLine("한줄출력");

            Console.Write("캐릭터이름 : ");
            Console.WriteLine("뿡뿡이\n");

            Console.WriteLine("<게임 타이틀>\n\n");
            Console.WriteLine("1. 메뉴 선택");
            Console.WriteLine("2. 캐릭터 선택 : 캐릭터1 \t 캐릭터2 \t 캐릭터3 \n");

            Console.WriteLine("키를 입력하세요.");
            Console.ReadKey();
            Console.WriteLine("\n");

            Console.Write("캐릭터의 이름을 입력하세요.\n>> ");
            string name = Console.ReadLine();
            Console.WriteLine("*** 캐릭터의 이름은 " + name + "입니다. ***");
        }
    }
}
