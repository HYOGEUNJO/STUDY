using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1230
{
    public class PACKMAN
    {
        // private
        private string[,] m_Map;
        private int m_X_Scale;
        private int m_Y_Scale;


        private string m_Man;
        private int m_Man_X;
        private int m_Man_Y;


        private string m_Coin1;
        private int m_Coin1_X;
        private int m_Coin1_Y;



        private int m_Coin_Count;


        private Random Rand;


        private ConsoleKeyInfo m_key;





        // public
        public void Set_Map(int X_Scale, int Y_Scale) // set 형식 , 보여주는 것이 아니라 전체적인 좌표에 벽과 이동가능구간을 구분하여 각각 다른 string을 대입시킨다.
        {                                             // Show()가 아니다! 맵 각 지점의 배열값에 벽/이동가능구간을 설정해주는 것이다.
            m_X_Scale = X_Scale;
            m_Y_Scale = Y_Scale;

            m_Map = new string[m_Y_Scale + 2, m_X_Scale + 2]; // 맵 전체크기 설정 , + 2 를 설정한 이유는 벽을 따로 구분짓기 위해서

            for (int Y = 0; Y <= m_Map.GetUpperBound(0); Y++) // 벽 설정
            {
                for (int X = 0; X <= m_Map.GetUpperBound(1); X++)
                {
                    if ((X == 0 || X == m_Map.GetUpperBound(1)) || (Y == 0 || Y == m_Map.GetUpperBound(0)))
                    {
                        m_Map[Y, X] = "■"; // 벽
                    }
                    else
                    {
                        m_Map[Y, X] = "  "; // 이동 가능 구역
                    }
                }
            }
        } // void Set_Map


        public void Set_Man() // 팩맨 표시(로케이션) , 맵 어레이 위에 표시되어야 한다.
        {
            // Man 관련
            m_Man = "◆";

            Rand = new Random();

            m_Man_X = Rand.Next(1, m_X_Scale + 1); // 맨(유저)의 시작위치는 맵에서 벽을 제외한 지점에서 생성토록 한다.
            m_Man_Y = Rand.Next(1, m_Y_Scale + 1);
                
        } // void Set_Man


        public void Set_Coin1() // 코인은 맨 을 만들고 나서 선언해야한다.
        {
            m_Coin1 = "★";
            
            Rand = new Random();

            while (true)
            {

                m_Coin1_X = Rand.Next(1, m_X_Scale + 1);
                m_Coin1_Y = Rand.Next(1, m_Y_Scale + 1);


                if ((m_Coin1_X == m_Man_X && m_Coin1_Y == m_Man_Y) ) // Man 과 Coin이 같은 위치에서 생성하는 것을 방지.
                {
                }
                else
                {
                    break;
                }
            }

        } // void Set_Coin1


      


        public void Show_Map() // get 형식
        {
            Console.Clear();

            for (int Y = 0; Y <= m_Map.GetUpperBound(0); Y++)
            {
                for (int X = 0; X <= m_Map.GetUpperBound(1); X++)
                {
                    if (X == m_Man_X && Y == m_Man_Y) // m_Man_X , m_Man_Y 의 지점일 경우 m_Man 표시 , Man의 이동은 m_Man_X , m_Man_Y의 변화로 설정된다.
                    {
                        Console.Write("{0}", m_Man);
                    }
                    else if ((X == m_Coin1_X && Y == m_Coin1_Y))
                    {
                        Console.Write("{0}", m_Coin1);
                    }
                
                    else // 그걸 제외한 경우에는 기존 Set_Map 에서 설정했던 것처럼 m_Map 의 각 지점(배열)에 따른 string 표시
                    {
                        Console.Write("{0}", m_Map[Y, X]);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Coin Count : {0}", m_Coin_Count);


        } // void Show_Map


        public void Move_Man(ConsoleKeyInfo UserInput) // 맨의 이동, m_Man_X 와 m_Man_Y 를 변화시켜 Show_Map()에 갱신토록 한다.
        {
            m_key = UserInput;

            switch (m_key.Key)
            {
                case ConsoleKey.W:
                    {
                        m_Man_Y -= 1;
                        if (m_Man_Y == 0)
                        {
                            m_Man_Y += 1;
                        }
                        else
                        {
                            m_Man = "▲";
                        }
                    }
                    break;
                case ConsoleKey.A:
                    {
                        m_Man_X -= 1;
                        if (m_Man_X == 0)
                        {
                            m_Man_X += 1;
                        }
                        else
                        {
                            m_Man = "◀";
                        }
                    }
                    break;
                case ConsoleKey.S:
                    {
                        m_Man_Y += 1;
                        if (m_Man_Y == m_Y_Scale + 1)
                        {
                            m_Man_Y -= 1;
                        }
                        else
                        {
                            m_Man = "▼";
                        }
                    }
                    break;
                case ConsoleKey.D:
                    {
                        m_Man_X += 1;
                        if (m_Man_X == m_X_Scale + 1)
                        {
                            m_Man_X -= 1;
                        }
                        else
                        {
                            m_Man = "▶";
                        }
                    }
                    break;
                default:
                    {
                        /* Do Nothing */
                    }
                    break;
            }
        } // void Move_Man


        public void If_Catch_Coin()
        {
            if ((m_Coin1_X == m_Man_X && m_Coin1_Y == m_Man_Y) )
            {
                if (m_Coin1_X == m_Man_X && m_Coin1_Y == m_Man_Y)
                {
                    m_Coin_Count++;
                    Set_Coin1();
                }
              
            }

            //if (m_Coin2_X == m_Man_X && m_Coin2_Y == m_Man_Y)
            //{
            //    m_Coin_Count++;
            //    Set_Coin2();
            //}
        } // void If_Catch_Coin










    } // class PACKMAN












} // End
