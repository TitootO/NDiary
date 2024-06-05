using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;
using NDiary.Model;
using NDiary.Data;

namespace NDiary.Controllers
{
    public class HomeController : Controller
    {
		private Database _database;
		public HomeController(Database database)
		{
			_database = database;
			_database.Users.Load();
			_database.Students.Load();
			
		}
		[Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
			//string role = User.FindFirst(x => x.Type == ClaimsIdentity.DefaultRoleClaimType).Value;
			return View();
		}
		[Authorize(Roles = "Admin")]
		public IActionResult Admin()
		{
			return View();
		}
		[Authorize(Roles = "Student")]
        public IActionResult Student()
        {
			string login = User.Identity.Name;
			User user = _database.Users.First(q => q.Login == login) as User;
			//ViewBag.name = user.Student.Name;
			//ViewBag.val = user.Student.Group.Name;
			//List<Student> students = _database.Students.Where(q => q.Group == user.Student.Group).ToList();
			return View();
		}
		[Authorize(Roles = "Parent")]
		public IActionResult Parent()
		{
			return View();
		}
		[Authorize(Roles = "Teacher")]
		public IActionResult Teacher()
		{
			return View();
		}
	}
}
