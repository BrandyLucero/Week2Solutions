using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallengeBL
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a loop from 1=>20
            for (int i = 1; i <= 20; i = i + 1)
            {
                FizzBuzz(i);

            }

                //call letter counter 
                LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
                LetterCounter('n', "Never gonna give you up never gonna let you down.");
                LetterCounter('s', "Sally sells seashells down by the seashore. She's from Sussex.");

                 //keep the console open
            Console.ReadKey();
        }

        //the function takes a numberand depending on if it is divisible by 5 or 3 the console will be "fizz", "buzz" or "fizzbuzz
        static void FizzBuzz(int number)
          
        {   
        //check to see if number is divisble by both 5and 3
            if (number % 5 == 0 && number % 3 == 0)
            {
                //if # is divisable by 5 & 3 write 
                Console.WriteLine("FizzBuzz");
            }
                //check ti see if number is divisble by 5
            else if (number % 5 == 0)
            {
                //if # is divisable by 5 write out fizz
                Console.WriteLine("Fizz");
            }
                //check to see iuf number is divisble by 3
            else if (number % 3 == 0)
            {
                //if # is divisable by 3 write buzz
                Console.WriteLine("Buzz");
            }
            else
            {
                //if not divizible by either than write the number
                Console.WriteLine(number);
            }
           
        }
        //create letter function
        static void LetterCounter(char letter, string inString)
            
        {
            //lower and upper case variables
             int lowerLetterCount = 0, upperLetterCount = 0;
         
            //change the cases to upper or lower

            string lowerCase = letter.ToString().ToLower();
            string upperCase = letter.ToString().ToUpper();

            //
            foreach (char c in inString)
            {
                if (c.ToString() == lowerCase)
                {
                  lowerLetterCount ++;
                   
                }
                if (c.ToString() == upperCase)
	            {
                  upperLetterCount++;
                }

                }

            int totalCount = upperLetterCount + lowerLetterCount;

          Console.WriteLine("Input: " + inString + "\n Number of lowercase " + letter.ToString().ToLower() + " 's" +  "found: " + lowerLetterCount +
              "\n " + "Number of UpperCase " + letter.ToString().ToUpper() + "'s" + " found: " + upperLetterCount +"\n Total Number " + letter + "'s" + "found: " + totalCount);


        }

       
        }
 }



