using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Class
{
    class Value_vs_Reference
    {
        /* 값 형식 vs 참조 형식 */

        struct ValueType
        {
            public int value;
        }

        class RefType
        {
            public int value;
        }

        static void Main1()
        {
            // struct
            ValueType valueType1 = new ValueType() { value = 10 };
            ValueType valueType2 = valueType1;      // 값이 복사됨
            valueType2.value = 20;                  // 값을 대입해도 원본에는 영향 없음
            Console.WriteLine(valueType1.value);    // 10
            Console.WriteLine(valueType2.value);    // 20

            // class
            RefType refType1 = new RefType() { value = 10 };
            RefType refType2 = refType1;            // 객체 주소가 복사됨
            refType2.value = 20;                    // 값을 대입하는 경우 원본 데이터가 변경됨
            Console.WriteLine(refType1.value);      // 20
            Console.WriteLine(refType2.value);      // 20
        }


        /* 값 호출 vs 참조 호출 */

        // 값에 의한 호출 (struct)
        static void Swap(ValueType left, ValueType right)  // leftValue가 들어오는게 아니라 leftValue가 갖고있는 10이라는 값 자체가 들어옴
        {
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
            Console.WriteLine($"swap : {left.value}, {right.value}");  // 함수 내에서는 값 바뀜
        }

        // 참조에 의한 호출 (class)
        static void Swap(RefType left, RefType right)  // leftRef, rightRef 자체가 들어옴 (객체 주소)
        {
            int temp = left.value;
            left.value = right.value;
            right.value = temp;
            Console.WriteLine($"swap : {left.value}, {right.value}");
        }

        static void Main2()
        {
            ValueType leftValue = new ValueType() { value = 10 };  // 원본
            ValueType rightValue = new ValueType() { value = 20 };  // 원본
            Console.WriteLine($"{leftValue.value}, {rightValue.value}");  // 10, 20
            Swap(leftValue, rightValue);  // 데이터의 복사본(10, 20 이라는 값)이 함수로 들어가기 때문에 원본이 바뀌지 않음
            Console.WriteLine($"final : {leftValue.value}, {rightValue.value}");  // 10, 20 (swap 함수 밖으로 나오면 다시 원본이 출력됨)

            RefType leftRef = new RefType() { value = 10 };
            RefType rightRef = new RefType() { value = 20 };
            Console.WriteLine($"{leftRef.value}, {rightRef.value}");  // 10, 20
            Swap(leftRef, rightRef);  // 원본의 주소가 함수로 들어가기 때문에 원본이 바뀜
            Console.WriteLine($"final : {leftRef.value}, {rightRef.value}");  //  20, 10
        }


        /* 깊은 복사 vs 얕은 복사 */

        class CopyConstructor
        {
            public RefType deep;
            public RefType shallow;

            public CopyConstructor(CopyConstructor other)
            {
                // 깊은복사
                this.deep = new RefType();
                this.deep.value = other.deep.value;

                // 얕은복사
                this.shallow = other.shallow;
            }
        }
    }
}
