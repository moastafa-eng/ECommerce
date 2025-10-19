using ECommerce.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Controllers
{
    public class CategoriesController : Controller
    {
        // Get Reference from DbContext
        private readonly ECommerceDbContext _context;

        // Constructor Dependency Injection to get the DbContext
        public CategoriesController(ECommerceDbContext context)
        {
            _context = context;
        }

        // This method is asynchronous (it runs tasks in the background).
        // 'async' means this function can contain code that runs without blocking the main thread.
        // 'Task<IActionResult>' means this method returns a "task" — a promise that will finish later.
        // 'await' tells the program to pause here until the background task finishes, 
        // then continue executing the rest of the code.
        // 'ToListAsync()' runs the database query in the background instead of blocking the thread.
        // Using async/await makes the web app faster and more responsive 
        // because the server can handle other user requests while waiting for the database.
        public async Task<IActionResult> Index()
        {
            var Respons = await _context.Categories.ToListAsync();
            return View(Respons);
        }
    }
}
