using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Book
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} ({Author})";
        }
    }
}
