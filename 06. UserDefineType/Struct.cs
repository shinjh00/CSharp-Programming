using System.Numerics;

namespace _06._UserDefineType
{
    class Struct
    {
        /***** 구조체 *****/

        /* 구조체 기본 사용 1 */

        struct MonsterStat  // MonsterStat 이라는 자료형이 있는 것처럼 사용할 수 있음
        {
            public int hp;
            public int level;
            public float range;
        }

        static void Main1()
        {
            MonsterStat stat;
            stat.hp = 10;
            stat.level = 1;
            stat.range = 3.5f;

            //void Attack(int hp, int mp, ...) { }  // 불편

            void Attack(MonsterStat stat)
            {
                float monsterRange = stat.range;
                monsterRange = 4.5f;
                Console.WriteLine(monsterRange);
            }
            Attack(stat);
        }

        /* 구조체 기본 사용 2 */

        struct StudentInfo
        {
            public string name;
            public int math;
            public int english;
            public int science;

            public int GetSum()
            {
                return math + english + science;
            }
            public float GetAvg()
            {
                return (math + english + science) / 3.0f;
            }
        }

        static void Main2()
        {
            StudentInfo shin;
            shin.name = "신졔";
            shin.math = 90;
            shin.english = 80;
            shin.science = 100;
            Console.WriteLine($"{shin.name}의 점수 총합은 {shin.GetSum()}입니다.");
            Console.WriteLine($"{shin.name}의 점수 평균은 {shin.GetAvg()}입니다.");

            StudentInfo kim;
            kim.name = "김첨지";
            kim.math = 30;
            kim.english = 40;
            kim.science = 50;
            Console.WriteLine($"{kim.name}의 점수 총합은 {kim.GetSum()}입니다.");
            Console.WriteLine($"{kim.name}의 점수 평균은 {kim.GetAvg()}입니다.");
        }


        /* 구조체 초기화 */

        struct Point
        {
            public int x;
            public int y;

            // 기본 초기화
            /*public Point()
            {
                this.x = 0;
                this.y = 0;
            }*/

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                // this : 자기 자신을 가리킴 (구조체 안에 있는 변수)
                // 오른쪽에 있는 값은 매개변수로 들어온 값
            }
        }

        static void Main3()
        {
            Point point1;
            point1.x = 1;
            Console.WriteLine($"point1.x : {point1.x}");
            //Console.WriteLine($"{point1.y}");  // error : 초기화하지 않은 변수 사용

            // 기본 초기화 사용
            Point point2 = new Point();
            Console.WriteLine($"point2 : ({point2.x}, {point2.y})");  // 기본 초기화는 안 만들어도 자동생성되어 기본으로 0, 0이 들어감 (int-0, bool-false, string-"")

            // 추가로 구현한 초기화 사용
            Point point3 = new Point(1, 2);  // 변수마다 매번 초기화할 필요없이 매개변수로 간략하게 표현 가능
            Console.WriteLine($"point3 : ({point3.x}, {point3.y})");

            // 초기화 및 값 대입
            Point point4 = new Point() { x = 3, y = 4 };
            Console.WriteLine($"point4 : ({point4.x}, {point4.y})");
        }


        /* 구조체 깊은 복사 1 */

        struct MyStruct
        {
            public int value1;
            public int value2;
        }

        static void Main4()
        {
            MyStruct s;
            s.value1 = 1;
            s.value2 = 2;

            MyStruct t = s;  // 구조체 내 모든 변수들의 값이 복사됨
            t.value1 = 3;

            Console.WriteLine(s.value1);  // 1
            Console.WriteLine(s.value2);  // 2
            Console.WriteLine(t.value1);  // 3
            Console.WriteLine(t.value2);  // 2
        }

        /* 구조체 깊은 복사 2 */

        struct Vector3
        {
            public float x;
            public float y;
            public float z;

            public Vector3(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public string ToString()
            {
                return $"({x}, {y}, {z})";
            }
        }

        static void Main5()
        {
            Vector3 source = new Vector3(1, 2, 3);
            Vector3 dest = source;
            Console.WriteLine(source.ToString());
            Console.WriteLine(dest.ToString());

            source.y = 10;
            dest.x = 5;
            Console.WriteLine(source.ToString());
            Console.WriteLine(dest.ToString());
        }
    }
}
