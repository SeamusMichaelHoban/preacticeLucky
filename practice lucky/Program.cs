using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_lucky
{
    class Program
    {
        static void Main(string[] args)
        {
            //string jackPot
            Console.WriteLine("The JackPot is $1 million Dollars!!");
            Console.WriteLine("Please use numbers 1-80");

            //Ask user for a starting number
            int[] userNums = new int[6];
            int userLowNum;
            while (userNums.Equals("1-80"))
            {
                Console.WriteLine("Please pick a starting number");
                userLowNum = int.Parse(Console.ReadLine());
            }

            //////Ask user for a ending number
            //int userHighNum;
            //while (userHighNum.Equals("1-80"))
            //{
            //    Console.WriteLine("Please pick an ending number");
            //    userHighNum = int.Parse(Console.ReadLine());
            //}
            ////Ask user to input 6 numbers they think will match the lucky numbers generated within the range
            //for (int i = 0; i < userNums.Length; i++)
            //{
            //    Console.WriteLine("Please pick 6 numbers you think will match the Lucky Numbers generated inbetween your lowest and highest numbers");
            //    userNums[i] = int.Parse(Console.ReadLine());
            //}

            ////Make sure the users numbers are within the range
            //min = intParse(Console.ReadLine());
            //max = intParse(Console.ReadLine());
            //pick = intParse(Console.ReadLine());
            //if (pick < min || pick > max) ;
            //Console.WriteLine("Opps your pick is out of your range");
            //Console.WriteLine("Plesase pick numbers within the range you selected");
            //{
            //    Double[]
            //}


            //nested for loop example
            int size = 6;    //Equals the max number of columns and rows
            int i, j;
            for (i = 0; i <= size; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();

            ////int userLowNum;
            ////Ask the user for thier low num, and keep asking them if they dont enter a valid number
            ////do
            ////{
            ////    Console.WriteLine("Enter a number 1-10: ");
            ////    userLowNum = int.Parse(Console.ReadLine());

            ////} while (userLowNum < 1 || userLowNum > 10);

            ////Ask the user for thier high num, and keep asking if they enter a valid number
            ////int userHiNum;
            ////do
            ////{
            ////    Console.WriteLine("Enter a number 71-80: ");
            ////    userHiNum = int.Parse(Console.ReadLine());

            ////} while (userLowNum < 71 || userLowNum > 80);







            ////// create random number generator
            //////get six random numbers

            //Console.WriteLine("Here are your 6 Lucky Numbers");
            //int[] RandNum = new int[6];
            //////// int array for 6 random #s
            ////////r.Next(min,max)

            //Random r = new Random();
            //for (int i = 0; i < RandNum.Length; i++)
            //{
            //    RandNum[i] = r.Next(1, 81);
            //    Console.WriteLine("Lucky Number: " + r.Next(1, 81));
            //}

            //Logic Requirments
            Console.WriteLine("You guessed all 6 numbers correctly!");
            Console.WriteLine("You won $1,000,000 dollars");

            //User Interface part 2
            Console.WriteLine("Thanks for playing");





        }//Main
    }//Program
}

 