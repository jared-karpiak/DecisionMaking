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

            // Logical Operators
            // ! = NOT 
            // && = AND
            // || = OR

            // != operator
            // Very often we need to check if something isn't true, rather than if something is true.
            // Depending on the use case, the logic could be better to check for false instead of true.
            // To check if a value does not equal another value, we use the != operator

            if (firstNumber != secondNumber)
            {
                Console.WriteLine($"{firstNumber} doesn't equal {secondNumber}.");
            }

            Console.Write("Is programming awesome (type 'yes' obviously')?  ");
            string userResponse = Console.ReadLine();
            bool programmingIsAwesome;

            if (userResponse.Contains("yes"))
                programmingIsAwesome = true;
            else
                programmingIsAwesome = false;

            // if we have a boolean variable, we can just add a ! to the front of it to check for its opposite
            // The below logic is the same as "programmingIsAwesome == false"
            //  |
            //  |
            //  V
            if (!programmingIsAwesome)
                Console.WriteLine("LIES!!!!");


            // && AND
            // The AND logical operator will combine multiple logical expressions so we can check that multiple conditions are true
            // before performing the operation.
            // This logic will check that our first number is between 5 and 10

            if (firstNumber > 5 && firstNumber < 10)
                Console.WriteLine($"{firstNumber} is between 5 and 10.");



            // || OR
            // The OR logical operator will allow us to check one or more conditions are true. As long as one of the conditions is true, the
            // code inside of the if statement will execute.

            if (secondNumber < 10 || secondNumber > 20)
                Console.WriteLine($"{secondNumber} is less than 10 or greater than 10.");


            // Logical expressions and operators can be combined to form more complex statements, so we can really narrow down the conditions
            // required to execute a logical expression.

            // The below statement is checking that
            // Programming Is Awesome AND firstNumber is great than the second Number
            // OR
            // Programming is not awesome AND firstNumber is less than the second number

            if (programmingIsAwesome && firstNumber > secondNumber || firstNumber < secondNumber && !programmingIsAwesome)
            {
                Console.WriteLine("Ummmmm, I have no idea what to write for this statement.");
            }

            // Logical Precedence
            // 1. (logical expressions in brackets)
            // 2. && expressions
            // 3. || expressions

            // Just like arithmetic operators, there is an order of operations for logical operators.
            // The acronym you can use is BAO (Brackets, AND, OR)
            // First we perform operations that are present in brackets ()
            // then we perform any AND (&&) operations
            // Lastly we check any OR (||) operations

            // If the operators are the same, for example three && checks in a row, they are evaluated from left to right

            // Here are some examples to illustrate this.

            // Example 1:
            // We will use the following values
            //      programmingIsAwesome = true;
            //      firstNumber = 5
            //      secondNumber = 10

            // Because && comes before || in precendence, the && statement is going to be checked first
            // programmingIsAwesome && firstNumber > secondNumber
            //          true        &&           false      
            // so the first statement is "false"

            // Now we check the second && statement
            // !programmingIsAwesome && firstNumber < secondNumber
            //          false       &&           true
            // so the second statement is also "false"

            // Lastly we check the || statement
            //          false       ||          false
            // So we evaluate to false and the if statement will not execute

            if (programmingIsAwesome && firstNumber > secondNumber || !programmingIsAwesome && firstNumber < secondNumber)
            {
                Console.WriteLine("Example 1 of logical precedence.");
            }

            // Example 2:
            // We will use the following values
            //      programmingIsAwesome = true;
            //      firstNumber = 5
            //      secondNumber = 10

            // This logic is slightly different, notice brackets were added to the middle and the second check is firstNumber is less than secondNumber

            // Following the BAO order
            // First we will analyze whats in the brackets.
            // firstNumber < secondNumber || !programmingIsAwesome
            //          true              ||        false
            // so the first statement is "true"

            // Next we check programmingIsAwesome, which is also "true"

            // Lastly we check firstNumber < secondNumber, which again is "true"

            // At the end we are left with:
            // true && true && true
            // So the code inside this if statement will execute

            if (programmingIsAwesome && (firstNumber < secondNumber || !programmingIsAwesome) && firstNumber < secondNumber)
            {
                Console.WriteLine("Example 2 of logical precedence.");
            }


            // Ternary Operator

            // The ternary operator is a special way of writing a simple if / else statement in a single line of code.
            // It has many uses, but a common use is to assign a value to a variable based on a current condition
            // It takes the following format:
            // <logicalExpression> ? <valueIfTrue> : <valueIfFalse>
           
            // Here is an example where we set the value of the variable highestNumber to whichever number is higher:

            int highestNumber = firstNumber > secondNumber ? firstNumber : secondNumber;

            Console.WriteLine($"The highest number is: {highestNumber}.");

            // Using the ternary operator is the same as doing this:

            int lowestNumber;
            if (firstNumber < secondNumber)
            {
                lowestNumber = firstNumber;
            }
            else
            {
                lowestNumber = secondNumber;
            }

            Console.WriteLine($"The lowest number is: {lowestNumber}");

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

            // Providing a list of items for a user to select, a menu where you press "A" to do one thing, press "B" to do another thing, etc.
            // would be a good use of a switch statement.

        }
    }
}
