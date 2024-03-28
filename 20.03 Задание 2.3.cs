using System.Collections;
//задание: Проверить правильность расстановок скобок в выражении, использующем скобки вида: “(”, “)”, “{”, “}”, “[”, “]”.
//Требование вложенности скобок разного вида не учитывать, т.е., например,
//последовательности скобок “({})[]” - правильно “([{()}]}” — не правильно.
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        bool isValid = CheckBracket(input);
        if (isValid)
        {
            Console.WriteLine("Правильная скобочная структура");
        }
        else
        {
            Console.WriteLine("Неправильная скобочная структура");
        }
    }

    static bool CheckBracket(string input)
    {
        Stack stack = new Stack();
        char[] openBrackets = { '(', '{', '[' };
        char[] closeBrackets = { ')', '}', ']' };

        foreach (char bracket in input)
        {
            if (Array.IndexOf(openBrackets, bracket) != -1)
            {
                stack.Push(bracket);
            }
            else if (Array.IndexOf(closeBrackets, bracket) != -1)
            {
                if (stack.Count == 0 || !IsTrueBracket((char)stack.Pop(), bracket))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        return stack.Count == 0;
    }

    static bool IsTrueBracket(char opening, char closing)
    {
        switch (opening)
        {
            case '(':
                return closing == ')';
            case '{':
                return closing == '}';
            case '[':
                return closing == ']';
            default:
                return false;
        }
    }
}
