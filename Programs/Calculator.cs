namespace Programs
{
    public static class Calculator
    {
        public static void Run()
        {
            bool continueCalculation = true;
            while (continueCalculation)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");

                string operation = Console.ReadLine()??"";

                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case "1":
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Result: {num1} + {num2} = {result}");
                        break;
                    case "2":
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Result: {num1} - {num2} = {result}");
                        break;
                    case "3":
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Result: {num1} * {num2} = {result}");
                        break;
                    case "4":
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation selected.");
                        break;
                }

                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                string continueResponse = Console.ReadLine()??"".ToLower();
                continueCalculation = continueResponse == "yes";
            }
        }
    }
}