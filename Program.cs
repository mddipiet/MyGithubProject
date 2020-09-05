using System;

namespace Lab_8_5_RealityTVStar
{
    class Program
    {
        static void Main(string[] args)
        {
            DreamHouseHunters contestantDHH = new DreamHouseHunters("Bassist", 60000, 3, 3, 2, "Geddy", "Lee", "7/29/53", "7831 105th Avenue",
                "Pleasant Prairie", "WI", 53158, "262-555-1234", "geddy.lee@rush.com");

            ParadiseIsland contestantPI = new ParadiseIsland("Male", "Charlene", 45, "Alex", "Lifeson", "8/27/53", "7831 105th Avenue",
                "Pleasant Prairie", "WI", 53158, "262-555-1234", "alex.lifeson@rush.com");

            AboveDeck contestantAD = new AboveDeck(20, "Canadian", "Peart", "Neil", "9/12/52", "7831 105th Avenue", "Pleasant Prairie", "WI", 53158, "262-555-1234"," neil.peart@rush.com");

            contestantDHH.Submit(); 
            contestantDHH.Accept();

            contestantPI.Submit();
            contestantPI.Accept();

            contestantAD.Submit();
            contestantAD.Accept();
        }
    }
}
