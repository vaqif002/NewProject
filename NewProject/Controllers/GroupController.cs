using Microsoft.AspNetCore.Mvc;
using NewProject.Models;

namespace NewProject.Controllers
{
    public class GroupController : Controller
    {
        public List<Group> groups = new List<Group>()
        {
        new Group
        {
            Name = "AB201",
        },
        new Group{Name="AB202"},
        new Group{Name="AB200"}






        };


        public IActionResult Index()
        {
            return View(groups);
        }
    }
}
