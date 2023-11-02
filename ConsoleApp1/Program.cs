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
            // Relational Operators : > < >= <= == != 
            // Logical Operators : && || !
            Console.WriteLine("Plase enter your name");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                if ((age >= 5) && (age <= 7))
                {
                    Console.WriteLine("Go to elementary school");
                }
                if ((age > 7) && (age < 13))
                {
                    Console.WriteLine("Go to middle school");
                }
                if ((age > 13) && (age <= 19))
                {
                    Console.WriteLine("Go to high school");
                }
                else
                {
                    Console.WriteLine("Go to college");
                }
            }

            bool canDrive = age >= 16 ? true : false;

            switch(age)
            {
                case 1:
                case 2:
                    Console.WriteLine("Go to hell");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Go to heaven");
                    break;
                default:
                    Console.WriteLine("What the hell");
                    // goto OtherSchool; This is not a good practice
                    break;
            }
        }
    }
}