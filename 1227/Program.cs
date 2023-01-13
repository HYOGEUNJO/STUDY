namespace _1227__
{
    internal class Program
    {
        // 전역변수
        static int iNum1 = 1;
        static int iNum2 = 3; // 현재 Main 함수 내에 같은 이름으로 지역변수가 있다. 우선순위는 지역변수가 전역변수보다 크다.
        static int iNum3 = 5;

        static void Main(string[] args)
        {
            // 함수(Function) 또는 메서드(Method)는 재사용을 목적으로 만든 특정 작업을 수행하는 코드 블록이다.
            // 함수를 부르는 다양한 명칭
            // 함수(Fucntion)
            // 메서드 (Method)
            // 프로시저(Procedure)
            // 서브모듈 (Submodule)

            // 프로그래밍을 하다 보면 같은 유형의 코드를 반복할 때가 많다. 이 코드들을 매번 입력하면 불편하고
            // 입력하다 실수도 할 수 있다. 이때 '함수'를 사용한다.

            // 프로그래밍 언어에서 함수는 어떤 동작 및 행위를 표현한다. 함수의 사용 목적은 코드 재사용에 있다.
            // 한 번 만들어 놓은 함수는 프로그램에서 한 번 이상 사용할 수 있다.
            // 지금까지 사용한 Main() 메서드는 C#의 시작 지점을 나타내는 특수한 목적의 함수로 볼 수 있다.
            // 또, Console 클래스의 wirteLine() 메서드도 함수로 볼 수 있다.

            // - 함수란 어떤 값을 받아서 그 값을 가지고 가공을 거쳐 어떤 결과값을 반환시켜 주는 코드이다.
            // - 함수는 프로그램 코드 내에서 특정한 기능을 처리하는 독립적인 하나의 단위 또는 모듈을 가리킨다.

            // 함수의 종류 (내장 함수와 사용자 정의 함수)
            // 함수에는 내장 함수와 사용자 정의 함수가 있다. 내장 함수는 C#이 자주 사용하는 기능을 미리 만들어서
            // 제공하는 함수로, 특정 클래스의 함수로 표현된다.
            // 내장 함수도 그 용도에 따라 문자열 관련 함수, 날짜 및 시간 관련 함수, 수학 관련 함수, 형식 변환 관련 함수
            // 등으로 나눌 수 있다. 이러한 내장 함수를 API(Application Programming Interface)로 표현한다.
            // 사용자 정의 함수는 내장 함수와 달리 프로그래머가 필요할 때마다 새롭게 기능을 추가하여 사용하는 함수이다.

            // 함수 정의하고 사용하기
            // 함수 정의(Define)는 함수를 만드는 작업이다. 함수 호출(Call)은 함수를 사용하는 작업이다. 함수 생성 및
            // 호출은 반드시 소괄호가 들어간다. 함수를 정의하는 형태는 지금까지 사용한 Main() 메서드와 유사하다.
            // 다음 코드는 함수를 만드는 가장 기본적인 형태를 보여준다.
            // static void [함수이름] ()
            // {
            //      함수내용
            // } 

            // 만든 함수를 호출하는 형태는 다음 세 가지가 있다.
            // [함수이름]();
            // [함수이름](매개변수);
            // 변수(결과값) = 함수이름(매개변수);

            Show();

            Multi();
            Multi("반갑습니다.");
            Multi("또 만나요", 2);

            Console.WriteLine("Factorial : {0}",Factorial(3));

            // 전역변수 지역변수
            int iNum1 = 10;
            int iNum2 = 30;
            Swap(iNum1, iNum2);
            Console.WriteLine("Main 의 Num1,2 값은 ? : {0}, {1}",iNum1,iNum2); // Main의 변수는 바뀌지 않았다.
            // intValue1, intValue2 는 Main에서 찾을 수 없다.
            Console.WriteLine("전역변수 iNum3의 값 : {0}", iNum3);


            // 화살표 함수
            Hi();
            Multiply(5, 4);


            // 예제. 3개의 정수 중에서 최대값을 찾는 함수 Maximum(x, y, z)를 정의할 것
            Maximum(1, 2, 3);

            // 예제. 화면에 "Hello"를 출력하는 SayHello() 함수를 작성. int 타입 매개변수 받아서 그 횟수만큼 반복해서 출력
            SayHello(5);

            // 예제. 다른 두 변이 주어졌을 때 직각 삼각형의 빗변을 계산하는 함수 Hypot()를 정의할 것. - 매개변수는 2개와 리턴 타입은 double 형
            Console.WriteLine("{0}", Hypot(3, 7));
            
            // 예제. 주어진 숫자가 소수인지 여부를 찾는 함수 Prime()을 작성. 판별할 값의 범위는 2~100 사이의 값 중에서 소수는 모두 출력.
            Prime();

            // 사용자가 입력하는 전화번호에서 소괄호를 삭제한 형태로 출력하는 프로그램 작성(함수사용). 전화번호 입력 -> 소괄호 삭제한 형태, quit입력하면 프로그램 종료, 종료 전까지 전화번호를 입력.
            Console.WriteLine($"{ PhoneOnlyNumber("010-6678-4802")}");
            Console.WriteLine($"{PhoneOnlyNumberReverse("010-6678-4802")}");



        }

        // 전역변수 지역변수
        static void Swap(int intValue1, int intValue2)
        {
            Console.WriteLine("바뀌기 전의 값 {0}, {1}", intValue1, intValue2);

            int temp;
            temp = intValue1;
            intValue1 = intValue2;
            intValue2 = temp;

            Console.WriteLine("바뀐 후의 값 {0}, {1}", intValue1, intValue2);

        }




        // Hello world 출력하는 사용자 정의 함수
        static void Show()
        {
            Console.WriteLine("Hello world!");
        }

        // 이 함수는 가장 간단한 형태의 함수로, 매개변수(Parameter)도 없고 반환값(Return value)도 없는 형태이다.

        static void ParameterAndReturn()
        {
            // 함수를 만들어 놓고 기능이 동일한 함수만 사용하지는 않는다. 호출할 때마다 조금씩 다른 기능을 적용할 떄는
            // 함수의 매개변수를 달리하여 호출할 수 있다. 매개변수(인자, 파라미터)는 함수에 어떤 정보를 넘겨주는 데이터를
            // 나타낸다. 이러한 매개변수 콤마를 기준으로 여러 개 설정할 수 있으며, 문자열과 숫자 등 모든 데이터 형식을 사용할 수 있다.


            // 매개변수(인자, 파라미터)가 없는 함수 : 매개변수변수도 없고 반환값도 없는 함수 형태는 가장 단순한 형태의 함수이다.
            // 앞에서 사용한 함수중에서 모든 변수에 있는 값을 문자열로 변환시키는 ToString() 매서드처럼 빈 괄호만 있는
            // 함수 형식을 나타낸다.

            // 매개변수가 있는 함수 : 특정 함수에 인자 값을 1개 이상 전달하는 방식이다. 정수형, 실수형, 문자형, 문자열형,
            // 개체형 등 여러 가지 데이터 형식을 인자 값으로 전달할 수 있다.

            // 반환값이 있는 함수(결과값이 있는 함수) : 함수의 처리 결과를 함수를 호출한 쪽으로 반활할 때는 return 키워드를
            // 사용하여 데이터를 돌려줄 수 있다.

            // 매개 변수가 가변(여러 개)인 함수 : C# 에서는 클래스 하나에 매개변수의 형식과 개수를 달리하여 이름이 동일한
            // 함수를 여러 개 만들 수 있다. 이를 가리켜 함수 중복 또는 함수 오버로드(Overload)라고 한다.

        }

        static void CompareValuesAndAbsolute(int firstValue,int secondValue)
        {
            int bigValue = int.MinValue; // int 의 가장 작은 값
            int smallValue = int.MaxValue; // 가장 큰 값

            if(firstValue < secondValue)
            {
                bigValue = secondValue;
                smallValue = firstValue;
            }
            else
            {
                bigValue = firstValue;
                smallValue = secondValue;
            }

            Console.WriteLine($"큰 값 : {bigValue}, 작은 값 : {smallValue}");

            // 절대값 처리
            if (firstValue < 0)
            {
                firstValue = firstValue * (-1);
            }
            else { }

            if (secondValue < 0)
            {
                secondValue = secondValue * (-1);
            }
            else { }

            Console.WriteLine($"두 수의 절대 값 : {firstValue} , {secondValue}");
        }

        static void FunctionOverloading()
        {
            // <함수 오버로드(다중 정의)>
            // 클래스 하나에 매개변수를 달리해서 이름이 동일한 함수 여러 개를 정의할 수 있는데, 이를 함수 오버로드라고 한다. 우리말로는 여러 번 정의한다는 의미이다.
        }

        // 숫자를 받아서 출력하는 함수
        static void GetNumber(int number)
        {
            Console.WriteLine($"Int32 : {number}");
            Console.WriteLine($"4바이트 정수 : {number}");
        }

        static void GetNumber(long number)
        {
            Console.WriteLine($"Int64 : {number}");
            Console.WriteLine($"8바이트 정수 : {number}");
        }

        static void Multi()
        {
            Console.WriteLine("안녕하세요");
        }

        static void Multi(string message)
        {
            Console.WriteLine(message);
        }

        static void Multi(string message, int count)
        {
            for(int i = 0; i<count; i++)
            {
                Console.WriteLine("{0}", message);
            }
        }

        static void RecursionFunction()
        {
            // <재귀(Recursion) 함수>
            // 함수에서 함수 자신을 호출하는 것. 
        }

        static int Factorial(int nData)
        {
            if(nData == 0 || nData == 1) // 탈출 조건
            {
                return 1;
            }

            Console.WriteLine("n의 값 : {0}",nData);

            return nData * Factorial(nData - 1); // 재귀 호출 부분
        }

        static void FunctionScope()
        {
            // <함수 범위>
            // 전역 변수와 지역 변수
            // 클래스와 같은 레벨에서 선언된 변수를 전역 변수(Global Variable) 또는 필드(Field)라고 하며, 함수 레벨에서 선언된 변수를 지역 변수(Local Variable)라고 한다. 
            // 이때 동일한 이름으로 변수를 전역 변수와 함수 내의 지역 변수로 선언할 수 있다. 함수 내에서는 함수 범위에 있는 지역 변수를 사용하고, 함수 범위 내에 선언된 변수가 없으면 전역 변수 내에 선언된 변수를 사용한다.
            // 단, C#에서는 전역 변수가 아닌 필드라는 단어를 주로 사용하며, 전역 변수는 언더스코어(_) 또는 m_ 접두사를 붙이는 경향이 있다.
        }

        static void ArrowFunction()
        {
            // <화살표 함수(Arrow Function)>
            // 화살표 모양의 연산자(=>)를 사용하여 메서드 코드를 줄일 수 있다. 프로그래밍에서 화살표 함수 또는 화살표 메서드는 람다 식(Lambda expression)의 또다른 이름이다.
            // 화살표 함수를 사용하면 함수를 줄여서 표현할 수 있다. 함수 고유의 표현을 줄여서 사용하면 처음에는 어색할 수 있지만, 익숙해지면 코드의 간결함을 유지할 수 있다.
        }

        static void Hi() => Console.WriteLine("안녕하세요");
        static void Multiply(int a, int b) => Console.WriteLine(a * b);

        // 예제. 최대값 찾는 함수
        static void Maximum(int iData1, int iData2, int iData3)
        {
            int Maximum = int.MinValue;
            if(iData1 > iData2)
            {
                Maximum = iData1;
            }
            else
            {
                Maximum = iData2;
            }

            if (Maximum > iData3){ }
            else
            {
                Maximum = iData3;
            }
            Console.WriteLine("최대값 : {0}", Maximum);
        }

        // 예제. 입력값만큼 "Hello" 출력
        static void SayHello(int iCount)
        {
            for(int i = 0; i <iCount; i++)
            {
                Console.WriteLine("Hello");
            }
        }

        // 예제. 삼각형 빗변 구하기
        static double Hypot(int iData1, int iData2)
        {
            return Math.Round(Math.Sqrt(iData1 * iData1 + iData2 * iData2),2);
        }

        // 예제. 소수 구하기
        static void Prime()
        {

            for(int i = 2; i<=100; i++)
            {
                int iCount = 0;
                for(int j = 1; j<= i; j++)
                {
                    if(i % j == 0)
                    {
                        iCount++;
                    }
                }
                if(iCount == 2)
                {
                    Console.WriteLine("숫자 {0} 는 소수입니다.", i);
                }
            }
        }

        // 예제. 전화번호에서 소괄호 삭제 후 출력
        static string PhoneOnlyNumber(string sData)
        {
            char[] cTmpPhone = new char[sData.Length];
            int iTmpLengthCount = 0;
            string Result = string.Empty;
            foreach (char Each in sData)
            {
                cTmpPhone[iTmpLengthCount] = Each;
                iTmpLengthCount++;
            }

            for(int i = 0; i < sData.Length; i++)
            {
                if ((cTmpPhone[i] == '(' || cTmpPhone[i] == ')') || cTmpPhone[i] == '-')
                {

                }
                else
                {
                    Result += cTmpPhone[i].ToString();

                }
            }

            return Result;


        }


        // 예제. 전화번호에서 소괄호 삭제 후 출력
        static string PhoneOnlyNumberReverse(string sData)
        {
            char[] cTmpPhone = new char[sData.Length];
            int iTmpLengthCount = 0;
            string Result = string.Empty;
            foreach (char Each in sData)
            {
                cTmpPhone[iTmpLengthCount] = Each;
                iTmpLengthCount++;
            }

            for (int i = sData.Length-1; i >= 0; i--)
            {
                if ((cTmpPhone[i] == '(' || cTmpPhone[i] == ')') || cTmpPhone[i] == '-')
                {

                }
                else
                {
                    Result += cTmpPhone[i].ToString();

                }
            }

            return Result;


        }







    }
}





// 과제 슬라이딩 퍼즐
