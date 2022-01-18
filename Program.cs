using System;

namespace practiceScoreCard
{

    public static class Game
    {
        public static void StartGame()
        {
             Console.WriteLine("Welcome to the Hartwell Rd. Archery Shoot!");
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

/*class Program
{
    static void Main(string[] args)
    {
        Program p = new Program();
        string result = p.GetUserDetails("Suresh Dasari", 31);
        Console.WriteLine(result);
        Console.WriteLine("Press Enter Key to Exit..");
        Console.ReadLine();
    }
    public string GetUserDetails(string name, int age)
    {
        string info = string.Format("Name: {0}, Age: {1}", name, age);
        return info;
    }*/