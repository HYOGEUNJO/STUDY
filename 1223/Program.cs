namespace _1223
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Random = new Random();
            int i_Random = default;



            int i_YourChoice = default;



            bool b_NextSequenceCheck = true;
            bool b_InputCheck = true;
            bool b_BattleSequenceCheck = true;







            string s_Player = "플레이어";
            string s_Health = "체력";
            string s_Mana = "마나";
            string s_strength = "힘";
            string s_Agility = "민첩";
            string s_Intelligence = "지능";


            string s_Damage = "데미지";



            string s_Enemy_AntQueen = "여왕 개미";




            int i_PlayerHealth = 100;
            int i_PlayerMana = 50;
            int i_PlayerStrength = 10;
            int i_PlayerAgility = 10;
            int i_PlayerIntelligence = 10;


            int i_Enemy_AntQueenHealth = 100;




            int i_PlayersAttack = default;
            int i_EnemysAttack = default;






            Console.WriteLine("=======================");
            Console.WriteLine("=====모험가 이야기=====");
            Console.WriteLine("=======================\n\n");

            string s_GameStartCheck = Console.ReadLine(); // 아무거나 입력하고 엔터 치는 것만으로도 게임이 시작된다.





            // 시퀀스 #1.
            Console.WriteLine("\"당신은 풀과 나무가 ~~~ 입구처럼 보인다.\"\n\n");

            Console.WriteLine("1. 입구로 들어간다.\n2. 다른 길로 간다.\n\n");

            while (b_NextSequenceCheck)
            {
                Console.Write("선택지를 입력해주세요 : ");
                int.TryParse(Console.ReadLine(), out i_YourChoice);
                Console.WriteLine();
                b_InputCheck = i_YourChoice == 1 || i_YourChoice == 2;

                if (b_InputCheck)
                {
                    b_NextSequenceCheck = false;
                }
                else
                {
                    Console.WriteLine("[System] 입력오류");
                }
            }
            b_NextSequenceCheck = true;
            b_InputCheck = true;

            switch (i_YourChoice)
            {

                case 1:
                    {
                        i_YourChoice = default;
                        Console.WriteLine("\"문으로 편하게 걸어 나왔다.\"\n\n");
                    }
                    break;
                case 2:
                    {
                        i_YourChoice = default;
                        Console.WriteLine("\"문을 지나왔으면 편히 왔을 길을 놔두고, 험난한 길을 오랫동안 걸어왔다. 그래도 걸어오니 머리가 한결 가벼워졌다.\"");
                        i_PlayerHealth -= 10;
                        i_PlayerIntelligence += 1;
                        Console.WriteLine("\"{0} {1} -10 , {2} {3} +1\"", s_Player, s_Health, s_Player, s_Intelligence);
                        Console.WriteLine("{0} {1} : {2}", s_Player, s_Health, i_PlayerHealth);
                        Console.WriteLine("{0} {1} : {2}\n\n", s_Player, s_Intelligence, i_PlayerIntelligence);
                    }
                    break;
            }


            // 시퀀스 #2.
            Console.WriteLine("\"당신은 풀과 나무가 ~~~ 눈에 들어왔다.\"\n\n");

            Console.WriteLine("1. 힘껏 잡아 당긴다(성공 확률 40%))\n2. 지나친다.\n\n");

            while (b_NextSequenceCheck)
            {
                Console.Write("선택지를 입력해주세요 : ");
                int.TryParse(Console.ReadLine(), out i_YourChoice);
                Console.WriteLine();
                b_InputCheck = i_YourChoice == 1 || i_YourChoice == 2;

                if (b_InputCheck)
                {
                    b_NextSequenceCheck = false;
                }
                else
                {
                    Console.WriteLine("[System] 입력오류");
                }
            }
            b_NextSequenceCheck = true;
            b_InputCheck = true;

            switch (i_YourChoice)
            {

                case 1:
                    {
                        i_YourChoice = default;
                        i_Random = Random.Next(1, 101);
                        if(i_Random <40)
                        {
                            Console.WriteLine("\"힘껏 잡아 당기니 몸에 근육이 생겼다.\"");
                            i_PlayerStrength += 2;
                            Console.WriteLine("\"{0} {1} +2\"",s_Player,s_strength  );
                            Console.WriteLine("{0} {1} : {2}\n\n",s_Player,s_strength,i_PlayerStrength  );

                        }
                        else
                        {
                            Console.WriteLine("\"무리하게 힘을 주다 허리를 삐끗했다.\"");
                            i_PlayerHealth -= 10;
                            Console.WriteLine("\"{0} {1} -10\"", s_Player, s_Health);
                            Console.WriteLine("{0} {1} : {2}\n\n", s_Player, s_strength,i_PlayerHealth);
                        }
                    }
                    break;
                case 2:
                    {
                        i_YourChoice = default;
                        Console.WriteLine("\"괜히 힘빼기 싫다. 무시하고 지나가자.\"\n\n");

                    }
                    break;
            }
            i_Random = default;


            // 시퀀스 #3.
            Console.WriteLine("\"당신은 산사태로 ~~~ 흙더미에서 뛰쳐나왔다.\"\n\n");

            Console.WriteLine("1. 전투 시작\n\n");

            while (b_NextSequenceCheck)
            {
                Console.Write("선택지를 입력해주세요 : ");
                int.TryParse(Console.ReadLine(), out i_YourChoice);
                Console.WriteLine();
                b_InputCheck = i_YourChoice == 1;

                if (b_InputCheck)
                {
                    b_NextSequenceCheck = false;
                }
                else
                {
                    Console.WriteLine("[System] 입력오류");
                }
            }
            b_NextSequenceCheck = true;
            b_InputCheck = true;


            Console.WriteLine("{0} {1} : {2}", s_Player, s_Health, i_PlayerHealth);
            Console.WriteLine("{0} {1} : {2}\n\n", s_Enemy_AntQueen, s_Health, i_Enemy_AntQueenHealth);
            while (b_BattleSequenceCheck)
            {
               


                Console.WriteLine("{0}의 공격!\n",s_Player);
                i_PlayersAttack = Random.Next(0, 40);
                i_Enemy_AntQueenHealth -= i_PlayersAttack;
                Console.WriteLine("{0} 은(는) {1} 에게 {2} 만큼 데미지를 입혔다.\n",s_Player,s_Enemy_AntQueen,i_PlayersAttack);
                Console.WriteLine("{0} 의 {1} : {2}\n", s_Enemy_AntQueen, s_Health, i_Enemy_AntQueenHealth);
                if (i_Enemy_AntQueenHealth <= 0)
                {
                    Console.WriteLine("{0} 이(가) 쓰러졌다.\n", s_Enemy_AntQueen);
                    b_BattleSequenceCheck = false;
                    break;
                }


                


                Console.WriteLine("{0}의 공격!\n",s_Enemy_AntQueen);
                i_EnemysAttack = Random.Next(0, 40);
                i_PlayerHealth -= i_EnemysAttack;
                Console.WriteLine("{0} 은(는) {1} 에게 {2} 만큼 데미지를 입혔다.\n", s_Enemy_AntQueen, s_Player, i_EnemysAttack);
                Console.WriteLine("{0} 의 {1} : {2}\n",s_Player,s_Health,i_PlayerHealth);
                if (i_PlayerHealth <= 0)
                {
                    Console.WriteLine("{0} 이(가) 쓰러졌다.\n", s_Player);
                    b_BattleSequenceCheck = false;
                    break;
                }


            }
            b_BattleSequenceCheck = true;
            i_PlayersAttack = default;
            i_EnemysAttack = default;










            Console.WriteLine("GAME END");


        }
    }
}


//// 화면 기본형


//Console.WriteLine("\"~~~~~~~~\"\n\n");

//Console.WriteLine("1. ~~~~\n2. ~~~~~~\n\n");

//while (b_NextSequenceCheck)
//{
//    Console.Write("선택지를 입력해주세요 : ");
//    int.TryParse(Console.ReadLine(), out i_YourChoice);
//    Console.WriteLine();
//    b_InputCheck = i_YourChoice == 1 || i_YourChoice == 2;

//    if (b_InputCheck)
//    {
//        b_NextSequenceCheck = false;
//    }
//    else
//    {
//        Console.WriteLine("[System] 입력오류");
//    }
//}
//b_NextSequenceCheck = true;
//b_InputCheck = true;

//switch (i_YourChoice)
//{

//    case 1:
//        {
//            i_YourChoice = default;
//        }
//        break;
//    case 2:
//        {
//            i_YourChoice = default;
//        }
//        break;
//}



// 전투 화면


//Console.WriteLine("{0} {1} : {2}", s_Player, s_Health, i_PlayerHealth);
//Console.WriteLine("{0} {1} : {2}\n\n", s_Enemy_AntQueen, s_Health, i_Enemy_AntQueenHealth);
//while (b_BattleSequenceCheck)
//{



//    Console.WriteLine("{0}의 공격!\n", s_Player);
//    i_PlayersAttack = Random.Next(0, 40);
//    i_Enemy_AntQueenHealth -= i_PlayersAttack;
//    Console.WriteLine("{0} 은(는) {1} 에게 {2} 만큼 데미지를 입혔다.\n", s_Player, s_Enemy_AntQueen, i_PlayersAttack);
//    Console.WriteLine("{0} 의 {1} : {2}\n", s_Enemy_AntQueen, s_Health, i_Enemy_AntQueenHealth);
//    if (i_Enemy_AntQueenHealth <= 0)
//    {
//        Console.WriteLine("{0} 이(가) 쓰러졌다.\n", s_Enemy_AntQueen);
//        b_BattleSequenceCheck = false;
//        break;
//    }





//    Console.WriteLine("{0}의 공격!\n", s_Enemy_AntQueen);
//    i_EnemysAttack = Random.Next(0, 40);
//    i_PlayerHealth -= i_EnemysAttack;
//    Console.WriteLine("{0} 은(는) {1} 에게 {2} 만큼 데미지를 입혔다.\n", s_Enemy_AntQueen, s_Player, i_EnemysAttack);
//    Console.WriteLine("{0} 의 {1} : {2}\n", s_Player, s_Health, i_PlayerHealth);
//    if (i_PlayerHealth <= 0)
//    {
//        Console.WriteLine("{0} 이(가) 쓰러졌다.\n", s_Player);
//        b_BattleSequenceCheck = false;
//        break;
//    }


//}
//b_BattleSequenceCheck = true;
//i_PlayersAttack = default;
//i_EnemysAttack = default;










// 지문 기본형
//Console.WriteLine("\"~~~~~\"");



// 플레이어 상태 변화 기본형
//Console.WriteLine("\"{0} {1} -10 , \"",  );
//Console.WriteLine("{0} {1} : {2}\n\n",  );


// 선택지에 확률이 있을 경우
//switch (i_YourChoice)
//{

//    case 1:
//        {
//            i_YourChoice = default;
//            i_Random = Random.Next(1, 101);
//            if (i_Random < 40)
//            {
//                Console.WriteLine("\"~~~~~\"");
//                i_PlayerStrength += 2;
//                Console.WriteLine("\"{0} {1} +2\"", s_Player, s_strength);
//                Console.WriteLine("{0} {1} : {2}\n\n", s_Player, s_strength, i_PlayerStrength);

//            }
//            else
//            {
//                Console.WriteLine("\"~~~~~~~\"");
//                i_PlayerHealth -= 10;
//                Console.WriteLine("\"{0} {1} -10\"", s_Player, s_Health);
//                Console.WriteLine("{0} {1} : {2}\n\n", s_Player, s_strength, i_PlayerHealth);
//            }
//        }
//        break;
//    case 2:
//        {
//            i_YourChoice = default;
//            Console.WriteLine("\"~~~~~~\"");
//        }
//        break;
//}
//i_Random = default;
