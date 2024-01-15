using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._Additional_Test
{
    class Property
    {
        public class Player
        {
            private int hp;

            public int HP { get; private set; } = 100;
        }

        static void Main1()
        {
            Player player = new Player();
            int playerHP = player.HP;
            Console.WriteLine($"playerHP : {playerHP}");
        }
    }
}
