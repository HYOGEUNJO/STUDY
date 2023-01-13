using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1228
{
    public class TrumpCard
    {
        private int[] trumpCardSet; // 내가 사용할 카드 세트
        private string[] trumpCardMark; // 트럼프 카드의 마크



        public void SetupTrumpCards()
        {
            trumpCardSet = new int[52];
            for (int i = 0; i < trumpCardSet.Length; i++)
            {
                trumpCardSet[i] = i + 1;
            } // 카드의 숫자를 셋업하는 loop

            // 트럼프 카드의 마크를 셋업
            trumpCardMark = new string[4] { "♥", "◆", "♠", "♣" };


        } // SetupTrumpCards()




        // 카드를 섞는 함수

        public void ShuffleCards()
        {
            ShuffleCards(200);
        }

        private void ShuffleCards(int howManyLoop)
        {
            for (int i = 0; i < howManyLoop; i++)
            {
                trumpCardSet = ShuffleOnce(trumpCardSet);
            }
        } // ShuffleCards()

        /////////////////

        // 셔플하고서 카드를 한 장 뽑아서 출력하는 함수
        public void ReRollCard()
        {
            ShuffleCards();
            RollCard();
        } // ReRollCard()




        // 한장의 카드를 뽑아서 보여주는 함수
        public void RollCard()
        {
            ShuffleCards();

            int card = trumpCardSet[0];
            string cardMark = trumpCardMark[(card - 1) / 13];
            string cardNumber = Math.Ceiling(card % 13.1).ToString();

            switch (cardNumber)
            {
                case "11":
                    cardNumber = "J";
                    break;
                case "12":
                    cardNumber = "Q";
                    break;
                case "13":
                    cardNumber = "K";
                    break;
                default:
                    // Do Nothing
                    break;


            } // switch



            Console.WriteLine("내가 뽑은 카드는 {0} {1} 입니다.", cardMark, cardNumber);
            Console.WriteLine(" ------");
            Console.WriteLine("| {0} {1} |", cardMark, cardNumber);
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("| {0} {1} |", cardNumber, cardMark);
            Console.WriteLine(" ------");
        } // RollCard()






        private void PrintCardSet()
        {
            foreach (int card in trumpCardSet)
            {
                Console.Write("{0} ", card);
            }
        } // PrintCardSet()




        private int[] ShuffleOnce(int[] intArray)
        {
            Random random = new Random();

            int iSourceIndex = random.Next(0, intArray.Length);
            int iDestinationIndex = random.Next(0, intArray.Length);

            int iTempVariable = intArray[iSourceIndex];
            intArray[iSourceIndex] = intArray[iDestinationIndex];
            intArray[iDestinationIndex] = iTempVariable;

            return intArray;
        } // ShuffleOnce()








    }
}
