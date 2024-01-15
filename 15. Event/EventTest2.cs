using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._Event
{
    class EventTest2
    {
        /*
         방어구의 내구도 시스템을 구현해보자
	     플레이어가 방어구를 착용하고, 플레이어 피격시마다 내구도가 1감소하도록 구현.
    	 내구도가 0이 되면 방어구가 해제되도록 구현하자.
         */

        public class Player
        {
            // 이벤트 구현
            public Action OnTakeDamage;

            public void Equip(Equipment equipment)
            {
                // 방어구 착용 구현
                Console.WriteLine("플레이어가 방어구를 착용했습니다.\n");
                equipment.Equip(this);
            }

            public void UnEquip(Equipment equipment)
            {
                // 방어구 해제 구현
                Console.WriteLine("플레이어의 방어구가 해제되었습니다.");
                //equipment.UnEquip(this);
            }

            public void TakeDamage(int damage)
            {
                // 이벤트 발생 구현
                Console.WriteLine("플레이어가 데미지를 받았습니다.");

                if (OnTakeDamage != null)
                    OnTakeDamage();
            }
        }
        
        public class Equipment
        {
            Player owner;  // 방어구
            int durability = 5;  // 내구도

            public event Action<int> OnChangeDu;

            public void Equip(Player owner)
            {
                // 방어구 착용시 반응 구현
                this.owner = owner;
                this.owner.OnTakeDamage += OnDamage;
            }
            
            public void UnEquip(Player owner)
            {
                // 방어구 해제시 반응 구현
                this.owner.OnTakeDamage -= OnDamage;
                this.owner = null;
            }

            public void OnDamage()
            {
                // 피격시 행동 구현
                durability--;
                Console.WriteLine($"방어구의 내구도가 1 감소해 {durability}이 되었습니다.\n");

                if (durability <= 0)
                {
                    Console.WriteLine("방어구가 파괴됩니다.");
                    this.owner.UnEquip(this);
                }
            }
        }

        static void Main()
        {
            Player player = new Player();
            Equipment equipment = new Equipment();

            player.Equip(equipment);

            player.TakeDamage(1);
            player.TakeDamage(1);
            player.TakeDamage(1);
            player.TakeDamage(1);
            player.TakeDamage(1);

            equipment.OnChangeDu += player.TakeDamage;
        }
    }
}
