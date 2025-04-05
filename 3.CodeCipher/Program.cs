namespace CodeCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            char[] array = input.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                char a = array[i];
                array[i] = (char)( a - n);
            }
            string result = string.Join("", array);
            Console.WriteLine(result);
        }
    }
}
