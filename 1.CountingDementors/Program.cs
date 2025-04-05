namespace CountingDementors
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int total = 0;
            for (;h>0; h--)
            {
                total += n;
                n += m;
            }
            Console.WriteLine(total);
        }
    }
}
