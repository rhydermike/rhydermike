using System;
namespace Mike
{
    public class MyData
    {
        public int PlanetNumber {get; set;}  
        public string PlanetDescription {get; set;}
        public string PlanetName {get; set;}
    }
    class Planets
    {
        static void Main (string[] arg)
        {
            MyData PlanetData = new MyData();
            for (PlanetData.PlanetNumber =1; PlanetData.PlanetNumber < 80; PlanetData.PlanetNumber++)
            {
            string[] FinalPlanetData=BuildDescription(PlanetData.PlanetNumber);
            PrintDescription(PlanetData.PlanetNumber, FinalPlanetData);
            }

        }


        static string [] BuildDescription (int PlanetNumber)
        {
            string[] Starts = {"R","B","Le","Sn","Cr","Pl","L","K","Qu","Ap"};
            string[] Middles = {"ara","er","oh","ee","al","am","ra","o","e","apa"};
            string[] Ends = {"ard","et","eck","als","ck","la","re","t","d","do"};
            string[] OPara = {"The planet ", "The delightful destination ", "A popular tourist spot, ", "A wretched hive of scum and villainy, ", "A planet long thought lost, ", "The often overlooked "};
            string[] SFamed = {" is famed for its ", " is well known for its ", " is sometimes avoided due to its reputation for "," is plagued by "};
            string[] Adjective = {"incredible ","jumping ","edible ","incredulous ","fashionable ","dancing ", "sporting ", "mostly harmless ","death-defying ", "musical ", "theatrical ", "electrically operated "};
            string[] NotorietyObject = {"lizards","liberals","politicians","guitarists","robots","crab people", "astute intellectuals", "robotic assassins of death", "humanoid felines", "ZX81 enthusiasts"};
            string[] GovernmentsAdj = {"Feudal", "Anarchic", "Liberal", "Social", "Mostly Unfair", "Republican"};
            string[] GovernmentType = {"Democracy", "Autocracy", "Technocracy", "Despotism", "Republic"};
            //string[] AltEnding = {"of death", "of cheese", "of legend"}
            
            double NewState, OldState;
            int SmallVal; 
            int[] Index = new int[3]; 
            const long Modulus = 2147483648;

                
            int f = PlanetNumber;

            OldState=f;  
            NewState=f;
            for (int g=0; g<3; g++)
                {
                    NewState = (214013 * OldState + 2531011) % Modulus;
                    NewState = NewState / 65536;
                    SmallVal = (int) NewState % Starts.Length;
                    Index[g] = SmallVal;
                    OldState = NewState;
                }
            int FinalState=(int)NewState;

            // collect strings
            string Gov, PlanetName, NObj, Famed, LongAdjective, PlanetOpening, PlanetDescription;
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
                
                PlanetOpening = OPara[FinalState % OPara.Length];

                PlanetDescription = PlanetOpening + PlanetName + Famed + LongAdjective + NObj + ".";
                string[] FinalPlanetData = {PlanetName,Gov,PlanetDescription};
                
                return FinalPlanetData;

        }

        static void PrintDescription(int PlanetNumber, string[] FinalPlanetData)
        {
//Print output    
            Console.WriteLine();
            Console.WriteLine($"Planet Number: {0}" + PlanetNumber);
            Console.WriteLine("Planet Name: " + FinalPlanetData[0]);
            Console.WriteLine("Government Type: " + FinalPlanetData[1]);
            Console.WriteLine("Planet Description:" + FinalPlanetData[2]);
            Console.WriteLine();
        }   
        
}
}
