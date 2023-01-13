namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 예제 1. 사용자로부터 2개의 문자열을 읽어서 같은지 다른지 화면에 출력하는 프로그램
            // ex)  첫번째 문자열 : Hello
            //      두번째 문자열 : World
            // equal 메서드를 사용하지 않는다.
            // hint . Length를 비교
            string s_UserInput = Console.ReadLine();
            string s_UserInput2 = Console.ReadLine();

            if (s_UserInput == s_UserInput2)
            {
                Console.WriteLine("서로 같다.");
            }
            else
            {
                Console.WriteLine("서로 다른다.");
            }
            Console.WriteLine("\n");



            // 예제 2. 5개의 음려(콜라, 물, 스프라이트, 쥬스, 커피)를 판매하는 자판기 머신을 구현해보기.
            // 사용자가 1부터 5사이의 숫자를 입력함.
            // 선택한 음료를 출력함.
            // 1 ~ 5 이외의 숫자를 선택하면 오류 메세지 출력한다.
            // hint . switc 문이나, if/else 문을 사용한다.
            Console.WriteLine("1~5 숫자를 입력해주세요.");
            int i_InputNum = default;
            int.TryParse(Console.ReadLine(), out i_InputNum);
            switch (i_InputNum)
            {
                case 1:
                    {
                        Console.WriteLine("콜라");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("물");

                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("스프라이트");

                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("주스");

                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("커피");

                    }
                    break;
                default:
                    {
                        Console.WriteLine("[System] 유효하지 않는 입력입니다.");
                    }
                    break;

            }




            // 예제3. 배열 days[]를 아래와 같이 초기화하고 배열 요소의 값을 다음과 같이 출력하는 프로그램 작성.
            // days[] 는 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 
            // 배열 days[ms -> 1월은 31까지 입니다. 2월은 2일 까지입니다.
            int[] iAr_Days = new int[12] { 31,29,31,30,31,31,31,31,31,31,31,31};




        }
    }
}