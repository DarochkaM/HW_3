using System;
public class HW_3_task1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string a = Console.ReadLine();
        char[] stringArray = a.ToCharArray();
        Array.Reverse(stringArray);
        string reversedStr = new string(stringArray);
        //Console.Write($"Actual String is : {a} \n");
        //Console.Write($"Reversed String is : {reversedStr} ");
        if (String.Equals(a, reversedStr))
        {
            Console.Write($"Yes, {a} is a palindrome\n");
        }
        else 
        {
            Console.Write($"No, {a} is not a palindrome\n");
        }
    }
}