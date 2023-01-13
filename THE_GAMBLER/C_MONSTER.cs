using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAMBLER
{
    public class C_MONSTER
    {
        public string Name;
        public int HP;
        public int ATK;
        public int DEF;
        public int Action;

        public int EXP;

        public C_MONSTER()
        {
            this.Name = String.Empty;
            this.HP = default;
            this.ATK = default;
            this.DEF = default;
            this.Action = default;
            this.EXP = default;
        } // C_MONSTER()
    } // class C_MONSTER


    public class WILDBOAR : C_MONSTER
    {
        public WILDBOAR()
        {
            this.Name = "와일드보어";
            this.HP = 30;
            this.ATK = 1;
            this.DEF = 1;
            this.Action = default;
            this.EXP = 50;
        } // WILDBOAR()
    } // class WILDBOAR : C_MONSTER


    public class GOBLIN : C_MONSTER
    {
        public GOBLIN()
        {
            this.Name = "고블린";
            this.HP = 70;
            this.ATK = 10;
            this.DEF = 7;
            this.Action = default;
            this.EXP = 50;
        }
    } // class GOBLIN : C_MONSTER


    public class UNDEAD : C_MONSTER
    {
        public UNDEAD()
        {
            this.Name = "언데드";
            this.HP = 15;
            this.ATK = 20;
            this.DEF = 20;
            this.Action = default;
            this.EXP = 50;
        }
    } // class UNDEAD : C_MONSTER





} // END
