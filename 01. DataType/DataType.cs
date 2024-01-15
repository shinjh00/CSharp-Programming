namespace _01._DataType
{
    class DataType
    {
        static void Main(string[] args)
        {
            /* 자료형 */

            int iValue = 10;
            iValue = 5;
            Console.WriteLine(iValue);

            float fValue;
            fValue = 1.2f;
            Console.WriteLine(fValue);

            Console.WriteLine();


            /* 변수 */

            int rValue = 20;
            int lValue = rValue;
            Console.WriteLine($"rValue 변수에 보관된 데이터는 {rValue}입니다.");
            Console.WriteLine($"lValue 변수에 보관된 데이터는 {lValue}입니다.");

            int level = 30;
            Console.WriteLine("당신의 레벨은 " + level + "입니다.");  // 유니티 개발에서는 **절대** 이렇게 쓰지 않기 (가비지가 많이 발생함)
            Console.WriteLine($"당신의 레벨은 {level}입니다.");  // 이렇게 쓰기

            Console.WriteLine();


            /* 상수 */

            const int MAX_EXP = 100;
            const string GAME_NAME = "리그오브레전드";
            // MAXEXP = 200;  // error
            // GAMENAME = "배틀그라운드";  // error
            Console.WriteLine(MAX_EXP);
            Console.WriteLine(GAME_NAME);

            Console.WriteLine();


            /* 형변환 */

            int damage = 23;
            //int modifyDamage = damage * 1.3f;  // error
            float damageToFloat = damage * 1.3f;
            Console.WriteLine(damageToFloat);

            int damageToInt = (int)damageToFloat;  // 명시적 형 변환 (소수점 버려짐)
            Console.WriteLine(damageToInt);

            double d = 123.345f;  // 묵시적 형 변환 (더 큰 범위에 담을 때)
            Console.WriteLine(d);

            char key = (char)65;  // 'A' 아스키 코드 활용
            Console.WriteLine(key);
            int value = (int)'a';  // '97'
            Console.WriteLine(value);

            string hp = "100";
            int hp1 = int.Parse(hp);  // 문자열 -> 정수 로 형 변환
            Console.WriteLine($"hp1 : {hp1}");

            int hp2;
            int.TryParse("100", out hp2);  // 안전하게 바꾸기. 제일 많이 씀
            Console.WriteLine($"hp2 : {hp2}");
            int hp3;
            int.TryParse("100fewee", out hp3);  // 맞지 않으면 안 바뀌고 0 반환
            Console.WriteLine($"hp3 : {hp3}");

            string hundred = 100.ToString();  // 정수 -> 문자열 로 형 변환
            Console.WriteLine(hundred);
        }
    }
}
