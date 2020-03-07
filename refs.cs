using System;

namespace example
{
    class refs
    {
        static void Main ()
        {
            int a = 10;
            Console.WriteLine(a);
            Calc(ref a);
            Console.WriteLine(a);
        
        }

        static void Calc (ref int Value)
        {
            int SecondValue = 20;
            Console.WriteLine(Value);
            Value=Value+1;
        }
    }
}
