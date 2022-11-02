using System;

public class Kata
{
    // Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
    // Example: Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
    // The returned format must be correct in order to complete this challenge.
    // Link: https://www.codewars.com/kata/create-phone-number
    public static string CreatePhoneNumber(int[] numbers)
    {
        string rs = String.Join("", numbers);
        return $"({rs.Substring(0, 3)}) {rs.Substring(3, 3)}-{rs.Substring(6)}";
    }
}