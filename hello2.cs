using System;
namespace Helloworld
{
    class Hello
    {
        static void Main(string[] args)
        {
            int i;
            bool coin;
            int toss = 0;
            int head_count = 0;
            int tail_count = 0;
            int same_count = 0;
            int last_result = 0;
            int greater_than_five = 0;
     Random rnd = new Random();
            for (i=1; i < 101; i++)
            {
            //    Console.Write(i);
            toss = rnd.Next(1,3);
            if (toss==last_result)
            {
                same_count++;
                if (same_count>5)
                {
                    greater_than_five++;
                }
            }
            else
            {
                same_count=0;
            }
            if (toss==1)
                {
                    coin=true;
                    head_count++;
                }
                else
                {
                    coin=false;
                    tail_count++;
                }                         
            if (coin == true)
            {
                Console.Write("H");
            }
            else
            {
            Console.Write("T");
            }
            last_result=toss;

            }   
        PrintResult(head_count, tail_count, greater_than_five);
        }
    static void PrintResult(int result1, int result2, int result3)
    {
        Console.WriteLine("");
        Console.WriteLine("Head count=" + result1);
        Console.WriteLine("Tail count=" + result2);
        Console.WriteLine("Total greater than five same in row="+result3);
    }
    }
}
