using lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Arjun", Address = "Kapan", Age = 20 },
                new Student { Id = 2, Name = "Aayush", Address = "Patan", Age = 18 },
                new Student { Id = 3, Name = "Anish", Address = "Bhakatapur", Age = 34 }
            };


            return View( students);
        }
    }

}
