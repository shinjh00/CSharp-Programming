namespace _10._Interface
{
    class Interface
    {

        public interface IEnterable
        {
            public void Enter();
        }

        public interface IOpenable
        {
            public void Open();
        }

        public class Box : IOpenable
        {
            public void Open()
            {
                Console.WriteLine("박스를 엽니다.");
            }
        }

        public class Door : IOpenable, IEnterable
        {
            public void Open()
            {
                Console.WriteLine("문을 엽니다.");
            }
            public void Enter()
            {
                Console.WriteLine("문에 들어갑니다.");
            }
        }

        public class Town : IEnterable
        {
            public void Enter()
            {
                Console.WriteLine("마을에 진입합니다.");
            }
        }

        public class Player
        {
            public void Open(IOpenable openable)
            {
                Console.WriteLine("플레이어가 대상을 열기를 시도합니다.");
                openable.Open();
            }

            public void Enter(IEnterable enterable)
            {
                Console.WriteLine("플레이어가 대상에 들어가기를 시도합니다.");
                enterable.Enter();
            }
        }

        static void Main(string[] args)
        {
            Player player = new Player();
            Box box = new Box();
            Town town = new Town();

            player.Open(box);
            player.Enter(town);

            Door door = new Door();

            player.Open(door);
            player.Enter(door);
        }
    }
}
