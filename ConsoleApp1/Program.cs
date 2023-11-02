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

        static void Main(string[] args)
        {
            //Console.WriteLine("Currency : {0:c}", 23.444);
            //Console.WriteLine("Pad with 0s : {0:d4}", 23);
            //Console.WriteLine("3 decimals : {0:f3}", 23.34343434);
            //Console.WriteLine("Commas : {0:n4}", 230439);

            //string randString = "This is a string";
            //Console.WriteLine(randString.Length);
            //Console.WriteLine(randString.Contains("is"));
            //Console.WriteLine(randString.IndexOf("is"));
            //Console.WriteLine(randString.Remove(10,6));
            //Console.WriteLine(randString.Insert(10,"short "));
            //Console.WriteLine(randString.Replace("string", "sentence"));
            //Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine("Pad left: {0}",
            //    randString.PadLeft(20, '.')
            //    ); 
            //Console.WriteLine("Pad right: {0}",
            //    randString.PadRight(20, '.')
            //    );
            //Console.WriteLine("Trim : {0}", randString.Trim());
            //Console.WriteLine(@"Exactly what I type\n");

            int[] favNums = new int[3];
            favNums[0] = 23;
            Console.WriteLine("Fav number 0 : {0}", favNums[0]);

            string[] customers = { "Paul", "Bob", "James" };
            var employees = new[] { "Mike", "Hike", "Like" };
            object[] randomArray = { "Hadi", 27, 1.23 };

            Console.WriteLine(customers);
            Console.WriteLine(employees);
            Console.WriteLine(randomArray);

            Console.WriteLine("randomArray 0 : {0}",
                randomArray[0].GetType());
            for (int j = 0; j < randomArray.Length; j++)
            {
                Console.WriteLine("Array : {0} : Value: {1}", j, randomArray[j]);
            }

            // Multi dimensional 
            string[,] custNmaes = new string[2, 2]
            {
                {"Hadi", "Bakhshi" },
                {"Mahsa", "Mohammadi" },
            };
            Console.WriteLine("MD Value : {0} {1}",
                custNmaes.GetValue(1,0), custNmaes.GetValue(1, 1));
            for (int f = 0; f < custNmaes.GetLength(0); f++)
            {
                for(int l = 0; l < custNmaes.GetLength(0); l++)
                {
                    Console.Write("{0}\n", custNmaes[f, l]);
                }
            }
            int[] randNums = { 1, 45, 6, 43, 2 };
            PrintArray(randNums, "FOREACH");

            Array.Sort(randNums);
            Array.Reverse(randNums);
            Console.WriteLine("1 at index : {0}",
                Array.IndexOf(randNums, 1));
            randNums.SetValue(0,1);
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;
            Array.Copy(srcArray, startInd, destArray, 0, length);
            PrintArray(destArray, "COPY");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach(int m in anotherArray)
            {
                Console.WriteLine("copy : {0}", m);
            }

            int[] numArray = { 1, 11, 22 };

        }    
    }
}