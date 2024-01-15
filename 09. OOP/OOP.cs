namespace _09._OOP
{
    class OOP
    {

        class Player
        {
            public int hp = 100;
            public int damage = 20;

            public void Attack(Monster monster)
            {
                monster.TakeHit(damage);
            }

            public void Use(Potion potion)
            {
                potion.Use(this);  // this = player
            }
        }

        class Monster
        {
            public int hp = 50;

            public void TakeHit(int damage)
            {
                hp -= damage;
                Console.WriteLine($"몬스터가 {damage}의 데미지를 입어 체력이 {hp}가 되었습니다.");
            }
        }

        class Potion
        {
            public int regen = 10;

            public void Use(Player user)
            {
                user.hp += regen;
                Console.WriteLine($"Potion을 사용해 플레이어의 체력이 {regen} 회복하여 {user.hp}가 되었습니다.");
            }
        }

        static void Main1(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();
            Potion potion = new Potion();

            player.Attack(monster);

            player.Use(potion);
        }
    }
}
