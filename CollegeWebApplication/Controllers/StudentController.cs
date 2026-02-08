using CollegeWebApplication.Data;
using CollegeWebApplication.Models;
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
        [HttpGet]
        public IActionResult Index()
        {
            var studentList = _context.StudentInfo.ToList();
            return View(studentList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentInfo student)
        {
            if (ModelState.IsValid)
            {
                _context.StudentInfo.Add(student);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View(student);
        }
       
       

    }
}
