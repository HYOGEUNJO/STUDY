namespace 과제_조효근_20221227
{
    internal class Program
    {
        static void Main(string[] args) // 슬라이딩 퍼즐 만들기
        {

            int X_RANGE = 2;
            int Y_RANGE = 2;


            // 이중배열 생성
            int[,] ar2by2 = new int[Y_RANGE, X_RANGE];



            // 중복되지 않는 값 생성
            int[] iNumbers = new int[X_RANGE * Y_RANGE];
            Random random = new Random();

            for (int i = 0; i < iNumbers.Length; i++)
            {
                iNumbers[i] = random.Next(1, X_RANGE * Y_RANGE + 1);

                for (int j = 0; j < iNumbers.Length; j++)
                {
                    if (i == j)
                    {
                    }
                    else
                    {
                        if (iNumbers[i] == iNumbers[j])
                        {
                            i--;
                            break;
                        }
                    }
                }
            }






            int iNumbers_Index = 0; // 값 저장 인덱스


            // 포인터('X')의 위치 표시
            int iPointer_X = default;
            int iPointer_Y = default;

            //// 포인터의 유효범위 지정
            //bool iPointer_X_Range = iPointer_X >= 0 && iPointer_X < X_RANGE;
            //bool iPointer_Y_Range = iPointer_Y >= 0 && iPointer_Y < Y_RANGE;








            for (int Y = 0; Y < Y_RANGE; Y++)
            {
                for (int X = 0; X < X_RANGE; X++)
                {

                    ar2by2[Y, X] = iNumbers[iNumbers_Index];
                    iNumbers_Index++;

                }
            }



            int nTemp;
            for (int i = 0; i < iNumbers.Length - 1; i++)
            {
                for (int j = 0; j < iNumbers.Length - 1; j++)
                {
                    if (iNumbers[j] > iNumbers[j + 1])
                    {
                        nTemp = iNumbers[j + 1];
                        iNumbers[j + 1] = iNumbers[j];
                        iNumbers[j] = nTemp;
                    }
                }
            }


            iNumbers_Index = 0; // 인덱스 초기화, 이중배열에 값 저장시에 재사용


            // 정답문
            int[,] ar2by2Tmp = new int[Y_RANGE, X_RANGE];


            for (int Y = 0; Y < Y_RANGE; Y++)
            {
                for (int X = 0; X < X_RANGE; X++)
                {
                    ar2by2Tmp[Y, X] = iNumbers[iNumbers_Index];
                    iNumbers_Index++;
                }
            }




            bool bExit = true;
            while (bExit)
            {
                // 탈출문
                int iSuccessCheckCount = 0;
                bool bEndScreen = true;

                if (iSuccessCheckCount == X_RANGE * Y_RANGE)
                {
                    Console.WriteLine("성공하였습니다!");

                    bExit = false;
                    bEndScreen = false;
                }






                int nTmp = 0;





                Console.WriteLine("=============================");
                Console.WriteLine("========슬라이딩 퍼즐========");
                Console.WriteLine("=============================");
                Console.WriteLine("\n");



                for (int Y = 0; Y < Y_RANGE; ++Y)
                {
                    Console.Write("      ");
                    for (int X = 0; X < X_RANGE; X++)
                    {

                        if (ar2by2[Y, X] == X_RANGE * Y_RANGE)
                        {
                            iPointer_X = X;
                            iPointer_Y = Y; // 포인터의 X,Y축 위치 저장.

                            nTmp = ar2by2[Y, X];

                            Console.Write(" X      ");
                        }
                        else
                        {
                            Console.Write("{0:D2}      ", ar2by2[Y, X]);

                        }



                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n");


                Console.WriteLine("=============================");





                // 키값 설정
                ConsoleKeyInfo Key = Console.ReadKey(true);

                Console.Clear();

                char cKeyToChar = default;

                if (Key.Key == ConsoleKey.W)
                {
                    iPointer_Y -= 1;
                    cKeyToChar = 'w';
                }
                if (Key.Key == ConsoleKey.A)
                {
                    iPointer_X -= 1;
                    cKeyToChar = 'a';
                }
                if (Key.Key == ConsoleKey.S)
                {
                    iPointer_Y += 1;
                    cKeyToChar = 's';
                }
                if (Key.Key == ConsoleKey.D)
                {
                    iPointer_X += 1;
                    cKeyToChar = 'd';
                }
                if (Key.Key == ConsoleKey.Escape) // Esc누르면 프로그램 종료
                {
                    bExit = false;
                }


                switch (cKeyToChar)
                {
                    case 'w':
                        {
                            if (iPointer_Y < 0)
                            {
                                iPointer_Y += 1;
                            }
                            else
                            {
                                ar2by2[iPointer_Y + 1, iPointer_X] = ar2by2[iPointer_Y, iPointer_X];
                                ar2by2[iPointer_Y, iPointer_X] = nTmp;
                            }
                        }
                        break;
                    case 'a':
                        {
                            if (iPointer_X < 0)
                            {
                                iPointer_X += 1;
                            }
                            else
                            {
                                ar2by2[iPointer_Y, iPointer_X + 1] = ar2by2[iPointer_Y, iPointer_X];
                                ar2by2[iPointer_Y, iPointer_X] = nTmp;
                            }
                        }
                        break;
                    case 's':
                        {
                            if (iPointer_Y == Y_RANGE)
                            {
                                iPointer_Y += 1;
                            }
                            else
                            {
                                ar2by2[iPointer_Y - 1, iPointer_X] = ar2by2[iPointer_Y, iPointer_X];
                                ar2by2[iPointer_Y, iPointer_X] = nTmp;
                            }
                        }
                        break;
                    case 'd':
                        {
                            if (iPointer_X == X_RANGE)
                            {
                                iPointer_X -= 1;
                            }
                            else
                            {
                                ar2by2[iPointer_Y, iPointer_X - 1] = ar2by2[iPointer_Y, iPointer_X];
                                ar2by2[iPointer_Y, iPointer_X] = nTmp;
                            }
                        }
                        break;


                }



                for (int Y = 0; Y < Y_RANGE; Y++)
                {
                    for(int X = 0; X < X_RANGE; X++)
                    {
                        if (ar2by2[Y,X] == ar2by2Tmp[Y,X])
                        {
                            iSuccessCheckCount++;
                        }
                    }
                }
              


            }











        }

        // 콘솔 클리어하는 함수
        static void ClearLines(int lineNumber)
        {
            for (int i = 0; i < lineNumber; i++)
            {
                Console.WriteLine();
            }
        }


    }
}