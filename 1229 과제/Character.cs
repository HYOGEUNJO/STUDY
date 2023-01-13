using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1229__2
{
    class Character // 조상 클래스, 여기서 플레이어 클래스와 몬스터 클래스가 분화된다.
    {
        // 모든 캐릭터(플레이어, 몬스터들)의 기본적인 공통사항
        public string Name; // 이름
        public string Description; // 설명
        public int Hp; // 체력포인트
        public int Defence; // 방어력
        public int Damage; // 공격력
    } // class Character


    class Player : Character // 유저가 플레이하는 플레이어 캐릭터
    {
        // 플레이어 캐릭터는 몬스터와 다르게 인벤토리를 가지고 있다.
        public string[] Inventory; // 인벤토리 배열
        public int InventoryIndex; // 인벤토리 배열에 순차적으로 아이템이 들어갈 수 있게 인덱스를 설정하였다.


        public Player()
        {
            // class Character
            this.Name = String.Empty;
            this.Description = "몬스터들을 무찌르기 위하여 여행중이다.";
            this.Hp = 99;
            this.Defence = 0;
            this.Damage = 10;


            // class Player
            this.Inventory = new string[255]; // 인벤토리 크기는 넉넉하게 잡았다.
            this.InventoryIndex = 0; // 0번째 배열부터 순차적으로 아이템이 장착된다.
        }
    } // class Player


    class Monster : Character // 몬스터들의 부모 클래스, 몬스터 클래스로부터 슬라임, 늑대, 스켈레톤, 마지막 보스인 여왕거미로 분화된다.
    {
        // 몬스터들은 자신들 고유의 아이템을 갖고 있다.
        public string[] Item;
    } //  class Monster


    class Slime : Monster // 제일 쉬운 상대
    {
        public Slime()
        {
            // class Character
            this.Name = "슬라임";
            this.Description = "흐물거리는 몸을 가진 약한 몬스터";
            this.Hp = 14;
            this.Defence = 1;
            this.Damage = 3;
            // 슬라임은 따로 아이템을 가지고 있지 않다.
        }
    } // class Slime


    class Wolf : Monster // 슬라임과 마찬가지로 쉬운 상대이긴 하나 늑대를 계속 잡아 가죽 갑옷을 얻어야지만 다음 상대안 스켈레톤을 아슬하게 무찌를 수 있다.
    {
        public Wolf()
        {
            // class Character
            this.Name = "늑대";
            this.Description = "산에서 서식하는 야수.";
            this.Hp = 24;
            this.Defence = 3;
            this.Damage = 7;
            // class Monster
            this.Item = new string[1] { "가죽 갑옷" }; // 늑대가 드롭하는 아이템
        }
    } // class Wolf


    class Skeleton : Monster // 늑대의 다음 상대, 스켈레톤이 드랍하는 아이템과 늑대의 아이템을 전부 장비해야지만 거미여왕을 무찌를 수 있다.
    {
        public Skeleton()
        {
            // class Character
            this.Name = "스켈레톤";
            this.Description = "죽은 자가 되살아나 공격한다.";
            this.Hp = 100;
            this.Defence = 2;
            this.Damage = 10;
            // class Monster
            this.Item = new string[2] { "낡은 장검", "낡은 방패" }; // 스켈레톤이 드롭하는 아이템
        }
    } // class Skeleton


    class SpiderQueen : Monster // 최종 보스
    {
        public bool GameEnding; // 거미여왕을 잡아야지만 엔딩을 볼 수 있다. bool형식의 트리거로 여왕을 무찌르면 반복문 트리거가 비활성되어 엔딩 장면이 나온다. 기본값은 true이다.
        public SpiderQueen()
        {
            // class Character
            this.Name = "여왕 거미";
            this.Description = "깊은 동굴에 서식하며, 지나가는 여행자들을 잡아먹는다. 당신은 이 몬스터를 처치하기 위하여 여행중이다.";
            this.Hp = 99;
            this.Defence = 4;
            this.Damage = 16;
            // class SpiderQueen
            GameEnding = true; // 엔딩 트리거
        }
    } // class SpiderQueen
} // END





