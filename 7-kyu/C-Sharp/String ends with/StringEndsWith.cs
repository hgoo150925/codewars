public class Kata
{
    // String ends with?
    // Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).
    // Examples:
    // solution('abc', 'bc') // returns true 
    // solution('abc', 'd') // returns false
    // Link: https://www.codewars.com/kata/string-ends-with
    public static bool Solution(string str, string ending) => str.EndsWith(ending) ? true : false;
}