using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAMBLER
{
    public class C_UI { } // class C_UI

    public class FRAME_BATTLE
    {
        public string[,] Frame;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FRAME_BATTLE()
        {
            this.Frame = new string[41, 41];

            for (int y = 0; y < 41; y++)
            {
                for (int x = 0; x < 41; x++)
                {
                    if (y == 0 || y == 22 || y == 26 || y == 28 ||y == 40)
                    {
                        this.Frame[y, x] = "■";
                    }
                    else if (x == 0 || x == 40)
                    {
                        this.Frame[y, x] = "■";
                    }
                    else
                    {
                        this.Frame[y, x] = "　";
                    }
                }
            } // for
        } // FRAME_BATTLE()
    } // class FRAME_BATTLE


    public class FRAME_CARD
    {
        public string[,] Frame;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public FRAME_CARD()
        {
            this.Frame = new string[10, 7];

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (y == 0 || y == 9)
                    {
                        this.Frame[y, x] = "──";
                    }
                    else if (x == 0 || x == 6)
                    {
                        this.Frame[y, x] = "│ ";
                    }
                    else
                    {
                        this.Frame[y, x] = "　";
                    }
                }
            } // for

            this.Frame[0, 0] = "┌─";
            this.Frame[0, 6] = "┐ ";
            this.Frame[9, 0] = "└─";
            this.Frame[9, 6] = "┘ ";
        } // FRAME_CARD()
    } // class FRAME_CARD


    public class FRAME_MONSTER
    {
        public string[,] Frame;

        public FRAME_MONSTER()
        {
            this.Frame = new string[6, 13];

            for (int y = 0; y < 6; y++)
            {
                for (int x = 0; x < 13; x++)
                {
                    if (y == 0 || y == 5)
                    {
                        this.Frame[y, x] = "──";
                    }
                    else if (x == 0 || x == 12)
                    {
                        this.Frame[y, x] = "│ ";
                    }

                    else
                    {
                        this.Frame[y, x] = "　";
                    }
                }
            }

            this.Frame[0, 0] = "┌─";
            this.Frame[0, 12] = "┐ ";
            this.Frame[5, 0] = "└─";
            this.Frame[5, 12] = "┘ ";
        } // FRAME_MONSTER()
    } // class FRAME_MONSTER








    public class FRAME_SHOP
    {
        public string[,] Frame;

        public FRAME_SHOP()
        {
            this.Frame = new string[41, 41];

            for (int y = 0; y < 41; y++)
            {
                for (int x = 0; x < 41; x++)
                {
                    if (y == 0 || y == 40)
                    {
                        this.Frame[y, x] = "■";
                    }
                    else if (x == 0 || x == 40)
                    {
                        this.Frame[y, x] = "■";
                    }
                    else
                    {
                        this.Frame[y, x] = "　";
                    }
                }
            } // for
        } //  FRAME_SHOP()
    } // class FRAME_SHOP

       
    public class FRAME_SANCTUM
    {
        public string[,] Frame;

        public FRAME_SANCTUM()
        {
            this.Frame = new string[41, 41];

            for (int y = 0; y < 41; y++)
            {
                for (int x = 0; x < 41; x++)
                {
                    if (y == 0 || y == 40)
                    {
                        this.Frame[y, x] = "■";
                    }
                    else if (x == 0 || x == 40)
                    {
                        this.Frame[y, x] = "■";
                    }
                    else
                    {
                        this.Frame[y, x] = "　";
                    }
                }
            } // for
        } // FRAME_SANCTUM()
    } // class FRAME_SANCTUM


















} // END
