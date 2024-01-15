namespace _11._Array
{
    class Array
    {
        static void Main(string[] args)
        {

            /* 배열 기본 */

            int[] scores = new int[5];

            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[3] = 40;
            scores[4] = 50;

            Console.WriteLine($"배열의 0번째 요소 : {scores[0]}");
            Console.WriteLine($"배열의 1번째 요소 : {scores[1]}");
            Console.WriteLine($"배열의 2번째 요소 : {scores[2]}");
            Console.WriteLine($"배열의 3번째 요소 : {scores[3]}");
            Console.WriteLine($"배열의 4번째 요소 : {scores[4]}");






            /* 배열 */

            int[] exam;  // 배열 선언
            exam = new int[26];  // 배열 초기화
            exam[0] = 99;
            exam[1] = 20;
            exam[2] = 60;
            Console.WriteLine(exam[0]);
            Console.WriteLine(exam[2]);

            float[] fArray = { 1.1f, 2.2f, 3.3f };  // 배열의 선언과 초기화
            // { }로 대입하려면 선언과 동시에 초기화. 배열의 크기는 초기화 한 개수만큼 자동으로 생성
            Console.WriteLine(fArray[1]);

            int[,] matrix = new int[5, 10];  // 2차원 배열
            int[,] matrix2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };  // 2차원 배열

            int[,,] cube = new int[3, 5, 20];  // 3차원 배열



        }
    }
}
