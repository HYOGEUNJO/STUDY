using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0104_실습
{
    public class Initialize
    {
        public Map map;
        public Control control;

        public Initialize()
        {
            map = new Map();
            control = new Control();
        }



        public void MapInit(int[,] _map)
        {
            map.presentMap = _map;
        }

        public void CharacterInit()
        {
            map.presentMap[control.character.preY, control.character.preX] = control.character.man;
        }

        public void CharacterMoveChange()
        {
            map.presentMap[control.character.preY, control.character.preX] = control.character.man;
        }

        public void ChangeToImage(int _y, int _x)
        {
            switch (map.presentMap[_y, _x])
            {
                case 0:
                    {
                        Console.Write(control.character.IMAGE_MAN);
                    }
                    break;
                case 1:
                    {
                        Console.Write(map.IMAGE_MOVE_POSSIBLE_AREA);
                    }
                    break;
                case 2:
                    {
                        Console.Write(map.IMAGE_WALL);
                    }
                    break;
                default:
                    {
                        Console.Write(map.IMAGE_PORTAL);
                    }
                    break;

            }
        }

        public void ShowAll()
        {
            for (int y = 0; y < map.presentMap.GetLength(0); y++)
            {
                for (int x = 0; x < map.presentMap.GetLength(1); x++)
                {
                    ChangeToImage(y, x);
                }
                Console.WriteLine();
            }
        }

        public void Move()
        {
            if (map.presentMap[control.character.postY, control.character.postX] == map.MOVE_POSSIBLE_AREA)
            {
                map.presentMap[control.character.preY, control.character.preX] = map.MOVE_POSSIBLE_AREA;
                control.character.preX = control.character.postX;
                control.character.preY = control.character.postY;
            }
            else if (map.presentMap[control.character.postY, control.character.postX] == map.WALL)
            {

            }
            else
            {
                map.presentMap[control.character.preY, control.character.preX] = map.MOVE_POSSIBLE_AREA;
                IfVisitPortal();
            }

            control.character.postX = default;
            control.character.postY = default;
        }

        public void IfVisitPortal()
        {
            switch (map.presentMap[control.character.postY, control.character.postX])
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

        public void MapChange()
        {
            switch (map.presentMap[control.character.postY, control.character.postX])
            {
                case 3: // top
                    {
                        MapInit(map.mapTop);
                        AfterPortalCharacterLocation();
                    }
                    break;
                case 4: // right
                    {
                        MapInit(map.mapRight);
                        AfterPortalCharacterLocation();
                    }
                    break;
                case 5: // bottom
                    {
                        MapInit(map.mapBottom);
                        AfterPortalCharacterLocation();
                    }
                    break;
                case 6: // left
                    {
                        MapInit(map.mapLeft);
                        AfterPortalCharacterLocation();
                    }
                    break;
                case 7: // middle
                    {
                        MapInit(map.mapMiddle);
                        AfterPortalCharacterLocation();
                    }
                    break;
            }
        }

        public void AfterPortalCharacterLocation()
        {
            control.character.preX = 6 - control.character.preX;
            control.character.preY = 6 - control.character.preY;

        }

        public void ClearBuffer()
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







    } // class Initialize


} // END
