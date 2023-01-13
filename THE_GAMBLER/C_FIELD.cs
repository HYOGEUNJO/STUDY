using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAMBLER
{
    public class C_FIELD
    {
        public C_MAP map;
        public TOWN town;
        public HUNTING_GROUND hunting_ground;
        public FOREST forest;
        public DUNGEON dungeon;
        public C_PLAYER player;

        public FRAME_SANCTUM sanctum;
        public FRAME_SHOP shop;


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool MoveCheck;






        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public C_FIELD()
        {
            map = new C_MAP();
            town = new TOWN();
            hunting_ground = new HUNTING_GROUND();
            forest = new FOREST();
            dungeon = new DUNGEON();
            player = new C_PLAYER();

            sanctum = new FRAME_SANCTUM();
            shop = new FRAME_SHOP();

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            MoveCheck = default;





        } // C_FIELD()






        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // about map

        public void Init_Map(int[,] _map)
        {
            map.Present = _map;
        } // Init_Map()

        public void Synchronize_Map_And_Player()
        {
            map.Present[player.Y_Current, player.X_Current] = C_PLAYER.Player;

        } // Synchronize_Map_And_Player()



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // about control

        public void MoveControl(ConsoleKeyInfo Input)
        {
            switch (Input.Key)
            {
                case ConsoleKey.W:
                    {
                        player.Y_After = player.Y_Current - 1;
                        player.X_After = player.X_Current;
                        MoveCheck = false;
                    }
                    break;
                case ConsoleKey.D:
                    {
                        player.Y_After = player.Y_Current;
                        player.X_After = player.X_Current + 1;
                        MoveCheck = false;
                    }
                    break;
                case ConsoleKey.S:
                    {
                        player.Y_After = player.Y_Current + 1;
                        player.X_After = player.X_Current;
                        MoveCheck = false;
                    }
                    break;
                case ConsoleKey.A:
                    {
                        player.Y_After = player.Y_Current;
                        player.X_After = player.X_Current - 1;
                        MoveCheck = false;
                    }
                    break;
            } // switch
        } // void InputControl()




        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // about move

        public void Move()
        {
            if (map.Present[player.Y_After, player.X_After] == C_MAP.MoveArea)
            {
                map.Present[player.Y_Current, player.X_Current] = C_MAP.MoveArea;
                player.Y_Current = player.Y_After;
                player.X_Current = player.X_After;
            }
            if (map.Present[player.Y_After, player.X_After] == C_MAP.Portal_Town || map.Present[player.Y_After, player.X_After] == C_MAP.Portal_HuntingGround || map.Present[player.Y_After, player.X_After] == C_MAP.Portal_Forest || map.Present[player.Y_After, player.X_After] == C_MAP.Portal_Dungeon)
            {
                map.Present[player.Y_Current, player.X_Current] = C_MAP.MoveArea;
                IfVisitPortal();
            }
            if (map.Present[player.Y_After, player.X_After] == C_MAP.Portal_Shop)
            {
                map.Present[player.Y_Current, player.X_Current] = C_MAP.MoveArea;
                IfVisitPortal();

            }
            if (map.Present[player.Y_After, player.X_After] == C_MAP.Portal_Sanctum)
            {
                map.Present[player.Y_Current, player.X_Current] = C_MAP.MoveArea;
                IfVisitPortal();
            }

            player.Y_After = default;
            player.X_After = default;

        } // Move()

        public void IfVisitPortal()
        {
            switch (map.Present[player.Y_After, player.X_After])
            {
                case C_MAP.Portal_Town:
                    {
                        Init_Map(town.Scale);
                        AfterPortalCharacterLocation();
                    }
                    break;
                case C_MAP.Portal_HuntingGround:
                    {
                        Init_Map(hunting_ground.Scale);
                        AfterPortalCharacterLocation();
                    }
                    break;
                case C_MAP.Portal_Forest:
                    {
                        Init_Map(forest.Scale);
                        AfterPortalCharacterLocation();
                    }
                    break;
                case C_MAP.Portal_Dungeon:
                    {
                        Init_Map(dungeon.Scale);
                        AfterPortalCharacterLocation();
                    }
                    break;
                case C_MAP.Portal_Shop:
                    {
                        ShowShop();


                    }
                    break;
                case C_MAP.Portal_Sanctum:
                    {
                        ShowSanctum();



                    }
                    break;





            }

        } // IfVisitPortal()

        public void AfterPortalCharacterLocation()
        {
            player.Y_Current = (C_MAP.Height - 1) - player.Y_Current;

        } // AfterPortalCharacterLocation()




        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // about show

        public void Show()
        {
            for (int y = player.Y_Current - 20; y <= player.Y_Current + 20; y++)
            {
                for (int x = player.X_Current - 20; x <= player.X_Current + 20; x++)
                {
                    if (map.Present[y, x] == C_PLAYER.Player)
                    {
                        Console.Write(C_PLAYER.Player_String);
                    }
                    if (map.Present[y, x] == C_MAP.MoveArea)
                    {
                        Console.Write(C_MAP.MoveArea_String);
                    }
                    if (map.Present[y, x] == C_MAP.Wall)
                    {
                        Console.Write(C_MAP.Wall_String);
                    }
                    if (map.Present[y, x] == C_MAP.Portal_Town || map.Present[y, x] == C_MAP.Portal_HuntingGround || map.Present[y, x] == C_MAP.Portal_Forest || map.Present[y, x] == C_MAP.Portal_Dungeon)
                    {
                        Console.Write(C_MAP.Portal_String);
                    }
                    if (map.Present[y,x] == C_MAP.Portal_Sanctum)
                    {
                        Console.Write(C_MAP.Sanctum_String);
                    }
                    if (map.Present[y, x] == C_MAP.Portal_Shop)
                    {
                        Console.Write(C_MAP.Shop_String);
                    }
                }
                Console.WriteLine();
            }

        } // Show()

        public void ClearBuffer()
        {
            Console.SetCursorPosition(0, 0);

        } // ClearBuffer()

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // about shop

        public void ShowShop()
        {
            Console.Clear();


            for(int y = 0; y < 41; y++)
            {
                for(int x = 0; x <41; x++)
                {
                    Console.Write(shop.Frame[y, x]);
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(4, 16);
            Console.Write("상점에 어서오세요. 모든 스탯 상승은 1000 EXP 가 필요합니다.");
            Console.ReadLine();

            if(player.EXP >= 1000)
            {
                Console.SetCursorPosition(4, 18);
                Console.Write("1000 EXP로 모든 스탯을 상승시켜드리겠습니다.");
                Console.ReadLine();

                player.EXP -= 1000;

                player.STR += 1;
                player.INT += 1;
                player.LUCK += 1;
            }
            else if (player.EXP < 1000)
            {
                Console.SetCursorPosition(4, 18);
                Console.Write("EXP가 부족하시네요.");

                Console.ReadLine();
                Console.SetCursorPosition(4, 20);
                Console.Write("몬스터를 처치하여 모아오시면 모든 스탯을 상승시켜드리겠습니다.");

                Console.ReadLine();
            }

            

            player.Y_Current = 31;
            player.X_Current = 50;
            player.Y_After = default;
            player.X_After = default;

            Console.Clear();
            Show();


        } // ShowShop()

        public void ShowSanctum()
        {
            Console.Clear();


            for (int y = 0; y < 41; y++)
            {
                for (int x = 0; x < 41; x++)
                {
                    Console.Write(shop.Frame[y, x]);
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(4, 16);
            Console.Write("성당에 도착하였습니다.");
            Console.ReadLine();
            Console.SetCursorPosition(4, 18);
            Console.Write("체력을 회복합니다.");
            Console.ReadLine();

            player.HP = player.STR * 10;
            

            player.Y_Current = 31;
            player.X_Current = 30;
            player.Y_After = default;
            player.X_After = default;

            Console.Clear();
            Show();


        } // ShowShop()

























        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




    } // class C_FIELD
} // END
