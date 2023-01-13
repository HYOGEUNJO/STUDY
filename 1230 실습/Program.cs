namespace _1230
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PACKMAN Game = new PACKMAN();
            Game.Set_Map(4, 4);
            Game.Set_Man();
            Game.Set_Coin1();

            while (true)
            {
                Game.Show_Map();
                Game.Move_Man(Console.ReadKey());
                Game.If_Catch_Coin();
            }










        }
    }
}