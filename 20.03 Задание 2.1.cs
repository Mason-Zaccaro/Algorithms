using System.Collections;
//задание: Используя стек, напечатать символы некоторой величины строкового типа в обратном порядке.
class Program
{
    static void Main(string[] args)
    {
        string inputString = Console.ReadLine();
        string reversString = ReverseString(inputString);
        Console.WriteLine($"Вводная строка: {inputString}");
        Console.WriteLine($"Перевернутая строка: {reversString}");
    }

    static string ReverseString(string input)
    {
        Stack stack = new Stack();
        foreach (char x in input)
        {
            stack.Push(x);
        }

        char[] reversedChars = new char[input.Length];
        int index = 0;
        while (stack.Count > 0)
        {
            reversedChars[index++] = (char)stack.Pop();
        }

        return new string(reversedChars);
    }
}