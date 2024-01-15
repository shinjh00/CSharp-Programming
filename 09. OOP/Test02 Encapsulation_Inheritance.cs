using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    class Test02_Encapsulation_Inheritance
    {

        class Monster
        {
            public string name;
            public int hp;

            public void TakeHit(int damage)
            {
                hp -= damage;
                Console.WriteLine($"[{name}]이/가 공격을 받아 체력이 {hp} 되었습니다.");
            }
        }

        class Orc : Monster
        {
            public Orc()
            {
                name = "오크";
                hp = 100;
            }
            public void anger()
            {
                Console.WriteLine($"[{name}]이/가 분노합니다.");
            }
        }

        class Slime : Monster
        {
            public Slime()
            {
                name = "슬라임";
                hp = 50;
            }
            public void split()
            {
                Console.WriteLine($"[{name}]이/가 분열됩니다.");
            }
        }

        class Dragon : Monster
        {
            public Dragon()
            {
                name = "드래곤";
                hp = 150;
            }
            public void breath()
            {
                Console.WriteLine($"[{name}]이/가 브레스를 뿜습니다.");
            }
        }

        static void Main1(string[] args)
        {
            Orc orc = new Orc();
            Slime slime = new Slime();
            Dragon dragon = new Dragon();

            orc.TakeHit(50);
            orc.anger();

            Console.WriteLine();

            slime.TakeHit(50);
            slime.split();

            Console.WriteLine();

            dragon.TakeHit(50);
            dragon.breath();
        }

    }
}
