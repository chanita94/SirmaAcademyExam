namespace Duels
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string input = Console.ReadLine();

                if (IsEpic(input)==true)
                {
                    Console.WriteLine("Epic");
                }
                else
                {
                    Console.WriteLine("Not Epic");
                }
        }
        static bool IsEpic(string sequence)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in sequence)
            {
                if (c == '/' || c == '<')
                {
                    stack.Push(c);
                }
                else if (c == '\\')
                {
                    if (stack.Count == 0 || stack.Pop() != '/')
                    {
                        return false;
                    }
                }
                else if (c == '>')
                {
                    if (stack.Count == 0 || stack.Pop() != '<') return false;
                }
                else if (c == '!')
                {
                    if (stack.Count > 0 && stack.Peek() == '!')
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push('!');
                    }
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;//if it is empty will be true 
        }

    }
}

