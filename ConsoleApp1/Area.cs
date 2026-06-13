using System;

public class Area
{
    public static void Run()
    {
        // Addition
        int num1, num2, sum;

        Console.Write("Enter first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        sum = num1 + num2;

        Console.WriteLine("Addition = " + sum);

        // Area of Square
        int side;

        Console.Write("Enter side of square: ");
        side = Convert.ToInt32(Console.ReadLine());

        int squareArea = side * side;

        Console.WriteLine("Area of Square = " + squareArea);

        // Area of Rectangle
        int length, width;

        Console.Write("Enter length of rectangle: ");
        length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter width of rectangle: ");
        width = Convert.ToInt32(Console.ReadLine());

        int rectangleArea = length * width;

        Console.WriteLine("Area of Rectangle = " + rectangleArea);
    }
}