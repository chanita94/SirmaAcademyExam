using System.Collections.Generic;

namespace _4.Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrayNames = Console.ReadLine().Split(", ");
            string Name = Console.ReadLine();
            int first = 0;
            bool foundFirst = false;
            int last = 0;
            bool foundLast = false;
            for (int i = 0; i < arrayNames.Length; i++)
            {
                if (arrayNames[i]==Name)
                {
                    if (foundFirst!=false)
                    {
                        last = i;
                        foundLast= true;
                    }
                    else
                    {
                        first = i;
                        foundFirst = true;
                    }

                }
            }
            if (foundLast == true && foundFirst == true)
            {
                Console.WriteLine($"First Occurrence: {first}");
                Console.WriteLine($"Last Occurrence: {last}");
            }
            else if (foundFirst == true&&foundLast==false)
            {
                Console.WriteLine($"First Occurrence: {first}");
                Console.WriteLine($"Last Occurrence: {first}");
            }
            else
            {
                Console.WriteLine("Record not found");
            }

        }
    }
}
