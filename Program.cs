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
            if(userName == "CIA")
            {
                Console.WriteLine("I'M CRASHING THIS PROGRAM WITH NO SURVIVORS");
                return;
            }
            else
            {
                Console.WriteLine($"Greetings {userName}!");   
            }
            if(userName == "Bane")
            {
                Console.WriteLine("You're a big guy.");
            }
            Console.WriteLine("What's your favorite number?");
            var firstNumberAsString = Console.ReadLine();
            Console.WriteLine("What's your second favorite number?");
            var secondNumberAsString = Console.ReadLine();
            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);
            Console.WriteLine(firstOperand + " " + secondOperand);
            var sum = (firstOperand + secondOperand);
            Console.WriteLine($"Your sum is {firstOperand} + {secondOperand} = {sum} ");
            var difference = (firstOperand - secondOperand);
            Console.WriteLine($"Your difference is {firstOperand} - {secondOperand} = {difference} ");
            var product = (firstOperand * secondOperand);
            Console.WriteLine($"Your product is {firstOperand} * {secondOperand} = {product}");
            var quotient = (firstOperand / secondOperand);
            Console.WriteLine($"Your quotient is {firstOperand} / {secondOperand} = {quotient}");
            var remainder = (firstOperand % secondOperand);
            Console.WriteLine($"Your remainder is {firstOperand} % {secondOperand} = {remainder}");





        }
    }
}
