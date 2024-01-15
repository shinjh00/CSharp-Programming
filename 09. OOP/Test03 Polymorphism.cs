using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    class Test03_Polymorphism
    {

        public class Skill
        {
            public string name;
            public int coolTime;

            public virtual void Execute(string name, int coolTime)
            {
                Console.WriteLine($"~~ [{name}]스킬 쿨타임 {coolTime} 진행 ~~");
            }
        }

        // 쿨타임 없음
        public class FireBall : Skill
        {
            public FireBall()
            {
                name = "화염구 투척";
                coolTime = 0;
            }

            public override void Execute(string name, int coolTime)
            {
                Console.WriteLine($"[{name}] 화염구를 던집니다.");
            }
        }

        // 쿨타임 5
        public class Heal : Skill
        {
            public Heal()
            {
                name = "체력 회복";
                coolTime = 5;
            }

            public override void Execute(string name, int coolTime)
            {
                Console.WriteLine($"[{name}] 체력을 회복합니다.");
                base.Execute(name, coolTime);
            }
        }

        // 쿨타임 10
        public class Teleport : Skill
        {
            public Teleport()
            {
                name = "순간이동";
                coolTime = 10;
            }

            public override void Execute(string name, int coolTime)
            {
                Console.WriteLine($"[{name}] 순간이동을 합니다.");
                base.Execute(name, coolTime);
            }
        }

        public class Player
        {
            string name;
            
            public Player()
            {
                name = "용사";
            }

            public void UseSkill(Skill skill)
            {
                Console.WriteLine($"[{name}]가 [{skill.name}] 스킬을 사용했습니다.");
                skill.Execute(skill.name, skill.coolTime);
            }
        }

        static void Main(string[] args)
        {
            Skill qSkill = new FireBall();
            Skill wSkill = new Heal();
            Skill eSkill = new Teleport();
            Player player = new Player();

            bool b = true;

            while (b)
            {
                Console.WriteLine("q, w, e 중에 사용할 스킬을 입력하세요. (종료 : x)");

                ConsoleKeyInfo input = Console.ReadKey();
                char skillChoice = Convert.ToChar(input.KeyChar);
                Console.WriteLine();

                if (skillChoice == 'q')
                {
                    player.UseSkill(qSkill);
                }
                else if (skillChoice == 'w')
                {
                    player.UseSkill(wSkill);
                }
                else if (skillChoice == 'e')
                {
                    player.UseSkill(eSkill);
                }
                else if (skillChoice == 'x')
                {
                    b = false;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
                Console.WriteLine();
            }
        }

    }
}
