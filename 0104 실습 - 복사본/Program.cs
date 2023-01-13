namespace _0104_실습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // map

            const int MOVE_POSSIBLE_AREA = 1;
            const string IMAGE_MOVE_POSSIBLE_AREA = "  ";
            const int WALL = 2;
            const string IMAGE_WALL = "■";
            const int TO_TOP_PORTAL = 3;
            const int TO_RIGHT_PORTAL = 4;
            const int TO_BOTTOM_PORTAL = 5;
            const int TO_LEFT_PORTAL = 6;
            const int TO_MIDDLE_PORTAL = 7;
            const string IMAGE_PORTAL = "※";



            int[,] presentMap;

            int[,] mapMiddle = new int[7, 7];
            int[,] mapRight = new int[7, 7];
            int[,] mapLeft = new int[7, 7];
            int[,] mapTop = new int[7, 7];
            int[,] mapBottom = new int[7, 7];


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


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // character

            const int MAN = 0;
            const string IMAGE_MAN = "옷";

            int man = MAN;
            int preX = 3;
            int preY = 3;
            int postX = preX;
            int postY = preY;

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // control


            void InputControl(ConsoleKeyInfo Input)
            {

                switch (Input.Key)
                {
                    case ConsoleKey.W:
                        {
                            postY = preY - 1;
                            postX = preX;
                        }
                        break;
                    case ConsoleKey.D:
                        {
                            postX = preX + 1;
                            postY = preY;
                        }
                        break;
                    case ConsoleKey.S:
                        {
                            postY = preY + 1;
                            postX = preX;
                        }
                        break;
                    case ConsoleKey.A:
                        {
                            postX = preX - 1;
                            postY = preY;
                        }
                        break;
                }
            }


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // system

            void MapInit(int[,] _map)
            {
                presentMap = _map;
            }

            void CharacterInit()
            {
                presentMap[preY, preX] = man;
            }

            void CharacterMoveChange()
            {
                presentMap[preY, preX] = man;
            }

            void ChangeToImage(int _y, int _x)
            {
                switch (presentMap[_y, _x])
                {
                    case 0:
                        {
                            Console.Write(IMAGE_MAN);
                        }
                        break;
                    case 1:
                        {
                            Console.Write(IMAGE_MOVE_POSSIBLE_AREA);
                        }
                        break;
                    case 2:
                        {
                            Console.Write(IMAGE_WALL);
                        }
                        break;
                    default:
                        {
                            Console.Write(IMAGE_PORTAL);
                        }
                        break;

                }
            }

            void ShowAll()
            {
                for (int y = 0; y < presentMap.GetLength(0); y++)
                {
                    for (int x = 0; x < presentMap.GetLength(1); x++)
                    {
                        ChangeToImage(y, x);
                    }
                    Console.WriteLine();
                }
            }

            void Move()
            {
                if (presentMap[postY, postX] == MOVE_POSSIBLE_AREA)
                {
                    presentMap[preY, preX] = MOVE_POSSIBLE_AREA;
                    preX = postX;
                    preY = postY;
                }
                else if (presentMap[postY, postX] == WALL)
                {

                }
                else
                {
                    presentMap[preY, preX] = MOVE_POSSIBLE_AREA;
                    IfVisitPortal();
                }

                postX = default;
                postY = default;
            }

            void IfVisitPortal()
            {
                switch (presentMap[postY, postX])
                {
                    case 3: // top
                        {
                            MapChange();
                        }
                        break;
                    case 4: // right
                        {
                            MapChange();
                        }
                        break;
                    case 5: // bottom
                        {
                            MapChange();
                        }
                        break;
                    case 6: // left
                        {
                            MapChange();
                        }
                        break;
                    case 7: // middle
                        {
                            MapChange();
                        }
                        break;
                }
            }

            void MapChange()
            {
                switch (presentMap[postY, postX])
                {
                    case 3: // top
                        {
                            MapInit(mapTop);
                            AfterPortalCharacterLocation();
                        }
                        break;
                    case 4: // right
                        {
                            MapInit(mapRight);
                            AfterPortalCharacterLocation();
                        }
                        break;
                    case 5: // bottom
                        {
                            MapInit(mapBottom);
                            AfterPortalCharacterLocation();
                        }
                        break;
                    case 6: // left
                        {
                            MapInit(mapLeft);
                            AfterPortalCharacterLocation();
                        }
                        break;
                    case 7: // middle
                        {
                            MapInit(mapMiddle);
                            AfterPortalCharacterLocation();
                        }
                        break;
                }
            }

            void AfterPortalCharacterLocation()
            {
                preX = 6 - preX;
                preY = 6 - preY;

            }

            void ClearBuffer()
            {
                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < 100; i++) ;
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                Console.SetCursorPosition(0, 0);
            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // game

            MapInit(mapMiddle);

            CharacterInit();

            while (true)
            {
                CharacterMoveChange();

                ShowAll();

                InputControl(Console.ReadKey());


                Move();

                ClearBuffer();
            }





        }
    }
}