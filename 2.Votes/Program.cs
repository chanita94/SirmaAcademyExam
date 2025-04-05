namespace Votes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yes = 0;
            int no = 0;
            int abstain = 0;
            string [] input = Console.ReadLine().Split(", ").ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=="Yes")
                {
                    yes ++;
                }
                else if (input[i]=="No")
                {
                    no ++;
                }
                else if(input[i]=="Abstain")
                {
                    abstain ++;
                }
            }
            if (yes>no&&yes>abstain)
            {
                Console.WriteLine("Yes");
            }
            else if(no>abstain&&no>yes)
            {
                Console.WriteLine("No");
            }
            else if(abstain>yes&&abstain>no)
            {
                Console.WriteLine("Abstain");
            }
            else
            {
                Console.WriteLine("Tie");
            }
        }
    }
}
