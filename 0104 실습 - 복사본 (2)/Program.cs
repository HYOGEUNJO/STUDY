namespace _0104_실습
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Initialize initialize = new Initialize();

            initialize.MapInit(initialize.map.mapMiddle);
            initialize.CharacterInit();

            while(true)
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