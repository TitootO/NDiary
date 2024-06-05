using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NDiary.Data;

namespace NDiary.Controllers
{
    public class AdminPagesController : Controller
	{
		private Database _database;
		public AdminPagesController(Database database)
		{
			_database = database;
		}

		//public IActionResult ListUsers()
		//{

		//	var users = _database.Users.Include(r => r.Role).Include(s => s.Student);
		//	return View(users.ToList());
		//}
		public IActionResult ListGroups()
		{

			var groups = _database.Groups.Include(f => f.Faculty);
			return View(groups.ToList());
		}
	}
}
