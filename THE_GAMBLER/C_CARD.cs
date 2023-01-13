using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAMBLER
{
    public class C_CARD
    {
        public int[] MarkInt;
        public int[] NumberInt;

        public string[] MarkString;
        public string[] NumberString;

        public Dictionary<int, (int, int)> Cards;
        public Dictionary<int, (int, int)> CardsTmp;

        public C_CARD()
        {
            MarkInt = new int[4] { 1, 2, 3, 4 };
            NumberInt = new int[13] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            MarkString = new string[4] { "♠", "◆", "♣", "♥" };
            NumberString = new string[13] { " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", "10", " J", " Q", " K", " A" };

            Cards = new Dictionary<int, (int, int)>();
            CardsTmp = new Dictionary<int, (int, int)>();

            int NumberIndex1 = 0;
            int NumberIndex2 = 0;
            int NumberIndex3 = 0;
            int NumberIndex4 = 0;

            for(int i = 0; i < 52; i++)
            {
                if (i <= 12)
                {
                    Cards.Add(i, (MarkInt[0], NumberInt[NumberIndex1]));
                    NumberIndex1++;
                }
                else if (i <= 25)
                {
                    Cards.Add(i, (MarkInt[1], NumberInt[NumberIndex2]));
                    NumberIndex2++;
                }
                else if (i <= 38)
                {
                    Cards.Add(i, (MarkInt[2], NumberInt[NumberIndex3]));
                    NumberIndex3++;
                }
                else
                {
                    Cards.Add(i, (MarkInt[3], NumberInt[NumberIndex4]));
                    NumberIndex4++;
                }
            }
        } // C_CARD()






    } // class C_CARD
} // END
