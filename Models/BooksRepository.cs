using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class BooksRepository : IBooksRepository
    {
        private readonly AppDbContext _appDbContext;

        public BooksRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Books> GetAllBooks 
        { 
           get
            {
                return _appDbContext.Books.Include(c => c.Category);
            }
        }

        public IEnumerable<Books> GetBooksOnSale
        {
            get
            {
                return _appDbContext.Books.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Books GetBooksById(int bookId)
        {
            return _appDbContext.Books.FirstOrDefault(c => c.BookId == bookId);
        }
    }
}
