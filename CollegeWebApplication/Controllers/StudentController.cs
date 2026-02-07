using CollegeWebApplication.Data;
using Microsoft.AspNetCore.Mvc;

namespace CollegeWebApplication.Controllers
{
    public class StudentController : Controller
    {
        private readonly CollegeWebDbContext _context;
        public StudentController(CollegeWebDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
