using Microsoft.AspNetCore.Mvc;
using Mission11.Models;
using Mission11.Models.ViewModels;
using System.Diagnostics;

namespace Mission11.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookstoreContext _context;

        public HomeController(ILogger<HomeController> logger, BookstoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int page)
        {

            int pageSize = 10;

            var viewModel = new BookstoreListViewModel
            {
                Books = _context.Books.OrderBy(x => x.Title).Skip((page - 1) * pageSize).Take(pageSize),
                PaginationInfo = new PaginationInfo
                {
                    PageNum = page,
                    ItemsPerPage = pageSize,
                    TotalNumItems = _context.Books.Count()
                }
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
