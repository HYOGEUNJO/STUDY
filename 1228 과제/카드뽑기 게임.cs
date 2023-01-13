using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 과제_조효근_20221228
{
    public class PickUpTheCard
    {
        private int[] ar_A_Pack_Of_Cards; // 한 벌의 트럼프 카드를 선언. 아직 배열크기를 지정하지 않은 상태. 카드를 다 쓴 경우 다시 초기화해야 하므로 미리 크기를 선언하지 않았다.
        private string[] ar_Card_Marks = new string[4] { "♠", "◆", "♣", "♥" }; // 카드의 4종류 문양. 카드를 다시 초기화할 때 카드 문양이 바뀌지 않으므로 미리 선언.

        int CardsIndex = 0; // 카드를 쓸 때(매 게임마다 컴퓨터가 2장, 유저가 1장 사용한다.)마다 카드의 인덱스를 바꾸어 매 게임마다 새로운 카드를 보여준다.
        
        string RightMark = string.Empty; // 문양 표시를 위한 변수 선언.
        string NumIntToString = string.Empty; // 추후 카드를 보여줄 때 정수형(int)을 문자열(string)으로 바꾸어 표기하기 위해 변수 선언.

        int FirstCardNum = default; // 컴퓨터가 보여줄 첫번째 카드를 저장.
        int SecondCardNum = default; // 컴퓨터가 보여줄 두번째 카드를 저장.
        int ThirdCardNum = default; // 유저의 카드를 저장.

        int UserPoint = 10000; // 유저가 게임을 시작할 때 가지고 시작하는 포인트.
        int BettingPoint = default; // 배팅 타임에 유저가 배팅할 금액을 저장.

        bool bExitGame = true; // 유저가 파산하거나 100,000 이상의 포인트를 모았을 경우 게임을 종료하기 위한 bool형의 스위치.

        public void GameInit() // 게임 시작 세팅
        {

            SetupCards(); // 게임에 사용할 카드 한 벌을 준비합니다.

            while (bExitGame) // 게임을 종료하기 위한 bool형의 스위치.
            {
                Console.WriteLine("User Point : {0}", UserPoint); // 현재 유저가 가지고 있는 포인트를 표시합니다.

                ShowComputersCards(); // 컴퓨터의 카드 2장을 보여준다.

                BetTime(); // 배팅타임 설정.

                ShowUserCard(); // 유저의 카드 1장을 보여준다. 굳이 보여줄 필요는 없는데 이쁘게 보이기 위해 만들었다.(유저의 카드정보만 저장해 놓아도 상관없다.)

                CompareComANdUser(); // 컴퓨터의 카드 2장과 유저의 카드 1장을 비교하여 승패를 가린다.

                RepackCardsCheck(ar_A_Pack_Of_Cards); // 조건부 함수. 카드 한 벌(52장)을 전부 쓰면 카드를 다시 셋업한다.

                Exit(); // 게임의 종료 조건 설정 : 100000 point를 벌던가 point 전부 탕진하던가.

                Console.ReadLine(); // Console.Clear() 전 잠깐 멈추기 위해서. 유저가 아무키나 눌리면 Console.Clear() 및 새로운 게임이 반복된다.

                Console.Clear(); // 화면을 청소한다.

            }
        } // GameInit()






        private void SetupCards() // 게임에 사용할 카드 한 벌을 준비합니다.
        {
            ar_A_Pack_Of_Cards = new int[52]; // 카드의 크기를 선언한다.

            for (int i = 0; i < ar_A_Pack_Of_Cards.Length; ++i) // 각 배열에 순차적으로 값을 매긴다.([0] = 1, [1] = 2, [2] = 3 ~~~ [51] = 52)
            {
                ar_A_Pack_Of_Cards[i] = i + 1;
            }

            ar_A_Pack_Of_Cards = ShuffleCards(ar_A_Pack_Of_Cards); // 기존 순차적으로 배연된 카드를 랜덤하게 섞는다.

        } // SetupCards()

        private int[] ShuffleCards(int[] ar_A_Pack_Of_Cards_) // 카드를 섞는 함수
        {
            for (int i = 0; i < 100; ++i) // 임의로 100번을 섞는다. 섞을 때는 난수인 인덱스의 해당 배열값을 다른 난수 인덱스의 배열값을 바꾼다.(전체를 섞는게 아니다. 카드 2장만 서로 바꾼다.)
            {
                Random random = new Random(); // 랜덤 클래스 선언.

                int ScrIndex = random.Next(0, ar_A_Pack_Of_Cards_.Length); // 난수 인덱스 생성1.
                int DstIndex = random.Next(0, ar_A_Pack_Of_Cards_.Length); // 난수 인덱스 생성2.

                int Tmp = ar_A_Pack_Of_Cards_[ScrIndex]; // 두 수를 서로 바꾸기 위해선 하나의 수를 저장을 해놔야 한다. 보조인수가 없다면 두 수는 같은 수를 저장할 수 밖에 없디.
                ar_A_Pack_Of_Cards_[ScrIndex] = ar_A_Pack_Of_Cards_[DstIndex]; // 난수 인덱스의 결과값을 다른 난수 인덱스의 결과값으로 복사한다.
                ar_A_Pack_Of_Cards_[DstIndex] = Tmp; // 미리 보조인수에 저장한 값을 다른 하나의 수에 복사한다. 이렇게 하여 두 수를 서로 복사 교환한다.
            }

            return ar_A_Pack_Of_Cards_; // 임의로 설정한 100번의 루프를 통해 값이 바뀐 배열을 함수 자체로 저장한다.
        }



        private void ShowComputersCards() // 컴퓨터의 카드 2장을 보여준다.
        {
            string ComputersFirstCardNumber = PrintNumbers(ar_A_Pack_Of_Cards[CardsIndex]); // 이미지화 하기 위해 정수형을 스트링형으로 바꾼다.
            string ComputersFirstCardMark = PrintMarks(ar_A_Pack_Of_Cards[CardsIndex]); // 카드 문양 종류를 배열의 크기마다 달리하기 위하여 string을 리턴하는 함수를 만들어 저장한다.
            FirstCardNum = ar_A_Pack_Of_Cards[CardsIndex]; // 카드의 인덱스는 새로운 카드를 보여줄 때마다 증가한다. 증가하기전의 카드 값을 FirstCardNum, SecondCardNum, ThirdCardNum에 미리 저장해 놓는다. 
            ar_A_Pack_Of_Cards[CardsIndex] = 0; // 사용된 배열은 0으로 변화시킨다.
            CardsIndex++; // 카드를 보여주고 났으니 인덱스를 증가시켜 다음 카드의 인덱스를 준비한다.
            string ComputersSecondCardNumber = PrintNumbers(ar_A_Pack_Of_Cards[CardsIndex]); // 위와 같다. 두번째 카드를 설정한다.
            string ComputersSecondCardMark = PrintMarks(ar_A_Pack_Of_Cards[CardsIndex]);
            SecondCardNum = ar_A_Pack_Of_Cards[CardsIndex];
            ar_A_Pack_Of_Cards[CardsIndex] = 0; // 사용된 배열은 0으로 변화시킨다.
            CardsIndex++; // 카드를 보여주고 났으니 인덱스를 증가시켜 다음 카드의 인덱스를 준비한다.

            Console.WriteLine("\n");
            Console.WriteLine("    --------        -------- ");
            Console.WriteLine("   |{0}    {1}|      |{2}    {3}|", ComputersFirstCardMark, ComputersFirstCardNumber, ComputersSecondCardMark, ComputersSecondCardNumber);
            Console.WriteLine("   |        |      |        |");
            Console.WriteLine("   |        |      |        |");
            Console.WriteLine("   |        |      |        |");
            Console.WriteLine("   |{0}    {1}|      |{2}    {3}|", ComputersFirstCardNumber, ComputersFirstCardMark, ComputersSecondCardNumber, ComputersSecondCardMark);
            Console.WriteLine("    --------        -------- \n\n"); // 보기 좋게 출력한다.

        } // ShowComputersCards()



        private string PrintNumbers(int ar_A_Pack_Of_Cards_) // 이미지화 하기 위해 정수형을 스트링형으로 바꾼다.
        {
            switch (ar_A_Pack_Of_Cards_ % 13) // 카드 배열의 값은 1부터 52까지 순서와 상관없이 저장해놓았다. 카드는 1(A) ~ 13(K)까지 있으므로 한 종류의 카드 개수인 13으로 나누어 나머지에 따라 카드번호를 재설정 한다.
            {
                case 0:
                    {
                        NumIntToString = " K";
                    }
                    break;
                case 1:
                    {
                        NumIntToString = " A";
                    }
                    break;
                case 2:
                    {
                        NumIntToString = " 2";
                    }
                    break;
                case 3:
                    {
                        NumIntToString = " 3";
                    }
                    break;
                case 4:
                    {
                        NumIntToString = " 4";
                    }
                    break;
                case 5:
                    {
                        NumIntToString = " 5";
                    }
                    break;
                case 6:
                    {
                        NumIntToString = " 6";
                    }
                    break;
                case 7:
                    {
                        NumIntToString = " 7";
                    }
                    break;
                case 8:
                    {
                        NumIntToString = " 8";
                    }
                    break;
                case 9:
                    {
                        NumIntToString = " 9";
                    }
                    break;
                case 10:
                    {
                        NumIntToString = "10";
                    }
                    break;
                case 11:
                    {
                        NumIntToString = " J";
                    }
                    break;
                case 12:
                    {
                        NumIntToString = " Q";
                    }
                    break;
            }

            return NumIntToString; // int형을 string형으로 변환후 리턴시킨다.
        } // PrintNumbers()



        private string PrintMarks(int ar_A_Pack_Of_Cards_) // 1~52까지 설정된 배열의 값에 따라 문양이 바뀐다.
        {
            if (ar_A_Pack_Of_Cards_ >= 1 && 14 > ar_A_Pack_Of_Cards_)
            {
                RightMark = ar_Card_Marks[0]; // 스페이드
            }
            else if (ar_A_Pack_Of_Cards_ >= 14 && 27 > ar_A_Pack_Of_Cards_)
            {
                RightMark = ar_Card_Marks[1]; // 다이아몬드
            }
            else if (ar_A_Pack_Of_Cards_ >= 27 && 40 > ar_A_Pack_Of_Cards_)
            {
                RightMark = ar_Card_Marks[2]; // 클로버
            }
            else
            {
                RightMark = ar_Card_Marks[3]; // 하트
            }

            return RightMark; // 문양 리턴.
        } // PrintMarks()





        private void BetTime() //  배팅타임 설정.
        {
            bool bCheck = true; // 입력 예외 사항을 위한 스위치

            while (bCheck) // 제대로 된 입력값을 때 까지 계속 물어본다.
            {
                Console.Write("배팅금액을 적어주세요. : ");

                if (int.TryParse(Console.ReadLine(), out BettingPoint) && BettingPoint <= UserPoint)
                {
                    bCheck = false; // 유효한 입력일 경우 반복문이 종료되고 다음 과정으로 넘어간다.
                }
                else
                {
                    Console.Write("[System] 유효하지 않는 입력입니다. "); // 유효하지 않은 입력일 경우.
                }
            }
        } // BetTime()





        private void ShowUserCard() // 유저의 카드 1장을 보여준다. 굳이 보여줄 필요는 없는데 이쁘게 보이기 위해 만들었다.(유저의 카드정보만 저장해 놓아도 상관없다.)
        {

            string UserCardNumber = PrintNumbers(ar_A_Pack_Of_Cards[CardsIndex]); // 위의 컴퓨터 카드를 보여줄 때랑 똑같은 과정이다.
            string UserCardMark = PrintMarks(ar_A_Pack_Of_Cards[CardsIndex]);
            ThirdCardNum = ar_A_Pack_Of_Cards[CardsIndex];
            ar_A_Pack_Of_Cards[CardsIndex] = 0; // 사용된 배열은 0으로 변화시킨다.
            CardsIndex++;

            Console.WriteLine("\n");
            Console.WriteLine("            --------");
            Console.WriteLine("           |{0}    {1}|", UserCardMark, UserCardNumber);
            Console.WriteLine("           |        |");
            Console.WriteLine("           |        |");
            Console.WriteLine("           |        |");
            Console.WriteLine("           |{0}    {1}|", UserCardNumber, UserCardMark);
            Console.WriteLine("            --------\n\n");
        } // ShowUserCard()





        private void CompareComANdUser() // 컴퓨터의 카드 2장과 유저의 카드 1장을 비교하여 승패를 가린다.
        {
            int Bigger = default; // 컴퓨터의 카드 2장 중 큰 것으로 설정
            int smaller = default; // 컴퓨터의 카드 2장 중 작은 것으로 설정

            if (Change52To13(FirstCardNum) >= Change52To13(SecondCardNum)) // Change52To13() : 미리 저장한 FirstCardNum, SecondCardNum, ThirdCardNum 는 최소 1, 최대 52 사이의 숫자를 저장 중이다. 이 게임은 숫자와 문양 전체를 고려한 점수가 아닌 문양과 상관없는 숫자만의 값으로 승패를 나눈다. 그러므로 52가지의 수 13가지의 수로 변환하여 비교한다.를 
            {
                Bigger = Change52To13(FirstCardNum); // 13가지의 수로 변환한 카드 중 큰 것
                smaller = Change52To13(SecondCardNum); // 13가지의 수로 변환한 카드 중 큰 것
            }
            else
            {
                Bigger = Change52To13(SecondCardNum); // 13가지의 수로 변환한 카드 중 큰 것
                smaller = Change52To13(FirstCardNum); // 13가지의 수로 변환한 카드 중 큰 것
            }

            if (Change52To13(ThirdCardNum) < Bigger && Change52To13(ThirdCardNum) > smaller) // 52에서 13의 경우의 수로 전환한 세번째카드(유저의 카드)와 컴퓨터의 카드를 비교하여 승패를 가린다.
            {
                Console.WriteLine("당신이 이겼습니다!");
                UserPoint += BettingPoint; // 이겼을 경우 배팅한 금액만큼 유저는 포인트를 얻는다.
            }
            else
            {
                Console.WriteLine("컴퓨터가 이겼습니다!");
                UserPoint -= BettingPoint; // 졌을 경우 배팅한 금액만큼 유저는 포인트를 잃는다.
            }

        } // CompareComANdUser()



        private int Change52To13(int FirstSecondThirdNumbers) // 기존 값은 숫자, 문양까지 고려하여 1~52 중의 결과값을 갖게 설정했지만, 이 게임 자체에서는 숫자만을 고려한 1~13까지의 결과값을 갖으므로 52를 13으로 나눈 나머지 값에 따라 각 카드의 점수를 다시 계산한다.
        {
            int Result = default;
            switch (FirstSecondThirdNumbers % 13)
            {
                case 0:
                    {
                        Result = 13; // 13의 배수인 카드(K)는 각 문양 중 가장 큰 수이지만 기준을 나누는 나머지를 확인할 경우 오히려 가장 작은 값을 나타낸다. 각 문양의 K값을 이번게임에서 가장 큰수를 의미하는 13으로 설정한다.
                    }
                    break;
                default:
                    {
                        Result = FirstSecondThirdNumbers % 13; // 13을 제외한 나머지는 각 카드의 결과값과 나머지가 같다.
                    }
                    break;
            }
            return Result; // 각 카드의 결과값을 리턴.
        } // Change52To13()





        private void RepackCardsCheck(int[] ar_A_Pack_Of_Cards_) // 조건부 함수. 카드 한 벌(52장)을 전부 쓰면 카드를 다시 셋업한다.
        {
            if (ar_A_Pack_Of_Cards_[50] == 0)   // 카드는 총 52장, 한 번의 게임에서 카드를 3장씩 사용한다. 그러므로 카드 한벌로 총 17번의 게임을 할 수 있다. CardsIndex를 통하여 이미 사용한(보여준) 카드 값을 0으로 다시 설정해준다.
            {                                   // 카드 한벌로 할 수 있는 마지막 게임은 카드의 51번째 까지 사용한다. 51번쨰 카드(배열로는 [50])의 카드가 0으로 바뀌었다면 카드를 새로 셋업하여 다음 게임을 이어가게 한다.
                Console.WriteLine("카드 한 벌을 다 사용하였습니다. 새로운 카드 한 벌을 사용합니다.");
                CardsIndex = 0; // 인덱스도 0으로 초기화 하여 다음 카드 한 벌의 인덱스를 계산한다.
                SetupCards(); // 처음 카드를 셋업할 때와 똑같이 셋업한다.
            }
        } // RepackCardsCheck()






        private void Exit() // 게임의 종료 조건 설정 : 100000 point를 벌던가 point 전부 탕진하던가.
        {
            if(UserPoint <= 0)
            {
                Console.WriteLine("당신은 파산했습니다!");
                bExitGame = false;
            }
            if(UserPoint >= 100000)
            {
                Console.WriteLine("당신이 이겼습니다!");

                bExitGame = false;
            }
        } // Exit()


    } // class
}
