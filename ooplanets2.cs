using System;
namespace Mike
{
    
    class Planets
    {
        public class MyData
    {
        public int PlanetNumber {get; set;}  
        public string PlanetDescription {get; set;}
        public string PlanetName {get; set;}
        public string Government {get; set;}
    }
//Main
        static void Main (string[] args)
        {
            MyData PlanetData = new MyData();

            if (args.Length==0)
            {
//Build and print x number of planets
            
            
            for (int i = 1; i < 1000; i++)
                {
                PlanetData.PlanetNumber=i;
                BuildDescription(PlanetData);
                PrintDescription(PlanetData);
                }
            }
            else
            {
                PlanetData.PlanetNumber=Int16.Parse(args[0]);
                BuildDescription(PlanetData);
                PrintDescription(PlanetData);
            }
            }
      


        public static void BuildDescription (MyData PlanetData)
        {
            string[] Starts = {"R","B","Le","Sn","Cr","Pl","L","K","Qu","Ap"};
            string[] Middles = {"ara","er","oh","ee","al","am","ra","o","e","apa"};
            string[] Ends = {"ard","et","eck","als","ck","la","re","t","d","do"};
            string[] OPara = {"The planet ", "The delightful destination ", "A popular tourist spot, ", "A wretched hive of scum and villainy, ", "A planet long thought lost, ", "The often overlooked "};
            string[] SFamed = {" is famed for its ", " is well known for its ", " is sometimes avoided due to its reputation for "," is plagued by "};
            string[] Adjective = {"incredible ","jumping ","edible ","incredulous ","fashionable ","dancing ", "sporty ", "mostly harmless ","death-defying ", "musical ", "theatrical ", "electrically operated "};
            string[] NotorietyObject = {"lizards","liberals","politicians","guitarists","robots","crab people", "astute intellectuals", "robotic assassins", "humanoid felines", "ZX81 enthusiasts"};
            string[] GovernmentsAdj = {"Feudal", "Anarchic", "Liberal", "Social", "Mostly Unfair", "Republican"};
            string[] GovernmentType = {"Democracy", "Autocracy", "Technocracy", "Despotism", "Republic"};
            string[] AltEnding = {" of death", " of moon cheese", " of legend", " of joyfulness"};
            
            double NewState, OldState;
            int SmallVal; 
            int[] Index = new int[3]; 
            const long Modulus = 2147483648;
            const long Mult = 214013;
            const long Addition = 2531011;
            const long Divisor = 65536;

            int f=PlanetData.PlanetNumber;
            
            OldState=f;  
            NewState=f;
            for (int g=0; g<3; g++)
                {
                    NewState = (Mult * OldState + Addition) % Modulus;
                    NewState = NewState / Divisor;
                    SmallVal = (int) NewState % Starts.Length;
                    Index[g] = SmallVal;
                    OldState = NewState;
                }
            int FinalState=(int)NewState;

            // collect strings
            string Gov, PlanetName, NObj, Famed, LongAdjective, PlanetOpening;
            Gov = GovernmentsAdj[FinalState % GovernmentsAdj.Length] + " " + GovernmentType[FinalState % GovernmentType.Length];

            PlanetName = Starts[Index[0]]+Middles[Index[1]]+Ends[Index[2]];
                if (FinalState % 3 == 1)
                {
                    LongAdjective = Adjective[FinalState % Adjective.Length] +PlanetName + "ian " + Adjective[(FinalState + 1) % Adjective.Length];
                }
                else
                {
                    LongAdjective = Adjective[FinalState % Adjective.Length];
                }

            NObj = NotorietyObject[FinalState % NotorietyObject.Length];
            Famed = SFamed[FinalState % SFamed.Length];

            string Ending;

            int FinalRND = FinalState / 2 % 5;
            
            if (FinalRND == 1)
            {
                Ending = AltEnding [FinalState % AltEnding.Length]+".";
            }
            else
            {
                Ending = ".";
            }
                
            PlanetOpening = OPara[FinalState % OPara.Length];

            PlanetData.PlanetNumber = f;
            PlanetData.PlanetDescription = PlanetOpening + PlanetName + Famed + LongAdjective + NObj + Ending;
            PlanetData.Government = Gov;
            PlanetData.PlanetName = PlanetName;
        }

        static void PrintDescription(MyData PlanetData)
        {
//Print output    
            Console.WriteLine();
            Console.WriteLine($"Planet Number: {0}" + PlanetData.PlanetNumber);
            Console.WriteLine("Planet Name: " + PlanetData.PlanetName);
            Console.WriteLine("Government Type: " + PlanetData.Government);
            Console.WriteLine("Planet Description:" + PlanetData.PlanetDescription);
        }   
        
}
}
