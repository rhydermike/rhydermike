using System;

namespace example
{
    class refs
    {
        static void Main ()
        {
            MyData Data = new MyData();
            int a = 10;
            Console.WriteLine(a);
            Calc(ref a);

            Data.Value = 111;
            Console.WriteLine(Data.Value);
            Second(Data);
            Console.WriteLine(Data.Value);
        
        }

        static void Calc (ref int Value)
        {
            int SecondValue = 20;
            Console.WriteLine(Value);
            Value=Value+1;
        }

        public static void Second(MyData Data)
        {
            Data.Value++;
        }
    }
    public class MyData
    {
        public int Value {get;set;}
    }
}
