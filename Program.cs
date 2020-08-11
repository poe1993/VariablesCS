using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 1;
            var fullName = ("Eric Poe");
            var today = ("August 11");
            Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today);
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Greetings {userName}!");
            Console.WriteLine("Can you give me two numbers? Please press Enter after the first Number");
            var firstNumberAsString = Console.ReadLine();
            var secondNumberAsString = Console.ReadLine();
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);
            Console.WriteLine(firstOperand + " " + secondOperand);
            var sum = (firstOperand + secondOperand);
            Console.WriteLine($"Your sum is {sum}");
            var difference = (firstOperand - secondOperand);
            Console.WriteLine($"Your difference is {difference}");
            var product = (firstOperand * secondOperand);
            Console.WriteLine($"Your product is {product}");
            var quotient = (firstOperand / secondOperand);
            Console.WriteLine($"Your quotient is {quotient}");
            var remainder = (firstOperand % secondOperand);
            Console.WriteLine($"Your remainder is {remainder}");





        }
    }
}
