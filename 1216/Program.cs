using System;

namespace _1216
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 주석(Comment) : 프로그램에 영향을 끼치지 않고 메모할 때 사용한다.
            // : 한 줄 주석
            /*
             *  : 여러 줄 주석이다
             */

            // 컴퓨터는 하드웨어 및 소프트웨어로 구성된다.
            // 하드웨어 : PC, 스마트폰과 같은 물리적으로 존재하는 장치를 의미한다.
            // 소프트웨어 : 하드웨어에 설치된 운영체제 및 어플리케이션(앱) 등을 의미한다.
            // 프로그램 : 우리가 하고자 하는 작업을 컴퓨터(하드웨어)에게 전달하여 주는 소프트웨어를 의미한다.
            // 프로그램 내부에는 " 무엇을 어떻게 하여라" 와 같은 형태의 명령어(Instruction)들이 들어 있다
            // 소프트웨어를 만드는 행위를 프로그래밍(Programming) 또는 코딩(Coding)이라고 한다.
            // 컴퓨터가 알아듣는 언어는 한가지 뿐이다. 0과 1의 형태로 구성되어 있으며 기계어(Manchine language)라고 부른다.
            // 과거 초기 형태의 컴퓨터는 이러한 기계어를 사용하여 프로그래밍 하였다.
            // 기계어는 인간에게 상당히 불편한(난해한) 언어이기 떄문에, 사람이 이해하기 쉬운 프로그래밍 언어가 만들어지게 되었다.
            // 프로그래밍 언어의 예약어(Keyward)와 문법으로 소프트웨어를 만드는 사람을 프로그래머(Programmer) 또는 개발자(Developer)라고 한다.
            // 프로그래밍 언어의 문법에 맞게 작성한, 텍스트로 된 명령집합을 코드(Code) 또는 소스(Source)라고 한다.
            // 소스코드를 기계어로 번역하는 작업을 컴파일(Compile)이라고 하며, 이러한 작업을 하는 소프트웨어를 컴파일러(Compiler)라고 부른다.

            // 프로그래밍을 하는 과정은 다음과 같다.
            // 1. 텍스트 에디터로 소스를 작성하여 파일로 저장한다.   ex) .cs 파일 등
            // 2. 소스파일을 컴파일하여 실행 프로그램을 생성한다.    ex) .exe 파일 등
            // 3. 프로그램을 실행한다.
            // 이 중 1. 2. 단계를 합쳐 빌드(Build)라고 부른다.
            // 프로그래밍 과정 중 발생한 오류를 버그(Bug)라고 부른다.
            // 오류를 탐색하고 수정하는 과정을 디버그(Debug), 디버깅(Debugging) 또는 트러블슈팅(Trouble shooting)이라고 부른다.

            // C#의 경우, C# 언어로 코딩하게 되면 우선 IL(Intermediate Language)코드로 변환된 이후 최종적으로 기계어로 변환된다.
            // IL코드를 보는 방법은 ildasm 을 이용하면 된다. 도구 -> 명령줄 -> 개발자 명령 프롬포트를 실행시킨 후 "ildasm" 입력.

            // <C#의 특징>
            // C#은 .Net 을 위한 많은 언어 중 하나로, 마이크로소프트의 닷넷 플랫폼을 기반으로 한다.
            // 절차적 언어와 객체지향적 언어의 특징, 그리고 함수형 프로그래밍 스타일을 제공하는 다중 패러다임 프로그래밍 언어이다.
            // C#은 C, C++, Java, Javascript 와 기초문법이 비슷하다.
            // C#은 자동으로 메모리를 관리한다.(Garbage collection 기능을 제공)
            // C#은 강력한 형식(Strongly Typed)의 언어이다.
            // C#은 Generic과 LINQ 등 편리한 기능을 제공한다.

            // .Net : 닷넷 프레임워크와 닷넷 코어를 합쳐서 말한다.
            // 닷넷은 소프트웨어 프레임워크로, 응용 프로그램의 개발 속도를 높이는 데 도움이 되는 API(Application Programming Interface) 및 서비스 모음이다.

            // 함수 : 프로그램에서 사용하기 위한 기능의 단위를 의미한다. 보통 하나의 함수는 하나의 기능을 실행한다.
            // 라이브러리 : 어떠한 기능을 구현할 때 도움이 되는 기능, 함수의 모음이다.
            // API : 어떠한 기능을 구현할 때 도움이 되도록 문서와 함께 제공되는 라이브러리 및 함수의 모음이다.

            // 플랫폼 : 프로그램을 실행하기 위한 배경환경 또는 운영체제를 의미한다.

            // C#의 기본 코드 구조
            // class 와 Main() 메서드가 반드시 있어야 하고, 하나 이상의 문(Statement)이 있어야 한다.
            // C#의 기본 코드는 위쪽에 네이스페이스 선언부와 Main() 메서드가 오고, 중괄호({}) 시작과 끝을 사용하여 프로그램 범위(Scope)를 구분한다.
            // 네임스페이스 : 자주 사용하는 네임스페이스를 위쪽에 미리 선언해 둘 수 있다.
            // Main() 메서드 : 프로그램의 시작 지점이며, 반드시 있어야 한다. Main() 앞에 static 키워드가 있어 개체를 생성하지 않고 바로 실핼할 수 있다.
            // Main() 메서드가 2개 이상이면 "프로그램 진입점이 2개 이상 정의되어 있습니다."라는 에러 메세지가 출력되어 프로그램이 컴파일되지 않는다.

            // 중괄호 ({}) : 프로그램 범위를 구분 짓는다.
            // 세미콜론 (;) : 명령어(문 또는 문장)의 끝을 나타낸다.
            // 메서드(Method) : 클래스에서 제공하는 멤버 함수를 의미한다.

            // C#은 대,소문자를 구분한다. 정확히 입력하지 않으면 에러가 발생한다.

            // 문법, 스타일, 패턴
            // 문법(Syntex) : 프로그래밍을 하기 위해 반드시 지켜야 하는 규칙이며, 프로그래밍 언어별로 다르다.
            // 스타일(Style) : 프로그래밍 가이드라인이다.
            // 패턴(Pattern) : 자주 사용하는 규칙과 스타일 모음이다.

            // 정규화된 이름(FUlly Qualified Names) : 아래와 같이 네임스페이스 이름과 형식 이름까지 전체를 지정하는 방식이다.
            //System.Console.WriteLine("Hello, world!"); // using System; 사용 안 할 경우 -
            //Console.WriteLine("Hello, world!"); // - 에러발생

            // 출력문 : 명령 프롬프트에 출력하는 구문
            // 주석문 : 실행에 영향을 주지 않는 코드 설명문
            Console.Write("Hello, world!");
            Console.WriteLine("Hello, world!");
            Console.Write("Hello, world!"); // 띄어쓰기 유무차이
            Console.Write("\n\n\n");

            // 들여쓰기 : 프로그램 소스 코드의 가독성을 위해서 사용하는 일반적이 들어쓰기 규칙.
            // 보통 4칸의 공백 또는 Tap을 사용하지만 혼용하면 안 된다.
            // 공백처리 : C#에서 명령어 사이, 기호와 괄호 사이의 공백, Tap, 줄 바꿈은 무시된다.
            Console.  WriteLine   (
                "Hello, world!"
                )       ;

            // 이스케이프 시퀀스
            // C#은 WriteLine() 메서드에서 사용할 확장 문자를 제공하는데, 이를 역슬래쉬(\) 기호와 특정 문자를 조합하면 특별한 기능을 사용할 수 있다.
            // 어떤 이스케이프 시퀀스가 있는지 검색해보면 된다.
            Console.Write("\n\n\n");
            Console.Write("Hello, world!");
            Console.Write("Hello, world!\n"); // \n : 줄 바꿈 기능.
            Console.WriteLine("Hello, world!");
            // https://learn.microsoft.com/ko-kr/cpp/c-language/escape-sequences?view=msvc-170

            // 문자열 보간법(string interpolation) 또는 문자열 템플릿(Stting template)이라고도 한다.
            // 문자열을 묶어서 처리하기 위한 기능이다. 기존에는 String.Format() 메서드를 주로 사용했었는데,
            // C# 6.0 버전부터 $"{}" 형태로 간결하게 제공하고 있다.
            Console.Write("\n\n\n");
            Console.WriteLine("Hello," + " world!"); // + 연산이 들어가며 숫자/문자 구분이 들어가 속도 저하는 생기지만, 어쨌든 보간처리가 된다.
            Console.WriteLine("{0},{1}", "Hello,"," world!");
            string hello = "Hello,";
            String world = " world!";
            Console.WriteLine($"{hello}{world}");

            const int THREE_NUMBER = 3;
            const string ODD_WORD = "홀수";
            Console.WriteLine($"{THREE_NUMBER}은(는) {ODD_WORD}입니다.");

            string stringFormat = string.Format("{0}은(는) {1}입니다.", THREE_NUMBER, ODD_WORD);
            Console.WriteLine(stringFormat);

            // 아래와 같이 문자열을 + 연산하면 특히 느리다.
            string stringPlus = THREE_NUMBER + "은(는) " + ODD_WORD + "입니다.";
            Console.WriteLine(stringPlus);

            string sName = "조효근";
            string sClass = "경일게임아카데미";
            string sStudy = "유니티";
            Console.Write($"{sName}{"\n"}{ sClass}{"\n"}{ sStudy}{"\n"}");

            // 변수 
            // 프로그램 값을 다루려면 데이터를 메모리에 잠시 보관해 놓고 사용할 수 있는 임시 저장공간이 필요하다.
            // 위와 같은 상황에서 변수를 사용하며, 변수를 사용하는 순서는 선언(메모리에 공간을 확보)하고 정의(대입, 할당)하여 사용하는 것이다.
            // 변수는 데이터 형식, 변수의 이름, 대입한 값으로 이루어져 있다.
            // 변수 선언 : 메모리에 데이터를 저장할 공간을 확보하는 것이다.
            // 변수 정의 확보한 공간에 값을 저장하는 것이다.
            // 변수 초기화 : 변수를 선언한 직후, 초기값으로 정의하는 것이다. 초기화는 변수의 초기값을 명확하게 정의하여 원치 않는 논리적인 오류를 방지하는 역할을 한다.
            Console.Write("\n\n\n");
            int number;         // 선언
            number = 100;       // 정의
            int number2 = 1;    // 초기화
            int trashValue;
            Console.WriteLine(number);

            Console.WriteLine("int는 얼마 만큼의 메모리를 할당하나요? -> {0}byte", sizeof(int));
            // bit : 0 또는 1을 표현할 수 있는 최소 단위, 하나의 비트는 0과 1중 하나를 가지고 있다.
            // [0][0]
            // [0][1]
            // [1][0]
            // [1][1] 2비트의 경우 4가지 경우의 수를 표현 가능하다.
            // byte : 수를 세는 단위, 1byte = 8bit

            // 변수 사용시 주의사항 및 규칙
            // 변수의 이름을 지을 때는 다음 규칙을 지켜야 한다.
            // 변수의 첫 글자는 반드시 문자로 지정한다. 숫자는 변수명의 첫 글자로 사용할 수 없다.
            // 변수명의 길이는 255자 이하여야 되며 공백을 포함할 수 없다. 255 = 1byte
            // 영문자와 숫자, 언더스코어(_) 조합으로 사용하며, 기타 특수 기호는 사용할 수 없다.
            // C#에서 사용하는 키워드는 사용할 수 없다.
            // 변수는 대,소문자를 구분하고, 일반적으로 소문자로 시작한다.
            // 변수는 타인이 보더라도 이해할 수 있는 이름으로 사용한다.

            // 데이터 형식
            // 변수에 저장할 수 있는 데이터의 종류를 자료형(Data type)이라고 한다.
            // int, string, bool, double, object 등 C#에서 기본으로 제공하는 데이터형식을 기본 형식(Primitive type)이라고 부른다.
            // int : 정수형 데이터 타입 (양수, 음수, 0)
            // float : 실수형 데이터 타입 (부동소수점 형태/ 3.14)
            // bool : 논리값을 가지는 데이터 타입(참/거짓)
            // char : 한 문자를 가지는 데이터 탑입('A')
            // string : 문자열을 가지는 데이터 타입("Hello"
            // object : C#에서 모든 자료형의 부모형 데이터 타입(모든 데이터를 저장 가능)











        } // Main()
    } // class Program
} // namespace _1216

namespace Monster
{
    public class Slime { }

}

namespace Pet
{
    public class Slime { }
}

// 블로그 과제
// 오늘 공부 내용
// 이스케이프 시퀀스 
// 메모리 세이프티 (Memory Safety) 개념