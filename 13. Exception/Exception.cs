namespace _13._Exception
{
    class Exception
    {
        /****************************************************************
         * 예외처리 (Exception Handling)
         *
         * 프로그램 동작 도중 발생하는 의도하지 않은 상황을 처리하는 방법
         ****************************************************************/

        // <조건문을 통한 예외처리>
        // 프로그램이 중단될 수 있을만한 처리를 조건문을 통해 진행할 수 없도록 제한
        // 가장 좋은 예외처리 방법은 처음부터 예외가 발생할 수 없도록 설계하는 것
        // 예외처리에 너무 떠넘기지말고 애초에 예외를 예방하여 코딩하는 습관이 더 좋을듯
        void Main1()
        {
            int value1 = 10;
            int value2 = 0;

            // 만약 value2가 0인 경우 예외처리를 진행하지 않으면 프로그램이 중단됨
            // 아래의 조건문을 통해 프로그램이 중단되는 상황에 대한 예외처리를 진행
            if (value2 != 0)
            {
                double result = value1 / (double)value2;
                Console.WriteLine($"결과는 {result}");
            }
            else
            {
                Console.WriteLine("0 으로 나눌 수 없습니다.");
            }
        }


        // <try catch 예외처리>
        // 예외가 발생할 수 있는 구문을 지정하고 진행중 예외가 발생할 경우 발생한 예외를 처리하는 구문을 작성
        // try : 예외발생에 대한 검사의 범위를 지정하는 블록
        // catch : 발생한 예외를 처리하는 블록
        static void Mains()
        {
            try
            {
                // try 구문 수행중 처리할 수 없는 예외상황 발생시
                // catch 구문중 처리할 수 있는 예외처리 부분이 실행됨

                Console.Write("수를 입력하세요 : ");
                string input = Console.ReadLine();

                int value = int.Parse(input);
                int[] array = new int[value];

                array[10] = 10;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("입력값이 정수로 변환이 불가한 경우 예외 발생");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("입력값으로 배열을 만들 수 없는 경우 예외 발생");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("입력값이 10 이하인 경우 [10] 인덱스 접근이 불가하여 예외 발생");
            }
            /*catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("모든 예외 상황을 확인하고 예외 발생시 처리");
            }*/
        }





    }
}
