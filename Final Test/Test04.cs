using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /* 주어진 두 배열에서 공통항목을 찾는 함수를 작성 ( 단, 중복은 허용하지 않음 ) */

    class Test04
    {
        public static int[] FindCommonItems(int[] array1, int[] array2)
        {
            List<int> resultList = new List<int>();
            
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        if (resultList.Contains(array1[i]) == false)
                        {
                            resultList.Add(array1[i]);
                        }
                    }
                }
            }

            int[] result = resultList.ToArray();

            return result;
        }

        static void Main0(string[] args)
        {
            Console.Write("첫 번째 배열을 입력하세요. (ex. 1, 5, 5, 10) : ");
            string input1 = Console.ReadLine();
            Console.Write("두 번째 배열을 입력하세요. (ex. 3, 5, 5, 10) : ");
            string input2 = Console.ReadLine();

            Console.WriteLine($"int[] array1 = {{ {input1} }}");
            Console.WriteLine($"int[] array2 = {{ {input2} }}");

            string[] str1 = input1.Split(", ");
            string[] str2 = input2.Split(", ");

            int[] array1 = new int[str1.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                int.TryParse(str1[i], out array1[i]);
            }
            int[] array2 = new int[str2.Length];
            for (int i = 0; i < str2.Length; i++)
            {
                int.TryParse(str2[i], out array2[i]);
            }

            int[] result = FindCommonItems(array1, array2);

            if (result.Length == 0)
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine($"{{ {string.Join(", ", result)} }}");
            }
        }
    }
}
