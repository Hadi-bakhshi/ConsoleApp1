﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Person
{
    internal interface IPerson
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public string GetFullName();
        
    }
}
