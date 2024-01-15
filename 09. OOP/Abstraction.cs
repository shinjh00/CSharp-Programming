using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    class Abstraction
    {

        public abstract class Animal
        {
            public string name;
            public int age;

            public abstract void Cry();  // 추상 함수가 하나라도 있으면 상위 클래스를 추상 클래스로 만드는게 좋음
            // 동물이 우는 소리는 다 다르니까 지금 당장 구현할 수 없어 일단 만들어 놓기
        }

        public class Cat : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("야옹");
            }
        }

        public class Dog : Animal
        {
            public override void Cry()
            {
                Console.WriteLine("멍멍");
            }
        }

        static void Main1()
        {
            Animal cat = new Cat();
            Animal dog = new Dog();

            cat.Cry();
            dog.Cry();
        }


        public abstract class Item
        {
            public abstract void Use();
        }

        public class Potion : Item
        {
            public override void Use()
            {
                Console.WriteLine("포션 사용 >> 체력 회복");
            }
        }

        public class Player
        {
            public void Use(Item item)
            {
                item.Use();
            }
        }

        static void Main2()
        {
            Item potion = new Potion();
            potion.Use();

            Player player = new Player();
            player.Use(potion);
        }

    }
}
