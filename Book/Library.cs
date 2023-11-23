using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> _books = new List<Book>();

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            //return _books.GetEnumerator(); // instead of writing my own enumerator, I can simply use this :))))))
            return new BookEnumerator(this);
        }

        // This is the non generic method
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Book this[int idx] => _books[idx];
        public int Count => _books.Count;
    }
}
