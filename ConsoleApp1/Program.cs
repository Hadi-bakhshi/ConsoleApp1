using ConsoleApp.Person;
using Converter;
using Extender;
using System; // it is going to import the namespace that has some classes and functions
using System.Globalization;
using System.Reflection;
using System.Text;

namespace ConsoleApp1
{
    public class Program
    {
        // ----------------- FUNCTIONS -----------------
        static void PrintArray(int[] intArray, string msg)
        {
            foreach (int i in intArray)
            {
                Console.WriteLine("{0}: {1}", msg, i);
            }
        }
        static void ArraysSection()
        {

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
                custNmaes.GetValue(1, 0), custNmaes.GetValue(1, 1));
            for (int f = 0; f < custNmaes.GetLength(0); f++)
            {
                for (int l = 0; l < custNmaes.GetLength(0); l++)
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
            randNums.SetValue(0, 1);
            int[] srcArray = { 1, 2, 3 };
            int[] destArray = new int[2];
            int startInd = 0;
            int length = 2;
            Array.Copy(srcArray, startInd, destArray, 0, length);
            PrintArray(destArray, "COPY");
            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 5);
            foreach (int m in anotherArray)
            {
                Console.WriteLine("copy : {0}", m);
            }

            int[] numArray = { 1, 11, 22 };
        }
        static void StringSection()
        {
            Console.WriteLine("Currency : {0:c}", 23.444);
            Console.WriteLine("Pad with 0s : {0:d4}", 23);
            Console.WriteLine("3 decimals : {0:f3}", 23.34343434);
            Console.WriteLine("Commas : {0:n4}", 230439);

            string randString = "This is a string";
            Console.WriteLine(randString.Length);
            Console.WriteLine(randString.Contains("is"));
            Console.WriteLine(randString.IndexOf("is"));
            Console.WriteLine(randString.Remove(10, 6));
            Console.WriteLine(randString.Insert(10, "short "));
            Console.WriteLine(randString.Replace("string", "sentence"));
            Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad left: {0}",
                randString.PadLeft(20, '.')
                );
            Console.WriteLine("Pad right: {0}",
                randString.PadRight(20, '.')
                );
            Console.WriteLine("Trim : {0}", randString.Trim());
            Console.WriteLine(@"Exactly what I type\n");
        }
        static double DoDivision(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x / y;
        }
        static void ExceptionHandlingSection()
        {
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
        static void LoopsSection()
        {
            int i = 1;
            while (i <= 10)
            {
                if (i % 2 == 0)
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
            int secretNumber = rnd.Next(1, 11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num: ", secretNumber);

            do
            {
                Console.WriteLine("Enter a number between 1 and 10");
                numberGuessed = Convert.ToInt32(Console.ReadLine());

            } while (secretNumber != numberGuessed);

            Console.WriteLine("You guessed it, it was {0}", numberGuessed);
        }
        static void OperatorsSection()
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

            switch (age)
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
        static void StringBuilderSection()
        {
            StringBuilder sb = new StringBuilder("Random text");
            StringBuilder sb2 = new StringBuilder("More stuff that is very important", 256);

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
        static void ExtensionMethod()
        {
            string example = "Let's talk dirty";
            string reversed = example.Reverse();
            Console.WriteLine("The first string is :{0} and reversed: {1}", example, reversed);
        }

        static void PracticeClassAndInterview()
        {
            var person = new Person()
            {
                Name = "hadi"
            };
            Console.WriteLine(person.GetFullName());
        }
        static void PracticeConversion()
        {
            var conversion = new Conversion(5, 6);

            conversion.Increment();
            conversion.Increment();
            conversion.Increment();

            conversion.Decrement();

            int val = conversion.GetX();

            Console.WriteLine("x is :{0}", val);
        }

        static void OverflowAndUnderflowExample()
        {
            try
            {
                int a = int.MinValue;
                a--;
                Console.WriteLine(a == int.MaxValue);

                int maxInt = int.MaxValue; // maxInt is 2147483647
                int result = maxInt + 1;   // This will cause an overflow, and result will be -2147483648

                // underflow
                float minFloat = float.Epsilon;
                float result2 = minFloat / 10;
                Console.WriteLine(result2);

                short x = 1, y = 1;
                /* short z = x + y;  compile time error => result is also an int, which cannot be implicitly cast
                                                           back to a short (because it could cause loss of data)
                */
                short z = (short)(x + y);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"exception is {ex}");
            }
        }
        static void SpecialValues()
        {
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NaN);
            Console.WriteLine(double.NegativeInfinity);
        }
        static void SayHello()
        {
            string name = "";
            Console.WriteLine("What is your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
        static double GetSum(double x = 1, double y = 1)
        {
            double sum = x + y;
            Console.WriteLine("Sum is {0}", sum);
            return sum;
        }
        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        public static void Swap(ref int num3, ref int num4)
        {
            int temp = num3;
            num3 = num4;
            num4 = temp;
        }
        static double GetSumMore(params double[] nums)
        {
            double sum = 0;

            foreach (int i in nums)
            {
                sum += i;
            }
            Console.WriteLine("Sum: {0}", sum);
            return sum;
        }

        static void FunctionsSection()
        {
            // <Access Specifier> <Return Type> <Method Name>(Parameters)
            // { <Body> }
            SayHello();
            GetSum(344, 543);
            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);
            // ---------------------------------------------
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before swap num1 : {0} and num 2 : {1}",
                num3, num4
                );
            Swap(ref num3, ref num4);
            Console.WriteLine("After swap num1 : {0} and num 2 : {1}",
                num3, num4
                );
            GetSumMore(1, 2, 3, 4, 5, 6, 7, 776767);
        }
        static void CharSection()
        {
            char copyrightSymbol = '\u00A9';
            char omegaSymbol = '\u03A9';
            char newLine = '\u000A';

            Console.WriteLine("char vals: {0} | {1} | {2}", copyrightSymbol, omegaSymbol, newLine);
        }
        static void StringsSection()
        {
            string a = "Here's a tab:\t";
            Console.WriteLine("The escape sequence - tab : {0}", a);
            string a1 = "\\\\server\\fileshare\\helloworld.cs";
            Console.WriteLine("Backslash is :{0}", a1);
            string a2 = @"\\server\fileshare\helloworld.cs";
            Console.WriteLine("verbatim: {0}", a2);
            string escaped = "First Line\r\nSecond Line";
            string verbatim = @"First Line
Second Line";
            // True if your text editor uses CR-LF line separators:
            Console.WriteLine(escaped == verbatim);
            string xml = @"<customer id=""123""></customer>";
            Console.WriteLine(xml);
        }
        // ----------------- END OF FUNCTIONS -----------------
        static void Main(string[] args)
        {
            //StringSection();
            //ArraysSection();
            //ExceptionHandlingSection();
            //LoopsSection();
            //OperatorsSection();
            //StringBuilderSection();
            //ExtensionMethod();
            //PracticeClassAndInterview();
            //PracticeConversion();
            //OverflowAndUnderflowExample();
            //SpecialValues();
            //CharSection();
            StringsSection();

            var janati = new Person { Name = "janati" };

            var mapper = new Mapper();

            var mapResult = mapper.Map<TooleSag>(janati);





            //Mapper<Conversion> mapper = new Mapper<Conversion>();
            //Dictionary<string, MethodInfo> methods = mapper.GetMethods();
            //foreach (var method in methods)
            //{
            //    Console.WriteLine($"Method name: {method.Key}, Return type: {method.Value.ReturnType}");
            //}

            
            //Dictionary<string, PropertyInfo> properties = mapper.GetProperties();

            //foreach (var property in properties)
            //{
            //    Console.WriteLine($"Property Name is : {property.Key}");
            //}

        }

    }
}