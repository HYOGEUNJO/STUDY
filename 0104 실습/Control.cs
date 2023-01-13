using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0104_실습
{
    public class Control
    {
        public Character character;

        public Control()
        {
            character = new Character();

        }


        public void InputControl(ConsoleKeyInfo Input)
        {
            switch (Input.Key)
            {
                case ConsoleKey.W:
                    {
                        character.postY = character.preY - 1;
                        character.postX = character.preX;
                    }
                    break;
                case ConsoleKey.D:
                    {
                        character.postX = character.preX + 1;
                        character.postY = character.preY;
                    }
                    break;
                case ConsoleKey.S:
                    {
                        character.postY = character.preY + 1;
                        character.postX = character.preX;
                    }
                    break;
                case ConsoleKey.A:
                    {
                        character.postX = character.preX - 1;
                        character.postY = character.preY;
                    }
                    break;
            }

        } // void InputControl()


    } // class Control


} // END
