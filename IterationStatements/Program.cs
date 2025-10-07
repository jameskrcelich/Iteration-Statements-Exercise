using System.Data.SqlTypes;

namespace IterationStatements
{
    public class Program
    {
        // private int i;
        
        // LukeWarm Section: Implement the following methods        
        // 1. Write a method that prints all numbers from 1000 down to -1000 to the console.
        //    - Method Signature: void PrintNumbers()
        public static void PrintNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"    {i}");
            }
        }
        
        // 2. Write a method that prints every third number from 3 to 999 to the console.
        //    - Method Signature: void PrintEveryThirdNumber()
        public static void PrintEveryThirdNumber()
        {
            for (int i = 3;  i <= 999; i+=3 )
            {
                Console.WriteLine($"    {i}");
            }
        }
        
        // 3. Write a method that accepts two integers as parameters and checks whether they are equal.
        //    - Method Signature: bool AreNumbersEqual(int num1, int num2)
        //    - Returns true if the numbers are equal, false otherwise.
        public static bool AreNumbersEqual( int num1, int num2 )
        {
            bool areNumsEqual = (num1 == num2) ? true : false; 
            
            return areNumsEqual;
        }
        
        // 4. Write a method that checks if a given number is even or odd.
        //    - Method Signature: bool IsEven(int number)
        //    - Returns true if the number is even, false if odd.
        public static bool IsEven( int num1 )
        {
            bool isNumEven = ( num1 % 2 == 0 ) ? true : false; 
            
            return isNumEven;
        }
        
        // 5. Write a method that checks if a given number is positive or negative.
        //    - Method Signature: bool IsPositive(int number)
        //    - Returns true if the number is positive, false if negative.
        public static bool IsPositive( int num1 )
        {
            bool isNumPositive = ( num1 > 0 ) ? true : false; 
            
            return isNumPositive;
        }

        // 6. Write a method that reads the age of a candidate and determines if they are eligible to vote.
        //    - Method Signature: bool CanVote(int age)
        //    - Returns true if the candidate can vote, false otherwise.
        public static bool CanVote( int age )
        {
            bool canVote = ( age >= 18 ) ? true : false; 
            
            return canVote;
        } 
        
        // Heatin' Up Section:
        // 1. Write a method that checks if an integer (provided by the user) is within the range of -10 to 10.
        //    - Method Signature: bool IsInRange(int number)
        //    - Returns true if the number is within the range, false otherwise.
        public static bool IsInRange( int num1 )
        {
            bool numInRange = ( num1 >= -10 && num1 <= 10 ) ? true : false; 
            
            return numInRange;
        }
        
        // 2. Write a method that displays the multiplication table (from 1 to 12) for a given integer.
        //    - Method Signature: void DisplayMultiplicationTable(int number)
        //    - Should print each line in the format: "1 * number = result"

        // In the Main method below, call each of your methods to test them.
        // Use various test cases to ensure they work as expected.      
        public static void DisplayMultiplicationTable( int num1 )
        {
            int i, j;

            for (i = 1; i <= num1; i++)
            {
                for (j = 1; j <= num1; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}"); 
                }
            }
        }
        
        static void Main(string[] args)
        {
            // print numbers -1000 to 1000 to the console
            PrintNumbers();
            
            // print every 3rd number from 3 - 999
            PrintEveryThirdNumber();
            
            // Prompt the user for the first number
            Console.Write("Enter the first number to compare equality: ");
            string input1 = Console.ReadLine();

            // Prompt the user for the second number
            Console.Write("Enter the second number to compare equality: ");
            string input2 = Console.ReadLine();

            // Convert the string inputs to integers
            // Using int.Parse() will throw an exception if the input is not a valid integer.
            // For more robust error handling, consider using int.TryParse().
            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            // check if the two user inputted numbers are equal
            if (AreNumbersEqual(num1, num2)) {
                    Console.WriteLine($"The numbers you entered {num1} and {num2} are equal");
            } else {
                    Console.WriteLine($"The numbers you entered {num1} and {num2} are not equal");
            }

            // check if first number entered by user is even or not
            if (IsEven(num1)) {
                Console.WriteLine($"{num1} is even");
            }else {
                Console.WriteLine($"{num1} is not even");
            }
            
            // check if first number entered by user is positive
            if (IsPositive(num1)) {
                Console.WriteLine($"{num1} is a positive number");
            }else {
                Console.WriteLine($"{num1} is not a positive number");
            }
            
            // check if first number from user is between -10 and 10
            if (IsInRange( num1 ) ) {
                    Console.WriteLine($"Number {num1} is between the range of -10 and 10");
            } else {
                    Console.WriteLine($"Number {num1} is not between the range of -10 and 10");
            }
            
            // Prompt the user for the second number
            Console.Write("Enter age of person to determine voter eligibility: ");
            string age = Console.ReadLine();

            // Convert the string inputs to integers
            // Using int.Parse() will throw an exception if the input is not a valid integer.
            // For more robust error handling, consider using int.TryParse().
            num1 = int.Parse(age);

            if (CanVote( num1 ) ) {
                    Console.WriteLine($"Person of {num1} years is eligible to vote");
            } else {
                    Console.WriteLine($"Person of {num1} years is not eligible to vote");
            }
            
            // display multiplication table for 12 numbers
            Console.WriteLine("\nDisplay multiplication table for 12 numbers");
            DisplayMultiplicationTable( 12 );
        }
    }
}
