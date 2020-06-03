using BookShop.Models;
using BookShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksRepository _booksRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BooksController(IBooksRepository booksRepository, ICategoryRepository categoryRepository)
        {
            _booksRepository = booksRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Books> books;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                books = _booksRepository.GetAllBooks.OrderBy(c => c.BookId);
                currentCategory = "Book offers";
            }
            else
            {
                books = _booksRepository.GetAllBooks.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new CandyListViewModel
            {
                Books = books,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var books = _booksRepository.GetBookById(id);
            if (books == null)
                return NotFound();

            return View(books);
        }
    }
}
