using System;
namespace Mike
{
    class Days
    {
        static void Main (string[] arg)
        {
            int TestNumber = 100;
            int CurrentDay = 3;
            string[] days = {"Monday", "Tuesday", "Wedneday", "Thursday", "Friday", "Saturday", "Sunday"};
            int result;

            result = (CurrentDay+TestNumber) & 7;
            Console.WriteLine(days[result-1]);



        }
    }
}