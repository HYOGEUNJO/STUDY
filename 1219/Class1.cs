using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1219
{
    internal class Program2
    {
        //static void Main(string[] args)
        {
            // 최대한도 사탕사기(금액은 유저입력 , 사탕 가격 300원(상수) , 살 수 있는 사탕 개수와 나머지 금액 출력)
            const int candyPrice = 300;
            Console.Write("돈 얼마 가지고 왔니? : ");
            string money = Console.ReadLine();
            Console.WriteLine("살 수 있는 사탕의 개수 : {0}\n나머지 돈 : {1}", int.Parse(money) / candyPrice, int.Parse(money) % candyPrice);

            Console.WriteLine("\n");
            // 화씨 온도를 섭씨 온도로 바꾸기
            Console.Write("화씨 몇도? : ");
            string fahrenheit = Console.ReadLine();
            Console.WriteLine("섭씨 : {0}", ((float.Parse(fahrenheit) - 32) * 5 / 9));
            
            // 새로운 입력 방법 **
            float input = default;
            float.TryParse(Console.ReadLine(), out input);
            Console.WriteLine(input);


            Console.WriteLine("\n");
            // 2개의 주사위를 던져서 주사위의 합을 표시하는 프로그램을 작성, 주사위는 랜덤한 수여야 한다.
            Random rand = new Random();
            int randomNum1 = rand.Next(1, 6 + 1);
            int randomNum2 = rand.Next(1, 6 + 1);
            Console.WriteLine("첫번째 주사위 : {0}", randomNum1);
            Console.WriteLine("두번째 주사위 : {0}", randomNum2);
            Console.WriteLine("두 주사위의 합 : {0}", randomNum1 + randomNum2);
            // random 함수
            Random ranInt = new Random();
            Console.WriteLine(ranInt.Next(1, 7));
            Console.WriteLine(ranInt.Next(1, 7));
            // -seed 값-
            Random rand2 = new Random(100); // 시드값 고정시 랜덤값이 고정된다.
            int ranInt3 = rand2.Next();
            int ranInt4 = rand2.Next();
            Console.WriteLine("{0}, {1}", ranInt3, ranInt4); 










        }

    }
}
