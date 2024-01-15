using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    class Test04_Abstraction
    {
        /*
         * 추상화 : 아이템를 클래스 생성
            플레이어는 아이템을 사용할 수 있도록 상호구현 구현
            아이템을 상속받는 클래스가 사용에 대해서 구현하도록
            포션, 해독초
         */

        public abstract class Item
        {
            public string name;

            public abstract void UseItem();
        }

        public class Potion : Item
        {
            public override void UseItem()
            {

            }
        }

        public class Herb : Item
        {
            public override void UseItem()
            {

            }
        }



    }
}
