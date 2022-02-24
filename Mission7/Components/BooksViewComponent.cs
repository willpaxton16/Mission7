using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mission7.Models;

namespace Mission7.Components
{
    public class BooksViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { get; set; }
        public BooksViewComponent (IBookstoreRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {
            //Still need to change "projectType" to whatever variable
            ViewBag.SelectedType = RouteData?.Values["category"];

            var books = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(books);
        }
    }
}
