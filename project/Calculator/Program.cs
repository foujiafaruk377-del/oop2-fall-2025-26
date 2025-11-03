using System;

class Program

{

    static void Main()

    {

        bool continueCalc = true;

        do

        {

            Console.WriteLine("=== Simple Calculator ===");

            Console.WriteLine("Select an operation:");

            Console.WriteLine("1. Addition (+)");

            Console.WriteLine("2. Subtraction (-)");

            Console.WriteLine("3. Multiplication (*)");

            Console.WriteLine("4. Division (/)");

            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice (1-5): ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 5)

            {

                Console.WriteLine("Exiting program. Goodbye!");

                break;

            }

            

            Console.Write("Enter first number: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            bool valid = true;

            switch (choice)

            {

                case 1:

                    result = num1 + num2;

                    Console.WriteLine($"Result: {num1} + {num2} = {result}");

                    break;

                case 2:

                    result = num1 - num2;

                    Console.WriteLine($"Result: {num1} - {num2} = {result}");

                    break;

                case 3:

                    result = num1 * num2;

                    Console.WriteLine($"Result: {num1} * {num2} = {result}");

                    break;

                case 4:

                    if (num2 != 0)

                    {

                        result = num1 / num2;

                        Console.WriteLine($"Result: {num1} / {num2} = {result}");

                    }

                    else

                    {

                        Console.WriteLine("Error: Division by zero is not allowed!");

                        valid = false;

                    }

                    break;

                default:

                    Console.WriteLine("Invalid choice! Please select 1-5.");

                    valid = false;

                    break;

            }

            if (valid)

            {

                Console.Write("\nDo you want to perform another calculation? (y/n): ");

                string again = Console.ReadLine().ToLower();

                if (again != "y")

                {

                    continueCalc = false;

                    Console.WriteLine("Thank you for using the calculator!");

                }

            }

            Console.WriteLine();

        } while (continueCalc);

    }

}
