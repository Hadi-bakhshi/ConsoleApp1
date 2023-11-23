using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class BookEnumerator : IEnumerator<Book>
    {

        private readonly Library _library;
        private int _idx;

        public BookEnumerator(Library library)
        {
            _library = library;
            _idx = -1;
        }

        public Book Current => _library[_idx];

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            return ++_idx < _library.Count;
        }

        public void Reset()
        {
            _idx = -1;
        }
    }
}
