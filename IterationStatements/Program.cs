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
        //    - Hint: Use `int.Parse()` or the safer `int.TryParse()` for extra practice in handling user input.
        public static bool CanVote( int num1 )
        {
            bool canVote = ( num1 >= 18 ) ? true : false; 
            
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
            int num1 = -5;
            int num2 = 2;
            
            // PrintNumbers();
            //PrintEveryThirdNumber();
            
            /* if (AreNumbersEqual(num1, num2))
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Numbers are not equal");
            } */
           
            if (IsInRange( num1 ) )
            {
                Console.WriteLine("Number is in range");
            }
            else
            {
                Console.WriteLine("Number is not in range");
            }
            
            DisplayMultiplicationTable( 12 );
            
        }
    }
}
