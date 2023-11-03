using System; // it is going to import the namespace that has some classes and functions

namespace ConsoleApp1
{
    public class Program
    {
        // ----------------- FUNCTIONS -----------------

        static void PrintArray(int[] intArray, string msg)
        {
            foreach(int i in intArray)
            {
                Console.WriteLine("{0}: {1}", msg, i);
            }
        }

        // ----------------- END OF FUNCTIONS -----------------

        static void Main(string[] args) {}    
    }
}