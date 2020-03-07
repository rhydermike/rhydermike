using System;
namespace Coin
{
class CoinToss
{

static void Main (string [] args)
{
    bool CurrentState; //true = heads : false = tails
    int TotalTosses=50;
    int TotalMatches=50;


    Console.WriteLine("Coin toss simulator");
    PlayRound();
}


public static void PlayRound ()
    {
        bool CurrentState, LastState;
        int SameStateCounter = 0, HeadCounter = 0, TailsCounter = 0;

        for (int i = 1; i<40; i++)
            {
                CurrentState = TossCoin();
                if (CurrentState == true)
                {
                    HeadCounter++;
                    Console.Write("H");
                }
                else
                {
                    TailsCounter++;
                    Console.Write("T");
                }
            }
    }

}
}


