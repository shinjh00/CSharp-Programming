namespace _08._Memory
{
    class Memory
    {
        /* 스택 영역 */

        // <함수호출스택>
        static void Stack2(int a)
        {
            int b = 1;
            a = 3;
        }
        static void Stack1(int a)
        {
            int b = 10;
            a = 2;
            Stack2(a);
        }
        static void Main()
        {
            int b = 20;
            int a = 1;  // 블록 안에서 생성, 블록 끝에서 소멸
            Stack1(a);  // Main 함수는 Stack1이 끝나지 않으면 끝날 수 없음
        }


        /* 힙 영역 */

        // <가비지 콜렉터>
        class HeapClass { }

        void Main2()
        {
            // 함수 시작시
            // 지역변수 local이 스택 영역에 저장됨

            HeapClass local;            // 함수 시작시 이미 메모리에 할당되어 있음 (클래스로 만든 변수는 주소값을 담는 변수임)
            local = new HeapClass();    // 인스턴스를 힙영역에 생성하고 주소값을 local에 보관

            // 함수 종료시
            // 지역변수 local 이 함수 종료와 함께 소멸됨
            // 인스턴스 new HeapClass() 는 함수 종료와 함께 더이상 사용되지 않음 (더이상 참조하는 변수가 없음)
            // 인스턴스 new HeapClass() 는 가비지가 되어 가비지 컬렉터가 동작할 때 소멸됨
        }


        /* 데이터 영역 */

        // static인 곳에서 static 아닌 함수는 쓸 수 없음 (static 아닌 곳에서 static인 함수는 쓸 수 있음) (주소상하관계 생각해보면 됨)
        public class StaticTest
        {
            public static int value;
            public static void Test()
            {

            }
            public int x;  // static 아닌 것도 가질 수 있음
        }
        public static class StaticClass  // static인 것만 가질 수 있음
        {
            public static int value;
            public static void Test()
            {

            }
        }

        class StaticClass1
        {
            public static int staticValue;
            public int nonStaticValue;

            public static void StaticFunc()
            {
                Console.WriteLine(staticValue);                     // 정적함수에서 정적변수를 사용
                // Console.WriteLine(nonStaticValue);               // error : 정적함수에서 멤버변수를 사용할 수 없음

                StaticClass1 staticClass1 = new StaticClass1();
                Console.WriteLine(staticClass1.nonStaticValue);     // 정적함수에서 생성한 인스턴스는 사용할 수 있음
            }

            public void NonStaticFunc()
            {
                Console.WriteLine(staticValue);
                Console.WriteLine(nonStaticValue);
            }
        }

        static class StaticClass2
        {
            // public int nonStaticValue;       // error : 정적클래스에서 멤버변수를 포함할 수 없음
            // public void NonStaticFunc() { }  // error : 정적클래스에서 멤버함수를 포함할 수 없음

            public static int staticValue;
            public static void StaticFunc() { }
        }

        void Main3()
        {
            StaticClass1.staticValue = 10;                  // 정적변수는 전역적으로 접근 가능 ( . 으로 바로 접근 가능)
            StaticClass1.StaticFunc();                      // 정적함수는 전역적으로 접근 가능
            // StaticClass.nonStaticInt = 10;               // error : 맴버변수는 인스턴스가 있어야 사용가능
            // StaticClass.NonStaticFunc();                 // error : 맴버함수는 인스턴스가 있어야 사용가능

            StaticClass1 instance = new StaticClass1();
            instance.nonStaticValue = 20;                   // 맴버변수는 인스턴스가 각자 가지고 있으며 인스턴스를 통해 접근
            instance.NonStaticFunc();                       // 맴버함수는 인스턴스가 각자 가지고 있으며 인스턴스를 통해 접근
            // instance.staticInt = 20;                     // error : 정적변수는 인스턴스가 아닌 클래스이름을 통해서 접근 (정적은 인스턴스로 접근 불가능)
            // instance.StaticFunc();                       // error : 정적함수는 인스턴스가 아닌 클래스이름을 통해서 접근

            // StaticClass2 instance = new StaticClass2();  // error : 정적클래스는 인스턴스를 만들 수 없음 (만들 필요도 없고)
            StaticClass2.staticValue = 30;
            StaticClass2.StaticFunc();
        }
    }
}
