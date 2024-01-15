using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09._OOP
{
    class Encapsulation
    {

        /* 접근 제한자 */

        public class AccessModifier
        {
            public int publicValue;
            private int privateValue;

            void Function()  // private
            {
                publicValue = 1;
                privateValue = 2;
            }
        }

        static void Main1()
        {
            AccessModifier modifier = new AccessModifier();
            //modifier.Function();  // 접근 불가능
            modifier.publicValue = 3;  // 접근 가능
            //modifier.privateValue = 4;  // 접근 불가능
            Console.WriteLine(modifier.publicValue);
        }


        /* 정보 은닉 */

        class Bank
        {
            int balance;  // 기본 접근 제한자 private

            public void Deposit(int money)
            {
                balance += money;
            }

            public void Withdrawal(int money)
            {
                balance -= money;
            }

            public void Check()
            {
                Console.WriteLine(balance);
            }
        }

        static void Main2()
        {
            Bank bank = new Bank();

            // 외부에서 Bank의 balance에 직접적으로 접근 불가
            //bank.balance = 0;

            // 외부에서는 Bank에서 의도한 Deposit, Withdrawal를 통해 balance를 다루도록 유도
            bank.Deposit(30000);
            bank.Withdrawal(10000);

            bank.Check();
        }


        /* 캡슐화 사용의미 1 */

        class VeryComplicatedObject
        {
            // 캡슐화된 클래스의 private은 외부에서 접근불가하므로 사용할 수 없음
            int veryComplicatedValue1;
            int veryComplicatedValue2;
            int veryComplicatedValue3;

            void VeryComplicatedFunction1() { }
            void VeryComplicatedFunction2() { }
            void VeryComplicatedFunction3() { }

            // 캡슐화된 클래스의 public은 외부에서 접근가능하므로 사용을 권장하는 기능
            public void UseThisFunction() { }
        }

        /* 캡슐화 사용의미 2 */

        class IntArray
        {
            int[] array = new int[10];  // array에 직접 접근 불가

            public void SetValue(int index, int value)  // SetValue를 이용해서 array를 다뤄야 함
            {
                if (index < 0 || index >= 10)
                    return;

                array[index] = value;
            }
        }

    }
}
