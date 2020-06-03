using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public interface IBooksRepository
    {
        IEnumerable<Books> GetAllBooks { get; }
        IEnumerable<Books> GetBooksOnSale { get; }
        Books GetBookById(int bookId);
    }
}
