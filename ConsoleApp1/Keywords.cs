// Ignore Spelling: Deconstruct

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Keywords
    {
        internal void Method1(B b) { }
    }

    internal class B { }

    class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("Base class Display method");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Display()
        {
            Console.WriteLine("Derived class Display method");
        }
    }


    class BaseClass2
    {
        public virtual void IWouldLikeToBeOverridden()
        {
            Console.WriteLine("Oh override me!!!!!!");
        }
    }

    class DerricedClass2 : BaseClass2
    {
        public override void IWouldLikeToBeOverridden()
        {
            Console.WriteLine("Oh yes thanks");
        }
    }

    abstract class AbstractClassTest
    {
        public abstract string AgainDisplay(string a);
    }

    class ConcreteClass : AbstractClassTest
    {
        public override string AgainDisplay(string a)
        {
            return a;
        }
        int Foo(int x) => x * 12;
    }


    public class Wine
    {
        public decimal Price;
        public int Year;
        public Wine(decimal price) { Price = price; }
        public Wine(decimal price, int year) : this(price) { Year = year; }
        public Wine(decimal price, DateTime year) : this(price, year.Year) { }
    }

    public class Class1
    {
        Class1() { }
        public static Class1 Create()
        {
            string mamad = "hello";
            return new Class1();
        }
    }

    class Rectangle
    {
        public readonly float Width, Height;
        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        public void Deconstruct(out float width, out float height)
        {
            width = Width;
            height = Height;
        }
    }

    internal class Sentence
    {

        string[] words = "The quick brown fox".Split();

        public string this[int wordNum]
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }
        public string this[Index index] => words[index];
        public string[] this [Range range] => words[range];

        public void FindMaMad()
        {
            var rect = new Rectangle(4, 5);
            Class1.Create();
        }
    }

    public class UseSentence
    {
        public void ManipulateSentence()
        {
            Sentence sentence = new Sentence();
            Console.WriteLine(sentence[3]);
            sentence[3] = "Kangaroo";
            Console.WriteLine(sentence[3]);

            Console.WriteLine(sentence[^1]);
            string[] firstTwoWords = sentence[..2];
            Console.WriteLine("Texts I got from are: {0}, {1}", firstTwoWords[0], firstTwoWords[1]);
        }
    }

}
