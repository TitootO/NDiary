using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NDiary.Data;
using NDiary.ViewModels;
using NDiary.Model;

namespace NDiary.Controllers
{
    public class AdminPagesController : Controller
	{
		private Database _database;
		List<User> users;
		List<Role> roles;
		public AdminPagesController(Database database)
		{
			_database = database;
		}

		//public IActionResult ListUsers()
		//{
		//	List<UserRole> roleModels = roles.Select(r => new UserRole(r.Id, r.Name)).ToList();
		//	UserListViewModel viewModel = new() {Roles = roleModels, Users = users };
		//	//var users = _database.Users.Include(r => r.Role).Include(s => s.Student);
		//	//return View(users.ToList());
		//	return View(viewModel);
		//}
		public IActionResult ListGroups()
		{

			var groups = _database.Groups.Include(f => f.Faculty);
			return View(groups.ToList());
		}
	}
}
