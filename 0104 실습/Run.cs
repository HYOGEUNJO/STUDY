using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0104_실습
{
    public class Run
    {
        public Initialize initialize;
      
        public Run()
        {
            initialize = new Initialize();
            
        }

        public void Init()
        {
            initialize.MapInit(initialize.map.mapMiddle);
            initialize.CharacterInit();
        }

        public void Start()
        {
            while (true)
            {
                initialize.CharacterMoveChange();

                initialize.ShowAll();

                initialize.control.InputControl(Console.ReadKey());

                initialize.Move();

                initialize.ClearBuffer();
            }
        }

    }
}
