using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private static List<Student>students = new List<Student>()
        {
            new(){Id=1,Name="Name1",Age=20 },
             new(){Id=2,Name="Name2",Age=10 },
             new(){Id=3,Name="Name3",Age=30 }
        };                  
        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult About(int id)

        {

            return View(students.Find(s => s.Id == id));
        }
    }
}
