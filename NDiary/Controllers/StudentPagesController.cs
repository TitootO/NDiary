using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NDiary.Data;
using NDiary.Model;

namespace NDiary.Controllers
{
    public class StudentPagesController : Controller
	{
		private Database _database;
		public StudentPagesController(Database database)
		{
			_database = database;
		}
		
		public IActionResult ProfilePage()
		{
			int id = Convert.ToInt32(User.Claims.FirstOrDefault(q => q.Type == "UserId").Value);
			var student = _database.Students.Where(g => g.UserId == id).First();
			var group = _database.Groups.Where(g => g.Id == student.GroupId).First();
			var faculty = _database.Faculties.Where(g => g.Id == group.FacultyId).First();
			group.Faculty = faculty;
			student.Group = group;
			return View(student);
		}
		public IActionResult GroupPage()
		{
			int id = Convert.ToInt32(User.Claims.FirstOrDefault(q => q.Type == "UserId").Value);
			var student = _database.Students.Where(g => g.UserId == id).First();
			List<Student> students = _database.Students.Where(q => q.GroupId == student.GroupId).ToList();

			return View(students);
		}
		public IActionResult DiaryPage()
		{
			int id = Convert.ToInt32(User.Claims.FirstOrDefault(q => q.Type == "UserId").Value);
			var student = _database.Students.Where(g => g.UserId == id).First();

			return View();
		}
	}
}
