using System.Configuration;

namespace TestConfig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"I am {ConfigurationManager.AppSettings["Name"]} working on {ConfigurationManager.AppSettings["CompanyName"]}");
            Console.ReadLine();
        }
    }
}
