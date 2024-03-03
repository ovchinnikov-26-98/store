using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public interface IBookRepository
    {
        Book[] GetAllByIsbn(string Isbn);
        Book[] GetAllByTitleOrAuthors(string titleOrAuthot);
    }
}
