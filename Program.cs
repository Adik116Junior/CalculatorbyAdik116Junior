using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! I am adik116 and this is my calculator");

        while (true) //Here I start the loop
        {
            Console.Write("Enter the first number you want to use in the calculator: "); 
            if (!double.TryParse(Console.ReadLine(), out double number1)) //Here If the conversion to double failed, execute the code inside the if block"
            {
                Console.WriteLine("Invalid number. Try again. ");
                continue;  // If the user enters an incorrect number, the program informs him about the error and returns him to start of loop.
            }

            Console.Write("Enter the operator (+,-,*,/): ");
            string operation = Console.ReadLine();//This line is used to read user-entered text from the console and assign it to the operation variable

            Console.Write("Enter the second number you want to use in the calculator: ");
            if (!double.TryParse(Console.ReadLine(), out double number2)) //Here is the same use as in 12th line
            {
                Console.WriteLine("Invalid number. Try again.");
                continue;  //Here is the same use as in the 15th line
            }

            double result = 0; 

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("You can't divide by 0. Try again.");
                        continue; //The program returns us to the start of loop
                    }
                    break;
                default: //if the value of the operation variable does not match any of the cases for mathematical operators (+, -, *, /), a default block will be executed, which informs the user that the operator is invalid, and the loop will resume
                    Console.WriteLine("Invalid operator, try again.");
                    continue;//Same use as in 49th line
            }

            Console.WriteLine($"result: {result}");

            Console.Write("Do you want to continue? Y/N:  ");
            string answer = Console.ReadLine();

            if (answer.ToLower() != "y")
            {
                Console.WriteLine("Thank you for using my calculator! ");
                break; // Here the program is ending the loop if we click another key than y
            }
        }
    }
}
