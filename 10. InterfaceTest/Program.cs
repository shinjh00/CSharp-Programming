namespace _10._InterfaceTest
{
    class Program
    {
        // 발견하는 기능
        public interface IDiscoverable
        {
            public void Discover(string name);
        }

        // 들어가는 기능
        public interface IEnterable
        {
            public void Enter(string name);
        }

        // 물체를 여는 기능
        public interface IOpenable
        {
            public void Open();
        }

        // 물체를 내려놓는 기능
        public interface IPutDown
        {
            public void PutDown(string name);
        }

        // 탑승물을 타는 기능
        public interface IRideable
        {
            public void Ride(string name);
        }

        /* 마을 */
        public class Town : IEnterable
        {
            string name = "마을";

            public void Enter(string name)
            {
                Console.WriteLine($"[{name}]가 [{this.name}]에 진입했습니다.");
            }
        }

        /* 집 */
        public class House : IDiscoverable, IOpenable, IEnterable
        {
            string name = "집";

            public void Discover(string name)
            {
                Console.WriteLine($"[{name}]가 [{this.name}]을 발견했습니다.");
            }

            public void Open()
            {
                Console.WriteLine($"[{this.name}] 문을 엽니다.");
            }

            public void Enter(string name)
            {
                Console.WriteLine($"[{name}]가 [{this.name}]으로 들어갑니다.");
            }
        }

        /* 상자 */
        public class Box : IDiscoverable, IOpenable
        {
            string name = "상자";

            public void Discover(string name)
            {
                Console.WriteLine($"[{name}]가 [{this.name}]를 발견했습니다.");
            }

            public void Open()
            {
                Console.WriteLine($"[{this.name}]를 열었더니 아이템이 나왔습니다.");
            }
        }

        /* 탑승물(차) */
        public class RideObject : IPutDown, IOpenable, IRideable
        {
            public string name = "차";

            public void PutDown(string name)
            {
                Console.WriteLine($"[{name}]가 [{this.name}]를 꺼내서 내려놓습니다.");
            }

            public void Open()
            {
                Console.WriteLine($"[{this.name}] 문을 엽니다.");
            }

            public void Ride(string name)
            {
                Console.WriteLine($"[{name}]가 [{this.name}]에 탑승합니다.");
            }
        }

        /* 플레이어 */
        public class Player
        {
            string name = "모험가";

            public void Discover(IDiscoverable discoverable)
            {
                discoverable.Discover(name);
            }
            public void Enter(IEnterable enterable)
            {
                enterable.Enter(name);
            }
            public void Open(IOpenable openable)
            {
                openable.Open();
            }
            public void PutDown(IPutDown putdown)
            {
                putdown.PutDown(name);
            }
            public void Ride(IRideable rideable)
            {
                rideable.Ride(name);
            }
        }

        static void Main(string[] args)
        {

            Player player = new Player();

            Town town = new Town();
            player.Enter(town);

            Console.WriteLine();

            House house = new House();
            player.Discover(house);
            player.Open(house);
            player.Enter(house);

            Console.WriteLine();

            Box box = new Box();
            player.Discover(box);
            player.Open(box);

            Console.WriteLine();

            RideObject rideObject = new RideObject();
            player.PutDown(rideObject);

            int input;
            do
            {
                Console.WriteLine($">> [{rideObject.name}] 문을 여시겠습니까? ( 1-연다  2-열지않는다 )");
                int.TryParse(Console.ReadLine(), out input);

                if (input == 1)
                {
                    player.Open(rideObject);
                    player.Ride(rideObject);
                }
                else if (input == 2)
                {
                    Console.WriteLine("문을 열지 않았습니다.\n");
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.\n");
                }
            } while (input != 1);

        }
    }
}
