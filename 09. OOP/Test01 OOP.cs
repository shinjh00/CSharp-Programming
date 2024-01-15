using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    class Test01_OOP
    {

        class Driver
        {
            public string name;

            public void Ride(Car car)
            {
                if (car.alterSpeed > 0)
                {
                    Console.WriteLine($"[{this.name}]이/가 [{car.name}]의 가속페달을 밟았습니다.");
                    car.Acceleration();
                }
                else if (car.alterSpeed < 0)
                {
                    Console.WriteLine($"[{this.name}]이/가 [{car.name}]의 브레이크를 밟았습니다.");
                    car.Deceleration();
                }
                else if (car.alterSpeed == 0)
                {
                    Console.WriteLine($"[{this.name}]의 속도가 유지됩니다.");
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
        }

        class Car
        {
            public string name;
            public int speed = 0;
            public int alterSpeed;

            public void Acceleration()
            {
                speed += alterSpeed;
                if (speed > 120)
                {
                    speed = 120;  // maxSpeed 고정해주기
                }
                Console.WriteLine($"[{this.name}]의 속도 {alterSpeed} 증가 (현재 속도 : {this.speed})");
            }

            public void Deceleration()
            {
                speed += alterSpeed;
                if (speed < 0)
                {
                    speed = 0;  // 음수 안나오도록 고정
                }
                Console.WriteLine($"[{this.name}]의 속도가 {alterSpeed} 감소 (현재 속도 : {this.speed})");
            }
        }

        static void Main1(string[] args)
        {
            Driver driver = new Driver();
            Car car = new Car();

            driver.name = "트럭기사";
            car.name = "트럭";


            bool rideYN = true;

            while (rideYN)
            {
                Console.WriteLine("== 가속: (숫자) 입력 / 감속: -(숫자) 입력 / 운행 종료: 'stop' 입력 ==");
                Console.Write("속도 변화 : ");
                string input = Console.ReadLine();

                if (input == "stop")
                {
                    rideYN = false;
                    Console.WriteLine("운행이 종료됩니다.");
                }
                else
                {
                    int.TryParse(input, out car.alterSpeed);
                    driver.Ride(car);
                    Console.WriteLine();
                }
            }

        }

    }
}
