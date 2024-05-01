using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();

        string userName = UserName();
        int userNumber = userNum();

        int squaredNumber = squaredNum(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void Welcome()
    {
        Console.WriteLine("prep 5 program");
    }

    static string UserName()
    {
        Console.Write("enter your name ");
        string name = Console.ReadLine();

        return name;
    }

    static int userNum()
    {
        Console.Write("What is your favorite number ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squaredNum(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}