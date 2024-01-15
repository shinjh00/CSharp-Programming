using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _10._Interface
{
    class Architecture
    {

        public interface IEnterable
        {
            public void Enter();
        }

        public abstract class Building : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("건물에 들어갑니다.");
            }
        }

        // 은행은 건물이다 : OK. 상속 관계가 적합
         public class Bank : Building
        {
            public void Enter()
            {
                Console.WriteLine("은행에 들어갑니다.");
            }
        }

        // 차는 들어갈 수 있다 : OK. 인터페이스가 적합
        public class Car : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("차 문을 열고 들어갑니다.");
            }
        }



    }
}
