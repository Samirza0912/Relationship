using ASP_ViewComponent.DAL;
using ASP_ViewComponent.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_ViewComponent.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BookController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Book> book = new List<Book>();
            book = _context.Books.Include(a_i => a_i.BookAuthors).ThenInclude(a => a.Authors)
                .Include(g_i => g_i.BookGenres).ThenInclude(g => g.Genres).ToList();
            return View(book);
        }
        public IActionResult Create()
        {
            ViewBag.Authors = new SelectList(_context.Authors.ToList(), "Id", "Name");
            ViewBag.Genres = new SelectList(_context.Genre.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Book newBook = new Book
            {
                Name = book.Name,
                Price = book.Price
            };
            List<BookAndGenreRelation> bookgenre = new List<BookAndGenreRelation>();
            foreach (var item in book.GenreIds)
            {
                BookAndGenreRelation bookGenre = new BookAndGenreRelation();
                bookGenre.GenreId = item;
                bookGenre.BookId = newBook.Id;
                bookgenre.Add(bookGenre);
            }
            newBook.BookGenres = bookgenre;
            List<BookAuthor> bookAuthors = new List<BookAuthor>();
            foreach (var item in book.AuthorIds)
            {
                BookAuthor bookAuthor = new BookAuthor();
                bookAuthor.AuthorId = item;
                bookAuthor.BookId = newBook.Id;
                bookAuthors.Add(bookAuthor);
            }
            newBook.BookAuthors = bookAuthors;
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
