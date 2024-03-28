using System.Collections;
//задание: Написать программу, которая определяет, является ли введенная скобочная структура правильной.
//Примеры правильных скобочных выражений: (), (())(), ()(), ((())), неправильных — )(, ())((), (, )))), ((())
class Program
{
    static void Main(string[] args)
    {
        string inputExpression = Console.ReadLine();
        bool isValid = CheckBrackets(inputExpression);

        if (isValid)
            Console.WriteLine("Правильная скобочная структура");
        else
            Console.WriteLine("Неправильная скобочная структура");
    }

    static bool CheckBrackets(string expression)
    {
        Stack stack = new Stack();

        foreach (char x in expression)
        {
            if (x == '(')
            {
                stack.Push(x);
            }
            else if (x == ')')
            {
                if (stack.Count == 0 || (char)stack.Pop() != '(')
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
