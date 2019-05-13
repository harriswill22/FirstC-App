using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Will Harris";
            //change tex color
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName,appVersion, appAuthor);

            Console.ResetColor();
            
            //Ask Users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game ....", inputName);

            //Int correct number 
            int correctNumber = 7;

            //Init guess var
            int guess = 0;
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while(guess != correctNumber){
                //Get user input
                string input = Console.ReadLine();

                //Cast to init and put in guess
                guess = Int32.Parse(input);

                // Match guess to corrrect number
                if(guess != correctNumber){
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Wrong number, please try again ");

            Console.ResetColor();
                }
            }

            //OutPut success message 
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("You are correct ");

            Console.ResetColor();
        }
    } 
}
