using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string letter = "";

        // Determine the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign using the remainder (%) operator
        string sign = "";
        int lastDigit = percentage % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Handle exceptional cases (No A+, No F+, No F-)
        if (letter == "A" && sign == "+")
        {
            sign = ""; // A+ becomes just A
        }
        else if (letter == "F")
        {
            sign = ""; // F+ or F- becomes just F
        }

        // Display both the grade letter and the sign in one print statement
        Console.WriteLine($"Your grade is {letter}{sign}.");

        // Determine if the student passed or failed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You can do better next time.");
        }
    }
}
