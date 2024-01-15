using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    class Polymorphism
    {

        /* 다형성 (변수) */

        class Car
        {
            protected string name;
            protected int speed;

            public void Move()
            {
                Console.WriteLine($"{name} 이/가 {speed} 의 속도로 이동합니다.");
            }
        }

        class Truck : Car
        {
            public Truck()
            {
                name = "트럭";
                speed = 30;
            }
        }

        class SportCar : Car
        {
            public SportCar()
            {
                name = "스포츠카";
                speed = 100;
            }
        }

        static void Main1()
        {
            Car car1 = new Truck();
            Car car2 = new SportCar();

            car1.Move();
            car2.Move();
        }


        /* 다형성 (함수) */
        // 변수처럼 그냥 바꾸지는 못함

        public class Skill
        {
            protected float coolTime;

            public virtual void Execute()  // 가상 함수
            {
                Console.WriteLine("스킬 재사용 대기시간을 진행시킴");
            }
        }

        public class FireBall : Skill
        {
            public FireBall()
            {
                coolTime = 3f;
            }

            public override void Execute()  // 오버라이딩
            {
                Console.WriteLine("불덩이 날리기");
            }
        }

        public class Heal : Skill
        {
            public Heal()
            {
                coolTime = 15f;
            }
        }

        public class Dash : Skill
        {
            public Dash()
            {
                coolTime = 10f;
            }

            public override void Execute()
            {
                base.Execute();  // 부모 클래스의 함수도 같이 실행하고 싶으면 이렇게
                Console.WriteLine("앞으로 전진");
            }
        }

        static void Main2()
        {
            Skill fireBall = new FireBall();
            Skill heal = new Heal();
            Skill dash = new Dash();

            Console.WriteLine("== FireBall ==");
            fireBall.Execute();
            // 부모 클래스의 Execute() 함수 대신에 FireBall에서 재정의한것만 실행됨

            Console.WriteLine("");
            Console.WriteLine("== Heal ==");
            heal.Execute();
            // 오버라이딩 없으면 상속 받은 부모 클래스의 Execute()가 실행됨

            Console.WriteLine("");
            Console.WriteLine("== Dash ==");
            dash.Execute();
            // base가 있어서 부모 클래스의 함수도 같이 실행됨

            FireBall fireBall2 = new FireBall();
            Heal heal2 = new Heal();
            Dash dash2 = new Dash();

            Console.WriteLine("");
            Console.WriteLine("== FireBall2 ==");
            fireBall2.Execute();

            Console.WriteLine("");
            Console.WriteLine("== Heal2 ==");
            heal2.Execute();
            
            Console.WriteLine("");
            Console.WriteLine("== Dash2 ==");
            dash2.Execute();
        }

    }
}
