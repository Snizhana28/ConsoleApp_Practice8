using ConsoleApp_Practice8.Domain;

namespace ConsoleApp_Practice8.Internal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alphabet = new Alphabet();
            foreach (var item in alphabet)
            {
                Console.Write($"{item}\t");
            }  
        }
    }
}