namespace _02._Operator_Test
{
    class Stat
    {
        /* 챔피언 스탯 관리 */
        /* 스킬 사용 시 스탯 변화 구현 */

        static void Main(string[] args)
        {
            /* 구분 : 기본능력(레벨당상승) : 최종수치 */

            // 체력 : 690(+98) : 2356
            float health = 690;
            const int hIncPerLevel = 98;

            // 체력 재생 : 8(+0.5) : 16.5
            float healthRegen = 8;
            const float hrIncPerLevel = 0.5f;

            // 공격력 : 69(+4.5) : 145.5
            float attackDamage = 69;
            const float adIncPerLevel = 4.5f;

            // 공격 속도 : 0.625(+3.65%) : 1.013
            float attackSpeed = 0.625f;
            const float asIncPerLevel = 3.65f * 0.01f;

            // 방어력 : 38(+4.2) : 109.4
            float armor = 38;
            const float aIncPerLevel = 4.2f;

            // 마법 저항력 : 32(+1.55) : 58.35
            float magicResist = 32;
            const float mrIncPerLevel = 1.55f;

            // 사거리 : 175 : 175
            float attackRange = 175;

            // 이동 속도 : 340 : 340
            float moveSpeed = 340;


            /******************
             캐릭터 레벨 설정
            ******************/
            int level;
            Console.Write("* 캐릭터 레벨 입력 : ");
            int.TryParse(Console.ReadLine(), out level);
            Console.WriteLine($"** 캐릭터의 레벨은 {{{level}}}입니다.\n");


            /************************
             레벨 설정에 따른 스탯
            ************************/
            Console.WriteLine($"=== 가렌 스탯 Level.{level} ===");

            health += hIncPerLevel * (level - 1);
            Console.WriteLine($"체력 : {health}");

            healthRegen += hrIncPerLevel * (level - 1);
            Console.WriteLine($"체력 재생 : {healthRegen}");

            attackDamage += adIncPerLevel * (level - 1);
            Console.WriteLine($"공격력 : {attackDamage}");

            attackSpeed += asIncPerLevel * (level - 1);
            Console.WriteLine($"공격 속도 : {attackSpeed}");

            armor += aIncPerLevel * (level - 1);
            Console.WriteLine($"방어력 : {armor}");

            magicResist += mrIncPerLevel * (level - 1);
            Console.WriteLine($"마법 저항력 : {magicResist}");

            Console.WriteLine($"사거리 : {attackRange}");

            Console.WriteLine($"이동 속도 : {moveSpeed}\n");


            /************
             전투 시작
            ************/
            // W스킬을 제외하고 모든 스킬 효과는 1회만 적용
            // 다른 스킬 사용 전에 기존 값으로 돌아옴

            Console.WriteLine("*** 전투 시작 ***\n");

            Console.WriteLine("공격을 받았습니다. (체력 -100)");
            health -= 100;
            Console.WriteLine("공격을 받았습니다. (체력 -100)");
            health -= 100;
            Console.WriteLine("공격을 받았습니다. (체력 -50)");
            health -= 50;
            Console.WriteLine($"체력 : {health}\n");


            /* 패시브 스킬 */
            // 최대 체력의 1.5% 만큼 회복

            Console.WriteLine(">> 패시브 스킬 발동");

            health += health * 0.015f;
            Console.WriteLine($"체력 : {health}\n");


            /* Q 스킬 사용 */
            // 이동 속도 35% 증가
            // 기본 공격 증가 : 총 피해량 = 30 + (1.5 * 총 공격력)

            Console.WriteLine(">> Q 스킬 사용");

            float qMoveSpeed = moveSpeed + (moveSpeed * 0.35f);
            float qAttackDamage = 30 + (1.5f * attackDamage);
            Console.WriteLine($"이동 속도 : {qMoveSpeed}");
            Console.WriteLine($"공격력 : {qAttackDamage}\n");


            /* W 스킬 사용 */
            // 유닛을 처치하면 영구적으로 0.2의 방어력과 0.2의 마법 저항력이 부여됨

            Console.WriteLine(">> W 스킬 사용");

            armor += (0.2f * armor);
            magicResist += (0.2f * magicResist);
            Console.WriteLine($"방어력 : {armor}");
            Console.WriteLine($"마법 저항력 : {magicResist}\n");


            /* E 스킬 사용 */
            // 사거리 = 325
            // 총 피해량 = 4 + (0.32 * 총 공격력)

            Console.WriteLine(">> E 스킬 사용");

            attackRange = 325;
            float eAttackDamage = 4 + (0.32f * attackDamage);
            Console.WriteLine($"사거리 : {attackRange}");
            Console.WriteLine($"공격력 : {eAttackDamage}\n");


            /* R 스킬 사용 */
            // 사거리 = 400
            // 총 피해량 = 150 + 대상이 잃은 체력(100이라고 가정)의 25%

            Console.WriteLine(">> R 스킬 사용");

            attackRange = 400;
            float rAttackDamage = 150 + (100 * 0.25f);
            Console.WriteLine($"사거리 : {attackRange}");
            Console.WriteLine($"공격력 : {rAttackDamage}\n");

            Console.WriteLine("*** 전투 끝 ***\n");
        }
    }
}
