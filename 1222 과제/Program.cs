namespace _1222_과제
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string[] sAr_PersonName = new string[5];
            for (int i = 0; i < sAr_PersonName.Length; i++)
            {
                sAr_PersonName[i] = "A" + i;
            }
            //for (int i = 0; i < sPersonName.Length; i++)
            //{
            //    Console.Write("{0}  ", sPersonName[i]);
            //}
            //Console.WriteLine("\n");





            int[] sAr_AppleEa = new int[5];



            Random rRandom = new Random();

            for (int i = 0; i < sAr_AppleEa.Length; i++)
            {
                sAr_AppleEa[i] = rRandom.Next(1, 500);
                for (int j = 0; j < sAr_AppleEa.Length; j++)
                {
                    if (i == j) { } // 인덱스가 같아 중복되는 경우를 제외. 인덱스가 같은 수면 해당 값은 항상 같을 수 밖에 없다. ex) sAr_AppleEa[0] == sAr_AppleEa[0] 이므로 
                    else // 인덱스가 동일하여 해당 값이 같은 경우를 제외하고 값이 중복되는 경우.
                    {
                        if (sAr_AppleEa[i] == sAr_AppleEa[j])
                        {
                            i -= 1;
                            break;
                        }
                        else { }
                    }
                }
            }



            for (int i = 0; i < sAr_AppleEa.Length; i++)
            {
                Console.Write("{0}  ", sAr_AppleEa[i]);
            }
            Console.WriteLine("\n");




        }
    }
}


//for (int i = 0; i < sAr_AppleEa.Length - 1; i++)
//{
//    for (int j = i + 1; j < sAr_AppleEa.Length; j++)
//    {
//        if (sAr_AppleEa[i] == sAr_AppleEa[j])
//        {
//            bISDuplicate = true;
//        }
//    }
//}

//if (bISDuplicate)
//{

//}
//else
//{
//    swich1 = false;
//}