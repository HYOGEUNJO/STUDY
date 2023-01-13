namespace _1226_과제
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int FIVEBYFIVESQUARE = 5; // 범위 지정

            int i_MovePointX = 1; // 사람('옷') X축 시작지점
            int i_MovePointY = 1; // 사람('옷') Y축 시작지점

            string s_WASD = string.Empty;


            while (true)
            {
              

                for (int i = 0; i < FIVEBYFIVESQUARE; i++) // 5 * 5 맵 설정
                {
                    for (int j = 0; j < FIVEBYFIVESQUARE; j++) // 5 * 5 맵 설정
                    {
                        if (i == 0 || i == 4) // Y축의 벽 설정
                        {
                            Console.Write("■ ");
                        }
                        else if (j == 0 || j == 4) // X축의 벽 설정
                        {
                            Console.Write("■ ");
                        }
                        else
                        {
                            if (i == i_MovePointY && j == i_MovePointX) // 방향키 입력시 사람 출력 위치 설정
                            {
                                Console.Write("옷 ");
                            }
                            else // 벽과 사람을 제외한 맵에 '.' 출력
                            {
                                Console.Write(" . "); 
                            }
                        }
                    }
                    Console.WriteLine();
                }

                Console.Write("방향키(wasd) 중 하나를 입력해주세요  : "); // 방향키 입력
                s_WASD = Console.ReadLine(); // 방향키 입력
                Console.WriteLine();

                // 방향키 입력에 따른 사람 위치 변화
                if (s_WASD == "w") 
                {
                    i_MovePointY -= 1; 
                }
                else if (s_WASD == "a")
                {
                    i_MovePointX -= 1;
                }
                else if (s_WASD == "s")
                {
                    i_MovePointY += 1;
                }
                else if (s_WASD == "d")
                {
                    i_MovePointX += 1;
                }
                else // wasd를 제외한 입력에 오류 출력
                {
                    Console.WriteLine("[System] 유효하지 않는 입력입니다.");
                }

                // 사람이 벽에 충동할 경우 설정
                if(i_MovePointY == 0)
                {
                    Console.WriteLine("꽝! 벽에 부딪혔습니다!");
                    i_MovePointY += 1;
                }
                else if (i_MovePointY == 4)
                {
                    Console.WriteLine("꽝! 벽에 부딪혔습니다!");
                    i_MovePointY -= 1;
                }

                if(i_MovePointX == 0)
                {
                    Console.WriteLine("꽝! 벽에 부딪혔습니다!");
                    i_MovePointX += 1;
                }
                else if(i_MovePointX == 4)
                {
                    Console.WriteLine("꽝! 벽에 부딪혔습니다!");

                    i_MovePointX -= 1;
                }

                Console.WriteLine();
            }



















        }
    }
}