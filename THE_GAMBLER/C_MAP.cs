using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAMBLER
{
    public class C_MAP
    {
        public int[,] Scale;

        public int[,] Present;


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public const int Height = 81;
        public const int Width = 81;

        public const string MoveArea_String = "　";
        public const int MoveArea = 1;

        public const string Wall_String = "■";
        public const int Wall = 2;

        public const string Portal_String = "▣";
        public const int Portal_Town = 81;
        public const int Portal_HuntingGround = 82;
        public const int Portal_Forest = 83;
        public const int Portal_Dungeon = 84;

        public const string Sanctum_String = "▤";
        public const int Portal_Sanctum = 51;

        public const string Shop_String = "▥";
        public const int Portal_Shop = 52;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public C_MAP()
        {
            this.Present = new int[Height, Width];
        } // C_MAP()

        public void SetScale()
        {
            Scale = new int[Height, Width];

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (y < 20 || 60 < y)
                    {
                        Scale[y, x] = C_MAP.Wall;
                    }
                    else if (x < 20 || 60 < x)
                    {
                        Scale[y, x] = C_MAP.Wall;
                    }
                    else
                    {
                        Scale[y, x] = C_MAP.MoveArea;
                    }
                }
            } // for
        } // SetScale()
    } // class C_MAP


    public class TOWN : C_MAP
    {
        public TOWN()
        {
            this.SetScale();

            this.Scale[59, 56] = C_MAP.Wall;
            this.Scale[59, 57] = C_MAP.Portal_HuntingGround;
            this.Scale[59, 58] = C_MAP.Portal_HuntingGround;
            this.Scale[59, 59] = C_MAP.Portal_HuntingGround;
            this.Scale[59, 60] = C_MAP.Portal_HuntingGround;
            this.Scale[60, 56] = C_MAP.Wall;
            this.Scale[60, 57] = C_MAP.Portal_HuntingGround;
            this.Scale[60, 58] = C_MAP.Portal_HuntingGround;
            this.Scale[60, 59] = C_MAP.Portal_HuntingGround;
            this.Scale[60, 60] = C_MAP.Portal_HuntingGround;


            this.Scale[30, 30] = C_MAP.Portal_Sanctum;
            this.Scale[30, 29] = C_MAP.Wall;
            this.Scale[29, 29] = C_MAP.Wall;
            this.Scale[29, 30] = C_MAP.Wall;
            this.Scale[29, 31] = C_MAP.Wall;
            this.Scale[30, 31] = C_MAP.Wall;

            this.Scale[30, 50] = C_MAP.Portal_Shop;
            this.Scale[30, 49] = C_MAP.Wall;
            this.Scale[29, 49] = C_MAP.Wall;
            this.Scale[29, 50] = C_MAP.Wall;
            this.Scale[29, 51] = C_MAP.Wall;
            this.Scale[30, 51] = C_MAP.Wall;

        } // TOWN()
    } // class C_TOWN : C_MAP


    public class C_BATTLEFIELD : C_MAP { } // class C_BATTLEFIELD : C_MAP


    public class HUNTING_GROUND : C_BATTLEFIELD
    {
        public HUNTING_GROUND()
        {
            this.SetScale();

            this.Scale[20, 56] = C_MAP.Wall;
            this.Scale[20, 57] = C_MAP.Portal_Town;
            this.Scale[20, 58] = C_MAP.Portal_Town;
            this.Scale[20, 59] = C_MAP.Portal_Town;
            this.Scale[20, 60] = C_MAP.Portal_Town;

            this.Scale[21, 56] = C_MAP.Wall;
            this.Scale[21, 57] = C_MAP.Portal_Town;
            this.Scale[21, 58] = C_MAP.Portal_Town;
            this.Scale[21, 59] = C_MAP.Portal_Town;
            this.Scale[21, 60] = C_MAP.Portal_Town;

            this.Scale[59, 20] = C_MAP.Portal_Forest;
            this.Scale[59, 21] = C_MAP.Portal_Forest;
            this.Scale[59, 22] = C_MAP.Portal_Forest;
            this.Scale[59, 23] = C_MAP.Portal_Forest;
            this.Scale[59, 24] = C_MAP.Wall;

            this.Scale[60, 20] = C_MAP.Portal_Forest;
            this.Scale[60, 21] = C_MAP.Portal_Forest;
            this.Scale[60, 22] = C_MAP.Portal_Forest;
            this.Scale[60, 23] = C_MAP.Portal_Forest;
            this.Scale[60, 24] = C_MAP.Wall;
        } // HUNTING_GROUND()
    } // class HUNTING_GROUND : C_BATTLEFIELD


    public class FOREST : C_BATTLEFIELD
    {
        public FOREST()
        {
            this.SetScale();

            this.Scale[20, 20] = C_MAP.Portal_HuntingGround;
            this.Scale[20, 21] = C_MAP.Portal_HuntingGround;
            this.Scale[20, 22] = C_MAP.Portal_HuntingGround;
            this.Scale[20, 23] = C_MAP.Portal_HuntingGround;
            this.Scale[20, 24] = C_MAP.Wall;

            this.Scale[21, 20] = C_MAP.Portal_HuntingGround;
            this.Scale[21, 21] = C_MAP.Portal_HuntingGround;
            this.Scale[21, 22] = C_MAP.Portal_HuntingGround;
            this.Scale[21, 23] = C_MAP.Portal_HuntingGround;
            this.Scale[21, 24] = C_MAP.Wall;

            this.Scale[59, 56] = C_MAP.Wall;
            this.Scale[59, 57] = C_MAP.Portal_Dungeon;
            this.Scale[59, 58] = C_MAP.Portal_Dungeon;
            this.Scale[59, 59] = C_MAP.Portal_Dungeon;
            this.Scale[59, 60] = C_MAP.Portal_Dungeon;

            this.Scale[60, 56] = C_MAP.Wall;
            this.Scale[60, 57] = C_MAP.Portal_Dungeon;
            this.Scale[60, 58] = C_MAP.Portal_Dungeon;
            this.Scale[60, 59] = C_MAP.Portal_Dungeon;
            this.Scale[60, 60] = C_MAP.Portal_Dungeon;
        } // FOREST()
    } // class FOREST : C_BATTLEFIELD


    public class DUNGEON : C_BATTLEFIELD
    {
        public DUNGEON()
        {
            this.SetScale();

            this.Scale[20, 56] = C_MAP.Wall;
            this.Scale[20, 57] = C_MAP.Portal_Forest;
            this.Scale[20, 58] = C_MAP.Portal_Forest;
            this.Scale[20, 59] = C_MAP.Portal_Forest;
            this.Scale[20, 60] = C_MAP.Portal_Forest;

            this.Scale[21, 56] = C_MAP.Wall;
            this.Scale[21, 57] = C_MAP.Portal_Forest;
            this.Scale[21, 58] = C_MAP.Portal_Forest;
            this.Scale[21, 59] = C_MAP.Portal_Forest;
            this.Scale[21, 60] = C_MAP.Portal_Forest;
        } // Set_Dungeon()
    } // class DUNGEON : C_BATTLEFIELD


}// END
