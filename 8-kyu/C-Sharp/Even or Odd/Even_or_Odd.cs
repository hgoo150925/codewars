using System;

namespace Solution
{
    public class SolutionClass
    {
        // Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
        // https://www.codewars.com/kata/even-or-odd
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }
}