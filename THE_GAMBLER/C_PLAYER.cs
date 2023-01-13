using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_GAMBLER
{
    public class C_PLAYER
    {
        public int Y_Current;
        public int X_Current;
        public int Y_After;
        public int X_After;

        public int STR;
        public int INT;
        public int LUCK;
        public int HP;
        public int EXP;

        public int DEF;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public const string Player_String = "◆";
        public const int Player = 0;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public C_PLAYER()
        {
            this.Y_Current = 40;
            this.X_Current = 40;
            this.Y_After = default;
            this.X_After = default;
            
            this.STR = 1;
            this.INT = 1;
            this.LUCK = 1;
            this.HP = STR * 10;
            this.EXP = 0;

            DEF = 0;
        } // C_PLAYER()
    } // class C_PLAYER


} // END
