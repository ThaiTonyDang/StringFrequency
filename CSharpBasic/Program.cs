using System;
using System.Collections.Generic;
using Contract;
using AlexDataAnalyser;
namespace CSharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDataAnalyser> Analysers = new List<IDataAnalyser>();
            Analysers.Add(new AlexAnalyser(@"C:\ABC"));
            foreach (IDataAnalyser analyser in Analysers)
            {
                Console.WriteLine($"Author is { analyser.Author} ");
                foreach (string str in analyser.GetTopTenStrings(analyser.Path))
                {
                    Console.WriteLine(str);
                }
            }
            Console.WriteLine("Press any ken to exit.");
            Console.ReadKey();
        }
    }
}
