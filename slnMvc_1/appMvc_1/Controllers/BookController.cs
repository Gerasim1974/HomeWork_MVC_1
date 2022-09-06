using Microsoft.AspNetCore.Mvc;
using appMvc_1.Models;
using System.Diagnostics;

namespace appMvc_1.Controllers
{
    public class BookController : Controller
    {
        BookModel myBook;// = new BookModel("Алиса в стране чудес", "Льюис Кэррол", 342);
        public IActionResult Index()
        {
            myBook = new BookModel();// ("Алиса в стране чудес", "Льюис Кэррол", 342);
            myBook._name = "Алиса в стране чудес";
            myBook._author = "Льюис Кэррол";
            myBook._pageCount = 342;
            return View(myBook);
        }

        public IActionResult Book()
        {
            return View();
        }
    }
}
