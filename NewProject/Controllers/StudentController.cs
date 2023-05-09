using Microsoft.AspNetCore.Mvc;
using NewProject.Models;

namespace NewProject.Controllers
{
    public class StudentController : Controller
    {
        public List<Student> Students = new List<Student>()
        {
        new Student
            {
                Id=1,
                Name="Qurban",
                Surname="Rustemov",
                Age=18      
            },
            new Student
             {
                Id =2,
                Name="Canpolad",
                Surname="Tahirov ",
                Age=19
             },
           new Student
           {
                Id=3,
                Name="Ulduz",
                Surname="Muradova",
                Age=18
            }

        };


        public IActionResult Index()
        {
            return View(Students);
        }
    }
}
