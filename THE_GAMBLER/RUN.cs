using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAMBLER
{
    public class RUN
    {




        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public C_FIELD field;
        public C_BATTLE battle;



        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public RUN()
        {
            field = new C_FIELD();
            battle = new C_BATTLE();



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            Console.SetWindowSize(82, 42);

            field.Init_Map(field.town.Scale);

            field.Synchronize_Map_And_Player();

            while (true)
            {
                field.Show();

                field.MoveCheck = true;
                while (field.MoveCheck)
                {
                    field.MoveControl(Console.ReadKey());
                }

                field.Move();

                battle.IfMeetEnemy(field); // ShuffleCards(); 포함

                if (battle.Accident)
                {
                    battle.CreateMonster(field);

                    while (battle.BattleStart)
                    {
                        battle.ResetDEF(field);

                        battle.ShowBattleUI();

                        battle.ShowPlayerCondition(field);

                        battle.ShowMonster();

                        battle.AfterPlayerAttackMonsterShow();

                        battle.CardShow();

                        battle.CardSelectCheck = true;
                        while(battle.CardSelectCheck)
                        {
                            battle.SelectCardControl(Console.ReadKey());
                        }

                        battle.RollDice(field);

                        battle.CardActionScript();

                        battle.PlayerAction(field);

                        battle.ShowPlayerCondition(field);

                        battle.MonsterDeadCheck(field);

                        battle.AfterPlayerAttackMonsterShow();

                        

                        battle.AllMonsterDie(field);

                        if (battle.Monster1_Alive == true || battle.Monster2_Alive == true || battle.Monster3_Alive == true)
                        {
                            battle.MonsterAttack1(field);

                            battle.ShowPlayerCondition(field);

                            battle.MonsterAttack2(field);

                            battle.ShowPlayerCondition(field);

                            battle.MonsterAttack3(field);

                            battle.ShowPlayerCondition(field);

                            Console.ReadLine();
                        }

                        battle.IfPlayerDie(field);

                    } // while (battle.BattleStart)
                } // if (battle.Accident)



                field.Synchronize_Map_And_Player();

                field.ClearBuffer();


            }




        } // RUN()









    } // class RUN
}
