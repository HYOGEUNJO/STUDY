

namespace _1220
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // <조건문2>
            // 선택문인 switch 문은 값에 따라 다양한 제어를 처리할 수 있다. 조건을 처리할 내용이 많은 경우 유용하다.
            // switch, case, default 키워드를 사용하여 조건을 처리한다.
            Console.Write("정수 1, 2, 3 중에 하나를 입력하시오 : ");
            int switchNumber = 0;
            int.TryParse(Console.ReadLine(), out switchNumber);

            switch (switchNumber)
            {
                case 1:
                    {
                        Console.WriteLine("1을(를) 입력하였습니다.");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("2을(를) 입력하였습니다.");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("3을(를) 입력하였습니다.");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("처리하지 않는 예외 입력입니다.");
                    }
                    break;
            } // switch
            //switch (switchNumber) // 추가설명 1.
            //{
            //    case 1: // 이 경우 1, 2, 3 모두 입력해도 case 3: 이 적용된다.
            //    case 2:
            //    case 3:
            //        {
            //            Console.WriteLine("3을(를) 입력하였습니다.");
            //        }
            //        break;
            //    default:
            //        {
            //            Console.WriteLine("처리하지 않는 예외 입력입니다.");
            //        }
            //        break;
            //} // switch
            //switch (switchNumber) // 추가설명 2.
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("1을(를) 입력하였습니다.");
            //            goto case 3; // case 1: 이 적용될 때 case 3: 도 함께 적용된다. but, 왠만하면 사용하지 말자. goto 를 사용하였다는 것은 로직이 잘못된 경우가 많다.
            //        }
            //        break;
            //    case 2:
            //        {
            //            Console.WriteLine("2을(를) 입력하였습니다.");
            //        }
            //        break;
            //    case 3:
            //        {
            //            Console.WriteLine("3을(를) 입력하였습니다.");
            //        }
            //        break;
            //    default:
            //        {
            //            Console.WriteLine("처리하지 않는 예외 입력입니다.");
            //        }
            //        break;
            //} // switch

            // 예제 1.
            Console.WriteLine("가장 좋아하는 프로그래밍 언어는?");
            Console.Write("1. C\t");
            Console.Write("2. C++\t");
            Console.Write("3. C#\t");
            Console.Write("4. Java\t");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("C 선택");
                    break;
                case 2:
                    Console.WriteLine("C++ 선택");
                    break;
                case 3:
                    Console.WriteLine("C# 선택");
                    break;
                case 4:
                    Console.WriteLine("Java 선택");
                    break;
                default:
                    Console.WriteLine("[System] 처리하지 않은 예외 입력입니다");
                    break;
            } // switch
            // 예제 2.
            Console.WriteLine("오늘의 날씨는 어떤가요?");
            string weather = Console.ReadLine(); // 숫자뿐만이 아니라 문자열도 입력할 수 있다.
            switch (weather)
            {
                case "맑음":
                    Console.WriteLine("오늘 날씨가 맑군요");
                    break;
                case "흐림":
                    Console.WriteLine("오늘 날씨가 흐리군요");
                    break;
                case "비":
                    Console.WriteLine("오늘 날씨가 비가 오는군요");
                    break;
                default:
                    Console.WriteLine("혹시 눈이 내리나요?");
                    break;
            }

            // while 문은 조건식이 참일 동안 문장을 반복 실행한다.
            // 5번만 실행할 경우
            int loopCounter = 0;
            while (loopCounter < 5)
            {
                Console.WriteLine("{0}번째 반복문 실행", loopCounter + 1);
                loopCounter++;
            }
            // 10부터 카운트 후 발사
            loopCounter = 10;
            while (loopCounter > 0)
            {
                Console.WriteLine("{0}  ", loopCounter);
                loopCounter -= 1;
                if (loopCounter == 0)
                {
                    Console.WriteLine("발사");
                }
            }
            //예제 1.구구단 프로그램 작성. User_input 받아서 해당 단을 출력
            Console.Write("출력하고 싶은 단 입력 : ");
            int user_input_dan = default;
            int.TryParse(Console.ReadLine(), out user_input_dan);
            const int DEFAULT_LOOP = 9;
            int loopCount = 1;
            while (loopCount <= DEFAULT_LOOP)
            {
                Console.WriteLine("{0} X {1} = {2}", user_input_dan, loopCount, user_input_dan * loopCount);
                loopCount++;
            }
            // 예제 2. 양의 정수를 입력받은 만틈 "Hello, world!"를 출력
            Console.Write("양의 정수를 입력하시오. : ");
            int loopCount1 = 0;
            bool bCheck1 = true;
            while (bCheck1)
            {
                int userInput1 = default;
                int.TryParse(Console.ReadLine(), out userInput1);
                if (userInput1 < 1)
                {
                    Console.Write("[System] 처리하지 않는 예외입니다. 다시 입력해주세요. : ");
                }
                else
                {
                    while (loopCount1 < userInput1)
                    {
                        Console.WriteLine("Hello, world!");
                        loopCount1++;
                    }
                    bCheck1 = false;
                }
            }
            // 예제 3. 양의 정수를 입력받아, 3의 배수를 출력.
            Console.Write("양의 정수를 입력하시오. : ");
            bool bCheck2 = true;
            int loopCount2 = 0;
            while (bCheck2)
            {
                int userInput2 = default;
                int.TryParse(Console.ReadLine(), out userInput2);
                if (userInput2 < 1)
                {
                    Console.Write("[System] 처리하지 않는 예외입니다. 다시 입력해주세요. : ");
                }
                else
                {
                    while (loopCount2 < userInput2)
                    {
                        Console.Write("{0}  ", 3 * (loopCount2 + 1));
                        loopCount2++;
                    }
                    Console.WriteLine();
                    bCheck2 = false;
                }
            }
            // 예제 4. 0을 입력할 때까지 입력한 모든 정수를 출력하라
            bool bCheck3 = true;
            int iSum = 0;
            while (bCheck3)
            {
                Console.WriteLine("양의 정수를 입력하시오.(0을 입력하면 종료됩니다.) : ");
                int userInput3 = default;
                int.TryParse(Console.ReadLine(), out userInput3);
                iSum += userInput3;
                Console.WriteLine("현재까지 총 합 : {0}", iSum);
                if (userInput3 == 0)
                {
                    bCheck3 = false;
                }
            }
            // 예제 5. 역순으로 구구단 출력
            Console.Write("출력하고 싶은 단 입력 : ");
            int user_input_dan2 = default;
            int.TryParse(Console.ReadLine(), out user_input_dan2);
            const int DEFAULT_LOOP2 = 0;
            int loopCount4 = 9;
            while (loopCount4 > DEFAULT_LOOP2)
            {
                Console.WriteLine("{0} X {1} = {2}", user_input_dan2, loopCount4, user_input_dan2 * loopCount4);
                loopCount4--;
            }
            // 예제 6. 정수의 평균을 출력하는 프로그램. 단, 총 입력할 개수를 물어보고, 평균값은 소수점 이하까지 출력하라.
            Console.Write("몇 개 입력할겁니까? : ");
            int userCount3 = default;
            int.TryParse(Console.ReadLine(), out userCount3);
            int userInput4 = default;
            int iSum2 = default;
            int loopCount3 = userCount3;
            while (loopCount3 > 0)
            {
                Console.WriteLine("정수를 입력하세요. : ");
                int.TryParse(Console.ReadLine(), out userInput4);
                iSum2 += userInput4;
                loopCount3--;
            }
            Console.WriteLine("평균 : {0}", (float)iSum2 / (float)userCount3);

            // for 문은 일정한 횟수만큼 반복할 때 유용하다. 
            // 초기식을 실행한 후에 조건식이 참인 동안, 문장을 반복한다. 한번 반복이 끝날 때마다 증감식이 실행된다.
            //int sumNumber = 0;
            //// loop 순서
            ////                  8.          10. ~~~
            ////                  5.          7.
            ////      1.          2.          4.   
            //for (int index = 0; index < 10; index++)
            //{
            //    // 9.
            //    // 6.
            //    // 3. 
            //    sumNumber += index;
            //}
            //Console.WriteLine($"1부터 10까지의 정수의 합 = {sumNumber}");
            //Console.WriteLine("1부터 10까지의 정수의 합 = {0}", sumNumber);
            //예제 1.
            int iSum100 = 0;
            Console.Write("1 부터 100 까지의 수 중 3의 배수가 아닌 수 :  ");
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                    //// Do Nothing.
                }
                else
                {
                    Console.Write("{0}  ", i);
                    iSum100 += i;
                }
            }
            Console.WriteLine();
            Console.WriteLine(iSum100);

            // break 문
            // 반복 루프를 벗어나기 위해서 사용한다. break 문이 실행되면 반복 루프는 즉시 중단되고 반복 루프 다음에 있는 문장이 실행된다.
            // continue 문
            // 현재 수행하고 있는 반복 과정의 나머지를 건너뛰고 다음 반복 과정을 강제적으로 시작하게 만든다. 
            // 반복 루프에서 continue 문을 만나게 되면 continue 문 다음에 있는 후속 코드들은 실행되지 않고 건너뛰게 된다.
            //for (int index = 1; index <= 10; index++)
            //{
            //    if (index == 4) { break; }
            //    Console.WriteLine("현재 인덱스 : {0}", index);
            //}
            //예제 1.영문 자음과 모음의 개수를 세기(대, 소문자 모두) ***
            string consonant = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXyYzZ";
            char[] splitConsonant = new char[consonant.Length];
            int splitConsonantcount = 0;
            foreach (char oneAlpha in consonant)
            {
                splitConsonant[splitConsonantcount] = oneAlpha;
                splitConsonantcount++;
            }
            string vowel = "aAeEiIoOuU";
            char[] splitVowel = new char[vowel.Length];
            int splitVowelcount = 0;
            foreach (char oneAlpha in vowel)
            {
                splitVowel[splitVowelcount] = oneAlpha;
                splitVowelcount++;
            }
            Console.Write("영어 단어를 입력하세요. : ");
            string inputEnglishWord = Console.ReadLine();
            char[] splitInputEnglishWord = new char[inputEnglishWord.Length];
            int wordCount = 0;
            foreach (char oneAlpha in inputEnglishWord)
            {
                splitInputEnglishWord[wordCount] = oneAlpha;
                wordCount++;
            }
            int iConsonantCount = 0;
            int iVowelCount = 0;
            for (int i = 0; i < splitInputEnglishWord.Length; ++i)
            {
                for (int i2 = 0; i2 < splitConsonant.Length; ++i2)
                {
                    if (splitInputEnglishWord[i] == splitConsonant[i2])
                    {
                        iConsonantCount++;
                    }
                }
                for (int i2 = 0; i2 < splitVowel.Length; ++i2)
                {
                    if (splitInputEnglishWord[i] == splitVowel[i2])
                    {
                        iVowelCount++;
                    }
                }
            }
            Console.WriteLine("자음 : {0}개 , 모음 {1}개", iConsonantCount, iVowelCount);
            // 예제 2.숫자 맞추기 게임 ***
            Random rRandom = new Random();
            int iCorrectNumber = rRandom.Next(1, 101);
            Console.WriteLine("정답 : {0}", iCorrectNumber);
            bool bLoopEnd = true;
            while (bLoopEnd)
            {
                int iAnswerNumber = default;
                int.TryParse(Console.ReadLine(), out iAnswerNumber);
                if (iAnswerNumber > 100 || iAnswerNumber < 1)
                {
                    Console.WriteLine("[System] 유효하지 않은 입력값 입니다. 1부터 100까지의 수를 입력하세요.");
                    continue;
                }
                if (iCorrectNumber == iAnswerNumber)
                {
                    Console.WriteLine("정답입니다.");
                    bLoopEnd = false; // break;
                }
                else if (iCorrectNumber > iAnswerNumber)
                {
                    Console.WriteLine("입력값 : {0}\n정답은 입력값보다 큰 수 입니다.", iAnswerNumber);
                }
                else
                {
                    Console.WriteLine("입력값 : {0}\n정답은 입력값보다 작은 수 입니다.", iAnswerNumber);
                }
            }
            //예제 2 - 1.사용자가 맞추는 것이 아닌 사용자가 결정한 번호를 컴퓨터가 추측하도록 수정.사용자는 컴퓨터에게 높거나 낮은지를 알려줘야 한다. 컴퓨터가 맞출때까지 반복.
            Random rRandom2 = new Random();
            Console.Write("정답을 입력해주세요 : ");
            int iUserCorrectAnser = default;
            int.TryParse(Console.ReadLine(), out iUserCorrectAnser);
            int iComputerAnswerUpper = 101;
            int iComputerAnswerLower = 1;
            int iComputerAnswer = rRandom2.Next(iComputerAnswerLower, iComputerAnswerUpper);
            bool bLoopEnd2 = true;
            int iUserAnswer = default;
            string UPDOWN = string.Empty;
            while (bLoopEnd2)
            {
                if (iUserCorrectAnser == iComputerAnswer)
                {
                    Console.WriteLine("컴퓨터의 대답 : {0}\n컴퓨터가 맞추었습니다.", iComputerAnswer);
                    bLoopEnd2 = false;
                }
                else
                {
                    Console.WriteLine("컴퓨터의 대답 : {0}", iComputerAnswer);
                    Console.Write("컴퓨터에게 UP 혹은 DOWN을 말씀해주세요 : ");
                    int.TryParse(Console.ReadLine(), out iUserAnswer);


                    if (iUserAnswer == 1) // UP
                    {
                        iComputerAnswerLower = iComputerAnswer + 1;
                        iComputerAnswer = rRandom2.Next(iComputerAnswerLower, iComputerAnswerUpper);
                    }
                    else if (iUserAnswer == 0) // DOWN
                    {
                        iComputerAnswerUpper = iComputerAnswer;
                        iComputerAnswer = rRandom2.Next(iComputerAnswerLower, iComputerAnswerUpper);
                    }
                }
            }
            // 예제 2-2. 예제 2-1에서 7번 이하로 컴퓨터가 맞출 수 있게 하여라.
            Random rRandom4 = new Random();
            Console.Write("정답을 입력해주세요 : ");
            int iUserCorrectAnser2 = default;
            int.TryParse(Console.ReadLine(), out iUserCorrectAnser2);
            int iComputerAnswerUpper2 = 101;
            int iComputerAnswerLower2 = 1;
            int iComputerAnswer2 = 100; //rRandom4.Next(iComputerAnswerLower2, iComputerAnswerUpper2);
            bool bLoopEnd3 = true;
            int iUserAnswer2 = default;
            int iComputerAnswerLoopCount = 0;
            while (bLoopEnd3)
            {
                if (iUserCorrectAnser2 == iComputerAnswer2)
                {
                    Console.WriteLine("컴퓨터의 대답 : {0}, LoopCount : {1}({2})\n컴퓨터가 맞추었습니다.", iComputerAnswer2,iComputerAnswerLoopCount, iComputerAnswerLoopCount+1);
                    bLoopEnd3 = false;
                }
                else
                {
                    Console.WriteLine("컴퓨터의 대답 : {0} , Loop Count : {1}({2})", iComputerAnswer2,iComputerAnswerLoopCount, iComputerAnswerLoopCount+1);
                    Console.Write("컴퓨터에게 UP 혹은 DOWN을 말씀해주세요 : ");
                    int.TryParse(Console.ReadLine(), out iUserAnswer2);

                    if (iUserAnswer2 == 1) // UP
                    {
                        iComputerAnswerLower2 = iComputerAnswer2;
                    }
                    else if (iUserAnswer2 == 0) // DOWN
                    {
                        iComputerAnswerUpper2 = iComputerAnswer2;
                    }
                    iComputerAnswer2 =(iComputerAnswerUpper2 + iComputerAnswerLower2)/2 ;
                    iComputerAnswerLoopCount++;
                }
            }
            // 예제 3. 산수 문제 자동 출제. 덧셈 문제를 자동으로 생성. 피연산자는 0 ~ 99 사이의 숫자(난수) 한 번이라도 맞으면 종료. 틀리면 리트라이(기본형) ***
            // 예제 3-1. 뺼셈, 곱셈, 나눗셈 문제도 출제
            Random rRandom3 = new Random();
            bool bMathProblem = true;
            bool bMathOK = true;
            bool bStart = true;
            while (bMathProblem)
            {
                Console.Write("무슨 문제(더하기, 빼기, 곱하기, 나누기) 풀래? : ");
                string sUserProblemChoice = Console.ReadLine();
                string sAddition = "더하기";
                string sSubtraction = "빼기";
                string sMultiply = "곱하기";
                string sDivide = "나누기";
                if (sUserProblemChoice == sAddition)
                {
                    int sNumber1, sNumber2;
                    sNumber2 = default;
                    sNumber1 = default;
                    while (bMathOK)
                    {
                        sNumber1 = rRandom3.Next(1, 100);
                        sNumber2 = rRandom3.Next(1, 100);
                        if (sNumber1 + sNumber2 < 100)
                            bMathOK = false;
                    }
                    while (bStart)
                    {
                        Console.Write("{0} + {1} = 정답 : ", sNumber1, sNumber2);
                        int iUserAns = default;
                        int.TryParse(Console.ReadLine(), out iUserAns);
                        if (iUserAns == (sNumber1 + sNumber2))
                        {
                            Console.WriteLine("정답입니다.");
                            bStart = false;
                        }
                        else
                        {
                        }
                    }
                }
                else if (sUserProblemChoice == sSubtraction)
                {
                    int sNumber1, sNumber2;
                    sNumber2 = default;
                    sNumber1 = default;
                    while (bMathOK)
                    {
                        sNumber1 = rRandom3.Next(1, 100);
                        sNumber2 = rRandom3.Next(1, 100);
                        if (sNumber1 > sNumber2)
                            bMathOK = false;
                    }
                    while (bStart)
                    {
                        Console.Write("{0} - {1} = 정답 : ", sNumber1, sNumber2);
                        int iUserAns = default;
                        int.TryParse(Console.ReadLine(), out iUserAns);
                        if (iUserAns == (sNumber1 - sNumber2))
                        {
                            Console.WriteLine("정답입니다.");
                            bStart = false;
                        }
                        else
                        {
                        }
                    }
                }
                else if (sUserProblemChoice == sMultiply)
                {
                    int sNumber1, sNumber2;
                    sNumber2 = default;
                    sNumber1 = default;
                    while (bMathOK)
                    {
                        sNumber1 = rRandom3.Next(1, 100);
                        sNumber2 = rRandom3.Next(1, 100);
                        if (sNumber1 * sNumber2 < 100)
                            bMathOK = false;
                    }
                    while (bStart)
                    {
                        Console.Write("{0} * {1} = 정답 : ", sNumber1, sNumber2);
                        int iUserAns = default;
                        int.TryParse(Console.ReadLine(), out iUserAns);
                        if (iUserAns == (sNumber1 * sNumber2))
                        {
                            Console.WriteLine("정답입니다.");
                            bStart = false;
                        }
                        else
                        {
                        }
                    }
                }
                else if (sUserProblemChoice == sDivide)
                {
                    double sNumber1, sNumber2;
                    sNumber2 = default;
                    sNumber1 = default;
                    while (bMathOK)
                    {
                        sNumber1 = rRandom3.Next(1, 100);
                        sNumber2 = rRandom3.Next(1, 100);
                        bMathOK = false;
                    }
                    while (bStart)
                    {
                        Console.Write("{0} / {1} = 정답 : ", sNumber1, sNumber2);
                        double iUserAns = default;
                        double.TryParse(Console.ReadLine(), out iUserAns);
                        if (iUserAns == Math.Round(sNumber1 / sNumber2, 2))
                        {
                            Console.WriteLine("정답입니다.");
                            bStart = false;
                        }
                        else
                        {
                        }
                    }
                }
                else
                {
                    Console.WriteLine("[System] 유효하지 않는 입력입니다.");
                    continue;
                }
                break;
            }

            // foreach 문은 배열(Array)이나 컬렉션(Collection) 같은 값을 여러 개 담고 있는 데이터 구조에서 각각의 데이터가 들어있는 만큼 반복하는 반복문이다. 데이터 개수나 반복 조건을 처리할 필요가 없다.
            // string 에서 글자를 하나씩 출력
            string stringText = "Hello, world!";
            int loopCount5 = 0;
            foreach (char oneCharacter in stringText)
            {
                Console.Write("{0}  ", oneCharacter);
                loopCount5++;
            }
            Console.WriteLine();
            Console.WriteLine("Loop Count : {0} , stringText's Length : {1}", loopCount5, stringText.Length);
            // 예제 1. 1 ~ 100 까지의 숫자 중에서 3의 배수이면서 4의 배수인 정수의 합 구하기
            int[] arInt1to100 = new int[100];
            for (int i = 1; i <= 100; ++i)
            {
                arInt1to100[i - 1] = i;
            }
            int isumm = 0;
            foreach (int inumbers3or4 in arInt1to100)
            {
                if ((inumbers3or4 % 3) == 0 && (inumbers3or4 % 4) == 0)
                {
                    isumm += inumbers3or4;
                }
            }
            Console.WriteLine("3의 배수이면서 4의 배수인 정수의 합 : {0}", isumm);
            // 예제 2. 두 개의 정수를 입력 받아서 두 수의 차를 출력하는 프로그램 작성. 항상 큰 수에서 작은 수를 뺀 결과를 출력할 것.
            while (true)
            {
                Console.WriteLine("두 개의 정수를 입력하시오.");
                int inputN1 = default;
                int.TryParse(Console.ReadLine(), out inputN1);
                int inputN2 = default;
                int.TryParse(Console.ReadLine(), out inputN2);
                if (inputN1 < 0 || inputN2 < 0)
                {
                    Console.WriteLine("다시 입력하세요.");
                    continue;
                }
                if (inputN1 > inputN2)
                {
                    Console.WriteLine("{0} - {1} = {2}", inputN1, inputN2, inputN1 - inputN2);
                }
                else if (inputN1 < inputN2)
                {
                    Console.WriteLine("{0} - {1} = {2}", inputN2, inputN1, inputN2 - inputN1);
                }
                else
                {
                    Console.WriteLine("다시 입력하세요.");
                }
            }
            // 예제 3. 구구단을 출력하되 짝수(2, 4, 6, 8)만 출력되도록 하며, 행은 각 단의 수만큼만 출력하여라.(2단 = 2 * 2, 4단 = 4 * 4), break/continue를 사용하여라.
            for (int i = 2; i <= 8; i = i + 2)
            {
                for (int i2 = 1; i2 <= i; ++i2)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, i2, i * i2);
                }
            }
            // 예제 4. 다음 식을 만족하는 모든 A와 Z를 구하는 프로그램을 작성.
            //     A Z
            //  +  Z A
            //  -------
            //     9 9
            int A = default;
            int Z = default;
            for (A = 0; A <= 9; ++A)
            {
                for (Z = 0; Z <= 9; ++Z)
                {
                    if ((10 * A + Z) == (10 * Z + A))
                    {
                        Console.WriteLine("A : {0}, Z : {1}", A, Z);
                    }

                }
            }


        }
    }
}

////블로그 과제
// 부동소수점
// 앱실론

//// 일반과제
//// *** 표시한 예제를 모든라인에서 각 라인이 어떤 역할을 하는지 주석으로 설명해서 제출할 것.(형태 zip파일, *gitignore참고, 용량)
// 파일명 : 과제_이름_날짜.zip