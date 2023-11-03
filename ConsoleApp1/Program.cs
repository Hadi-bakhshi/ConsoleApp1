using System; // it is going to import the namespace that has some classes and functions
using System.Globalization;
using System.Text;

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

        static void Main(string[] args) 
        { 
            StringBuilder sb = new StringBuilder("Random text");
            StringBuilder sb2 = new StringBuilder("More stuff that is very important",256);

            Console.WriteLine("Capacity : {0}", sb2.Capacity);
            Console.WriteLine("Length : {0}", sb.Length);
            sb2.AppendLine(" More important text");
            Console.WriteLine(sb2.ToString());

            CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "Hadi Bakhshi";
            sb2.AppendFormat(enUs, "Best Customer : {0}", bestCust);
            Console.WriteLine(sb2.ToString());
            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            sb2.Append("Random Text");
            Console.WriteLine(sb.Equals(sb2));
            sb2.Insert(11, " that is great");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11, 7);
            Console.WriteLine(sb2.ToString());

        }    
    }
}