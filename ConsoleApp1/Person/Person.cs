using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Person
{
    [Custom]
    internal class Person : IPerson
    {

        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;


        public string GetFullName()
        {
            return Name + " " + LastName;
        }
    }
}
