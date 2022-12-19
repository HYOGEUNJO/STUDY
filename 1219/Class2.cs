using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1219
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            // <제어문 소개>
            // 프로그램을 이루는 3가지의 중요한 제어 구조에는 순차 구조(순차문), 선택 구조(조건문), 반복 구조(반복문)가 있다.

            // -순차문-
            // 프로그램은 기본적으로 Main() 메서드 시작 지점부터 끝 지점까지 코드가 나열되면 순서대로 실행 후 종료한다.

            // -제어문-
            // 프로그램 실행 순서를 제어하거나 프로그램 내용을 반복하는 작업 등을 처리할 때 사용하는 구문으로 조건문과 반복문으로 구분한다.

            // -조건문(선택문)-
            // 조건의 참 또는 거짓에  따라 서로 다른 명령문을 실행할 수 있는 구조이다. 분기문 또는 비교 판단문이라고 하기도 한다.

            // -반복문-
            // 특정 명령문을 지정된 수만큼 반복해서 실행하 때나 조건식이 참일 동안 반복시킬 때 사용한다.

            // <if / else 문>
            // 프로그램 흐름을 여러 가지 갈래로 가지치키(Branching)할 수 있는데, 이때 if 문을 사용한다.
            // if 문은 조건을 비교해서 판단하는 구문으로 if, else if, else 세가지 키워드가 있다.

            // -예제 #1. 두 개의 정수 중에서 더 큰 수를 찾는 프로그램
            int numberX, numberY;
            Console.Write("X 값을 입력하시오 : ");
            int.TryParse(Console.ReadLine(), out numberX);
            Console.Write("Y 값을 입력하시오 : ");
            int.TryParse(Console.ReadLine(), out numberY);
            if (numberY < numberX)
            {
                Console.WriteLine("X가 Y보다 큽니다.");
            }
            else
            {
                Console.WriteLine("Y가 X보다 크거나 같습니다.");
            }

            // -실습 #1. 컵의 사이즈를 받어서 100ml 미만은 small, 100ml 이상 200ml 미만은 medium, 200ml 이상은 large 라고 출력하는 if-else 문을 작성하여라.
            Console.Write("컵의 사이즈를 정수로 입력하시오. : ");
            int cup_size = default;
            int.TryParse(Console.ReadLine(), out cup_size);
            if (cup_size < 1)
            {
                Console.WriteLine("잘못 입력하였습니다.(음수 혹은 '0' 입력)");
            }
            else if (cup_size < 100 && cup_size >= 1)
            {
                Console.WriteLine("small");
            }
            else if (cup_size < 200 && cup_size >= 100)
            {
                Console.WriteLine("medium");
            }
            else
            {
                Console.WriteLine("large");
            }

            // 실습 #2. 비밀 코드 맞추기. 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
            // 비밀코드는 'a' ~ 'z' 사이의 문자
            // 컴퓨터는 사용자의 추측을 읽고서 앞에 있는지, 뒤에 있는지를 알려준다.(즉, 사용자에게 힌트를 준다)
            Random rand = new Random();
            char secretCode = (char)rand.Next(97, 123); //
            Console.WriteLine("정답 : {0}", secretCode);
            char SECRET_CODE = secretCode;
            bool isSmallAlphabet = false;
            bool isBigAlphabet = false;
            bool isAlphabet = false;
            isSmallAlphabet = ('a' <= SECRET_CODE && SECRET_CODE <= 'z');
            isBigAlphabet = ('A' <= SECRET_CODE && SECRET_CODE <= 'Z');
            isAlphabet = isSmallAlphabet || isBigAlphabet;
            if (isAlphabet)
            {
                Console.WriteLine("{0}는 알파벳이 맞습니다.", SECRET_CODE);
            }
            else
            {
                Console.WriteLine("{0}는 알파벳이 아닙니다.", SECRET_CODE);
            }
            while (true)
            {
                Console.WriteLine("'a' 부터 'z' 까지의 알파벳 하나를 입력하세요");
                char answerCode = default;
                char.TryParse(Console.ReadLine(), out answerCode);
                Console.WriteLine("입력하신 알파벳은 {0}입니다.", answerCode);
                if (answerCode == secretCode)
                {
                    Console.WriteLine("정답입니다");
                    break;
                }
                else if (answerCode < secretCode)
                {
                    Console.WriteLine("입력하신 값은 비밀코드 보다 앞쪽에 있는 문자입니다.");
                }
                else
                {
                    Console.WriteLine("입력하신 값은 비밀코드 보다 뒤쪽에 있는 문자입니다.");
                }
            }

            // 실습 #3. 세 개의 정수 중에서 큰 수 찾기
            // split 방법 1.
            Console.WriteLine("3개의 정수를 입력하세요.");
            string inputNum = Console.ReadLine();
            string[] splitInput = inputNum.Split(" ");
            Console.WriteLine("입력하신 세 가지의 정수는 각각 {0} , {1} , {2} 입니다.", splitInput[0], splitInput[1], splitInput[2]);
            int num1 = default;
            int num2 = default;
            int num3 = default;
            int.TryParse(splitInput[0], out num1);
            int.TryParse(splitInput[1], out num2);
            int.TryParse(splitInput[2], out num3);
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("가장 큰 값은 {0}입니다.", num1);
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("가장 큰 값은 {0}입니다.", num2);
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("가장 큰 값은 {0}입니다.", num3);
            }
            Console.WriteLine();

            // split 방법 2.
            Console.WriteLine("3개의 정수를 입력하세요.");
            string[] inputNum2 = Console.ReadLine().Split(" ");
            int[] splitInput2 = Array.ConvertAll(inputNum2, int.Parse);
            Console.WriteLine("입력하신 세 가지의 정수는 각각 {0} , {1} , {2} 입니다.", splitInput2[0], splitInput2[1], splitInput2[2]);
            if (splitInput2[0] > splitInput2[1] && splitInput2[0] > splitInput2[2])
            {
                Console.WriteLine("가장 큰 값은 {0}입니다.", splitInput2[0]);
            }
            else if (splitInput2[1] > splitInput2[2] && splitInput2[1] > splitInput2[0])
            {
                Console.WriteLine("가장 큰 값은 {0}입니다.", splitInput2[1]);
            }
            else if (splitInput2[2] > splitInput2[0] && splitInput2[2] > splitInput2[1])
            {
                Console.WriteLine("가장 큰 값은 {0}입니다.", splitInput2[2]);
            }

















        }

    }
}
