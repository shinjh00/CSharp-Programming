using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional_Test
{
    class Property_Event
    {
        public class Player
        {
            private int hp;

            public event Action<int> OnChangeHP;

            public int HP
            {
                get { return hp; }
                set
                {
                    hp = value;
                    Console.WriteLine($"플레이어 체력이 {hp}이 됩니다.");

                    if (OnChangeHP != null)
                    {
                        OnChangeHP( value );
                    }
                }
            }
        }

        static void Main1()
        {
            Player player = new Player();
            UI ui = new UI();

            // 이벤트 매핑
            player.OnChangeHP += ui.HpUi;
            player.HP = 20;
            player.HP = 30;
            player.HP = 50;
        }

        public class UI
        {
            public void HpUi(int hp)
            {
                Console.WriteLine($"UI 체력바가 {hp}이 됩니다.");
            }
        }
    }
}
