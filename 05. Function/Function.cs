namespace _05._Function
{
    class Function
    {
        /* 함수 구성 & 사용 */

        static int Plus(int left, int right)
        {
            Console.WriteLine($"input : {left}, {right}");
            int result = left + right;
            Console.WriteLine($"output : {result}");
            return result;
        }
        static void Main()
        {
            Plus(1, 2);
            int value = Plus(3, 4);
        }


        /* 반환형 */

        static int Return10()
        {
            Console.WriteLine("도달하는 코드");
            return 10;
            Console.WriteLine("도달하지 않는 코드");
        }
        static void Main1()
        {
            int ret = Return10();
            Console.WriteLine(ret);
        }


        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"번호 : {phone}");

            //return;  // void 반환형에서 return을 진행하는 경우 함수 종료의 역할을 함
        }
        static void Main2()
        {
            PrintProfile("홍길동", "010-1234-1234");
        }


        /* 매개변수 */

        static int Minus(int left, int right)
        {
            return left - right;
        }
        static void Main3()
        {
            int value1 = Minus(20, 10);
            Console.WriteLine(value1);
            int value2 = Minus(30, 10);
            Console.WriteLine(value2);
        }


        /* 함수 호출 순서 */

        static int TripleShot()
        {
            int damage = 0;
            for (int i = 0; i < 3; i++)
            {
                damage += Attack();
            }
            return damage;
        }
        static int Attack()
        {
            Console.WriteLine("공격!");
            return 10;
        }
        static void Main4()
        {
            int totalDamage = TripleShot();
            Console.WriteLine(totalDamage);
        }


        /* 함수 오버로딩 */
        // 함수 이름은 같지만 매개변수의 자료형을 달리하여 다른 함수로 재정의하는 기술

        static int Multi(int left, int right)
        {
            return left * right;
        }
        static float Multi(float left, float right)
        {
            return left * right;
        }
        static double Multi(double left, double right)
        {
            return left * right;
        }
        static void Main5()
        {
            int m1 = Multi(2, 3);
            float m2 = Multi(2.0f, 3.0f);
            double m3 = Multi(2.0, 3.0);

            Console.WriteLine($"int:{m1}, float:{m2}, double:{m3}");
        }

    }
}
