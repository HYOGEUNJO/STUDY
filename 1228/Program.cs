namespace _1228
{
    internal class Program
    {
        static void Main(string[] args)
        {





















            // class를 사용해서 로또번호 생성기를 작성할 것, 1~45 사이의 랜덤숫자(중복 X), 6개의 랜덤한 숫자를 출력
            LotooNumberCreator LottoCreator = new LotooNumberCreator();
            LottoCreator.PrintLottoNumbers();

            //// 가위바위보 게임(사용자가 인풋한다.)
            //RockSciccorsPaper rcp = new RockSciccorsPaper();
            //string userInput = Console.ReadLine();
            //rcp.PrintResult(userInput);



            ////////////////
            TrumpCard trumpCard = new TrumpCard();
            trumpCard.SetupTrumpCards();
            for(int i = 0; i < 100; i++)
            {
                trumpCard.ReRollCard();
            }










        } // Main()
    }







    //// 교수님 버전, if문을 사용하지 않고 배열(45) 자체를 셔플하여 앞 6배열만 출력.
    public class LotooNumberCreator
    {
        int[] arLottoNumbers;

        public void PrintLottoNumbers() // 여기서 로또 번호 출력
        {
            arLottoNumbers = new int[45];
            for (int i = 0; i < arLottoNumbers.Length; i++)
            {
                arLottoNumbers[i] = i + 1;
            } // loop : 로또 번호를 순서대로 초기화 하는 루프

            for (int i = 0; i < 100; i++) // 100동안 셔플
            {
                arLottoNumbers = ShuffleOnce(arLottoNumbers);
            }

            //for(int i = 0; i < arLottoNumbers.Length; i++)
            //{
            //    Console.Write("{0}  ", arLottoNumbers[i]);
            //}
            //Console.WriteLine();

            for (int i = 0; i < 6; i++) // 셔플한 순서대로 6개의 자리만 출력
            {
                Console.Write("{0}  ", arLottoNumbers[i]);
            }
            Console.WriteLine();
        } // PrintLottoNumbers()



        // 내부에서 배열을 1번 섞는 함수
        private int[] ShuffleOnce(int[] arLottoNumbers_)
        {
            Random random = new Random();

            int iSourceIndex = random.Next(0, arLottoNumbers_.Length);
            int iDestinationIndex = random.Next(0, arLottoNumbers_.Length);

            int iTempVariable = arLottoNumbers_[iSourceIndex];
            arLottoNumbers_[iSourceIndex] = arLottoNumbers_[iDestinationIndex];
            arLottoNumbers_[iDestinationIndex] = iTempVariable;

            return arLottoNumbers_;
        } // ShuffleOnce()
    } // LotooNumberCreator
    ////





    public class RockSciccorsPaper
    {
        public void PrintResult(string UserInput_)
        {
            UserInputCheck(UserInput_);

            string sComputersChoice = string.Empty;
            switch (ComputersChoice())
            {
                case 0:
                    {
                        sComputersChoice = "가위";
                    }
                    break;
                case 1:
                    {
                        sComputersChoice = "바위";
                    }
                    break;
                case 2:
                    {
                        sComputersChoice = "보";
                    }
                    break;
            }

            Console.WriteLine("컴퓨터는 {0}를 냈습니다.", sComputersChoice);
            //Console.WriteLine("당신은 {0를 냈습니다.}", UserInput_);

            if (UserInputCheck(UserInput_) == ComputersChoice())
            {
                Console.WriteLine("비겼습니다.");
            }
            else if (UserInputCheck(UserInput_) == 0 && ComputersChoice() == 2)
            {
                Console.WriteLine("당신이 이겼습니다");
            }
            else if(UserInputCheck(UserInput_) > ComputersChoice())
            {
                Console.WriteLine("당신이 이겼습니다");
            }
            else
            {
                Console.WriteLine("컴퓨터가 이겼습니다");

            }






        } // PrintResult(string UserInput_)


        private int UserInputCheck(string UserInput_)
        {
            int iUserChoice = default;
            bool bInputCheck = true;
            while (bInputCheck)
            {
                switch (UserInput_)
                {
                    case "가위":
                        {
                            iUserChoice = 0;
                            bInputCheck = false;
                        }
                        break;
                    case "바위":
                        {
                            iUserChoice = 1;
                            bInputCheck = false;
                        }
                        break;
                    case "보":
                        {
                            iUserChoice = 2;
                            bInputCheck = false;
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("[System] 다시 입력해주세요");
                            UserInput_ = Console.ReadLine();
                        }
                        break;
                }
            }

            return iUserChoice;
        } // UserInputCheck(string UserInput_)



        private int ComputersChoice() // 컴퓨터의 선택
        {
            Random random = new Random();
            int iComputersChoice = random.Next(0, 3);
            return iComputersChoice;
        } // ComputersChoice()







    } // RockSciccorsPaper












}