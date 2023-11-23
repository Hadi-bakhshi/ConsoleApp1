namespace Book;
public class Program
{
    static void Main()
    {
        Library library =
        [
            new Book { Title = "The Alchemist", Author = "Paulo Coelho" },
            new Book { Title = "Atomic Habits", Author = "James Clear" },
            new Book { Title = "It Ends With Us", Author = "Colleen Hoover" },
            new Book { Title = "Harry Potter", Author = "J. K. Rowling" },
        ];

        //for (int i = 0; i < library.Count; i++)
        //{
        //    Console.WriteLine(library[i]);
        //}

        foreach (var bk in library)
        {
            Console.WriteLine(bk);
        }
    }
}