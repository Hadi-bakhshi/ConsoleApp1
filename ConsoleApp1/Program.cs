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

        static double DoDivision(double x, double y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }

        // ----------------- END OF FUNCTIONS -----------------

        static void Main(string[] args) {
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}", DoDivision(num1, num2));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can not divide by zero", ex.Message);
                Console.WriteLine(ex.GetType().Name);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }
            finally
            {
                Console.WriteLine("cleaning up");
            }
        
        }    
    }
}