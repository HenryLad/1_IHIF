using System;

Console.Write("Enter first operand: ");
double firstNumber = double.Parse(Console.ReadLine()!);
Console.Write("Enter second operand: ");
double secondNumber = double.Parse(Console.ReadLine()!);
Console.Write("Enter operator (+ | - | * | /): ");
string Operator = Console.ReadLine()!;

double result = 0;

switch (Operator)
{
    case "+":
        result = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber:F2} + {secondNumber:F2} = {result:F2}");
        break;
    case "-":
        result = firstNumber - secondNumber;
        Console.WriteLine($"{firstNumber:F2} - {secondNumber:F2} = {result:F2}");
        break;
    case "*":
        result = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber:F2} * {secondNumber:F2} = {result:F2}");
        break;
    case "/":
        if (secondNumber != 0)
        {
            result = firstNumber / secondNumber;
            Console.WriteLine($"{firstNumber:F2} / {secondNumber:F2} = {result:F2}");
        }
        else
        {
            Console.WriteLine("Division by zero is not allowed.");
        }
        break;
    default:
        Console.WriteLine($"{Operator} is an unknown operator.");
        break;
}
