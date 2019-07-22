using System;

namespace WindowsApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Intro();

        }

        /***
         * Welcome Message
         */
        public static void Intro()
        {
            string AppName = "Number Guesser";
            string version = "1.0.0";
            string Author = "Tambi Asawo";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("This is a " + AppName + " Game");
            Console.WriteLine("Created By: " + Author);
            Console.WriteLine("Version: " + version);

            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string InputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, welcome to the {1} game", InputName, AppName);
            PlayGame(InputName);

        }

        /***
        * Code for Playing Game
        */
        public static void PlayGame(String Name)
        {
            Console.WriteLine("Guess a number between 1 and 10: ");
            int Input = Int32.Parse(Console.ReadLine());

            Random Num = new Random();
            int RightNo =Num.Next(1, 11);

            Boolean PlayAgain = true;
            while (PlayAgain)
            {
                if (Input != RightNo)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry! Try again.");
                    Console.ResetColor();
                    Console.WriteLine("Guess a number between 1 and 10: ");
                    Input = Int32.Parse(Console.ReadLine());
                }


                else
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Yes. You got it!");
                    Console.ResetColor();
                    Console.WriteLine("Do you want to play Again? [Y or N]");
                    string PlayInput = Console.ReadLine().ToUpper();
                    if (PlayInput == "Y")
                    {
                        Console.WriteLine("OK! Guess a number between 1 and 10: ");
                        Input = Int32.Parse(Console.ReadLine());
                    }
                    else if (PlayInput == "N")
                    {
                        Console.WriteLine("OK. Bye {0}", Name);
                        PlayAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input. Enter Y for Yes and N for No");
                        Console.WriteLine("Do you want to play Again? [Y or N]");
                        PlayInput = Console.ReadLine().ToUpper();
                        if (PlayInput == "Y")
                        {
                            Console.WriteLine("OK! Guess a number between 1 and 10: ");
                            Input = Int32.Parse(Console.ReadLine());
                        }
                        else if (PlayInput == "N")
                        {
                            Console.WriteLine("OK. Bye {0}", Name);
                            PlayAgain = false;
                        }

                    }
                }
            }

        }

    }
}

