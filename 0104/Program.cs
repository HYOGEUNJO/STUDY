namespace _0104
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Description desc = new Description();

            // 값 전달 방식
            int number1 = 10; 
            int number2 = 20;
            desc.ValueTypeParam(number1, number2); // 값 형식으로 전달. Main 값(원본)은 바뀌지 않는다.
            Console.WriteLine("[Main(기본 전달)] first {0} , second {1}", number1, number2);
            Console.WriteLine();

            // 참조 전달 방식
            desc.RefTypeParam(ref number1, ref number2); // 포인터 전달 방식.
            Console.WriteLine("[Main(ref 후)] first {0} , second {1}", number1, number2);
            Console.WriteLine();

            // 반환형 전달 방식
            int number = 1;
            Console.WriteLine("[Main(out 전)] number {0}", number);
            desc.OutTypeParam(out number);
            Console.WriteLine("[Main(out 후)] number {0}", number);
            Console.WriteLine();

            string strNumber = "100";
            int intNumber;
            int.TryParse(strNumber, out intNumber);
            Console.WriteLine("{0}", intNumber + 10);

            string strNumber2 = "*!@";
            int intNumber2;
            int.TryParse(strNumber2, out intNumber2);
            Console.WriteLine("{0}", intNumber2); // 숫자로 전환되지 않으면 0으로 취급한다.
            Console.WriteLine();

            // 가변형 전달 방식
            desc.FlexibleTypeParam(1, 2, 3, 10, 40, 111, 1235);



        }
    }
}