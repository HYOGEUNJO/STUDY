using System; // 기능을 가져온다.

namespace _1221 // 프로그램 이름.
{
    // 클래스 밖에서는 아무것도 되지 않는다.
    //int iExam = 0;
    internal class Program // C#에서는 모든 요소들이 클래스 안에 종속되어야 한다.
    {
        static void Main(string[] args) // Main 메서드가 있어야 C# 콘솔창을 이용할 수 있다.
        {
            //// 프로그램은 여기서 부터 읽어 들인다.

            //// if(/* 조건문A 검사*/)
            //// {
            ////     // A조건이 참이라면 여기로 온다.
            ////     // A조건문은 여기서 부터 읽기 시작한다.
            ////     // A조건문은 여기서 끝난다.
            //// } 
            //// else if(/* 조건문B 검사*/) // A조건문이 거짓일 경우
            //// {
            ////     // B조건이 참이라면 여기로 온다.
            ////     // B조건문은 여기서 부터 읽기 시작한다.
            ////     // B조건문은 여기서 끝난다.
            //// }
            //// else // A,B조건문에 거짓일 경우
            //// {
            ////     
            //// }
            //// 조건문을 실행하였으면 여기서 부터 다시 프로그램을 시작한다.
            //string sPersonalGender = "여자";
            //if (sPersonalGender.Equals("남자"))
            //{
            //    Console.WriteLine("남자");
            //}
            //else if (sPersonalGender == "여자")
            //{
            //    Console.WriteLine("여자");
            //}
            //else
            //{
            //    Console.WriteLine("남자도 여자도 아니다.");
            //}

            //// 1 ~ 100 중 3의 배수를 제외한 수의 합 구하기
            //int iValue_ = 0;
            //int iSum_ = 0;
            //for (iValue_ = 1; iValue_ <= 100; iValue_++)
            //{
            //    bool bIsMultipleOfThree = (iValue_ % 3 == 0);
            //    Console.WriteLine("{0} 은 3의 배수인가 : {1}", iValue_, bIsMultipleOfThree);
            //    if (bIsMultipleOfThree == false)
            //    {
            //        iSum_ += iValue_;
            //        Console.WriteLine("3의 배수가 아닌 수의 합 : {0}\n", iSum_);
            //    }
            //    else
            //    {
            //        // 3의 배수일 경우
            //    }
            //    Console.WriteLine();
            //} // loop : 100번
            //Console.WriteLine("\n");
            //Console.WriteLine("=======================");
            //Console.WriteLine("총 합 : {0}", iSum_);
            //Console.WriteLine("=======================");

            //// 양의 정수를 입력받아 그 수만큼 "Hello, world!"를 출력.
            //int iSomeNumber = 100;
            //bool bIsPositiveInteger = (0 < iSomeNumber);

            //// 프로그램 사용자로부터 계속 정수를 입력 받는다. 입력 받은 갑슬 계속해서 더해나가며, 사용자가 '0'을 입력할 때까지 계속된다.
            //int iSomeNumber2 = 100;
            //bool bIsNumberZero = (iSomeNumber2 == 0);

            //// 프로그램 사용자로부터 입력 받은 정수에 해당하는 구구단을 출력하되, 역순으로 출력
            //int iUserInputNumber = 3;
            //for (int i = 9; i >= 9; i--)
            //{
            //    Console.WriteLine("{0} X {1} = {2}", iUserInputNumber, i, iUserInputNumber * i);
            //} // loop : 9번

            //Console.Write("\n\n");

            //// 프로그램 사용자로 부터 입력 받은 정수의 평균을 출력하는 프로그램. 두가지 조건 : 1. 먼저 몇개의 정수를 입력할 것인지 2. 그 수만큼 정수를 입력 받는다. 평균값은 소수점 이하까지.

            //// 컴퓨터가 숨기고 있는 비밀코드를 추측. 코드는 a ~ z 사이의 문자. 컴퓨터는 사용자의 추측을 읽고 사용자에게 힌트(up/down) 힌트를 준다.
            //char cScretCode = 'y';
            //char cUserInputAlphabet = 'c';
            //bool bIsSmallAlphabet = ('a' <= cUserInputAlphabet && cUserInputAlphabet <= 'z');
            //bool bISAlphabetFore = (cUserInputAlphabet < cScretCode);
            //bool bISAlphabetBack = (cUserInputAlphabet > cScretCode);
            //if (bIsSmallAlphabet) { /*Do Nothing*/ }
            //else
            //{
            //    Console.WriteLine("{0} {1}", "[System] 유효하지 않은 입력입니다.", "알파벳 소문자만을 입력해주세요.");
            //}
            //if (bISAlphabetFore)
            //{
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 앞에 있습니다.");
            //}
            //else {/* Do Nothing*/ }
            //if (bISAlphabetBack)
            //{
            //    Console.WriteLine("당신의 알파벳은 시크릿 코드보다 뒤에 있습니다.");
            //}
            //else {/* Do Nothing*/ }

            //// 1 ~ 100 숫자 중에서 3의 배수이면서 4의 배수인 정수의 합 구하기.
            //int iSumNumber = 0;
            //int iSomeNumber3 = 100;
            //bool bIsMultipleOfThree2 = (iSomeNumber3 % 3 == 0);
            //bool bIsMultipleOfFour = (iSomeNumber3 % 4 == 0);
            //bool bIsSatisfyCondition = bIsMultipleOfThree2 && bIsMultipleOfFour;
            //if (bIsSatisfyCondition)
            //{
            //    iSumNumber += iSomeNumber3;
            //}

            //// 별을 100번 찍는 법
            //for (int i = 0; i <= 100; i++) // 2중 for문
            //{
            //    Console.Write("{0} ", "*");
            //}
            //Console.WriteLine("\n");
            //for (int i = 0; i < 10; ++i)
            //{
            //    for (int i2 = 0; i2 < 10; ++i2)
            //    {
            //        Console.Write("{0} ", "*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //int iOneHundredCount = 0;
            //for (int i = 0; i < 10; ++i) // 3중 for문 
            //{
            //    for (int i2 = 0; i2 < 10; ++i2)
            //    {
            //        for (int i3 = 0; i3 < 10; ++i3)
            //        {
            //            iOneHundredCount++;
            //            if (100 < iOneHundredCount) { break; }
            //            else { /*Do Nothing*/ }
            //            Console.Write("{0} ", "*"); // 별 찍는 지점
            //            if (iOneHundredCount % 10 == 0) // 별을 10번 찍을 때마다 줄을 바꾼다.
            //            {
            //                Console.WriteLine();
            //            }
            //        }
            //    }
            //}

            //// 유저가 줄의 수를 입력 받아, 등차 수열로 한 줄이 내려갈 때마다 별 1개씩 추가로 증가하는 프로그램.(삼각형 2개씩 증가)
            //int fUserInputLine = default;
            //int.TryParse(Console.ReadLine(), out fUserInputLine);


            //if (fUserInputLine % 2 == 1)
            //{
            //    for (int i = 1; i <= fUserInputLine; i++)
            //    {
            //        for (int i2 = 1; i2 <= fUserInputLine; ++i2)
            //        {
            //            if (i2 + i <= fUserInputLine / 2 + 1 || i2 - i > fUserInputLine / 2 || i - i2 > fUserInputLine / 2 || (i + i2 > fUserInputLine + (fUserInputLine / 2 + 1)))
            //            {
            //                Console.Write("{0} ", "0");
            //            }
            //            else
            //            {
            //                Console.Write("{0} ", "X");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    for (int i = 1; i <= fUserInputLine; i++)
            //    {
            //        for (int i2 = 1; i2 <= fUserInputLine; ++i2)
            //        {
            //            if (i2 + i <= fUserInputLine / 2 || i2 - i > fUserInputLine / 2 || i - i2 > fUserInputLine / 2 || (i + i2 > fUserInputLine + (fUserInputLine / 2 + 1)))
            //            {
            //                Console.Write("{0} ", "0");
            //            }
            //            else
            //            {
            //                Console.Write("{0} ", "X");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //}



            // 야구 게임.
            Random rRandom = new Random();
            int[] arIntCorrectAnswer = new int[3];
            bool bDuplicationCheck = true;
            const int INT_ANSWER_COUNT = 3;

            while (bDuplicationCheck)
            {
                for (int i = 0; i < INT_ANSWER_COUNT; ++i)
                {
                    arIntCorrectAnswer[i] = rRandom.Next(1, 10);
                }
                for (int i = 0; i < INT_ANSWER_COUNT; i++)
                {
                    for (int j = 0; j < INT_ANSWER_COUNT; j++)
                    {
                        for (int k = 0; k < INT_ANSWER_COUNT; k++)
                        {
                            if (arIntCorrectAnswer[i] != arIntCorrectAnswer[j])
                            {
                                if (arIntCorrectAnswer[i] != arIntCorrectAnswer[k])
                                {
                                    if (arIntCorrectAnswer[j] != arIntCorrectAnswer[k])
                                    {
                                        bDuplicationCheck = false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("미리 정답 확인.");
            for (int i = 0; i < INT_ANSWER_COUNT; ++i)
            {
                Console.Write("<{0}번째 정답> :  {1}  ", i + 1, arIntCorrectAnswer[i]);
            }
            Console.WriteLine();

            const int INT_TRY_CHANCE = 9;

            int iLoopCount = 1;
            bool bGameOver = true;
            while (bGameOver)
            {
                int iBallCount = 0;
                int iStrikeCount = 0;
                bool bUserInputCheck = true;
                int[] arInt_InputUserAnswer = new int[3];

                while (bUserInputCheck) //
                {
                    Console.WriteLine("정답을 입력하세요. : ");
                    for (int j = 0; j < INT_ANSWER_COUNT; ++j)
                    {
                        Console.Write("{0}번째 투구 : ", j + 1);
                        int.TryParse(Console.ReadLine(), out arInt_InputUserAnswer[j]);
                    }
                    Console.WriteLine("유저의 투구 확인.");
                    for (int j = 0; j < INT_ANSWER_COUNT; ++j)
                    {
                        Console.Write("<{0}번째 투구> :  {1}  ", j + 1, arInt_InputUserAnswer[j]);
                    }
                    Console.WriteLine();


                    for (int j = 0; j < INT_ANSWER_COUNT; j++)
                    {
                        for (int k = 0; k < INT_ANSWER_COUNT; k++)
                        {
                            for (int l = 0; l < INT_ANSWER_COUNT; l++)
                            {
                                if (arInt_InputUserAnswer[j] != arInt_InputUserAnswer[k])
                                {
                                    if (arInt_InputUserAnswer[j] != arInt_InputUserAnswer[l])
                                    {
                                        if (arInt_InputUserAnswer[k] != arInt_InputUserAnswer[l])
                                        {
                                            bUserInputCheck = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }



                if ((arInt_InputUserAnswer[0] == arIntCorrectAnswer[0] || arInt_InputUserAnswer[1] == arIntCorrectAnswer[1]) || arInt_InputUserAnswer[2] == arIntCorrectAnswer[2])
                {
                    iStrikeCount++;
                }
                










                if (iStrikeCount == 3)
                {
                    Console.WriteLine("정답입니다.");
                    bGameOver = false;
                }







                Console.WriteLine("STRIKE : {0} , BALL {1}", iStrikeCount, iBallCount);

                // arIntCorrectAnswer[]
                // arInt_InputUserAnswer[]
                ++iLoopCount;
                if (iLoopCount == INT_TRY_CHANCE)
                {
                    bGameOver = false;
                }
            }











        }
















        //// <컬렉션>
        //// 이름 하나로 데이터 여러 개를 담을 수 있는 자료 구조를 컬렉션(Collection) 또는 컨테이너(Container)라고 한다. C#에서 다루는 컬렉션은 배열(Array), 리스트(List), 사전(Dictionary) 등이 있다.

        //// <배열>
        //// 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자료구조이다. 각각의 데이터들은 인덱스(번호)를 사용하여 독립적으로 접근된다. 배열을 사용하면 편리하게 데이터를 모아서 관리할 수 있다.

        //// <배열의 특징>
        //// 1. 배열 하나에는 데이터 형식 한 종류만 보관할 수 있다.
        //// 2. 배열은 메모리의 연속된 공간을 미리 할당하고, 이를 대괄호[]와 0부터 시작하는 정수형 인덱스를 사용하여 접근할 수 있다.
        //// 3. 배열을 선언할 때는 new 키워드로 배열을 생성한 후 사용할 수 있다.
        //// 4. 배열에서 값 하나는 요소(Element) 또는 항목(Item)으로 표현한다.
        //// 5. 필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이 향상된다.

        //// <배열의 종류>
        //// 1차원 배열 : 배열의 첨자를 하나만 사용하는 배열
        //// 다차원 배열 : 첨자 2개 이상을 사용하는 배열(n차원 배열)
        //// 가변(Jagged) 배열 : '배열의 배열'이라고도 하며, 이름 하나로 다양한 차원의 배열을 표현할 때 사용한다.

        //// <배열의 선언과 초기화>
        //int[] arIntNumbers = new int[5] { 1, 2, 3, 4, 5 };
        //for(int i = 0; i < arIntNumbers.Length; i++)
        //{
        //    Console.Write("{0}  ", arIntNumbers[i]);
        //}
        //Console.WriteLine();
        //Console.WriteLine(arIntNumbers[arIntNumbers.Length - 1]); // 마지막 배열의 수 확인.
        //foreach(int element in arIntNumbers) // element 에 arIntNumbers[] 배열을 저장하고, 배열인덱스가 달라진다.
        //{
        //    Console.Write("{0}  ", element);
        //}

        ////int iNum1 = 1;
        ////int iNum2 = 2;
        ////int iNum3 = 3;
        ////int iNum4 = 4;
        ////int iNum5 = 5;

        //Console.WriteLine();


















    } // 프로그램(Main) 읽기 범위(END).
}
