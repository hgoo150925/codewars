namespace Solution
{
    public static class Program
    {
        // Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
        // https://www.codewars.com/kata/string-repeat
        public static string RepeatStr(int n, string s)
        {
            string res = "";
            for (int i = 0; i < n; i++)
            {
                res += s;
            }
            return res;
        }
    }
}