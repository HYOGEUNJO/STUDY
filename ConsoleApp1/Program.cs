namespace ConsoleApp1
{
    internal class Program
    {
        protected static int origRow;
        protected static int origCol;

        protected static void WriteAt(string s, int x, int y)
        {
            try
            {
                Console.SetCursorPosition(origCol + x, origRow + y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }


        static void Main(string[] args)
        {




            Console.SetCursorPosition(5, 5);
            Console.WriteLine("s");
            Console.ReadLine();
        }
    }
}