using System;
using System.CodeDom;
using System.Collections;

namespace practiceScoreCard
{

    public static class Game
    {
        public static void StartGame()
        {
             Console.WriteLine("Welcome to the Hartwell Rd. Archery Shoot!");
             Scorecard a = new Scorecard();
             Console.WriteLine("How many people are shooting through?");
             int answer1 = Convert.ToInt32(Console.ReadLine());
             string answer2 = "test";
             string result = a.GetScorecardDetails(answer1, answer2);
             Console.WriteLine(result);
             Console.WriteLine("Press Enter Key to Exit..");
             Console.ReadLine();
        }

        class Scorecard
        {
            public string GetScorecardDetails(int numofshooters , string shooterlist )
            {
                string info = string.Format( "Number of shooters: {0} \nNames of shooters: {1} ", numofshooters , shooterlist);
                if (numofshooters > 4)
                {
                    Console.WriteLine("That's too many shooters.  Try again");
                    StartGame();
                    return null;

                }
                else return info; 
                        
            }
        }
        public static void Main()
        {
            StartGame();
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