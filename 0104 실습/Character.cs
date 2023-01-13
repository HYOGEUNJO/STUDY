using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0104_실습
{
    public class Character
    {
        public int MAN;
        public string IMAGE_MAN;

        public int man;
        public int preX;
        public int preY;
        public int postX;
        public int postY;

        public Character()
        {
            MAN = 0;
            IMAGE_MAN = "옷";

            man = MAN;
            preX = 3;
            preY = 3;
            postX = preX;
            postY = preY;

        }// Character()


    } // class Character


} // END
