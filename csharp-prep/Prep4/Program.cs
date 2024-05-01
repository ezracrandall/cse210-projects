using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string userInput;
        int userNumber;

        while (true)
        {
            Console.Write("Enter a number (0 to quit): ");
            userInput = Console.ReadLine();
            
            if (userInput == "0")
                break;
            
            userNumber = int.Parse(userInput);
            numbers.Add(userNumber);
        }

 
        int sum = 0;
        int count =0;
        int maxNum =sum;
        foreach (int number in numbers)
        {
            sum += number;
            count++;
            if (number > maxNum)
            maxNum = number;
        }
        float average = (float)sum / count;




        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The number of numbers is: {count}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($" The max number is: {maxNum}");




    }
}
