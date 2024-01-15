using System.Threading.Tasks.Sources;

namespace _02._Operator
{
    class Operator
    {
        static void Main(string[] args)
        {
            bool b = false;
            int i = 0;
            float f = 0.0f;

            /***** 산술 연산자 *****/

            /* 이진 연산자 */

            i = 2 + 3;          // + 더하기
            i = 3 - 1;          // - 빼기
            i = 3 * 3;          // * 곱하기
            f = 5.0f / 2.0f;    // / 나누기 : 5/3과 같이 int의 나눗셈은 소수점을 버림
            i = 13 % 3;         // % 나머지

            // 나머지 연산 쓰는 경우
            i = 142 % 10;           // 숫자 맨 끝자리 알고 싶을 때
            i = (142 / 10) % 10;    // 두번째 자리 알고 싶을 때

            /* 단항 연산자 */

            i = +3;     // 단항 연산자 (양수) : 그대로 반환
            i = -3;     // 단항 연산자 (음수) : 마이너스로 변환 (2의 보수 만들기)
            ++i;        // 전위 증가 연산자   : 1 증가
            i++;        // 후위 증가 연산자   : 1 증가
            --i;        // 전위 감소 연산자   : 1 감소
            i--;        // 후위 감소 연산자   : 1 감소

            // 전위 연산자 : 연산 -> 값 반환
            i = 0;
            Console.WriteLine(i);       // 0
            Console.WriteLine(++i);     // 1
            Console.WriteLine(i);       // 1

            // 후위 연산자 : 값을 반환 -> 연산
            i = 0;
            Console.WriteLine(i);       // 0
            Console.WriteLine(i++);     // 0
            Console.WriteLine(i);       // 1

            Console.WriteLine();


            /***** <대입 연산자> *****/

            i = 10;

            /* 복합 대입 연산자 */

            int hp = 100;
            hp += 10;  // hp = hp + 10
            hp -= 10;  // hp = hp - 10


            /***** <비교 연산자> *****/

            b = 3 > 1;      // true
            b = 3 < 1;      // false
            b = 2 <= 2;     // true
            b = 3 == 3;     // true
            b = 2 == 3;     // false
            b = 2 != 3;     // true


            /***** <논리 연산자> *****/

            b = !false;      // true -> false, false -> true
            b = true && false;
            b = false || true;

            /* 조건부 논리 연산자 */

            // 빠른 계산을 위해 [ false && x(논리자료형) ]과 같이 쓰면
            // 결과는 항상 false이기 때문에 x는 무시하게 됨
            int iValue = 10;
            bool bValue = false && (++iValue > 5);
            Console.WriteLine(iValue);  // 10

            // 빠른 계산을 위해 [ true || x(논리자료형) ]과 같이 쓰면
            // 결과는 항상 true이기 때문에 x는 무시하게 됨
            iValue = 10;
            bValue = true || (++iValue > 5);
            Console.WriteLine(iValue);  // 10

            Console.WriteLine();


            /***** <비트 연산자> : 다른 것에 비해 미친듯이 빠르다 *****/

            // 2진수, 16진수
            int ib = 0b0011;    // 3   // 0b가 앞에 붙으면 2진수 표현
            int ix = 0x001A;    // 26  // 0x가 앞에 붙으면 16진수 표현 ( (1 * 12^1) + (A * 12^0) )
            Console.WriteLine($"ib: {ib}, ix: {ix}");

            /* 단항 연산자 */

            // 비트 보수
            int ib2 = 0b1001;   // 9
            int ib3 = ~0b1001;  // -10
            Console.WriteLine($"ib2: {ib2}, ib3: {ib3}");

            int ix2 = 0x35;     // 53
            int ix3 = ~0x35;    // -54
            Console.WriteLine($"ix2: {ix2}, ix3: {ix3}");
            Console.WriteLine($"ix2: {ix2}, ix3: {ix3}");

            /* 이진 연산자 */

            int ibAnd = 0b1001 & 0b1100;    // 데이터를 비트 단위로 and 연산
            int ibOr = 0b1001 | 0b1100;     // 데이터를 비트 단위로 or 연산
            int ibXor = 0b1001 ^ 0b1100;    // 데이터를 비트 단위로 xor 연산
            Console.WriteLine($"ibAnd: {ibAnd}, ibOr: {ibOr}, ibXor: {ibXor}");

            /* 비트 쉬프트 연산 */

            int ib4 = 0b0010;       // 2
            int ib5 = ib4 << 1;     // 0b0100 -> 4
            Console.WriteLine($"ib4: {ib4}, ib5: {ib5}");

            // 단항 > 곱하기 > 더하기 > 시프트 > 비교 > 논리 > 대입
        }
    }
}
