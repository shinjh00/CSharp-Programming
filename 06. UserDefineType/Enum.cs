using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._UserDefineType
{
    class Enum
    {
        /***** 열거형 *****/

        /* 열거형 기본 사용 */

        enum Direction { Up, Down, Left, Right }
        static void Main()
        {
            // 방향 자료형 : 위쪽, 아래쪽, 왼쪽, 오른쪽
            Direction dir = Direction.Up;  // 입력값의 혼용 없이 열거형에 정의된 값으로 쓸 수 있음
            switch (dir)
            {
                case Direction.Up:  // 열거형에 인덱스가 자동으로 부여되므로 case 0: 이라고 표현해도 됨
                    Console.WriteLine("위로 이동");
                    break;
                case Direction.Down:
                    Console.WriteLine("아래로 이동");
                    break;
                case Direction.Left:
                    Console.WriteLine("왼쪽로 이동");
                    break;
                case Direction.Right:
                    Console.WriteLine("오른쪽로 이동");
                    break;
            }
        }

        /* 열거형 변환 */

        enum Season
        {
            Spring,  // 0
            Summer,  // 1
            Autumn = 20,  // 정수값을 직접 할당 가능
            Winter  // 21 (정수값을 직접 할당한 경우 이전 멤버 +1 값을 가짐)
        }

        static void Main2()
        {
            Season season1 = Season.Autumn;  // Autumn
            int value1 = (int)Season.Autumn;  // 20
            Console.WriteLine($"{season1}, {value1}");

            Season season2 = (Season)0;  // 정수에서 열거형 변수로 형변환
            Console.WriteLine(season2);  // Spring

            Season season3 = (Season)11;  // 열거형에 11이 없지만 그냥 11로 출력됨 (열거형 중에 어떤걸로도 표현 안됨)
            Console.WriteLine(season3);
        }
    }
}
