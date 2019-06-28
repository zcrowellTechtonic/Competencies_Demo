using System;

//Namespace
namespace C_Sharp_Competency
{
    //Main Class
    class MainClass
    {
        //Entry Point Method
        public static void Main(string[] args)
        {
            GetAppInfo(); //Run get app info function to display app information

            GreetUser(); //Ask for users name and greet

            while (true)
            {

                //Create a new random object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();

                    //Make sure input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use a real number");
                        //Keep going
                        continue;
                    }
                    //Cast to int and out into the guess variable
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Great guess! You're super duper A+ awesome!");

                //Ask user if they want to play again
                Console.WriteLine("Play again ? [Y, N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        //Get and display app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Zach C";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app inf0
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        //Greets user with message
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print color message

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Output success message
            Console.ForegroundColor = color;

            //Tell user it's the correct number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
} 
