using Store;
using System.Linq;

namespace Strore.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[] 
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth","Art of Programming"),
            new Book(2, "ISBN 12312-31232", "M. Fowler", "Refactoring"),
            new Book(3, "ISBN 12312-31233", "B. Kernighan, D. Ritchie", "C Programming Language")
        };

        public Book[] GetAllByIsbn(string Isbn)
        {
            return books.Where(book => book.Isbn==(Isbn))
                .ToArray();
        }

        public Book[] GetAllByTitleOrAuthors(string query)
        {
            return books.Where(book => book.Author.Contains(query)
            || book.Title.Contains(query))
                .ToArray();
        }
    }
}