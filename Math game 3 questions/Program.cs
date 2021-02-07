using System;

namespace Math_game_3_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1; int num2; int num3; int answerscorrect; int answersbad;

            Console.Title = "Math Questions";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to math games! We will ask you 3 questions. Aswer them all correctly for a price!");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Question 1");
            Console.WriteLine("What is 10 + 5 + 6");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 21)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                answerscorrect = 1; answersbad = 0;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("That's not correct, result is 21");
                answersbad = 1; answerscorrect = 0;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Next question is:");
            Console.WriteLine("What is 100 / 20");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (num2)
            {
                case 5:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct");
                    answerscorrect = 2; answersbad = 0;
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You were close. Result was 5");
                    if (answerscorrect > 1)
                    {
                        answersbad = 1;
                    }
                    else
                    {
                        answersbad = 2;
                    }
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect, Result was 5");
                    if (answerscorrect > 1)
                    {
                        answersbad = 1;
                    }
                    else
                    {
                        answersbad = 2;
                    }
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Last question!");
            Console.WriteLine("What is the number of answers this game has?");
            num3 = Convert.ToInt32(Console.ReadLine());

            switch (num3)
            {
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Good job. That's the answer");
                    if (answerscorrect == 2)
                    {
                        answerscorrect = 3; answersbad = 0;
                    }
                    else if(answerscorrect == 1)
                    {
                        answerscorrect = 1; answersbad = 2;
                    }
                    else
                    {
                        answerscorrect = 0; answersbad = 3;
                    }
                        break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is incorrect, the answer is 3");
                    if (answerscorrect == 2)
                    {
                        answerscorrect = 2; answersbad = 1;
                    }
                    else if (answerscorrect == 1)
                    {
                        answerscorrect = 1; answersbad = 2;
                    }
                    else
                    {
                        answerscorrect = 0; answersbad = 3;
                    }
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("That's the game! You got " + answerscorrect + " correct answers and: " + answersbad + " bad answers!");
            Console.WriteLine("--------------------------------------------------------------------------------------------------- ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hope you enjoyed it! Made by knighter 2021, Press any key to close the window (code lines used:126)");
            Console.ReadKey();

        }
    }
}
