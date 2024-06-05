using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NDiary.Data;

namespace NDiary.Controllers
{
    public class StudentPagesController : Controller
	{
		private Database _database;
		public StudentPagesController(Database database)
		{
			_database = database;
		}
		public IActionResult Portfolio(string name)
		{
			//var student = _database.Students.Where(g => g.Name == name).First();
			//return View(student);
			return View();
		}
		//public IActionResult ProfilePage(string name, string val)
		//{
		//	var student = _database.Students.Where(g => g.Name == name).First();
		//	var group = _database.Groups.Where(g => g.Name ==  val).First();
		//	return View(student);
		//}
		//public IActionResult GroupPage(string val)
		//{

		//	int id = _database.Groups.FirstOrDefault(q => q.Name == val).Id;
		//	List<Student> students = _database.Students.Where(q => q.GroupId == id).ToList();

		//	return View(students);
		//}
		public IActionResult SchedulePage(string ras)
		{
			//var group = _database.Groups.Where(g => g.Name == ras).First();
			return View(/*group*/);
		}
	}
}
