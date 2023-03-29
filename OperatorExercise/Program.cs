using System.ComponentModel;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose add, subtract, multiply, or divide");
            var chosenOperator = Console.ReadLine();

            Console.WriteLine("Enter first number");
            var firstNum =  Console.ReadLine();
            int firstNumConverted = Int32.Parse(firstNum);

            Console.WriteLine("Enter second number");
            var secondNum = Console.ReadLine();
            int secondNumConverted = Int32.Parse(secondNum);

            int result = 0;

            switch (chosenOperator) {
                case "add":
                    result = Add(firstNumConverted, secondNumConverted);
                    break;
                case "subtract":
                    result = Subtract(firstNumConverted, secondNumConverted);
                    break;
                case "multiply":
                    result = Multiply(firstNumConverted, secondNumConverted);
                    break;
                case "divide":
                    result = Divide(firstNumConverted, secondNumConverted);
                    break;
                default:
                    result = 0;
                    Console.WriteLine("Math operation not supported");
                    break;
            }

            Console.WriteLine("Next, we'll calculate the area of a circle. What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            CalculateCircleArea(radius);
        }

        static int Add (int num1, int num2) {
            int result = num1 + num2;
            Console.WriteLine($"{num1} plus {num2} is {result}");
            return num1 + num2; 
        }

        static int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine($"{num1} minus {num2} is {result}");
            return num1 - num2;
        }

        static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine($"{num1} multiplied by {num2} is {result}");
            return num1 * num2;
        }

        static int Divide(int num1, int num2) {
            int division = num1 / num2;
            int quotient = num1 % num2;
            Console.WriteLine($"{num1}/{num2} is {division} with a remainder of {quotient}");
            return division;
        }

        static double CalculateCircleArea(double radius) {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
            return area;
        }
    }
}
