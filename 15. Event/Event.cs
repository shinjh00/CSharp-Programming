namespace _15._Event
{
    class Event
    {
        /****************************************************************
         * 이벤트 (Event)
         * 
         * 일련의 사건이 발생했다는 사실을 다른 객체에게 전달
         * 델리게이트의 일부 기능을 제한하여 이벤트의 용도로 사용
         ****************************************************************/

        // 예를 들어 플레이어가 공격을 당해 데미지를 받았을 경우
        // 그걸 알리면
        // 체력바 게이지 줄어듦, 사운드 피격음 재생, 이펙터 반짝거리기
        // 등의 현상이 일어날 수 있음
        // 그럴 때 이벤트가 발생했음을 알리는 기능
        // 콜백을 여러 대상에게 전달하는 셈


        // <이벤트 선언>
        // 델리게이트 변수 앞에 event 키워드를 추가하여 이벤트로 선언
        public class Player
        {
            private int hp;

            public event Action OnGetCoin;      // 이벤트
            public Action OnDamaged;      // 델리게이트

            public Action OnDied;
            private void Die()
            {
                if (OnDied != null)
                {
                    OnDied();
                }
            }

            public void GetCoin()
            {
                Console.WriteLine("플레이어가 코인을 얻음");

                if (OnGetCoin != null)
                    OnGetCoin();        // 일련의 사건이 발생했을 때 이벤트 발생
            }

            public void GetDamage()
            {
                Console.WriteLine("플레이어가 데미지를 받음");

                if (OnDamaged != null)
                {
                    OnDamaged();        // 일련의 사건이 발생했을 때 이벤트 발생
                }
            }
        }


        // <이벤트 등록 & 해제>
        // 이벤트에 반응할 객체의 추가할 함수를 += 연산자를 통해 참조 추가
        // 이벤트에 반응할 객체의 제거할 함수를 -= 연산자를 통해 참조 제거
        static void Main1()
        {
            Player player = new Player();
            UI ui = new UI();
            SFX sfx = new SFX();
            VFX vfx = new VFX();

            // 이벤트에 반응할 객체의 함수 추가
            player.OnGetCoin += ui.CoinUI;
            player.OnGetCoin += sfx.CoinSound;

            // 원래같으면 이렇게 했을것을
            //player.GetCoin();
            //ui.CoinUI();
            //sfx.CoinSound();

            // 일련의 사건이 발생했을 때 이벤트를 통한 반응
            player.GetCoin();
            // 플레이어가 코인을 얻음
            // UI에 코인수를 갱신
            // 코인을 얻는 효과음 재생

            // 이벤트 방식으로 코드 수정없이 이벤트시 반응할 객체를 추가 가능
            player.OnGetCoin += vfx.CoinEffect;

            player.GetCoin();
            // 플레이어가 코인을 얻음
            // UI에 코인수를 갱신
            // 코인을 얻는 효과음 재생
            // 코인을 얻는 반짝거리는 효과

            // 이벤트 방식으로 코드 수정없이 이벤트시 반응할 객체를 제거 가능
            player.OnGetCoin -= sfx.CoinSound;

            player.GetCoin();
            // 플레이어가 코인을 얻음
            // UI에 코인수를 갱신
            // 코인을 얻는 반짝거리는 효과


            // <문제점>
            // 1. 델리게이트 체인 = (대입) 가능
            // 이전에 담겨있던 이벤트들이 싹 사라질 수 있음
            //player.OnGetCoin = sfx.CoinSound;

            // 2. 이벤트 발생이 외부에서 가능
            // 외부에서 함부로 호출할 수 있음
            //player.OnGetCoin();

            // 단순히 델리게이트 체인으로 구현하기엔 위의 1, 2 문제점이 있는데
            // 그것을 방지하기 위해 event를 붙이면
            // 1. = (대입) 불가능 (+=, -= 밖에 못 씀)
            // 2. 외부에서 호출할 수 없음

        }

        public class UI
        {
            public void CoinUI() { Console.WriteLine("UI에 코인수를 갱신"); }
        }

        public class SFX
        {
            public void CoinSound() { Console.WriteLine("코인을 얻는 효과음 재생"); }
        }

        public class VFX
        {
            public void CoinEffect() { Console.WriteLine("코인을 얻는 반짝거리는 효과"); }
        }


        // <델리게이트 체인과 이벤트의 차이점>
        // 델리게이트 또한 체인을 통하여 이벤트로서 구현이 가능
        // 하지만 델리게이트는 두가지 사항 때문에 이벤트로서 사용하기 적합하지 않음
        // 1. = 대입연산을 통해 기존의 이벤트에 반응할 객체 상황이 초기화 될 수 있음
        // 2. 클래스 외부에서 이벤트를 발생시켜 원하지 않는 상황에서 이벤트 발생 가능
        // event 키워드를 추가할 경우 델리게이트에서 위 두가지 기능을 제한하여 이벤트 전용으로 사용을 유도할 수 있음
        // 즉, event 변수는 델리게이트에서 기능을 제한하여 이벤트 전용의 기능만으로 사용하는 기능

        public class EventSender
        {
            public Action OnDelegate;
            public event Action OnEvent;

            public void DelegateCall()
            {
                if (OnDelegate != null)
                    OnDelegate();
            }

            public void EventCall()
            {
                if (OnEvent != null)
                    OnEvent();
            }
        }

        public class EventListener
        {
            public void ReAction() { }
        }

        void Main2()
        {
            EventSender sender = new EventSender();
            EventListener listener1 = new EventListener();
            EventListener listener2 = new EventListener();
            EventListener listener3 = new EventListener();

            // 제한사항 1. 이벤트 변수는 = 대입연산 불가

            // 델리게이트는 대입연산이 가능하여, 이벤트에 반응할 객체들의 상황을 잃을 문제점이 있음
            sender.OnDelegate += listener1.ReAction;
            sender.OnDelegate += listener2.ReAction;
            sender.OnDelegate = listener3.ReAction;     // 주의! 기존의 이벤트에 반응할 객체들이 초기화됨

            // 이벤트는 대입연산이 불가하여, 이벤트에 반응할 객체들의 상황을 온전히 유지 가능
            sender.OnEvent += listener1.ReAction;
            sender.OnEvent += listener2.ReAction;
            // sender.OnEvent = listener3.ReAction;     // error : 이벤트는 = 대입연산 불가


            // 제한사항 2. 이벤트 변수는 클래스 외부에서 호출 불가

            // 델리게이트는 외부에서 호출이 가능하여, 객체가 일련의 사건이 발생하지 않아도 이벤트 발생이 진행될 문제점이 있음
            sender.OnDelegate();                        // 주의! 일련의 사건이 발생하지 않아도 이벤트 발생이 가능

            // 이벤트는 외부에서 호출이 불가하여, 객체가 일련의 사건이 발생한 경우에서만 내부에서 이벤트 발생 보장이 가능
            // sender.OnEvent();                        // error : 이벤트는 외부에서 호출 불가
        }

    }
}
