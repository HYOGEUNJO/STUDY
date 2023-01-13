using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1229
{
    class MyCharacter
    {
        public string Name;
        public string Description;
        public int Hp;
        public int Defence;
        public int Damage;

        public void ShowInformation()//string Name_, string Description_, int Hp_, int Defence_, int Damage_)
        {
            Console.WriteLine("< {0} >", Name);
            Console.WriteLine("설명 : {0}", Description);
            Console.WriteLine("체력 : {0}", Hp);
            Console.WriteLine("방어력 : {0}", Defence);
            Console.WriteLine("공격력 : {0}", Damage);
            Console.WriteLine();
        }

        protected void Attacking(string Name_, int Damage_)
        {
            Console.WriteLine("{0} 이(가) {1} 의 데미지로 공격했다.", Name_, Damage_);
        }
        protected void Attacked(string Opposition_Name_, int Damage_, int Opposition_Hp_)
        {
            Console.WriteLine("{0} 은(는) {1} 의 데미지를 받아 체력이 {2} 로 변하였다.", Opposition_Name_, Damage_, Opposition_Hp_);
            Opposition_Hp_ -= Damage_;
        }

        public void AttackProcess(string Name_, int Damage_, string Opposition_Name_,int Opposition_Hp_)
        {
            Attacking(Name_, Damage_);
            Attacked(Opposition_Name_, Damage_, Opposition_Hp_);
        }

    } // class MyCharacter


    class MyPlayer : MyCharacter
    {
        public string[] Inventory;

        public MyPlayer()
        {
            // class MyCharacter
            this.Name = "모험가";
            this.Description = "마왕을 무찌르기 위하여 여행을 떠난 용사이다.";
            this.Hp = 100;
            this.Defence = 10;
            this.Damage = 10;
            // class MyPlayer
            this.Inventory = new string[255]; 

        }



    } // class MyPlayer


    class MyMonster : MyCharacter
    {
        public string[] Item;
    } //  class MyMonster


    class MySlime : MyMonster
    {
        public MySlime()
        {
            // class MyCharacter
            this.Name = "슬라임";
            this.Description = "흐물거리는 몸을 가진 가장 약한 몬스터";
            this.Hp = 10;
            this.Defence = 1;
            this.Damage = 1;
            // class MyMonster
            this.Item = new string[2] {"슬라임 체액", "포션"};
        }


    } // class MySlime


    class MyWolf : MyMonster
    {
        public MyWolf()
        {
            // class MyCharacter
            this.Name = "늑대";
            this.Description = "산에서 서식하는 야수";
            this.Hp = 30;
            this.Defence = 3;
            this.Damage = 5;
            // class MyMonster
            this.Item = new string[3] { "늑대 가죽", "늑대 송곳니", "가죽 갑옷" };
        }



    } // class MyWolf


    class MySkeleton : MyMonster
    {
        public MySkeleton()
        {
            // class MyCharacter
            this.Name = "스켈레톤";
            this.Description = "죽은 자가 되살아나 공격한다";
            this.Hp = 70;
            this.Defence = 2;
            this.Damage = 7;
            // class MyMonster
            this.Item = new string[4] {"금화","스켈레톤 뼈다귀","낡은 장검","낡은 방패" };
        } // class MySkeleton


    } // class MyCharacter






}
