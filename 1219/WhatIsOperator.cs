namespace _1219
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // <연산자>
            // 데이터로 연산 작업을 수행할 때는 연산자(Operator)를 사용한다. 연산자는 기능에 따라 대입, 산술, 관계, 논리, 증감, 조건, 비트, 시프트 연산자 등으로 나누며, 이용 형태에 따라 항 1개로 연사을 하는 단항(Unary) 연산자와 항 2개로 연산을 하는 이항(Binary) 연산자, 항 3개로 연산을 하는 삼항(Tenary) 연산자로 나눈다.
            // -단항 연산자-
            // 단항 연산자는 연산자와 피연산자 하나로 식을 처리한다.
            // ex) [연산자] [피연산자]
            // + 연산자 : 특정 정수형 변수 값을 그대로 출력한다.
            // - 연산자 : 특정 정수형 변수 값을 음수로 변경하여 출력한다. 음수 값이 들어 있다면 양수로 변환해서 반환한다.
            const int PLUS_FIVE = +5;
            const int MINUS_FIVE = -5;
            const int MINUS_FIVE2 = -5;

            // -식과 문-
            // 값 하나 또는 연산을 진행하는 구문의 계산식을 식(Expresion) 또는 표현식이라고 한다. 
            // 표현식을 사용하여 명령 하나를 진행하는 구문을 문(Statement) 또는 문장이라고 한다.

            // -이항 연산자-
            // 이항 연산자는 연산자와 피연산자 2개로 식을 처리한다.
            // ex) [피연산자1] [연산자] [피연산자2]
            const int PLUS_TEN = 5 + 5;

            // -삼항 연산자-
            // 삼항 연산자는 식 1개의 항(Expresion)과 그 경과에 따른 피연산자 각 1개씩 총 2개 항으로 식을 처리한다.
            // ex) (식) ? [피연산자1] : [피연산자2]
            int x = default;
            x = PLUS_TEN;
            string compareTen = (x > 9) ? "{0}은(는) 9보다 크다" : "{0}은(는) 9보다 크지 않다";
            Console.WriteLine(compareTen, x);

            // -변환 연산자-
            // () 기호를 사용하여 특정 값을 원하는 데이터 형식으로 변환할 수 있다.
            const int PI_INT = (int)3.141592;
            const float PI_FLOAT = (float)3.141592;
            Console.WriteLine("PI_INT : {0}, PI_FLOAT : {1}", PI_INT, PI_FLOAT);

            // -산술, 관계, 논리, 증감, 조건, 비트, 시프트 연산자-
            // -산술 연산자-
            // 더하기(Add), 뺴기(Subtract), 곱하기(Multiply), 나누기(Divide), 나머지(Remainder, Modules) 등 수학적 연산을 하는 데 사용한다. 보통 정수 형식과 실수 형식의 산술 연산에 사용한다.
            // ex) +, -, *, /, %

            // -문자열 연결 연산자-
            // 산술 연산자 중 하나인 + 연산자는 피연산자의 데이터 타입에 따라 산술 연산 또는 문자열 연결 연산을 수행한다.
            // + 연산자 : 두 항이 숫자일 때는 산술 연산 가능, 문자열일때는 문자열 연결 가능.
            string addMessage = "조" + "효" + "근";
            Console.WriteLine(addMessage);

            // -할당 연산자(Assignment operator)-
            // 변수에 데이터를 대입하는 데 사용한다. 할당 연산자를 대입 연산자라고도 한다. C#에서 = 기호는 같다는 의미가 아니라 오른쪽에 있는 값 또는 식의 결과를 왼쪽 변수에 할당하라고 지시하는 것이다.
            // ex) =, +=, -=, *=, /=, %=

            // -증감 연산자(Increment / Decrement operator)
            // 변수 값을 1 증가시키거나 1 감소시키는 연산자이다. 증감 연산자가 변수 앞에 위치하느냐, 뒤에 위치하느냐에 따라 연산 처리 우선순위가 결정된다.
            // ++(증가 연산자) : 변수 값에 1을 더한다.
            // --(감소 연산자) : 변수 값에 1을 뺀다.
            int number = 3;
            number *= 2;
            Console.WriteLine(number);

            // 증감 연산자가 앞에 붙으면 전위 증감 연산자라고 하며, 변수 뒤에 붙으면 후위 증감 연산자라고 한다.
            // 전위(Prefix) 증감 연산자 : 정수형 변수 앞에 연산자가 위치하여 변수 값을 미리 증감한 후 나머지 연산을 수행한다.
            // 후위(Postfix) 증감 연산자 : 정수형 변수 뒤에 연산자가 위치하여 연산식(대입)을 먼저 실행한 후 나중에 변수 값을 증감한다.
            Console.WriteLine(++number); // 전위
            Console.WriteLine(number++); // 후위
            Console.WriteLine(number);
            // C#에서 발생하는 복잡한 오류
            number = 0;
            number = number++; // 혹은 number = (number++); - 소괄호를 사용해도 우선 계산되지 않는다.
            Console.WriteLine(number); // 값을 저장하는 메모리와 참조를 저장하는 메모리가 나누어져 있어서 전위/후위 연산이 지정되지 않는다. C#을 사용할 때는 이렇게 사용하지 말고 아래와 같이 명확한 방법을 사용하자.
            number += 1; // 추천하며 사용하는 방법.
            Console.WriteLine(number);

            // -관계형(비교) 연산자(Relational/Comparative operator)-
            // 두 항이 큰지, 작은지 또는 같은지 등을 비교하는 데 사용한다. 관계형 연산자의 결과값은 논리 데이터 형식인 참(True) 또는 거짓(False)으로 출력된다.
            // ex) <, <=, >, >=, ==, !=
            bool isBigger = false;
            isBigger = (5 < 10); // 무조건 참
            Console.WriteLine(isBigger);
            isBigger = (10 < 5); 
            Console.WriteLine(isBigger);

            // -논리 연산자(Logical operator)는 논리곱(AND), 논리합(OR), 논리부정(NOT)의 조건식에 대한 논리 연산을 수행한다. 연산의 결과값은 참 또는 거짓의 bool 형식으로 반환되어 Boolean 연산자라고도 한다.
            // ex) &&(2진수로 두수의 같은 자리의 수를 비교할 때 둘다 1이면 결과값의 자리가 1로 표현된다.), ||(2진수로 두수의 같은 자리의 수를 비교할 때 둘 중 하나라도 1이면 결과값의 자리가 1로 표현된다.), !
            isBigger = !isBigger; // 기존에 Fasle 상태였다.
            Console.WriteLine(isBigger);
            isBigger = (5 < 10) || (10 < 5); // (5 < 10) 값이 이미 참이기 때문에 결과값은 TRUE이다.
            Console.WriteLine(isBigger);
            isBigger = (5 < 10) && (10 < 5); // 이미 (10 < 5)결과가 참이 아니기 떄문에 결과값은 FALSE이다.
            Console.WriteLine(isBigger);
            isBigger = (5 < 10) && (10 > 5); // 두 식 모두 참
            Console.WriteLine(isBigger);
            isBigger = (5 > 10) && (10 < 5); // 두 식 모두 거짓
            Console.WriteLine(isBigger);
            isBigger = (5 > 10) || (10 < 5); // 두 식 모두 거짓
            Console.WriteLine(isBigger);

            // -비트 연산자(Bit operator)-
            // 정수형 데이터의 값을 이진수 비트 단위로 연산을 수행할 때 사용한다.
            // ex) &, |, ^, ~
            int bitNumber = 2; // 10(2)
            int bitResult = 0; // 00(2)

            bitNumber = 4;
            bitResult = bitNumber & 12; // 비트마스크
            Console.WriteLine("bitResult(은)는 2진수로 0x02(16)를 가지고 있을까요? {0}", bitResult);

            // -시프트 연산자(Shift operator)-
            // 정수 데이터가 담겨 있는 메모리의 비트를 왼쪽 또는 오른쪽으로 지정한 비트만큼 이동시킨다.
            // ex) <<, >>
            bitResult = bitNumber << 1;
            Console.WriteLine(bitResult); // 100(2) = 4

            // -조건 연산자(Conditional operator)-
            // 조건에 따라서 참일 때와 거짓일 때 결과를 다르게 반환한다 
            // (조건식) ? (식1 또는 값1) : (식2 또는 값2) 형태의 연산자이다. if~else 문의 축약형이기도 하다.
            isBigger = false;
            isBigger = (5==10) || (10>5);
            Console.WriteLine(isBigger);
            isBigger = (5 == 10) && (10 > 5);
            Console.WriteLine(isBigger);

            // -나열(콤마) 연산자-
            // 콤마를 구분자로 하여 한 문장에 변수 여러 개를 선언할 때 사용한다.
            int intNum1, intNum2, intNum3;

            // -sizeof 연산자-
            // 단항 연산자로 데이터 형식 자체의 크기를 구하는 데 사용한다.
            // sizeof([데이터 타입]) 형태로 사용하며, 운영체제와 CPU아키텍쳐의 종류에 따라 결과값이 다르게 나올 수 있다.
            Console.WriteLine("int 메모리 크기 : {0}바이트", sizeof(Int32));

            // <연산자 우선순위>
            // 연산자 여러 개를 함께 사용할 경우 우선순위(Precedence)에 따라 계산된다.
            // 우선순위가 어려울 경우 일단 괄호() 연산자부터 사용하자.


            // <실습>
            Console.Write("\n\n");
            // 사용자에게 주어, 동사, 목적어를 각각 물어보고 이것들을 합하여 [주어 + 동사 + 목적어] 형태로 출력하는 프로그램을 작성해보자
            Console.Write("주어 : ");
            string subject = Console.ReadLine();
            Console.Write("동사 : ");
            string verb = Console.ReadLine();
            Console.Write("목적어 : ");
            string object_ = Console.ReadLine();
            Console.WriteLine("{0} {1} a {2}", subject, verb, object_);

            Console.Write("\n");
            // 사용자의 나이를 물어보고, 10년 후에 몇 살이 되는지를 출력하는 프로그램을 작성
            Console.Write("당신의 나이는? : ");
            string age = Console.ReadLine();
            Console.WriteLine("당신의 현재 나이 : {0}\n10년 후에 당신의 나이 : {1}", age, int.Parse(age) + 10);

            Console.Write("\n");
            // 직각 삼각형의 양변 길이(입력 값은 빗변이 아닐 경우)를 읽어서 빗변의 길이를 계산하는 프로그램을 작성.
            Console.Write("첫번째 변의 길이? : ");
            string side1 = Console.ReadLine();
            Console.Write("두번째 변의 길이? : ");
            string side2 = Console.ReadLine();
            Console.Write("빗변의 길이 (결과) = {0}", Math.Sqrt(int.Parse(side1) * int.Parse(side1) + int.Parse(side2) * int.Parse(side2)));

            //Console.Write("\n\n\n");
            //string a = Console.ReadLine();
            //float a1 = float.Parse(a);
            //string b = Console.ReadLine();
            //float b1 = float.Parse(b);
            //float c = 0;
            //while(true)
            //{
            //    if(c*c == (a1*a1 + b1*b1))
            //    {
            //        string c1 = c.ToString();
            //        Console.WriteLine($"빗변의 길이 : {c1}");
            //        break;
            //    }
            //    ++c;
            //}

            Console.Write("\n");
            // 상자의 길이, 너비, 높이를 입력하라는 메세지를 표시.
            Console.Write("길이는? : ");
            string length = Console.ReadLine();
            Console.Write("너비는? : ");
            string width = Console.ReadLine();
            Console.Write("높이는? : ");
            string height = Console.ReadLine();
            Console.WriteLine("상자의 표면적 : {0}\n상자의 부피 : {1}", int.Parse(length) * int.Parse(width) * 2 + int.Parse(width) * int.Parse(height) * 2 + int.Parse(height) * int.Parse(length) * 2, int.Parse(length) * int.Parse(width) * int.Parse(height));

            Console.Write("\n");
            // 면적의 단위인 평을 평방미터로 환산하는 프로그램 작성
            Console.Write("몇 평인가요? : ");
            string pyung = Console.ReadLine();
            Console.WriteLine("평방미터 : {0}", float.Parse(pyung) * 3.3058f);

            Console.Write("\n");
            // 시간을 초단위로 변환하라.
            Console.Write("몇 시간? : ");
            string hours = Console.ReadLine();
            Console.Write("몇 분? : ");
            string minutes = Console.ReadLine();
            Console.Write("몇 초? : ");
            string seconds = Console.ReadLine();
            Console.WriteLine("총 : {0}", int.Parse(hours) * 3600 + int.Parse(minutes) * 60 + int.Parse(seconds));

            Console.Write("\n");
            // 퀴즈 #1,#2,#3 , 중간고사 , 기말고사 성적을 입력받아 총합을 계산하여라.
            Console.Write("퀴즈#1? : ");
            string quiz1 = Console.ReadLine();
            Console.Write("퀴즈#2? : ");
            string quiz2 = Console.ReadLine();
            Console.Write("퀴즈#3? : ");
            string quiz3 = Console.ReadLine();
            Console.Write("중간고사? : ");
            string mid_term = Console.ReadLine();
            Console.Write("기말고사? : ");
            string final_term = Console.ReadLine();
            Console.WriteLine("총 합 = {0}", int.Parse(quiz3) + int.Parse(quiz2) + int.Parse(quiz1) + int.Parse(mid_term) + int.Parse(final_term));




            





        }
    }
}

