using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAMBLER
{
    public class C_BATTLE
    {
        public FRAME_BATTLE frame_battle;
        public FRAME_CARD frame_card;
        public FRAME_MONSTER frame_monster;
        public WILDBOAR wildboar;
        public GOBLIN goblin;
        public UNDEAD undead;
        public C_CARD card;


        public C_MONSTER monster1;
        public C_MONSTER monster2;
        public C_MONSTER monster3;

        public C_MONSTER chosenmonter;

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public bool Accident;
        public bool BattleStart;

        public int CardIndex;

        public int FirstCardMark;
        public int FirstCardNumber;
        public int SecondCardMark;
        public int SecondCardNumber;
        public int ThirdCardMark;
        public int ThirdCardNumber;
        public int FourthCardMark;
        public int FourthCardNumber;
        public int FifthCardMark;
        public int FifthCardNumber;

        public bool CardSelectCheck;
        public bool MonsterSelectCheck;

        public int DiceResult;

        public bool Monster1_Alive;
        public bool Monster2_Alive;
        public bool Monster3_Alive;


        public int ChosenCardMark;
        public int ChosenCardNumber;

        public int ChosenMonsterIndex;

        public bool MonsterAliveCheck;


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public C_BATTLE()
        {
            frame_battle = new FRAME_BATTLE();
            frame_card = new FRAME_CARD();
            frame_monster = new FRAME_MONSTER();
            wildboar = new WILDBOAR();
            goblin = new GOBLIN();
            undead = new UNDEAD();
            card = new C_CARD();


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            

            Accident = default;
            BattleStart = default;

            CardIndex = 0;

            FirstCardMark = default;
            FirstCardNumber = default;
            SecondCardMark = default;
            SecondCardNumber = default;
            ThirdCardMark = default;
            ThirdCardNumber = default;
            FourthCardMark = default;
            FourthCardNumber = default;
            FifthCardMark = default;
            FifthCardNumber = default;

            CardSelectCheck = default;
            MonsterSelectCheck = default;

            DiceResult = default;

            Monster1_Alive = default;
            Monster2_Alive = default;
            Monster3_Alive = default;


            ChosenCardMark = default;
            ChosenCardNumber = default;

            ChosenMonsterIndex = default;

            MonsterAliveCheck = default;

        } // C_BATTLE()







        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // about UI show

        public void ShowBattleUI()
        {
            Console.SetCursorPosition(0, 0);


            ShowBattleFrame();
            ShowMonsterFrame();
            ShowCardFrame();
        } // ShowBattleUI()

        public void ShowBattleFrame()
        {
            Console.SetCursorPosition(0, 0);

            for (int y = 0; y < 41; y++)
            {
                for (int x = 0; x < 41; x++)
                {
                    Console.Write(frame_battle.Frame[y, x]);
                }
                Console.WriteLine();

                //Console.ReadLine();

            }
        } // ShowBattleFrame()

        public void ShowMonsterFrame()
        {
            for (int y = 0; y < 6; y++)
            {
                Console.SetCursorPosition(2, 1 + y);
                for (int x = 0; x < 13; x++)
                {
                    Console.Write(frame_monster.Frame[y, x]);
                }
            }

            Console.SetCursorPosition(14, 7);
            Console.Write("<1>");

            for (int y = 0; y < 6; y++)
            {
                Console.SetCursorPosition(28, 1 + y);
                for (int x = 0; x < 13; x++)
                {
                    Console.Write(frame_monster.Frame[y, x]);
                }
            }

            Console.SetCursorPosition(40, 7);
            Console.Write("<2>");

            for (int y = 0; y < 6; y++)
            {
                Console.SetCursorPosition(54, 1 + y);
                for (int x = 0; x < 13; x++)
                {
                    Console.Write(frame_monster.Frame[y, x]);
                }
            }

            Console.SetCursorPosition(66, 7);
            Console.Write("<3>");
        } // ShowMonsterFrame()

        public void ShowCardFrame()
        {
            for (int y = 0; y < 10; y++)
            {
                Console.SetCursorPosition(2, 30 + y);
                for (int x = 0; x < 7; x++)
                {
                    Console.Write(frame_card.Frame[y, x]);
                }
            }

            Console.SetCursorPosition(8, 29);
            Console.Write("[1]");

            for (int y = 0; y < 10; y++)
            {
                Console.SetCursorPosition(18, 30 + y);
                for (int x = 0; x < 7; x++)
                {
                    Console.Write(frame_card.Frame[y, x]);
                }
            }

            Console.SetCursorPosition(24, 29);
            Console.Write("[2]");

            for (int y = 0; y < 10; y++)
            {
                Console.SetCursorPosition(34, 30 + y);
                for (int x = 0; x < 7; x++)
                {
                    Console.Write(frame_card.Frame[y, x]);
                }
            }

            Console.SetCursorPosition(40, 29);
            Console.Write("[3]");

            for (int y = 0; y < 10; y++)
            {
                Console.SetCursorPosition(50, 30 + y);
                for (int x = 0; x < 7; x++)
                {
                    Console.Write(frame_card.Frame[y, x]);
                }
            }

            Console.SetCursorPosition(56, 29);
            Console.Write("[4]");

            for (int y = 0; y < 10; y++)
            {
                Console.SetCursorPosition(66, 30 + y);
                for (int x = 0; x < 7; x++)
                {
                    Console.Write(frame_card.Frame[y, x]);
                }
            }

            Console.SetCursorPosition(72, 29);
            Console.Write("[5]");
        } // ShowCardFrame()

        public void ShowPlayerCondition(C_FIELD _field)
        {
            Console.SetCursorPosition(4, 27);
            Console.Write("                                                                      ");
            Console.SetCursorPosition(4, 27);
            Console.Write("HP : {0}   DEF : {1}   EXP : {2} // STR : {3}   INT : {4}   LUCK : {5}" , 
                _field.player.HP, _field.player.DEF, _field.player.EXP, _field.player.STR, _field.player.INT, _field.player.LUCK);

        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // about battle

        public void IfMeetEnemy(C_FIELD _field)
        {
            Random random = new Random();

            int Meet = random.Next(1, 101);

            if (_field.map.Present == _field.hunting_ground.Scale || _field.map.Present == _field.forest.Scale || _field.map.Present == _field.dungeon.Scale)
            {
                if (Meet <= 5)
                {
                    Accident = true;

                    ShuffleCards();

                    Console.SetCursorPosition(30, 19);
                    Console.WriteLine("몬스터가 나타났다!");
                    Console.ReadLine();
                    Console.SetCursorPosition(30, 19);
                    Console.WriteLine("　　　　　　　　　");
                }
            }
        } // MeetEnemy() : ShuffleCards();

        public void CardActionScript()
        {
            switch(ChosenCardMark)
            {
                case 1:
                    {
                        Console.SetCursorPosition(4, 25);
                        Console.Write("물리공격을 선택하셨습니다. 공격할 몬스터를 지정해주세요.(<>)");

                        MonsterSelectCheck = true;
                        while (MonsterSelectCheck)
                        {
                            SelectMonsterControl(Console.ReadKey());
                        }
                        
                    }
                    break;
                case 2:
                    {
                        Console.SetCursorPosition(4, 25);
                        Console.Write("방어를 선택하셨습니다.");
                    }
                    break;
                case 3:
                    {
                        Console.SetCursorPosition(4, 25);
                        Console.Write("마법공격을 선택하셨습니다.");
                    }
                    break;
                case 4:
                    {
                        Console.SetCursorPosition(4, 25);
                        Console.Write("회복을 선택하셨습니다.");
                    }
                    break;


            }




        } // CardAction(int _Nmark, int _Nnumber)

        public void ResetDEF(C_FIELD _field)
        {
            _field.player.DEF = 0;
        } // ResetDEF(C_FIELD _field)

        public void MonsterDeadCheck(C_FIELD _field)
        {
            if(monster1.HP <= 0)
            {
                Monster1_Alive = false;
            }
            if (monster2.HP <= 0)
            {
                Monster2_Alive = false;
            }
            if (monster3.HP <= 0)
            {
                Monster3_Alive = false;
            }
        } // MonsterDeadCheck()

        public void MonsterAttack1(C_FIELD _field)
        {
            if(Monster1_Alive == true)
            {
                Console.SetCursorPosition(4, 23);
                Console.Write("                                                       ");
                Console.SetCursorPosition(4, 24);
                Console.Write("                                                       ");
                Console.SetCursorPosition(4, 25);
                Console.Write("                                                       ");

                Console.SetCursorPosition(4, 23);
                Console.Write("첫번째 몬스터의 공격! ");
                Console.ReadLine();
                Console.SetCursorPosition(4, 24);
                Console.Write("{0} 의 데미지!",monster1.ATK);
                Console.ReadLine();

                if(_field.player.DEF > monster1.ATK)
                {
                    _field.player.DEF -= monster1.ATK;
                }
                else
                {
                    _field.player.HP -= (monster1.ATK - _field.player.DEF); 
                    _field.player.DEF = 0;
                }
            }
        } // MonsterAttack1(C_FIELD _field)


        public void MonsterAttack2(C_FIELD _field)
        {
            if (Monster2_Alive == true)
            {
                Console.SetCursorPosition(4, 23);
                Console.Write("                                                       ");
                Console.SetCursorPosition(4, 24);
                Console.Write("                                                       ");
                Console.SetCursorPosition(4, 25);
                Console.Write("                                                       ");

                Console.SetCursorPosition(4, 23);
                Console.Write("두번째 몬스터의 공격!");
                Console.ReadLine();
                Console.SetCursorPosition(4, 24);
                Console.Write("{0} 의 데미지!", monster2.ATK);
                Console.ReadLine();

                if (_field.player.DEF > monster2.ATK)
                {
                    _field.player.DEF -= monster2.ATK;
                }
                else
                {
                    _field.player.HP -= (monster2.ATK - _field.player.DEF);
                    _field.player.DEF = 0;
                }
            }
        } // MonsterAttack1(C_FIELD _field)

        public void MonsterAttack3(C_FIELD _field)
        {
            if (Monster3_Alive == true)
            {
                Console.SetCursorPosition(4, 23);
                Console.Write("                                                       ");
                Console.SetCursorPosition(4, 24);
                Console.Write("                                                       ");
                Console.SetCursorPosition(4, 25);
                Console.Write("                                                       ");

                Console.SetCursorPosition(4, 23);
                Console.Write("세번째 몬스터의 공격!");
                Console.ReadLine();
                Console.SetCursorPosition(4, 24);
                Console.Write("{0} 의 데미지!", monster2.ATK);
                Console.ReadLine();

                if (_field.player.DEF > monster3.ATK)
                {
                    _field.player.DEF -= monster3.ATK;
                }
                else
                {
                    _field.player.HP -= (monster3.ATK - _field.player.DEF);
                    _field.player.DEF = 0;
                }
            }
        } // MonsterAttack1(C_FIELD _field)

        public void AllMonsterDie(C_FIELD _field)
        {
            if(Monster1_Alive == false && Monster2_Alive == false && Monster3_Alive == false)
            {
                Console.SetCursorPosition(4, 23);
                Console.Write("                                                       ");
                Console.SetCursorPosition(4, 24);
                Console.Write("                                                       ");
                Console.SetCursorPosition(4, 25);
                Console.Write("                                                       ");

                Console.SetCursorPosition(4, 23);
                Console.Write("전투에서 승리하셨습니다!");
                Console.ReadLine();
                Console.SetCursorPosition(4, 24);
                Console.Write("플레이어는 {0} 의 경험치를 얻습니다!",monster1.EXP + monster2.EXP + monster3.EXP);
                ShowPlayerCondition(_field);
                Console.ReadLine();
                Console.SetCursorPosition(4, 25);
                Console.Write("필드로 돌아갑니다!");
                Console.ReadLine();

                _field.player.EXP += monster1.EXP + monster2.EXP + monster3.EXP;

                BattleStart = false;
                Accident = false;
            }
        } // AllMonsterDie(C_FIELD _field)

        public void IfPlayerDie(C_FIELD _field)
        {
            if(_field.player.HP <= 0)
            {
                Console.SetCursorPosition(4, 23);
                Console.Write("                                                       ");
                Console.SetCursorPosition(4, 24);
                Console.Write("                                                       ");
                Console.SetCursorPosition(4, 25);
                Console.Write("                                                       ");

                Console.SetCursorPosition(4, 23);
                Console.Write("당신은 죽었습니다. 마을로 돌아갑니다.");
                Console.ReadLine();

                _field.map.Present[_field.player.Y_Current, _field.player.X_Current] = C_MAP.MoveArea;

                _field.player.Y_Current = 40;
                _field.player.X_Current = 40;
                _field.player.Y_After = default;
                _field.player.X_After = default;

                BattleStart = false;
                Accident = false;

                _field.player.EXP = 0;
                _field.player.HP = _field.player.STR * 10;

                _field.Init_Map(_field.town.Scale);
                _field.Synchronize_Map_And_Player();

                
            }
        } // IfPlayerDie(C_FIELD _field)




















        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // about monster show

        public void CreateMonster(C_FIELD _field)
        {
            chosenmonter = new C_MONSTER();

            if (_field.map.Present == _field.hunting_ground.Scale)
            {
                monster1 = new WILDBOAR();
                monster2 = new WILDBOAR();
                monster3 = new WILDBOAR();
            }
            else if (_field.map.Present == _field.forest.Scale)
            {
                monster1 = new GOBLIN();
                monster2 = new GOBLIN();
                monster3 = new GOBLIN();
            }
            else if (_field.map.Present == _field.dungeon.Scale)
            {
                monster1 = new UNDEAD();
                monster2 = new UNDEAD();
                monster3 = new UNDEAD();
            }

            BattleStart = true;

            Monster1_Alive = true;
            Monster2_Alive = true;
            Monster3_Alive = true;

        } // CreateMonster(C_FIELD _field)

        public void ShowMonster()
        {
            Console.SetCursorPosition(4, 2);
            Console.Write("몬스터 : {0}", monster1.Name);
            Console.SetCursorPosition(4, 3);
            Console.Write("HP : {0}", monster1.HP);
            Console.SetCursorPosition(4, 4);
            Console.Write("공격력 : {0}", monster1.ATK);
            Console.SetCursorPosition(4, 5);
            Console.Write("방어력 : {0}", monster1.DEF);
      

            Console.SetCursorPosition(30, 2);
            Console.Write("몬스터 : {0}", monster2.Name);
            Console.SetCursorPosition(30, 3);
            Console.Write("HP : {0}", monster2.HP);
            Console.SetCursorPosition(30, 4);
            Console.Write("공격력 : {0}", monster2.ATK);
            Console.SetCursorPosition(30, 5);
            Console.Write("방어력 : {0}", monster2.DEF);
           

            Console.SetCursorPosition(56, 2);
            Console.Write("몬스터 : {0}", monster3.Name);
            Console.SetCursorPosition(56, 3);
            Console.Write("HP : {0}", monster3.HP);
            Console.SetCursorPosition(56, 4);
            Console.Write("공격력 : {0}", monster3.ATK);
            Console.SetCursorPosition(56, 5);
            Console.Write("방어력 : {0}", monster3.DEF);


            if (Monster1_Alive == false)
            {
                Console.SetCursorPosition(4, 3);
                Console.Write("HP :     ");
                Console.SetCursorPosition(4, 3);
                Console.Write("HP : {0}", 0);
            }

            Console.SetCursorPosition(30, 3);
            Console.Write("HP :     ");
            Console.SetCursorPosition(30, 3);
            Console.Write("HP : {0}", monster2.HP);

            if (Monster2_Alive == false)
            {
                Console.SetCursorPosition(30, 3);
                Console.Write("HP :     ");
                Console.SetCursorPosition(30, 3);
                Console.Write("HP : {0}", 0);
            }

            Console.SetCursorPosition(56, 3);
            Console.Write("HP :     ");
            Console.SetCursorPosition(56, 3);
            Console.Write("HP : {0}", monster3.HP);

            if (Monster3_Alive == false)
            {
                Console.SetCursorPosition(56, 3);
                Console.Write("HP :     ");
                Console.SetCursorPosition(56, 3);
                Console.Write("HP : {0}", 0);
            }

            Console.ReadLine();
        } // ShowMonster()

        public void AfterPlayerAttackMonsterShow()
        {
            Console.SetCursorPosition(4, 3);
            Console.Write("HP :     ");
            Console.SetCursorPosition(4, 3);
            Console.Write("HP : {0}", monster1.HP);

            if(Monster1_Alive == false)
            {
                Console.SetCursorPosition(4, 3);
                Console.Write("HP :     ");
                Console.SetCursorPosition(4, 3);
                Console.Write("HP : {0}", 0);
            }

            Console.SetCursorPosition(30, 3);
            Console.Write("HP :     ");
            Console.SetCursorPosition(30, 3);
            Console.Write("HP : {0}", monster2.HP);

            if (Monster2_Alive == false)
            {
                Console.SetCursorPosition(30, 3);
                Console.Write("HP :     ");
                Console.SetCursorPosition(30, 3);
                Console.Write("HP : {0}", 0);
            }

            Console.SetCursorPosition(56, 3);
            Console.Write("HP :     ");
            Console.SetCursorPosition(56, 3);
            Console.Write("HP : {0}", monster3.HP);

            if (Monster3_Alive == false)
            {
                Console.SetCursorPosition(56, 3);
                Console.Write("HP :     ");
                Console.SetCursorPosition(56, 3);
                Console.Write("HP : {0}", 0);
            }

        } // AfterPlayerAttackMonsterShow()




        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // about card

        public void ShuffleCards()
        {
            Random random = new Random();

            for(int i = 0; i < 100; i++)
            {
                card.CardsTmp = card.Cards;

                int Scr = random.Next(0,card.Cards.Count);
                int Dst = random.Next(0,card.Cards.Count);

                (int, int) Tmp = card.CardsTmp[Scr];
                card.CardsTmp[Scr] = card.CardsTmp[Dst];
                card.CardsTmp[Dst] = Tmp;
            } // for
        } // ShuffleCards()

        public void CardShow()
        {
            Console.SetCursorPosition(4, 23);
            Console.Write("카드를 뽑습니다.");
            Console.ReadLine();
            Console.SetCursorPosition(4, 23);
            Console.Write("                  ");

            FirstCardMark = card.CardsTmp[CardIndex].Item1;
            FirstCardNumber = card.CardsTmp[CardIndex].Item2;

            Console.SetCursorPosition(3, 31);
            Console.Write(ChangeToMarkString(FirstCardMark));
            Console.SetCursorPosition(3, 32);
            Console.Write(ChangeToNumberString(FirstCardNumber));

            CardIndex++;
            IfCardsEnd();

            SecondCardMark = card.CardsTmp[CardIndex].Item1;
            SecondCardNumber = card.CardsTmp[CardIndex].Item2;

            Console.SetCursorPosition(19, 31);
            Console.Write(ChangeToMarkString(SecondCardMark));
            Console.SetCursorPosition(19, 32);
            Console.Write(ChangeToNumberString(SecondCardNumber));

            CardIndex++;
            IfCardsEnd();

            ThirdCardMark = card.CardsTmp[CardIndex].Item1;
            ThirdCardNumber = card.CardsTmp[CardIndex].Item2;

            Console.SetCursorPosition(35, 31);
            Console.Write(ChangeToMarkString(ThirdCardMark));
            Console.SetCursorPosition(35, 32);
            Console.Write(ChangeToNumberString(ThirdCardNumber));

            CardIndex++;
            IfCardsEnd();

            FourthCardMark = card.CardsTmp[CardIndex].Item1;
            FourthCardNumber = card.CardsTmp[CardIndex].Item2;

            Console.SetCursorPosition(51, 31);
            Console.Write(ChangeToMarkString(FourthCardMark));
            Console.SetCursorPosition(51, 32);
            Console.Write(ChangeToNumberString(FourthCardNumber));

            CardIndex++;
            IfCardsEnd();

            FifthCardMark = card.CardsTmp[CardIndex].Item1;
            FifthCardNumber = card.CardsTmp[CardIndex].Item2;

            Console.SetCursorPosition(67, 31);
            Console.Write(ChangeToMarkString(FifthCardMark));
            Console.SetCursorPosition(67, 32);
            Console.Write(ChangeToNumberString(FifthCardNumber));

            CardIndex++;
            IfCardsEnd();

            Console.SetCursorPosition(4, 23);
            Console.Write("카드를 선택해주세요.([])");
        } // CardShow()

        public string ChangeToMarkString(int _card)
        {
            return card.MarkString[_card - 1];
        } // ChangeToMarkString(int _card)

        public string ChangeToNumberString(int _card)
        {
            return card.NumberString[_card - 2];
        } // ChangeToNumberString(int _card)

        public void IfCardsEnd()
        {
            if (CardIndex >= card.Cards.Count)
            {
                ShuffleCards();

                CardIndex = 0;
            }
        } // IfCardsEnd()






        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // about control

        public void SelectCardControl(ConsoleKeyInfo Input)
        {
            switch (Input.Key)
            {
                case ConsoleKey.D1:
                    {
                        Console.SetCursorPosition(4, 23);
                        Console.Write("당신이 선택한 카드는 {0} {1} 입니다.", ChangeToMarkString(FirstCardMark), ChangeToNumberString(FirstCardNumber));
                        Console.SetCursorPosition(4, 24);
                        Console.ReadLine();

                        ChosenCardMark = FirstCardMark;
                        ChosenCardNumber = FirstCardNumber;

                        CardSelectCheck = false;
                    }
                    break;
                case ConsoleKey.D2:
                    {
                        Console.SetCursorPosition(4, 23);
                        Console.Write("당신이 선택한 카드는 {0} {1} 입니다.", ChangeToMarkString(SecondCardMark), ChangeToNumberString(SecondCardNumber));
                        Console.SetCursorPosition(4, 24);
                        Console.ReadLine();

                        ChosenCardMark = SecondCardMark;
                        ChosenCardNumber = SecondCardNumber;

                        CardSelectCheck = false;
                    }
                    break;
                case ConsoleKey.D3:
                    {
                        Console.SetCursorPosition(4, 23);
                        Console.Write("당신이 선택한 카드는 {0} {1} 입니다.", ChangeToMarkString(ThirdCardMark), ChangeToNumberString(ThirdCardNumber));
                        Console.SetCursorPosition(4, 24);
                        Console.ReadLine();

                        ChosenCardMark = ThirdCardMark;
                        ChosenCardNumber = ThirdCardNumber;

                        CardSelectCheck = false;
                    }
                    break;
                case ConsoleKey.D4:
                    {
                        Console.SetCursorPosition(4, 23);
                        Console.Write("당신이 선택한 카드는 {0} {1} 입니다.", ChangeToMarkString(FourthCardMark), ChangeToNumberString(FourthCardNumber));
                        Console.SetCursorPosition(4, 24);
                        Console.ReadLine();

                        ChosenCardMark = FourthCardMark;
                        ChosenCardNumber = FourthCardNumber;

                        CardSelectCheck = false;
                    }
                    break;
                case ConsoleKey.D5:
                    {
                        Console.SetCursorPosition(4, 23);
                        Console.Write("당신이 선택한 카드는 {0} {1} 입니다.", ChangeToMarkString(FifthCardMark), ChangeToNumberString(FifthCardNumber));
                        Console.SetCursorPosition(4, 24);
                        Console.ReadLine();

                        ChosenCardMark = FifthCardMark;
                        ChosenCardNumber = FifthCardNumber;

                        CardSelectCheck = false;
                    }
                    break;
            } // switch
        } // SelectCardControl(ConsoleKeyInfo Input)

        public void SelectMonsterControl(ConsoleKeyInfo Input)
        {
            switch (Input.Key)
            {
                case ConsoleKey.D1:
                    {
                        if (Monster1_Alive)
                        {
                            chosenmonter = monster1;
                            ChosenMonsterIndex = 1;

                            Console.SetCursorPosition(4, 25);
                            Console.Write("                                                               ");
                            Console.SetCursorPosition(4, 25);
                            Console.Write("첫번째 몬스터를 공격합니다.");
                            Console.ReadLine();

                            MonsterSelectCheck = false;
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    {
                        if (Monster2_Alive)
                        {
                            chosenmonter = monster2;
                            ChosenMonsterIndex = 2;

                            Console.SetCursorPosition(4, 25);
                            Console.Write("                                                               ");
                            Console.SetCursorPosition(4, 25);
                            Console.Write("두번째 몬스터를 공격합니다.");
                            Console.ReadLine();

                            MonsterSelectCheck = false;
                        }
                    }
                    break;
                case ConsoleKey.D3:
                    {
                        if (Monster3_Alive)
                        {
                            chosenmonter = monster3;
                            ChosenMonsterIndex = 3;

                            Console.SetCursorPosition(4, 25);
                            Console.Write("                                                               ");
                            Console.SetCursorPosition(4, 25);
                            Console.Write("세번째 몬스터를 공격합니다.");
                            Console.ReadLine();

                            MonsterSelectCheck = false;
                        }
                    }
                    break;
            } // switch
        } // SelectCardControl(ConsoleKeyInfo Input)







        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // about dice

        public void RollDice(C_FIELD _field)
        {
            Random random = new Random();

            Console.SetCursorPosition(3, 24);
            Console.Write("주사위를 굴립니다.");
            Console.ReadLine();

            int dice = random.Next(1, 4 + (_field.player.LUCK) * 2 + 1);

            if (dice == 1)
            {
                DiceResult = 1;
            }
            else if(dice <= 1 + 3 + (_field.player.LUCK))
            {
                DiceResult = random.Next(2, 6);
            }
            else
            {
                DiceResult = 6;
            }

            Console.SetCursorPosition(3, 24);
            Console.Write("주사위의 눈은 {0} 입니다.",DiceResult);
            Console.ReadLine();
        } // RollDice(C_FIELD _field)

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        // about calculate

        public void PlayerAction(C_FIELD _field)
        {
            MeleeAttack(_field);
            Defend(_field);
            MagicAttack(_field);
            Heal(_field);
        }
        
        public void MeleeAttack(C_FIELD _field)
        {
            int amount = 0;

            if (ChosenCardMark == 1)
            {
                Console.SetCursorPosition(4, 25);
                Console.Write("                           ");

                if (DiceResult == 1)
                {
                    chosenmonter.HP = chosenmonter.HP + chosenmonter.DEF - (_field.player.STR + ChosenCardNumber);
                    amount = (_field.player.STR + ChosenCardNumber) - chosenmonter.DEF;
                }
                else if (2 <= DiceResult && DiceResult <= 5)
                {
                    chosenmonter.HP = chosenmonter.HP + chosenmonter.DEF - ((_field.player.STR + ChosenCardNumber) * 2);
                    amount = ((_field.player.STR + ChosenCardNumber) * 2) - chosenmonter.DEF;
                }
                else
                {
                    chosenmonter.HP = chosenmonter.HP + chosenmonter.DEF - (((_field.player.STR + ChosenCardNumber) * 2) * 2);
                    amount = (((_field.player.STR + ChosenCardNumber) * 2) * 2) - chosenmonter.DEF;
                }
            }

            switch(ChosenMonsterIndex)
            {
                case 1:
                    {
                        monster1 = chosenmonter;
                        Console.SetCursorPosition(4, 25);
                        Console.Write("첫번째 몬스터에게 {0} 만큼의 데미지를 입혔습니다!", amount);
                        Console.ReadLine();
                        ChosenMonsterIndex = default;
                    }
                    break;
                case 2:
                    {
                        monster2 = chosenmonter;
                        Console.SetCursorPosition(4, 25);
                        Console.Write("두번째 몬스터에게 {0} 만큼의 데미지를 입혔습니다!", amount);
                        Console.ReadLine();
                        ChosenMonsterIndex = default;
                    }
                    break;
                case 3:
                    {
                        monster3 = chosenmonter;
                        Console.SetCursorPosition(4, 25);
                        Console.Write("세번째 몬스터에게 {0} 만큼의 데미지를 입혔습니다!", amount);
                        Console.ReadLine();
                        ChosenMonsterIndex = default;
                    }
                    break;
            }
        } // MeleeAttack(C_FIELD _field)

        public void Defend(C_FIELD _field)
        {
            int amount = 0;

            if (ChosenCardMark == 2)
            {
                Console.SetCursorPosition(4, 25);
                Console.Write("                           ");

                if (DiceResult == 1)
                {
                    _field.player.DEF = ((_field.player.STR + (ChosenCardNumber * 2)) / 2);
                    amount = ((_field.player.STR + (ChosenCardNumber * 2)) / 2);
                }
                else if (2 <= DiceResult && DiceResult <= 5)
                {
                    _field.player.DEF = (_field.player.STR + (ChosenCardNumber * 2));
                    amount = (_field.player.STR + (ChosenCardNumber * 2));
                }
                else
                {
                    _field.player.DEF = ((_field.player.STR + (ChosenCardNumber * 2)) * 2);
                    amount = ((_field.player.STR + (ChosenCardNumber * 2)) * 2);
                }

                Console.SetCursorPosition(4, 25);
                Console.Write("플레이어는 {0} 만큼의 방어도를 얻습니다!", amount);
                Console.ReadLine();

            }

            
        } // Defend(C_FIELD _field)

        public void MagicAttack(C_FIELD _field)
        {
            int amount = 0;

            if (ChosenCardMark == 3)
            {
                Console.SetCursorPosition(4, 25);
                Console.Write("                           ");

                if (DiceResult == 1)
                {
                    monster1.HP = monster1.HP + monster1.DEF - ((((_field.player.INT) * 2) + ChosenCardNumber) / 2);
                    monster2.HP = monster2.HP + monster2.DEF - ((((_field.player.INT) * 2) + ChosenCardNumber) / 2);
                    monster3.HP = monster3.HP + monster3.DEF - ((((_field.player.INT) * 2) + ChosenCardNumber) / 2);

                    amount = ((((_field.player.INT) * 2) + ChosenCardNumber) / 2) - monster1.DEF;
                }
                else if (2 <= DiceResult && DiceResult <= 5)
                {
                    monster1.HP = monster1.HP + monster1.DEF - (((_field.player.INT) * 2) + ChosenCardNumber);
                    monster2.HP = monster2.HP + monster2.DEF - (((_field.player.INT) * 2) + ChosenCardNumber);
                    monster3.HP = monster3.HP + monster3.DEF - (((_field.player.INT) * 2) + ChosenCardNumber);

                    amount = (((_field.player.INT) * 2) + ChosenCardNumber) - monster1.DEF;
                }
                else
                {
                    monster1.HP = monster1.HP + monster1.DEF - ((((_field.player.INT) * 2) + ChosenCardNumber) * 2);
                    monster2.HP = monster2.HP + monster2.DEF - ((((_field.player.INT) * 2) + ChosenCardNumber) * 2);
                    monster3.HP = monster3.HP + monster3.DEF - ((((_field.player.INT) * 2) + ChosenCardNumber) * 2);

                    amount = ((((_field.player.INT) * 2) + ChosenCardNumber) * 2) - monster1.DEF;
                }

                Console.SetCursorPosition(4, 25);
                Console.Write("적 전체에게 {0} 만큼의 광역공격!", amount);
                Console.ReadLine();
            }

            
        } // MagicAttack(C_FIELD _field)

        public void Heal(C_FIELD _field)
        {
            int amount = 0;

            if (ChosenCardMark == 4)
            {
                Console.SetCursorPosition(4, 25);
                Console.Write("                           ");

                if (DiceResult == 1)
                {
                    if (_field.player.HP + (_field.player.INT + ChosenCardNumber) >= (_field.player.STR * 10))
                    {
                        amount = ((_field.player.STR * 10) - _field.player.HP);

                        _field.player.HP = _field.player.STR * 10;
                    }
                    else
                    {
                        amount = (_field.player.INT + ChosenCardNumber) / 2;
                        _field.player.HP = _field.player.HP + ((_field.player.INT + ChosenCardNumber) / 2);
                    }
                }
                else if (2 <= DiceResult && DiceResult <= 5)
                {
                    
                    if(_field.player.HP + (_field.player.INT + ChosenCardNumber) >= (_field.player.STR * 10))
                    {
                        amount = ((_field.player.STR * 10) - _field.player.HP);

                        _field.player.HP = _field.player.STR * 10;
                    }
                    else
                    {
                        amount = (_field.player.INT + ChosenCardNumber);
                        _field.player.HP = _field.player.HP + (_field.player.INT + ChosenCardNumber);
                    }
                }
                else
                {
                    if (_field.player.HP + (_field.player.INT + ChosenCardNumber) >= (_field.player.STR * 10))
                    {
                        amount = ((_field.player.STR * 10) - _field.player.HP);

                        _field.player.HP = _field.player.STR * 10;
                    }
                    else
                    {
                        amount = (_field.player.INT + ChosenCardNumber) * 2;
                        _field.player.HP = _field.player.HP + ((_field.player.INT + ChosenCardNumber) * 2);
                    }
                }

                Console.SetCursorPosition(4, 25);
                Console.Write("플레이어는 {0} 만큼 체력을 회복합니다!", amount);
                Console.ReadLine();
            }
        } // Heal(C_FIELD _field)






































































    } // class C_BATTLE
} // END
