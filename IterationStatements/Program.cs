using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Xml.XPath;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        public static void PrintThousand()  //Write a method that will print to the console all numbers 1000 through - 1000

        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }
        public static void PrintThree()  //Write a method that will print to the console numbers 3 through 999 by 3 each time
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }

        public static bool AreIntegersEqual(int num1, int num2)  //Write a method to accept two integers as parameterss and check whether they are equal or not
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static string EvenOrOdd(int num) //Write a method to check whether a given number is even or odd
        {
            if(num % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
            
        }

        public static string PositiveOrNegative(int number) //Write a method to check whether a given number is positive or negative
        {
            if (number > 0)
            {
                return "This number is positive";
            }
            else if (number < 0)
            {
                return "This number is negative";
            }
            else
            {
                return "zero";
            }
        }       
        public static string AgeToVote(int age) //Write a method to read the age of a candidate and determine whether they can vote.
        {
            //console.writeline("enter your age:");
            //int age = int.parse(console.readline());

            if (age >= 18)
            {
                return "You can vote!";
            }
            else
            {
                return "Looks like you're still too young!";
            }

        }
        public static bool IsInRange(int num) //Write a method to check if an integer(from the user) is in the range -10 to 10 //Hint: Use Parse or the safer TryParse() for an extra challenge
                                                                                                                               //Parse()
                                                                                                                               //TryParse()
        {
            return num >= -10 && num<= 10;
        }

        
        

        //Heatin Up Section:
        

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();

            PrintThree();

            bool areEqual= AreIntegersEqual(5, 5);

            Console.WriteLine("Enter a number to find out if it's even or odd");
            var num = int.Parse(Console.ReadLine());
            var result=EvenOrOdd(num);
            Console.WriteLine(result);

            Console.WriteLine("Enter a number to detemine whether it's positive or negative");
            var userInput = int.Parse(Console.ReadLine());
            var outcome= PositiveOrNegative(userInput);
            Console.WriteLine(outcome);

            Console.WriteLine("Enter your age");
            var age = int.Parse(Console.ReadLine());
            var ageOutcome = AgeToVote(age);
            Console.WriteLine(ageOutcome);

            Console.WriteLine("Enter a number:");
            var userAge= int.Parse(Console.ReadLine());
            var decision= IsInRange(userAge);
            Console.WriteLine(decision);
          
        }
    }
}
