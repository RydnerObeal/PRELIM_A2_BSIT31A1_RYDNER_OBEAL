using Microsoft.AspNetCore.Mvc;
using PRELIM_A2_BSIT31A1_RYDNER_OBEAL.Models;
using System;
using System.Collections.Generic;

namespace PRELIM_A2_BSIT31A1_RYDNER_OBEAL.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            var lib = new Library
            {
                Books = new List<Book>()
            };

            lib.Books.Add(new Book
            {
                Title = "Book 1",
                Author = new Author { Name = "Author 1" },
                Genre = Genre.Fiction,
                BorrowedBy = null,
                DateLastReturned = DateTime.Now.AddDays(-1)
            });

            lib.Books.Add(new Book
            {
                Title = "Book 2",
                Author = new Author { Name = "Author 2" },
                Genre = Genre.NonFiction,
                BorrowedBy = null,
                DateLastReturned = DateTime.Now.AddDays(-2)
            });

            lib.Books.Add(new Book
            {
                Title = "Book 3",
                Author = new Author { Name = "Author 3" },
                Genre = Genre.Mystery,
                BorrowedBy = null,
                DateLastReturned = DateTime.Now.AddDays(-3)
            });

            lib.Books.Add(new Book
            {
                Title = "Book 4",
                Author = new Author { Name = "Author 4" },
                Genre = Genre.Fantasy,
                BorrowedBy = null,
                DateLastReturned = DateTime.Now.AddDays(-4)
            });

            lib.Books.Add(new Book
            {
                Title = "Book 5",
                Author = new Author { Name = "Author 5" },
                Genre = Genre.Biography,
                BorrowedBy = null,
                DateLastReturned = DateTime.Now.AddDays(-5)
            });

            lib.Books.Add(new Book
            {
                Title = "Book 6",
                Author = new Author { Name = "Author 6" },
                Genre = Genre.Science,
                BorrowedBy = null,
                DateLastReturned = DateTime.Now.AddDays(-6)
            });

            lib.Books.Add(new Book
            {
                Title = "Book 7",
                Author = new Author { Name = "Author 7" },
                Genre = Genre.Romance,
                BorrowedBy = null,
                DateLastReturned = DateTime.Now.AddDays(-7)
            });

            lib.Books.Add(new Book
            {
                Title = "Book 8",
                Author = new Author { Name = "Author 8" },
                Genre = Genre.Horror,
                BorrowedBy = null,
                DateLastReturned = DateTime.Now.AddDays(-8)
            });

            lib.Books.Add(new Book
            {
                Title = "Book 9",
                Author = new Author { Name = "Author 9" },
                Genre = Genre.Comedy,
                BorrowedBy = null,
                DateLastReturned = DateTime.Now.AddDays(-9)
            });

            lib.Books.Add(new Book
            {
                Title = "Book 10",
                Author = new Author { Name = "Author 10" },
                Genre = Genre.Action,
                BorrowedBy = null,
                DateLastReturned = DateTime.Now.AddDays(-10)
            });

            return View(lib);
        }
    }
}
