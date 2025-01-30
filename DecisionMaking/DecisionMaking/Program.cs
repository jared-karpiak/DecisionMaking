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

            /**** Switch statements ****/
            // Switch statements will execute specific pieces of code based on the value of a
            // variable or expression.
            // This would be preferable to a large chain of if/else if/else statements.

            Console.Write($"Please enter a letter: ");
            string letterChosen = Console.ReadLine();

            //Convert the letterChosen to lower case and then parse it as a char
            char letter = char.Parse(letterChosen.ToLower());

            // to start a switch statement, use the "switch" keyword.
            // Then in parentheses put the variable or expression you wish to examine
            
            switch (letter)
            {
                // For each use case, use the keyword "case" followed by the value that you are expecting and a colon :
                // NOTE: Only constants can be used in a "case" statement.
                // The below example is the same as: if (letter == 'a')
                case 'a':
                    //This code will execute if letter == 'a'
                    Console.WriteLine($"You entered the letter 'a'.");
                    // At the end of each case statement, we must put the "break" keyword
                    break;
                case 'b':
                    Console.WriteLine($"You entered the letter 'b'.");
                    break;
                // if none of the cases match, then the "default" case will execute
                // This is equivalent to the "else" statement.
                default:
                    Console.WriteLine($"You entered the character '{letter}'.");
                    break;
            }

            // It would be more common to use switch statements when we are assessing a variable
            // that could have multiple values.
            // if statements would be more useful for more complicated logic to perform operations.


            //Get two numbers from the user for the logical operator demo
            Console.Write($"Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write($"Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            // Logical Operators
            // != = NOT Equal to
            // && = AND
            // || = OR

            // != operator
            // Very often we need to check if something isn't true, rather than if something is true.
            // Depending on the use case, the logic could be better to check for false instead of true.
            // To check if a value does not equal another value, we use the != operator






            // Ternary Operator
        }
    }
}
