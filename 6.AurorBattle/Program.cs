using System.Xml;

namespace AurorBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> formation = Console.ReadLine().Split(", ").Select(int.Parse).ToList(); 
            string [] input = Console.ReadLine().Split(" ");
            while (input[0] != "end")
            {
                if(input[0] == "destroy")
                {
                    try
                    {
                        formation.RemoveAt(int.Parse(input[1]));
                        Console.WriteLine(string.Join(", ", formation));
                    }
                    catch
                    {
                        input = Console.ReadLine().Split(" ");
                        continue;
                    }

                }
                else if(input[0] == "swap")
                {
                    try
                    {
                        int a = int.Parse(input[1]);
                        int b = int.Parse(input[2]);
                        int c = formation[a];
                        formation[a] = formation[b];
                        formation[b] = c;
                        Console.WriteLine(string.Join(", ", formation));
                    }
                    catch
                    {
                        input = Console.ReadLine().Split(" ");
                        continue;
                    }

                }
                else if(input[0] =="add")
                {
                    formation.Add(int.Parse(input[1]));
                    Console.WriteLine(string.Join(", ", formation));
                }
                else if (input[0]=="insert")
                {
                    try
                    {
                        formation.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        Console.WriteLine(string.Join(", ", formation));
                    }
                    catch
                    {
                        input = Console.ReadLine().Split(" ");
                        continue;
                    }
                    
                }
                else if (input[0] == "center")
                {
                    if (formation.Count%2==0)
                    {
                        Console.WriteLine($"{formation[formation.Count / 2-1]}, {formation[formation.Count / 2]}");
                    }
                    else
                    {
                        
                        Console.WriteLine(formation[formation.Count / 2]);
                    }

                }
                input = Console.ReadLine().Split(" ");
            }

        }
    }
}
