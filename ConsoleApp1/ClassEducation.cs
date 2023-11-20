using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Animal
    {
        public string? Name { get; set; }
    }

    public class Dog : Animal
    {

        public string WhatIsTheDogName()
        {
            string name = "Jessi";
            return name;
        }

    }


    public class ClassEducation
    {
        public void UpCasting()
        {
            Dog dog = new Dog();
            Animal myAnimal = dog;

            myAnimal.Name = "Asqar";

            Console.WriteLine(myAnimal.Name);

        }

    }
}
