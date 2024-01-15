using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
    class Lambda
    {

        //Lambda, LinQ 고급 프로그래밍 나중에 실력쌓였을 때 연습

        void Main0()
        {
            Action<string> action;

            // <함수를 통한 할당>
            // 클래스에 정의된 함수를 직접 할당
            // 클래스의 멤버함수로 연결하기 위한 기능이 있을 경우 적합
            action = Message;

            // <무명메서드>
            // 함수를 통한 연결은 함수가 직접적으로 선언되어 있어야 사용 가능
            // 할당하기 위한 함수가 간단하고 자주 사용될수록 비효율적
            // 간단한 표현식을 통해 함수를 즉시 작성하여 전달하는 방법
            // 전달하기 위한 함수가 간단하고 일회성으로 사용될 경우에 적합

        }

        void Message(string message)
        {
            Console.WriteLine(message);
        }


    }
}
