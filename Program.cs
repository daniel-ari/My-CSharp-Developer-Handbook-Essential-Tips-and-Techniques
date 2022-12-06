
public class EarlyReturns
{
    /*
    Avoid unnecessary computations by using early returns and exit conditions.
    When writing C# code, it's important to consider the performance of your code and avoid making unnecessary computations that could slow down your program
    One way to do this is to use early returns and exit conditions, which allow you to exit a method or loop early if certain conditions are met.
    Using early returns can make your code more efficient and easier to read, as it allows you to avoid writing complex conditional statements and nested loops.
    Just be sure to use them carefully and only when it makes sense to do so, as they can also make your code less predictable and more difficult to debug if used incorrectly.
    */
    public static string ReverseString(string str)
    {
        // The ReverseString method uses an early return to avoid reversing an empty or null string, which would be unnecessary and potentially error-prone
        if (string.IsNullOrEmpty(str))
        {
            return string.Empty;
        }
        // Use the string.Reverse() method to efficiently reverse the string.
        return new string(str.Reverse().ToArray());
    }

    public static int Factorial(int num)
    // If the number is less than or equal to 0, the factorial is 1, so you can use an early return to exit the method immediately and avoid making unnecessary calculations.
    {
        if (num <= 0)
        {
            return 1;
        }
        // Use the Enumerable.Range and Enumerable.Aggregate methods to calculate the factorial.
        return Enumerable.Range(1, num).Aggregate((x, y) => x * y);
    }
}

// This is the main C# file where the functions are called
public class Program
{
    public static void Main()
    {
        Console.WriteLine(EarlyReturns.ReverseString("This text is reversed now."));
        Console.WriteLine(EarlyReturns.Factorial(8).ToString());
    }
}
