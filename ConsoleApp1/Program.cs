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

        static void Main() 
        {
            int i = 1;
            while (i <= 10)
            {
                if(i % 2 == 0)
                {
                    i++;
                    continue;
                }
                if (i == 9) break;
                Console.WriteLine(i);
                i++;
            }


            // Do while
            Random rnd = new Random();
            int secretNumber = rnd.Next(1,11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num: ", secretNumber);

            do
            {
                Console.WriteLine("Enter a number between 1 and 10");
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNumber != numberGuessed);
            
            Console.WriteLine("You guessed it, it was {0}",numberGuessed);
        }
    }
}