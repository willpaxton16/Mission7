using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission7.Models;
using Mission7.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace Mission7.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository book;
        
        public HomeController (IBookstoreRepository temp)
        {
            book = temp;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;

            var y = new BooksViewModel
            {
                Books = book.Books
                .OrderBy(p => p.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    NumProjects = book.Books.Count(),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(y);
        }

    }
}
