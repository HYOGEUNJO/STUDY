using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1229__2
{
    public class Game // 캐릭터 클래스 와 게임 실행을 따로 분리하고 싶어서 Game 생성자를 따로 만들었다.
    {
        int UserChoice = default; // 유저가 선택할 수 있는 선택지, 숫자를 입력하여 행동이 분화되게 하였다.

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // 유저의 기본 선택지에서 UserChoice로 결정하면 해당 행동이 true로 변하게 하였다.
        bool Go_Status = false; // 상태창 보기
        bool Go_MonsterDictionary = false; // 몬스터 도감 보기
        bool Go_HuntingGround = false; // 사냥터로 이동하기
        bool Go_Sanctum = false;// 성소로 가서 체력을 체우기

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // 사냥터에서 싸울 상대를 고르면 해당 트리거가 true로 변화하게 하였다.
        bool Hunt_Slime = false;
        bool Hunt_Wolf = false;
        bool Hunt_Skeleton = false;
        bool Hunt_Spider_Queen = false;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // 반복행동 트리거와 아이템 입수 트리거
        bool LoopExit = false;
        bool ItemCheck = true;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // 아이템 드롭확률을 결정하였다.
        Random rRandom = new Random();

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Game() // Game 생성자 선언시 바로 게임이 실행된다. 그리고 플레이어와 몬스터의 생성자를 함께 호출한다.
        {
            Player player = new Player();
            Slime slime = new Slime();
            Wolf wolf = new Wolf();
            Skeleton skeleton = new Skeleton();
            SpiderQueen spider_queen = new SpiderQueen();

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            What_Is_Player_Name(player); // 게임 실행하자마자 유저의 이름을 정하게 한다. 반복문에 포함되어 있지 않아 이름을 한번만 정하게 하였다.

            while (spider_queen.GameEnding) // 거미여왕을 처리하기 전까지 반복하게 한다. 반복문 트리거는 거미여왕을 처치 유무로 결정하였다.
            {
                What_Do_You_Want_Do(player); // 기본선택지, 여기서 플레이어는 행동을 정한다.

                ShowStatus(player); // 기본 선택지에서 상태창을 보고 싶은 경우

                ShowMonsterDictionary(player, slime, wolf, skeleton, spider_queen); // 기본선택지에서 몬스터 도감을 보고 싶은 경우

                Hunting_Ground(player, slime, wolf, skeleton, spider_queen); // 기본선택지에서 사냥터로 이동하고 싶을 경우

                HuntingSlime(player, slime); // 사냥터로 이동 후 몬스터를 선택하여 전투를 시작한다.

                HuntingWolf(player, wolf); // 사냥터로 이동 후 몬스터를 선택하여 전투를 시작한다.

                HuntingSkeleton(player, skeleton); // 사냥터로 이동 후 몬스터를 선택하여 전투를 시작한다.
                 
                HuntingSpiderQueen(player, spider_queen); // 사냥터로 이동 후 몬스터를 선택하여 전투를 시작한다.

                VisitSanctum(player); // 기본 선택지에서 성소를 방문하고 싶을 경우

            }

            // 거미여왕을 처리하면 반복문 트리거가 비활성되어 엔딩 멘트가 나오게 하였다.
            Console.Clear();
            Console.WriteLine("{0} 은(는) 마침내 {1} 을(를) 무찔렀습니다.\n{0} 의 여정은 여기서 마침표를 찍습니다.",player.Name,spider_queen.Name);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("플레이 해주셔서 감사합니다.");
        } // Game()





        private void ShowUI(Player player_) // 기본적인 UI를 표시한다. 화면 초기화 기능도 한다.
        {
            Console.Clear();
            Console.WriteLine("이름 : {0} / 현재 체력 : {1} / 공격력 : {2} / 방어력 : {3}\n\n", player_.Name, player_.Hp, player_.Damage, player_.Defence);
        } // void ShowUI



        private void What_Is_Player_Name(Player player_) // 게임 실행하자마자 유저의 이름을 정하게 한다.
        {
            Console.Write("당신의 이름은 ? : ");
            player_.Name = Console.ReadLine();
        } // void What_Is_Player_Name



        private void What_Do_You_Want_Do(Player player_) // 기본선택지, 여기서 플레이어는 행동을 정한다.
        {
            ShowUI(player_);

            Console.WriteLine("어떤 걸 하시겠습니까?\n\n");

            Console.WriteLine("1. 현재 {0} 의 상태보기", player_.Name);
            Console.WriteLine("2. 몬스터 도감 보기");
            Console.WriteLine("3. 사냥터 가기");
            Console.WriteLine("4. 성소 들어가기 (체력회복)");
            Console.WriteLine();

            Console.Write("결정 : ");
            int.TryParse(Console.ReadLine(), out UserChoice); // 인트형으로 입력하면 스위치 조건문으로 이동하여 해당 행동의 트리거가 활성화되는 방식으로 하였다.

            switch (UserChoice)
            {
                case 1:
                    {
                        Go_Status = true; // 상태창
                    }
                    break;
                case 2:
                    {
                        Go_MonsterDictionary = true; // 몬스터 도감
                        LoopExit = true; // 몬스터 도감에서 어떤 걸 볼지 결정할 떄 입력오류가 생기면 다시 선택할 수 있게 하였다
                    }
                    break;
                case 3:
                    {
                        Go_HuntingGround = true; // 사냥터
                        LoopExit = true; // 사냥터에서 몬스터를 선택할 때 입력오류가 생기면 다시 선택할 수 있게 하였다.
                    }
                    break;
                case 4:
                    {
                        Go_Sanctum = true; // 성소(체력회복)
                    }
                    break;
                default: // 입력오류시
                    {
                        Console.WriteLine();
                        Console.WriteLine("[System] 유효하지 않는 입력입니다.");
                        Console.ReadLine();
                    }
                    break;
            }
            UserChoice = default; // 선택이 끝난 후 초기화하여 다음에 다시 쓸 때 오류가 생기지 않도록 하였다.
        } // void What_Do_You_Want_Do



        private void ShowStatus(Player player_) // 기본 선택지에서 상태창을 보고 싶은 경우
        {
            if (Go_Status) 
            {

                Console.Clear();

                Console.WriteLine("이름 : {0}\n", player_.Name);
                Console.WriteLine("{0}\n", player_.Description);
                Console.WriteLine("체력 : {0}\n", player_.Hp);
                Console.WriteLine("방어력 : {0}\n", player_.Defence);
                Console.WriteLine("공격력 : {0}\n", player_.Damage);
                Console.Write("현재 장비하고 있는 아이템 : "); // 몬스터를 사냥후 아이템이 드롭되면 상태창에서 확인할 수 있도록 하였다.
                for (int i = 0; i < player_.Inventory.Length; i++)
                {
                    if (player_.Inventory[i] == null)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("{0}  ",player_.Inventory[i]); // 아이템을 장비하고 있다면 순차적으로 아이템을 알려준다.
                    }
                }
                Console.WriteLine();
                Console.ReadLine();

                Go_Status = false; // 트리거 초기화
            } // if
        } // void ShowStatus



        private void ShowMonsterDictionary(Player player_, Slime slime_, Wolf wolf_, Skeleton skeleton_, SpiderQueen spider_queen_) // 기본선택지에서 몬스터 도감을 보고 싶은 경우
        {
            if (Go_MonsterDictionary)
            {
                ShowUI(player_);

                while (LoopExit)
                {
                    ShowUI(player_);

                    Console.WriteLine("어떤 몬스터 정보를 확인하시겠습니까?\n\n");

                    Console.WriteLine("1. {0}", slime_.Name);
                    Console.WriteLine("2. {0}", wolf_.Name);
                    Console.WriteLine("3. {0}", skeleton_.Name);
                    Console.WriteLine("4. {0}", spider_queen_.Name);
                    Console.WriteLine();

                    Console.Write("결정 : ");
                    int.TryParse(Console.ReadLine(), out UserChoice);


                    switch (UserChoice) // 유저가 선택한 몬스터 정보를 확인할 수 있게 하였다.
                    {
                        case 1:
                            {
                                ShowUI(player_);

                                Console.WriteLine("이름 : {0}\n", slime_.Name);
                                Console.WriteLine("설명 : {0}\n", slime_.Description);
                                Console.WriteLine("체력 : {0}\n", slime_.Hp);
                                Console.WriteLine("방어력 : {0}\n", slime_.Defence);
                                Console.WriteLine("공격력 : {0}", slime_.Damage);

                                LoopExit = false; // 입력오류 트리거 초기화
                            }
                            break;
                        case 2:
                            {
                                ShowUI(player_);

                                Console.WriteLine("이름 : {0}\n", wolf_.Name);
                                Console.WriteLine("설명 : {0}\n", wolf_.Description);
                                Console.WriteLine("체력 : {0}\n", wolf_.Hp);
                                Console.WriteLine("방어력 : {0}\n", wolf_.Defence);
                                Console.WriteLine("공격력 : {0}", wolf_.Damage);

                                LoopExit = false; // 입력오류 트리거 초기화
                            }
                            break;
                        case 3:
                            {
                                ShowUI(player_);

                                Console.WriteLine("이름 : {0}\n", skeleton_.Name);
                                Console.WriteLine("설명 : {0}\n", skeleton_.Description);
                                Console.WriteLine("체력 : {0}\n", skeleton_.Hp);
                                Console.WriteLine("방어력 : {0}\n", skeleton_.Defence);
                                Console.WriteLine("공격력 : {0}", skeleton_.Damage);

                                LoopExit = false; // 입력오류 트리거 초기화
                            }
                            break;
                        case 4:
                            {
                                ShowUI(player_);

                                Console.WriteLine("이름 : {0}\n", spider_queen_.Name);
                                Console.WriteLine("설명 : {0}\n", spider_queen_.Description);
                                Console.WriteLine("체력 : {0}\n", spider_queen_.Hp);
                                Console.WriteLine("방어력 : {0}\n", spider_queen_.Defence);
                                Console.WriteLine("공격력 : {0}", spider_queen_.Damage);

                                LoopExit = false; // 입력오류 트리거 초기화
                            }
                            break;
                        default:
                            {
                                Console.WriteLine();
                                Console.WriteLine("[System] 유효하지 않는 입력입니다.");
                                Console.ReadLine();
                            }
                            break;
                    }
                }
                UserChoice = default; // 입력값 초기화
                Go_MonsterDictionary = false; // 선택지 트리거 초기화
                Console.ReadLine();

            } // if
        } // void ShowMonsterDictionary



        private void Hunting_Ground(Player player_, Slime slime_, Wolf wolf_, Skeleton skeleton_, SpiderQueen spider_queen_) // 기본선택지에서 사냥터로 이동하고 싶을 경우
        {
            if (Go_HuntingGround)
            {
                ShowUI(player_);

                while (LoopExit) // 입력오류 트리거
                {
                    ShowUI(player_);

                    Console.WriteLine("어떤 몬스터를 사냥하시겠습니까?\n\n");

                    Console.WriteLine("1. {0}", slime_.Name);
                    Console.WriteLine("2. {0}", wolf_.Name);
                    Console.WriteLine("3. {0}", skeleton_.Name);
                    Console.WriteLine("4. {0}", spider_queen_.Name);
                    Console.WriteLine();

                    Console.Write("결정 : ");
                    int.TryParse(Console.ReadLine(), out UserChoice); // 선택지 입력

                    switch (UserChoice) // 입력값에 따른 몬스터를 활성화 해준다.
                    {
                        case 1:
                            {
                                Hunt_Slime = true;
                                LoopExit = false;
                            }
                            break;
                        case 2:
                            {
                                Hunt_Wolf = true;
                                LoopExit = false;
                            }
                            break;
                        case 3:
                            {
                                Hunt_Skeleton = true;
                                LoopExit = false;
                            }
                            break;
                        case 4:
                            {
                                Hunt_Spider_Queen = true;
                                LoopExit = false;
                            }
                            break;
                        default:
                            {
                                Console.WriteLine();
                                Console.WriteLine("[System] 유효하지 않는 입력입니다.");
                                Console.ReadLine();
                            }
                            break;
                    }
                }
                UserChoice = default; // 입력 초기화
                Go_HuntingGround = false; // 선택지 트리거 초기화
            } // if
        } // void Hunting_Ground



        private void HuntingSlime(Player player_, Slime slime_) // 사냥터로 이동 후 몬스터를 선택하여 전투를 시작한다.
        {
            if (Hunt_Slime)
            {
                LoopExit = true;
                while (LoopExit)
                {
                    BattleUI_Player(player_, slime_); // 전투시 UI를 플레이어일 때와 몬스터일 때를 구분하였다.(인수가 공통적이지 않기 떄문에)

                    // 플레이어 선공 : 전투는 플레이어의 선공이다.

                    if (slime_.Hp <= 0) // 플레이어의 공격으로 몬스터가 쓰러졌을 때
                    {
                        Console.WriteLine("{0} 을(를) 쓰러트렸습니다!", slime_.Name);
                        Console.ReadLine();
                        LoopExit = false;
                        slime_.Hp = 14; // 다음에 또 잡을 수 있게 몬스터의 체력을 초기화 한다.
                        break;
                    }

                    BattleUI_Monster(slime_, player_);

                    // 몬스터 후공

                    if (player_.Hp <= 0) // 전투로 플레이어가 쓰러졌을 경우
                    {
                        slime_.Hp = 14;
                        Console.WriteLine("{0} 은(는) 쓰러졌습니다. 마을로 귀환합니다.", player_.Name); // 마을로 귀환하여 루프를 재실행한다.
                        Console.ReadLine();
                        LoopExit = false;
                        player_.Hp = 99; // 쓰러지고 나서 다시 체력이 가득 찬 상태로 변화시켜준다.
                        break;
                    }
                }
                Hunt_Slime = false; // 몬스터 선택 트리거 초기화
            } // if
        } // void HuntingSlime


        private void HuntingWolf(Player player_, Wolf wolf_) // 사냥터로 이동 후 몬스터를 선택하여 전투를 시작한다.
        {
            if (Hunt_Wolf)
            {
                LoopExit = true;
                while (LoopExit)
                {
                    BattleUI_Player(player_, wolf_);

                    // 플레이어 선공

                    if (wolf_.Hp <= 0)
                    {
                        Console.WriteLine("{0} 을(를) 쓰러트렸습니다!", wolf_.Name);
                        Console.ReadLine();
                        LoopExit = false;
                        wolf_.Hp = 24;

                        for (int i = 0; i < player_.Inventory.Length; i++) // 기존에 플레이어가 드롭 아이템을 가지고 있다면 중복으로 장비하지 않기 위해 조건문을 달았다.
                        {
                            if (player_.Inventory[i] == wolf_.Item[0]) // 유저 인벤토리 배열에 동일 아이템이 있을 경우 아이템 수령 화면에 들어가지 않게 하였다.
                            {
                                ItemCheck = false; // 아이템 수령 트리거
                            }
                            else
                            {

                            }
                        }

                        if (ItemCheck) // 만약에 드롭아이템이 없었다면 일정 확률로 장비할 수 있게 하였다.
                        {
                            int i = rRandom.Next(1, 101); // 드롭확률 설정

                            if (i <= 30) // 드롭확률은 30%이다.
                            {
                                player_.Inventory[player_.InventoryIndex] = wolf_.Item[0]; // 플레이어 인벤토리에 드롭 아이템을 넣어준다.
                                player_.InventoryIndex++; // 아이템 수령 후 인벤토리 인덱스를 증가시켜 같은 인덱스에 아이템을 수령하는 걸 막았다.
                                player_.Defence += 2; // 가죽 갑옷을 장비하면 방어력이 2 올라간다.

                                Console.WriteLine("{0} 은(는) {1} 을(를) 쓰러트리고 {2} 을(를) 획득하였습니다.\n" +
                                    "{0} 의 {3} 이(가) {4}만큼 증가합니다.", player_.Name, wolf_.Name, wolf_.Item[0], "방어력", 2);
                                Console.ReadLine();
                            }
                        }
                        break;
                    }

                    BattleUI_Monster(wolf_, player_); // 전투시

                    if (player_.Hp <= 0)
                    {
                        wolf_.Hp = 24;
                        Console.WriteLine("{0} 은(는) 쓰러졌습니다. 마을로 귀환합니다.", player_.Name);
                        Console.ReadLine();
                        LoopExit = false;
                        player_.Hp = 99;
                        break;
                    }
                }
                ItemCheck = true;
                Hunt_Wolf = false;
            } // if
        } // void HuntingWolf



        private void HuntingSkeleton(Player player_, Skeleton skeleton_) // 사냥터로 이동 후 몬스터를 선택하여 전투를 시작한다.
        {
            if (Hunt_Skeleton)
            {
                LoopExit = true;
                while (LoopExit)
                {
                    BattleUI_Player(player_, skeleton_);

                    // 플레이어 선공

                    if (skeleton_.Hp <= 0)
                    {
                        Console.WriteLine("{0} 을(를) 쓰러트렸습니다!", skeleton_.Name);
                        Console.ReadLine();
                        LoopExit = false;
                        skeleton_.Hp = 100;

                        for (int i = 0; i < player_.Inventory.Length; i++)
                        {
                            if (player_.Inventory[i] == skeleton_.Item[0])
                            {
                                ItemCheck = false;
                            }
                            else
                            {

                            }
                        }

                        if (ItemCheck) // 스켈레톤의 드롭아이템은 2개이다. 그래서 아이템 체크 및 드롭확률 설정을 2번 따로 잡았다.
                        {
                            int i = rRandom.Next(1, 101);

                            if (i <= 20) // 20퍼센트 확률
                            {
                                player_.Inventory[player_.InventoryIndex] = skeleton_.Item[0];
                                player_.InventoryIndex++;
                                player_.Damage += 5;

                                Console.WriteLine("{0} 은(는) {1} 을(를) 쓰러트리고 {2} 을(를) 획득하였습니다.\n" +
                                    "{0} 의 {3} 이(가) {4}만큼 증가합니다.", player_.Name, skeleton_.Name, skeleton_.Item[0], "공격력", 5);
                                Console.ReadLine();
                            }
                        }

                        ItemCheck = true; // 아이템 확인 트리거 초기화

                        for (int i = 0; i < player_.Inventory.Length; i++)
                        {
                            if (player_.Inventory[i] == skeleton_.Item[1])
                            {
                                ItemCheck = false;
                            }
                            else
                            {

                            }
                        }

                        if (ItemCheck)
                        {
                            int i = rRandom.Next(1, 101);

                            if (i <= 20)
                            {
                                player_.Inventory[player_.InventoryIndex] = skeleton_.Item[1];
                                player_.InventoryIndex++;
                                player_.Defence += 3;

                                Console.WriteLine("{0} 은(는) {1} 을(를) 쓰러트리고 {2} 을(를) 획득하였습니다.\n" +
                                    "{0} 의 {3} 이(가) {4}만큼 증가합니다.", player_.Name, skeleton_.Name, skeleton_.Item[1], "방어력", 3);
                                Console.ReadLine();
                            }
                        }
                        break;
                    }

                    BattleUI_Monster(skeleton_, player_);

                    if (player_.Hp <= 0)
                    {
                        skeleton_.Hp = 100;
                        Console.WriteLine("{0} 은(는) 쓰러졌습니다. 마을로 귀환합니다.", player_.Name);
                        Console.ReadLine();
                        LoopExit = false;
                        player_.Hp = 99;
                        break;
                    }
                }
                ItemCheck = true;
                Hunt_Skeleton = false;
            } // if



        } // void HuntingSkeleton


        private void HuntingSpiderQueen(Player player_, SpiderQueen spider_queen_) // 사냥터로 이동 후 몬스터를 선택하여 전투를 시작한다.
        {
            if (Hunt_Spider_Queen) // 최종보스
            {
                LoopExit = true;
                while (LoopExit)
                {
                    BattleUI_Player(player_, spider_queen_);

                    // 플레이어 선공

                    if (spider_queen_.Hp <= 0) // 최종보스는 일부러 모든 몬스터의 드롭아이템을 장비해야지만 처치할 수 있게 설정하였다.
                    {
                        Console.WriteLine("{0} 을(를) 쓰러트렸습니다!", spider_queen_.Name);
                        Console.ReadLine();
                        LoopExit = false;
                        spider_queen_.Hp = 99;
                        spider_queen_.GameEnding = false; // 거미여왕을 처치하면 전체적인 루프를 비활성시켜 엔딩 멘트를 볼 수 있게 하였다.
                        break;
                    }

                    BattleUI_Monster(spider_queen_, player_);

                    if (player_.Hp <= 0)
                    {
                        spider_queen_.Hp = 99;
                        Console.WriteLine("{0} 은(는) 쓰러졌습니다. 마을로 귀환합니다.", player_.Name);
                        Console.ReadLine();
                        LoopExit = false;
                        player_.Hp = 99;
                        break;
                    }
                }
                Hunt_Spider_Queen = false;
            } // if
        } // void HuntingSpiderQueen



        private void BattleUI_Player(Player player_, Monster monsterX) // 플레이어의 전투화면
        {
            Console.Clear();
            Console.WriteLine("{0} 의 현재 체력 : {1}\n\n", player_.Name, player_.Hp);
            Console.WriteLine("{0} 의 현재 체력 : {1}\n\n", monsterX.Name, monsterX.Hp);

            Console.WriteLine("{0} 의 공격!", player_.Name);
            Console.WriteLine("{0} 은(는) {1}에게 {2} 만큼의 데미지를 입혔다!", player_.Name, monsterX.Name, DamageCalculation_Player(player_, monsterX));
            monsterX.Hp -= DamageCalculation_Player(player_, monsterX);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("{0} 의 현재 체력 : {1}\n\n", player_.Name, player_.Hp);
            Console.WriteLine("{0} 의 현재 체력 : {1}\n\n", monsterX.Name, monsterX.Hp);
            Console.ReadLine();
        } // void BattleUI_Player

        private void BattleUI_Monster(Monster monsterX, Player player_) // 몬스터 턴의 전투화면
        {
            Console.Clear();
            Console.WriteLine("{0} 의 현재 체력 : {1}\n\n", player_.Name, player_.Hp);
            Console.WriteLine("{0} 의 현재 체력 : {1}\n\n", monsterX.Name, monsterX.Hp);

            Console.WriteLine("{0} 의 공격!", monsterX.Name);
            Console.WriteLine("{0} 은(는) {1}에게 {2} 만큼의 데미지를 입혔다!", monsterX.Name, player_.Name, DamageCalculation_Monster(monsterX, player_));
            player_.Hp -= DamageCalculation_Monster(monsterX, player_);
            Console.ReadLine();

            Console.Clear();
            Console.WriteLine("{0} 의 현재 체력 : {1}\n\n", player_.Name, player_.Hp);
            Console.WriteLine("{0} 의 현재 체력 : {1}\n\n", monsterX.Name, monsterX.Hp);
            Console.ReadLine();
        } // void BattleUI_Player



        private int DamageCalculation_Player(Player player_, Monster monsterX) // 인수에 따라 계산 순서가 변화되어 int를 리턴하는 계산식을 플레이어/몬스터 기준을 따로하여 만들었다.
        {
            return player_.Damage - monsterX.Defence; // 플레이어 및 몬스터가 받는 데미지는 공격자의 데미지 - 피공격자의 방어력으로 설정하였다.
        } // int DamageCalculation_Player



        private int DamageCalculation_Monster(Monster monsterX, Player player_)
        {
            return monsterX.Damage - player_.Defence;
        } // int DamageCalculation_Monster



        private void VisitSanctum(Player player_) // 기본 선택지에서 성소를 방문하고 싶을 경우
        {
            if (Go_Sanctum)
            {
                ShowUI(player_);

                Console.WriteLine("당신은 성소를 방문하였습니다. 사제의 축복을 받아 체력을 모두 회복하였습니다.");
                player_.Hp = 99; // 체력을 회복시켜준다.
                Go_Sanctum = false;

                Console.ReadLine();
            } // if
        } // void VisitSanctum


    } // class Game












}
