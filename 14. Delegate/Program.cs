namespace _14._Delegate
{
    internal class Program
    {
        public class Player
        {
            public void Jump()
            {
                Console.WriteLine("점프");
            }
            
            public void Dash()
            {
                Console.WriteLine("대쉬");
            }
        }

        static void Main0(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Player player = new Player();

            Button jumpButton = new Button();
            jumpButton.OnClick = player.Jump;

            jumpButton.Click();
            
            Button dashButton = new Button();
            dashButton.OnClick = player.Dash;

            dashButton.Click();





        }

        public class Button
        {
            public Action OnClick;

            public void Click()
            {
                if (OnClick != null)
                {
                    OnClick();
                }
            }
        }

    }
}
