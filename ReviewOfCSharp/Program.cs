using System;

namespace ReviewOfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ChallengeOne();
            ChallengeTwo();
            ChallengeThree();
            ChallengeFive();
            ChallengeSix();
            ChallengeSeven();



        }
        public static int ChallengeOne(string userInput)
        {
            int product = 1;
            string[] numStringArray = userInput.Split(',');
            int[] numArray = new int[numStringArray.Length];
            //This will catch the short array
            if (numStringArray.Length < 3) { return 0; }
            //This will perform the conversion
            try
            {
                for (int i = 0; i < numStringArray.Length; i++)
                {
                    if (!int.TryParse(numStringArray[i], out numArray[i]))
                    {
                        numArray[i] = 1;
                    }
                    if (i < 3) { product *= numArray[i]; }
                }
            }
            catch
            {
                //Will handle a non-integer.
                return 1;
            }
            return product;
        }

        static void ChallengeTwo()
        {
            int userLoopNumber = UserPrompt();
            GetUserNumbers(userLoopNumber);
        }
        
        static void  GetUserNumbers(int userLoopNumber)
        {
            int[] userNumbersArray = new int[userLoopNumber];
            string currentUserNumber;
            decimal currentUserNumberConverted;
            for (int i = 1; i <= userLoopNumber; i++)
            {
                Console.Write($"{i} of {userLoopNumber} - Enter a number: ");
                currentUserNumber = Console.ReadLine();
                currentUserNumberConverted = Convert.ToDecimal(currentUserNumber);
                if(currentUserNumberConverted < 0)
                {
                    Console.WriteLine("Only positive numbers allowed");
                    i--;
                }
            }
            
        }
        static int UserPrompt()
        {
            Console.Write("Please enter a number between 2-10: ");
            string userInput = Console.ReadLine();
            int userInputConverted = Convert.ToInt32(userInput);

            if (userInputConverted < 2 || userInputConverted > 10)
            {
                return UserPrompt();
                
            }
            else
            {
                return userInputConverted;
            }


            static void ChallengeThree()
            {
                Console.WriteLine("    *    \n" +
                    "   ***   \n" +
                    "  *****  \n" +
                    "********\n" +
                    "  *****  \n" +
                    "   ***   \n" +
                    "    *    \n");
            }

            static void Main(string[] args)
            {

                int[] arr = new int[] { -1, -99, -134, -678, -2, -56 };
                int result = ChallengeFive(arr);
                Console.WriteLine(result);



            }
            public static int ChallengeFive(int[] arr)
            {
                int maxValueHolder = Int32.MinValue;

                foreach (int num in arr)
                {
                    if (num > maxValueHolder)
                    {
                        maxValueHolder = num;
                    }

                }
                return maxValueHolder;
            }



            static void ChallengeSix()
            {
                string path = "../../../RandomWords.txt";
                Console.WriteLine(" Please give me some words to save.");
                string userInput = Console.ReadLine();
                File.WriteAllText(path, userInput);

            }
            public static void ChallengeSeven()
            {
                string path = "../../../RandomWords.txt";
                string readStuff = File.ReadAllText(path);
                Console.WriteLine(readStuff);
            }

        }

    }
}
