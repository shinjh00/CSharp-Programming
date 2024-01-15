namespace _01._DataType_Test
{
    class Character
    {
        /* 캐릭터 선택창 만들기 */

        static void Main(string[] args)
        {
            string name;
            string job;
            int level;
            int hp;

            Console.WriteLine("<캐릭터 선택창>\n");

            Console.Write("이름을 입력하세요 : ");
            name = Console.ReadLine();
            Console.Write("직업을 입력하세요 : ");
            job = Console.ReadLine();
            Console.Write("레벨을 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out level);
            Console.Write("체력을 입력하세요 : ");
            int.TryParse(Console.ReadLine(), out hp);

            Console.WriteLine("");

            Console.WriteLine("선택하신 캐릭터는");
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"직업 : {job}");
            Console.WriteLine($"레벨 : {level}");
            Console.WriteLine($"체력 : {hp}");
        }
    }
}
