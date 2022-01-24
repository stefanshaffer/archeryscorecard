using System;

namespace practiceScoreCard
{

    public static class Game
    {
        private static string _shooter;

        public static void StartGame()
        {
             Console.WriteLine("Welcome to the Hartwell Rd. Archery Shoot!");
             PrintShooters();
             card b = new card();
             b.scorekeeper = GetScorekeeper();
             Scorecard a = new Scorecard();
             b.shootertotal = NumShooters();

             string result = a.GetScorecardDetails(b.shootertotal, b.scorekeeper);
             Console.WriteLine(result);
             Console.WriteLine("Press Enter Key to Exit..");
             Console.ReadLine();
        }

        public static string GetScorekeeper()
        {
            Console.WriteLine("Who is keeping score?");
            string keeper = Console.ReadLine();
            return keeper;
            
            
        }

        private static int NumShooters()
        {
            Console.WriteLine("How many people are shooting through?");
            var shooters = Convert.ToInt32(Console.ReadLine());
            return shooters;
        }

        public static void PrintShooters()
        {
            string[] shooterlist = new string[NumShooters()];
            for (int i = 0; i < shooterlist.Length; i++)
            {
                Console.WriteLine("Who is the index :" + " " + i.ToString());
                shooterlist[i] = Console.ReadLine();
            }

            foreach (var shooter     in shooterlist)
            {
                Console.WriteLine(shooter);
            }


        }

        public static void Main()
        {
            StartGame();
        }

        class Scorecard
        {
            public string GetScorecardDetails(int numofshooters , string keeper )
            {
                string info = string.Format( "Number of shooters: {0} \nScorekeeper: {1} ", numofshooters , keeper);
                if (numofshooters > 4)
                {
                    Console.WriteLine("That's too many shooters.  Try again");
                    StartGame();
                    return null;

                }
                else return info; 
                        
            }
        }
    }
}