namespace _1222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 모드 연산
            //int iExNumber = 1_0822;
            //Console.WriteLine("64로 Mod 연산 : {0}", iExNumber % 64);

            //// <다차원 배열>
            //// 2차원 배열, 3차원 배열처럼 차원이 2개 이상인 배열을 다차원 배열이라고 한다.
            //// C#에서 배열을 선언할 떄는 콤마를 기준으로 차원을 구분한다.
            //int[] iArExArray = new int[2] { 1, 2 };
            //int[,] iArExTwoArray = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            //int[,] iArExTwoArray2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            //int[,] iArExTwoArray3 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //int[,,] iArExThreeArray = new int[2, 2, 2]
            //{
            //{ { 1, 2 }, { 3, 4 } },
            //{ { 5, 6 }, { 7, 8 } }
            //};
            //// 3행 3열 짜리 배열에서 행과 열이 같으면 1, 다른면 0을 출력.
            //iArExTwoArray = new int[3, 3];
            //for (int y = 0; y < 3; y++) // 입력
            //{
            //    for (int x = 0; x < 3; x++)
            //    {
            //        if (x == y)
            //        {
            //            iArExTwoArray[y, x] = 1;
            //        }
            //        else
            //        {
            //            iArExTwoArray[y, x] = 0;
            //        }
            //    }
            //}

            //for (int y = 0; y <= iArExTwoArray.GetUpperBound(0); y++)
            //{
            //    for (int x = 0; x <= iArExTwoArray.GetUpperBound(1); x++)
            //    {
            //        Console.Write("{0} ", iArExTwoArray[y, x]);
            //    }
            //    Console.WriteLine();
            //} // 출력
            //Console.WriteLine();

            //// <가변 배열>
            //// 차원이 2개 이상인 배열은 다차원 배열이고, 배열 길이가 가변 길이인 배열은 가변 배열이라고 한다.
            //int[][] iAr_ExAdjustableTwo = new int[2][];
            //iAr_ExAdjustableTwo[0] = new int[2] { 1, 2 };
            //iAr_ExAdjustableTwo[1] = new int[3] { 3, 4, 5 };
            //for (int y = 0; y < 2; y++)
            //{
            //    for (int x = 0; x < iAr_ExAdjustableTwo[y].Length; x++)
            //    {
            //        Console.Write("{0} ", iAr_ExAdjustableTwo[y][x]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //// 배열 설명
            //int[] iAr_ExamExplain;          // int형 데이터 타입의 배열을 선언
            //iAr_ExamExplain = new int[3];   // 데이터 타입의 변수 3개를 메모리에 할당.
            //iAr_ExamExplain[0] = 1;         // 0번째 인덱스에 1이라는 정수값을 대입
            //iAr_ExamExplain[1] = 2;         // 1번째 인덱스에 2이라는 정수값을 대입
            //iAr_ExamExplain[2] = 3;         // 2번째 인덱스에 3이라는 정수값을 대입
            //for (int i = 0; i < iAr_ExamExplain.Length; i++)
            //{
            //    Console.WriteLine("{0}번째 인덱스의 값 -> {1}", i, iAr_ExamExplain[i]);
            //} // loop 3번
            //Console.WriteLine();
            //// iAr_ExamExplain 배열에서 int 형 데이터 타입의 값을 하나씩 뽑아서 index에 저장할 것이다.
            //foreach (int index in iAr_ExamExplain)
            //{
            //    Console.WriteLine("iAr_ExamExplain 배열에서 뽑아온 값  : {0}", index);
            //} // loop : iAr_ExamExplain 배열의 길이만큼 도는 루프
            //Console.WriteLine();

            //// 예제 1. 배열을 사용하여 국어 점수의 총점과 평균 구하기.
            //// 학생 3명의 점수를 저장하는 배열 선언하여 각 학생별로 점수를 할당하고 (범위는 1~100점)
            //// 모든 학생의 총점과 평균을 구해서 출력하는 프로그램. 
            //// 유저 인풋(점수) 받아서 프로그램 작성 해볼 것(입력하라는 것).
            //// 이상한 입력 예외처리.
            //int[] iAr_StudentKoreanScore = new int[3];
            //int i_KoreanSum = 0;
            //double d_KoreanAver = 0;
            //int i_loopCountKorean = 0;
            //bool b_KoreanScoreCheck = true;
            //Console.WriteLine("유저의 점수를 입력하세요."); // 점수입력
            //while (b_KoreanScoreCheck)
            //{
            //    int iUserInput = default;
            //    int.TryParse(Console.ReadLine(), out iUserInput);
            //    if (iUserInput > 0 && iUserInput <= 100)
            //    {
            //        iAr_StudentKoreanScore[i_loopCountKorean] = iUserInput;
            //        i_KoreanSum += iAr_StudentKoreanScore[i_loopCountKorean];
            //        i_loopCountKorean++;


            //    }
            //    else
            //    {
            //        Console.WriteLine("[System] 유효하지 않는 입력입니다. 재입력 해주세요");
            //        continue;
            //    }
            //    if (i_loopCountKorean == 3)
            //    {
            //        b_KoreanScoreCheck = false;
            //    }
            //}
            //d_KoreanAver = Math.Round((double)(i_KoreanSum) / (iAr_StudentKoreanScore.Length), 2);
            //Console.WriteLine("총점 : {0} , 평균 : {1}", i_KoreanSum, d_KoreanAver);

            //// 예제 2. 배열에서 최대값 찾기.
            //int[] iAr_FindMaximum = new int[100];
            //Random rRandom = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    iAr_FindMaximum[i] = rRandom.Next(1, 101);
            //}

            //int i_LoopCountFindMaximum = 0;
            //Console.WriteLine("<생성값 확인>");
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write("{0}  ", iAr_FindMaximum[i_LoopCountFindMaximum]);
            //        i_LoopCountFindMaximum++;
            //    }
            //    Console.WriteLine();
            //}

            //int i_TmpFindMaximum = iAr_FindMaximum[0];
            //int i_TmpIndexFindMaximum = 0;
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i_TmpFindMaximum < iAr_FindMaximum[i])
            //    {
            //        i_TmpFindMaximum = iAr_FindMaximum[i];
            //        i_TmpIndexFindMaximum = i;
            //    }
            //}
            //Console.WriteLine("최대값 : {0}", i_TmpFindMaximum);








            // 예제 3. 사과를 제일 좋아하는 사람 찾기.

            string[] sPersonName = new string[5]; /*{ "철수", "영희", "민수" };*/
            for (int i = 0; i < sPersonName.Length; i++)
            {
                sPersonName[i] = "A" + i;
            }
            for (int i = 0; i < sPersonName.Length; i++)
            {
                Console.WriteLine(sPersonName[i]);
            }
            int[] iAppleNumber = new int[5];

            // 입력 1. 직접 입력(중복 제외 및 미유효 입력 제외)

            bool bSettingCheck = true;

            //while (bSettingCheck)
            {
                //bool bIsDuplicate = false; // 직접 입력시 경고 신호

                for (int iCountInput = 0; iCountInput < iAppleNumber.Length; iCountInput++)
                {
                    /*Console.WriteLine("{0}의 사과 개수를 입력하세요.", sPersonName[iCountInput]);

                    int iIsRightInput = default;
                    bool bIsRightInput = int.TryParse(Console.ReadLine(), out iIsRightInput);
                    if (bIsRightInput && (iIsRightInput > 0 && iIsRightInput <= 100))
                    {
                        iAppleNumber[iCountInput] = iIsRightInput;
                    }
                    else
                    {
                        Console.WriteLine("[System] 잘못된 입력");
                        iCountInput -= 1;
                    }*/ // 직접 입력시

                    // 랜덤 난수
                    Random rRandom = new Random();
                    iAppleNumber[iCountInput] = rRandom.Next(1,6);


                }
                for (int i = 0; i < iAppleNumber.Length; i++)
                {
                        Console.WriteLine("{0}  ",iAppleNumber[i]);
                }
                // 중복 확인
                for (int i = 0; i < iAppleNumber.Length; i++)
                {
                    for(int j = 0; j < iAppleNumber.Length; j++)
                    {
                        
                    }
                }



                /*for (int i = 0; i < iAppleNumber.Length - 1; i++)
                {
                    for (int j = 0; j < iAppleNumber.Length - 1 - i; j++)
                    {

                        if (iAppleNumber[i] == iAppleNumber[j + 1 + i])
                        {
                            bIsDuplicate = true; 
                        }
                        else
                        {
                            bSettingCheck = false;
                        }


                    }
                }*/ //  직접입력시

                // 알림 메세지
                /*if (bIsDuplicate)
                {
                    Console.WriteLine("[System]중복. 다시 입력해주세요.");
                    bSettingCheck = true;
                }
                else
                {
                    Console.WriteLine("각자의 사과 개수 확인.");
                    for (int i = 0; i < iAppleNumber.Length; i++)
                    {
                        Console.WriteLine("{0}의 사과 개수 : {1} ,", sPersonName[i], iAppleNumber[i]);
                    }
                    Console.WriteLine();

                }*/
            } // while



            



            //for (int i = 0; i < iAppleEatingNumber.Length; i++)
            //{
            //    Console.WriteLine("{0}", iAppleEatingNumber[i]);
            //}
            // 입력 2. 정렬 도전 시 유저 입력 제외. 데이터는 난수로 채워놓고 중복제거.


        }
    }
}


//////////////////////////////////////////////////////////////
//// 사람과 개수를 3*2 배열로 통합.
//string[,] sAr_SaveOrigin = new string[3, 2];

//for (int i = 0; i <= sAr_SaveOrigin.GetUpperBound(0); i++)
//{
//    for (int j = 0; j <= sAr_SaveOrigin.GetUpperBound(1); j++)
//    {
//        if (j == 0)
//        {
//            if (i == 0)
//            {
//                sAr_SaveOrigin[i, j] = sPersonName[i];
//            }
//            else if (i == 1)
//            {
//                sAr_SaveOrigin[i, j] = sPersonName[i];
//            }
//            else
//            {
//                sAr_SaveOrigin[i, j] = sPersonName[i];
//            }

//        }
//        else // if (j == 1)
//        {
//            if (i == 0)
//            {
//                sAr_SaveOrigin[i, j] = iAppleNumber[i].ToString();
//            }
//            else if (i == 1)
//            {
//                sAr_SaveOrigin[i, j] = iAppleNumber[i].ToString();
//            }
//            else
//            {
//                sAr_SaveOrigin[i, j] = iAppleNumber[i].ToString();
//            }
//        }
//    }
//}
//for (int i = 0; i <= sAr_SaveOrigin.GetUpperBound(0); i++)
//{
//    for (int j = 0; j <= sAr_SaveOrigin.GetUpperBound(1); j++)
//    {
//        Console.Write(" {0} ", sAr_SaveOrigin[i, j]);
//    }
//    Console.WriteLine();
//}