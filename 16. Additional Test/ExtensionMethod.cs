namespace _16._Additional_Test
{
    static class ExtensionMethod
    {
        public static bool isEven(this int value)
        {
            if (value % 2 == 1)
            {
                Console.WriteLine($"{value}는 홀수입니다.");
                return true;
            }
            else
            {
                Console.WriteLine($"{value}는 짝수입니다.");
                return false;
            }
        }

        public static void Main1(string[] args)
        {
            string input = Console.ReadLine();
            int value;
            int.TryParse(input, out value);

            Console.WriteLine(value.isEven());
        }
    }
}
