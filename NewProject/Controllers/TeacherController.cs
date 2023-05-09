using Microsoft.AspNetCore.Mvc;
using NewProject.Models;

namespace NewProject.Controllers
{
    public class TeacherController : Controller
    {
		public List<Teacher> Teachers = new List<Teacher>()
		{
		new Teacher
			{
				
				Name="Asif",
				Surname="Memmedov",
				Subject="Mathematic",
				Experience="3 year"
			},
			new Teacher
			 {
					Name="Nezrin",
				Surname="Babekova",
				Subject="English language",
				Experience="1 year"
			 },
		   new Teacher
		   {
				Name="Tunzale",
				Surname="Memmedova",
				Subject="French language",
				Experience="4 year"
			}

		};
		public IActionResult Index()
        {
            return View(Teachers);
        }
    }
}
