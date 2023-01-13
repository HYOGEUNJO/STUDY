using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0104_실습
{
    public class Map
    {
        public int MOVE_POSSIBLE_AREA;
        public string IMAGE_MOVE_POSSIBLE_AREA;
        public int WALL;
        public string IMAGE_WALL;
        public int TO_TOP_PORTAL;
        public int TO_RIGHT_PORTAL;
        public int TO_BOTTOM_PORTAL;
        public int TO_LEFT_PORTAL;
        public int TO_MIDDLE_PORTAL;
        public string IMAGE_PORTAL;

        public int[,] mapMiddle;
        public int[,] mapRight;
        public int[,] mapLeft;
        public int[,] mapTop;
        public int[,] mapBottom;
        public int[,] presentMap;


        public Map()
        {
            MOVE_POSSIBLE_AREA = 1;
            IMAGE_MOVE_POSSIBLE_AREA = "  ";
            WALL = 2;
            IMAGE_WALL = "■";
            TO_TOP_PORTAL = 3;
            TO_RIGHT_PORTAL = 4;
            TO_BOTTOM_PORTAL = 5;
            TO_LEFT_PORTAL = 6;
            TO_MIDDLE_PORTAL = 7;
            IMAGE_PORTAL = "※";


            mapMiddle = new int[7, 7];
            mapRight = new int[7, 7];
            mapLeft = new int[7, 7];
            mapTop = new int[7, 7];
            mapBottom = new int[7, 7];
            presentMap = new int[7, 7];


            for (int y = 0; y < 7; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (y == 0 || y == 6)
                    {
                        mapMiddle[y, x] = WALL;
                        mapRight[y, x] = WALL;
                        mapLeft[y, x] = WALL;
                        mapTop[y, x] = WALL;
                        mapBottom[y, x] = WALL;
                    }
                    else if (x == 0 || x == 6)
                    {
                        mapMiddle[y, x] = WALL;
                        mapRight[y, x] = WALL;
                        mapLeft[y, x] = WALL;
                        mapTop[y, x] = WALL;
                        mapBottom[y, x] = WALL;
                    }
                    else
                    {
                        mapMiddle[y, x] = MOVE_POSSIBLE_AREA;
                        mapRight[y, x] = MOVE_POSSIBLE_AREA;
                        mapLeft[y, x] = MOVE_POSSIBLE_AREA;
                        mapTop[y, x] = MOVE_POSSIBLE_AREA;
                        mapBottom[y, x] = MOVE_POSSIBLE_AREA;
                    }
                }
            }

            mapMiddle[1, 3] = TO_TOP_PORTAL;
            mapBottom[1, 3] = TO_MIDDLE_PORTAL;

            mapMiddle[3, 1] = TO_LEFT_PORTAL;
            mapRight[3, 1] = TO_MIDDLE_PORTAL;

            mapMiddle[5, 3] = TO_BOTTOM_PORTAL;
            mapTop[5, 3] = TO_MIDDLE_PORTAL;

            mapMiddle[3, 5] = TO_RIGHT_PORTAL;
            mapLeft[3, 5] = TO_MIDDLE_PORTAL;

        } // Map()


    } // class Map


} // END
