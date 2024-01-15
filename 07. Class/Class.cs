using System.Data.Common;
using System.Text.Json.Serialization;

namespace _07._Class
{
    class Class
    {
        /***** 클래스 *****/

        /* 클래스 구성 */

        class Student
        {
            public string name;
            public int math;
            public int english;
            public int science;

            public float GetAverage()
            {
                return (math + english + science) / 3f;
            }
        }

        static void Main()
        {
            Student kim = new Student();    // 클래스 인스턴스를 생성하고 지역변수(kim)가 인스턴스를 참조함
            kim.name = "김첨지";   // 인스턴스의 변수에 접근하기 위해 참조한 변수에 . 를 붙여 사용
            kim.math = 10;
            kim.english = 50;
            kim.science = 100;

            float average = kim.GetAverage();  // 클래스 내 함수에 접근하기 위해 참조한 변수에 . 를 붙여 사용
            Console.WriteLine(average);
        }


        /* 클래스 생성자 */

        class Car
        {
            public string name;
            public string color;

            // 기본 생성자는 다른 생성자를 포함하지 않은 경우에만 자동 생성됨
            /*public Car()
            {

            }*/

            public Car(string name, string color)
            {
                this.name = name;
                this.color = color;
            }
        }

        static void Main2()
        {
            Car car;
            //car.name = "차";  // error : 클래스 지역변수는 인스턴스 없이 사용 불가

            Car truck = new Car("트럭", "blue");
            Console.WriteLine($"{truck.name}, {truck.color}");

            //Car taxi = new Car();  // error : 기본 생성자는 다른 생성자를 포함하지 않은 경우에만 자동 생성됨
        }


        /* 클래스 얕은 복사 */

        class MyClass
        {
            public int value1;
            public int value2;
        }

        static void Main3()
        {
            MyClass s = new MyClass();
            s.value1 = 1;
            s.value2 = 2;

            MyClass t = s;  // 변수가 같은 인스턴스를 참조함
            t.value1 = 3;

            MyClass m = new MyClass();
            m.value1 = 4;

            // 같은 인스턴스를 참조하기 때문에 복사본을 변경하는 경우 원본도 변경됨
            Console.WriteLine(s.value1);  // 3
            Console.WriteLine(s.value2);  // 2
            Console.WriteLine(t.value1);  // 3
            Console.WriteLine(t.value2);  // 2
            Console.WriteLine(m.value1);  // 4
            Console.WriteLine(m.value2);  // 0
        }
    }
}
