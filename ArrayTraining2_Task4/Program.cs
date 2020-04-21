using System;

namespace ArrayTraining2_Task4
{
    class Program
    {
        static bool IsPalindrom(string text)
        {
            var stringToCheck = text.Replace(" ", string.Empty);

            stringToCheck = stringToCheck.ToLower();

            int lastIndex = stringToCheck.Length - 1;
            for (int i = 0; i < stringToCheck.Length / 2; i++)
            {
                if (stringToCheck[i] != stringToCheck[lastIndex - i])
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter your text to check if it is palindrome: ");
            var text = Console.ReadLine();
            var responce = IsPalindrom(text) ? string.Empty : "not ";
            Console.WriteLine($"The text that you have entered (\"{text}\") is {responce} a palindrom.");
            Console.ReadLine();
        }
            
    }
}
