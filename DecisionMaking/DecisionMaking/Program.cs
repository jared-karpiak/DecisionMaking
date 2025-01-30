namespace DecisionMaking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome user to the comparison application
            Console.WriteLine("Welcome to the comparison application!!!!!!!!!");

            // Get first number from user
            Console.Write("Enter the first number: ");
            string stringFirstNumber = Console.ReadLine();
            int firstNumber = int.Parse(stringFirstNumber);

            // Get Second number
            Console.Write("Enter the second number: ");
            string sSecondNumber = Console.ReadLine();
            int secondNumber = int.Parse(sSecondNumber);

            // Compare numbers to see which is greater.
            // > - Greater than. Checks if the number on the left is greater than the number on the right
            // < - less than. Checks if the number on the left is smaller than the number on the right
            // == - equal to. Checks if the value on the left is equal to the number on the right
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"The first number {firstNumber} is bigger  " +
                    $"than the second number {secondNumber}.");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine($"The first number {firstNumber} is equal to  " +
                    $" the second number {secondNumber}.");
            }
            else
            {
                Console.WriteLine($"The first number {firstNumber} is smaller  " +
                    $"than the second number {secondNumber}.");
            }

            // if / else if / else statements are executed from top to bottom.
            // The first "true" statement in an if/else if/else chain is the one that will be executed,
            // even if some of the following statements are also true.


            //add the two numbers
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"The sum of the two variables is {sum}");

            /**** Nested If Statments ****/

            // if statements can be nested inside of each other to provide additional logic.
            
            // check if the sum is greater than 10
            if (sum > 10)
            {
                // if it is greater than 10, also check if the number is even
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"The number {sum} is even.");
                }
                else
                {
                    Console.WriteLine($"The number {sum} is odd.");
                }
            }

            // it would be best practice to limit the number of nested if statements
            // as much as possible


        }
    }
}
