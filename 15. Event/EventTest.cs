using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._Event
{
    class EventTest
    {
        public class Player
        {
            private int totalCoin = 0;

            public event Action OnGetCoin;

            public void GetCoin(int coin)
            {
                totalCoin += coin;
                Console.WriteLine($"<코인 {coin}개를 얻어 총 {totalCoin}개가 되었습니다.>");

                if (OnGetCoin != null)
                    OnGetCoin();

                Console.WriteLine();
            }
        }

        static void Main1()
        {
            Player player = new Player();
            UI ui = new UI();
            SFX sfx = new SFX();
            VFX vfx = new VFX();

            player.OnGetCoin += ui.CoinUI;
            player.OnGetCoin += sfx.CoinSound;
            player.OnGetCoin += vfx.CoinEffect;

            player.GetCoin(5);
            player.GetCoin(7);
            player.GetCoin(10);
        }

        public class UI
        {
            public void CoinUI()
            {
                Console.WriteLine($"> UI의 코인 개수를 갱신");
            }
        }

        public class SFX
        {
            public void CoinSound()
            {
                Console.WriteLine("> 코인을 얻는 소리 띠링~");
            }
        }

        public class VFX
        {
            public void CoinEffect()
            {
                Console.WriteLine("> 코인을 얻는 효과 반짝!");
            }
        }

    }
}
