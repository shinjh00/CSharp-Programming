using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    public class Inheritance
    {

        // 부모 클래스
        public class Monster
        {
            public string name;
            public int hp;

            public void TakeHit(int damage)
            {
                hp -= damage;
                Console.WriteLine($"[{name}]이 {damage}의 데미지를 받아 체력이 {hp}이 되었습니다.");
            }
        }

        // 자식 클래스
        public class Dragon : Monster
        {
            // 생성자
            public Dragon()
            {
                name = "용";
                hp = 100;
            }

            // 자식 클래스에서 추가 기능 구현
            public void Breath()
            {
                Console.WriteLine($"[{name}]이 화염을 뿜습니다.");
            }
        }

        // 자식 클래스
        public class Slime : Monster
        {
            // 생성자
            public Slime()
            {
                name = "슬라임";
                hp = 50;
            }
        }

        public class Hero
        {
            string name = "용사";
            int damage = 3;

            public void Attack(Monster monster)
            {
                Console.WriteLine($"[{name}]이/가 [{monster.name}]에게 {damage}만큼의 공격을 했습니다.");
                monster.TakeHit(damage);
            }
        }

        static void Main1()
        {
            Dragon dragon = new Dragon();
            Console.WriteLine($"{dragon.name}, {dragon.hp}");
            dragon.TakeHit(10);
            dragon.Breath();

            Console.WriteLine();

            Slime slime = new Slime();
            Console.WriteLine($"{slime.name}, {slime.hp}");
            slime.TakeHit(5);

            Console.WriteLine();

            Hero hero = new Hero();
            hero.Attack(dragon);
            hero.Attack(slime);

            Console.WriteLine();

            // 업캐스팅 : 자식 클래스를 부모 클래스에 보관 (묵시적 형변환)
            Monster monster1 = new Dragon();
            Monster monster2 = new Slime();
            monster1.TakeHit(10);
            //monster1.Breath();  // 업캐스팅 한 경우 부모 클래스에는 없고 자신만 가진 기능은 불가능

            // 다운캐스팅 : 부모 클래스를 자식 클래스에 보관 (강제 형변환) (위험부담이 있음)
            Dragon dra = (Dragon)monster1;  // 100%인 경우에만 진행
            //Slime sli = (Slime)monster1;  // 빨간줄은 안뜨는데 캐스팅할 수 없으므로 에러남

            if (monster1 is Dragon)
            {
                Dragon d = (Dragon)monster1;  // monster1이 Dragon이 맞을때만 형변환 하도록 할 수 있음
                Console.WriteLine("monster1은 드래곤이 맞습니다.");
            }
            else
            {
                Console.WriteLine("monster1은 드래곤이 아닙니다.");
            }
            
            if (monster2 is Dragon)
            {
                Console.WriteLine("monster2는 드래곤이 맞습니다.");
            }
            else
            {
                Console.WriteLine("monster2는 드래곤이 아닙니다.");
            }

            Dragon asDragon = monster1 as Dragon;  // 위의 if문을 축약한 문법 (되면 해주고 안되면 null 반환)
            Console.WriteLine(asDragon);  // Dragon 클래스라는 내용이 뜸
            Console.WriteLine(monster1.name);  // Dragon.name 즉, '용'이 뜸
            Slime asSlime = monster1 as Slime;
            Console.WriteLine(asSlime);  // null이라서 빈칸출력
        }

    }
}
