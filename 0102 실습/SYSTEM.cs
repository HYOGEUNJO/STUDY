using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0102_실습
{
    public class POKER
    {
        public Random RAN;

        public Dictionary<int, (string, int)> dCards;

        public string[] Marks = new string[4] { "♠", "◇", "♣", "♡" };
        public string[] StringNumbers = new string[13] { " A", " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", "10", " J", " Q", " K" };
        public int CardIndex = 0;
        public int CardNum;

        public string BettingResponse;

        public int UserMoney;
        public int BettingMoney;
        public int TotalBettingMoney;

        public bool Escape = true;

        public int userPoint;
        public int comPoint;


        string sn;




        public POKER()
        {
            UserMoney = 10000;

            MAX_FRAME maxF = new MAX_FRAME();
            CARDS_FRAME cardF = new CARDS_FRAME();
            CARDS_BACK cardB = new CARDS_BACK();

            while (Escape)
            {
                BettingMoney = 0;
                userPoint = 0;
                comPoint = 0;

                SetCards();

                ShowUI(maxF);



                // com card : back 2
                ShowBacK(3, 1, cardB);
                ShowBacK(22, 1, cardB);



                // user card : dCards[0] , dCards[1]
                cardF.SetCardPaint(dCards[0].Item1, ChangeNumToString(dCards[0].Item2));
                ShowCard(3, 31, cardF);
                cardF.SetCardPaint(dCards[1].Item1, ChangeNumToString(dCards[1].Item2));
                ShowCard(22, 31, cardF);



                BettingTime();

                // common card
                cardF.SetCardPaint(dCards[2].Item1, ChangeNumToString(dCards[2].Item2));
                ShowCard(3, 16, cardF);
                cardF.SetCardPaint(dCards[3].Item1, ChangeNumToString(dCards[3].Item2));
                ShowCard(22, 16, cardF);
                cardF.SetCardPaint(dCards[4].Item1, ChangeNumToString(dCards[4].Item2));
                ShowCard(41, 16, cardF);

                BettingTime();

                // common card

                cardF.SetCardPaint(dCards[5].Item1, ChangeNumToString(dCards[5].Item2));
                ShowCard(60, 16, cardF);

                BettingTime();

                // common final card

                cardF.SetCardPaint(dCards[6].Item1, ChangeNumToString(dCards[6].Item2));
                ShowCard(79, 16, cardF);

                Console.ReadLine();

                // com card open
                cardF.SetCardPaint(dCards[7].Item1, ChangeNumToString(dCards[7].Item2));
                ShowCard(3, 1, cardF);
                cardF.SetCardPaint(dCards[8].Item1, ChangeNumToString(dCards[8].Item2));
                ShowCard(22, 1, cardF);








                UserPoint();









                Console.ReadLine();
            } // while
        }







        public void SetCards()
        {
            dCards = new Dictionary<int, (string, int)>();

            CardIndex = 0;
            CardNum = 1;

            for(int i = 0; i < 52; i++)
            {
                if(i<=12)
                {
                    dCards.Add(CardIndex, (Marks[0], CardNum));
                }
                else if(i<=25)
                {
                    dCards.Add(CardIndex, (Marks[1], CardNum));
                }
                else if (i <= 38)
                {
                    dCards.Add(CardIndex, (Marks[2], CardNum));
                }
                else 
                {
                    dCards.Add(CardIndex, (Marks[3], CardNum));
                }
                CardIndex++;
                CardNum++;
            } // for
            

            ShuffleCards();
        } // void SetCards()




        public void ShuffleCards()
        {
            RAN = new Random();

            for (int i = 0; i < 200; i++)
            {
                int ScrIndex = RAN.Next(0, dCards.Count); // 난수 인덱스 생성1.
                int DstIndex = RAN.Next(0, dCards.Count); // 난수 인덱스 생성2.

                (string, int) Tmp = dCards[ScrIndex];
                dCards[ScrIndex] = dCards[DstIndex];
                dCards[DstIndex] = Tmp;
            }
        } // void ShiffleCards()


        


        public void ShowUI(MAX_FRAME _maxF)
        {
            Console.Clear();

            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < _maxF.m_Height; i++)
            {
                for (int j = 0; j < _maxF.m_Width; j++)
                {
                    Console.Write("{0}", _maxF.m_Scale[i, j]);
                }
                Console.WriteLine();
            }
            ShowUserMoney();
            Console.SetCursorPosition(0, 0);
        } // void ShowUI()



       




        public string ChangeNumToString(int _num)
        {
            switch(_num % 13)
            {
                case 1:
                    {
                        sn = StringNumbers[0];
                    }
                    break;
                case 2:
                    {
                        sn = StringNumbers[1];
                    }
                    break;
                case 3:
                    {
                        sn = StringNumbers[2];
                    }
                    break;
                case 4:
                    {
                        sn = StringNumbers[3];
                    }
                    break;
                case 5:
                    {
                        sn = StringNumbers[4];
                    }
                    break;
                case 6:
                    {
                        sn = StringNumbers[5];
                    }
                    break;
                case 7:
                    {
                        sn = StringNumbers[6];
                    }
                    break ;
                case 8:
                    {
                        sn = StringNumbers[7];
                    }
                    break;
                case 9:
                    {
                        sn = StringNumbers[8];
                    }
                    break;
                case 10:
                    {
                        sn = StringNumbers[9];
                    }
                    break;
                case 11:
                    {
                        sn = StringNumbers[10];
                    }
                    break;
                case 12:
                    {
                        sn = StringNumbers[11];
                    }
                    break;
                case 0:
                    {
                        sn = StringNumbers[12];
                    }
                    break;
            }
            return sn;
        } // string ChangeNumToString()

        public void ShowCard(int x, int y, CARDS_FRAME CARDFRAME)
        {
            for (int i = 0; i < CARDFRAME.m_CHeight; i++)
            {
                Console.SetCursorPosition(x, y);
                y += 1;
                for (int j = 0; j < CARDFRAME.m_CWidth; j++)
                {
                    Console.Write("{0}", CARDFRAME.m_CScale[i, j]);
                }
            }
        } // void ShowCard


        public void ShowBacK(int x, int y, CARDS_BACK CARDFRAME)
        {
            for (int i = 0; i < CARDFRAME.m_CHeight; i++)
            {
                Console.SetCursorPosition(x, y);
                y += 1;
                for (int j = 0; j < CARDFRAME.m_CWidth; j++)
                {
                    Console.Write("{0}", CARDFRAME.m_CScale[i, j]);
                }
            }
        } // void ShowCard



        public void ShowUserMoney()
        {
            Console.SetCursorPosition(90, 32);
            Console.WriteLine("현재 유저 잔액 : {0}", UserMoney);
        } // void ShowUserMoney()











        public void BettingTime()
        {
            Console.SetCursorPosition(60, 37);
            Console.Write("배팅하시겠습니까?(Y/N) : ");
            BettingResponse = Console.ReadLine();
            if (BettingResponse == "Y" || BettingResponse == "y" || BettingResponse == "1")
            {
                while (true)
                {
                    Console.SetCursorPosition(60, 37);
                    Console.Write("얼마를 배팅하시겠습니까?(금액) : ");
                    if (int.TryParse(Console.ReadLine(), out BettingMoney)&&(BettingMoney <= UserMoney && BettingMoney >= 0))
                    {
                        TotalBettingMoney += BettingMoney;
                        UserMoney -= BettingMoney;

                        Console.SetCursorPosition(90, 32);
                        Console.Write("                           ");
                        ShowUserMoney();

                        Console.SetCursorPosition(90, 33);
                        Console.WriteLine("현재 배팅 금액 : {0}", TotalBettingMoney);
                        Console.SetCursorPosition(60, 37);
                        Console.Write("                                             ");
                        break;
                    }
                    else
                    {
                        Console.SetCursorPosition(60, 37);
                        Console.Write("                                                ");
                    } 


                }


            }
            else
            {

                Console.SetCursorPosition(60, 37);
                Console.Write("                                                ");


            }

            BettingResponse = default;
        }

        public void UserPoint()
        {
            int[] a = new int[7];
            for(int i = 0; i < 7; i++)
            {
                a[i] = dCards[i].Item2;
            }


            Array.Sort(a);











            //Console.SetCursorPosition(50, 2);
            //for(int i = 0; i< 7; i++)
            //{
            //    Console.Write("{0}  ",userTmp[i]);
            //}

        }












    } // class POKER

}
