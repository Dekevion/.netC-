using System;

// Namespace

namespace NetConsole
{
    // Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars

            string appName = "Guess the Number";
            string appVersion = "1.0.0";
            string appAuthor = "Dekevion Wade";


            // Change text Color
            Console.ForegroundColor = ConsoleColor.Blue;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);


            //Reset ConsoleColor
            Console.ResetColor();

            // Ask for the user's name

            Console.WriteLine("What is your name?");

            //Get user input  READLINE
            string inputName = Console.ReadLine();

            //Write out user's name into console

            Console.WriteLine("Hello {0}....." ,inputName);

            while(true) { 
            // Set correct Number

            // int correctNumber = 9;

            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            // Initialize the gues variable

            int guess = 0;

            //ask the user to guess the number

            Console.WriteLine("Guess a number between 1 and 10");

            // while guess is not correct 
            while(guess != correctNumber) {
                // Get the user's input
                string input = Console.ReadLine();

                // Make sure its a number
                if (!int.TryParse(input, out guess)) { 
                
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter an actual number!");

                    // Reset Color
                    Console.ResetColor();
                    continue;
                }

                // Cast to int and put inside guess
                guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Change text Color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Write out app info
                        Console.WriteLine("Wrong Number Please try again");


                        //Reset ConsoleColor
                        Console.ResetColor();

                        // Ask to play again
                        Console.WriteLine("Play again [Y or N]");

                        // Get Answer
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
                    Console.WriteLine("You guessed the Correct Number!");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                }
            }

            // Lets users know its the correct number
           
        }

        static void getAppInfo() { 
        }
    }
}
