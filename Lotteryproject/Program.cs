using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotteryproject
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string playAgain = "";

                //started do while loop
                do
                {
                    Console.WriteLine("Let's plays the lottery");
                    //user sets the range, check to make sure user picks a number greater than 0 and within the range
                    Console.WriteLine("Please enter the lowest number in a range of positive numbers,");
                    int userLowNumber = int.Parse(Console.ReadLine());
                    while (userLowNumber < 0)
                    {
                        Console.WriteLine("Please enter a positive number ");
                        userLowNumber = int.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Please enter the highest number in a range of positive numbers");
                    int userHigherNumber = int.Parse(Console.ReadLine());
                    while (userHigherNumber < userLowNumber)
                    {

                        Console.WriteLine("Please enter a number a higher number");
                        userHigherNumber = int.Parse(Console.ReadLine());
                        break;
                    }
                    //Ask user to guess 6 numbers
                    int numberofGuessess = 6;
                    int[] userNumbers = new int[numberofGuessess];



                    for (int i = 0; i < userNumbers.Length; i++)
                    {
                        Console.WriteLine("Enter your  number");
                        int numberEntered = int.Parse(Console.ReadLine());

                        while (numberEntered < userLowNumber || numberEntered > userHigherNumber)
                        {
                            Console.WriteLine("Please enter a number with in range");
                            break;
                        }
                        userNumbers[i] = numberEntered;
                    }



                    //computer generates random numbers
                    //declare variables should ave done it in the beginning

                    int[] lottoNumbers = new int[6];
                    Random rand = new Random();
                    int temp = 0;
                    int count = 0;

                    //fill array with lottery numbers
                    for (int i = 0; i < lottoNumbers.Length; i++)
                    {
                        temp = rand.Next(userLowNumber, userHigherNumber);//generate random number


                        // check to for duplicate
                        while (lottoNumbers.Contains(temp) == true)
                            temp = rand.Next(userLowNumber, userHigherNumber); // duplicate, try again

                        //add new number
                        lottoNumbers[i] = temp;
                        count++;
                    }
                    // display the numbers
                    foreach (int i in lottoNumbers)
                    {
                        Console.WriteLine("Lucky Number: " + (i));
                    }
                    // Compare user and computer for matches, for example loop

                    int numbersCorrect = 0;

                    for (int i = 0; i < userNumbers.Length; i++)
                    {
                        foreach (int number in lottoNumbers)
                            if (number == userNumbers[i])
                            {
                                numbersCorrect += 1;

                            }
                    }
                    //informs user of numbers matched
                    Console.WriteLine("You have guessed {0}, numbers correctly", numbersCorrect);


                    if (numbersCorrect == 6)
                    {
                        Console.WriteLine("You have won $1,000,000");
                    }
                    else if (numbersCorrect >= 3)
                    {
                        Console.WriteLine("You have won $250,000");
                    }

                    else if (numbersCorrect >= 1)
                    {
                        Console.WriteLine("You have won $100");
                    }
                    else
                    {
                        Console.WriteLine("Thank you, you lose");

                    }

                    //    Ask user to play again

                    Console.WriteLine("Would you like to play again? YES or No");
                    playAgain = Console.ReadLine();
                    while (playAgain.ToLower() == "No")
                    {
                        Console.WriteLine(" Thanks for playing");
                        Console.WriteLine("last chance, YES/NO");
                        playAgain = Console.ReadLine();
                        if (playAgain.ToLower() == "NO")
                        {
                            break;

                        }

                    }
                }

                while (playAgain.ToLower() == "yes");

            }
        }
    }
}















































