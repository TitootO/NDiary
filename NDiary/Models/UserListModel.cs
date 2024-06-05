using Microsoft.AspNetCore.Mvc.Rendering;
using NDiary.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace NDiary.Models
{
    public class UserListModel
	{
		public IEnumerable<User> Users { get; set; } = new List<User>();
		public SelectList Roles { get; set; } = new SelectList(new List<Role>(), "Id", "Name");
	}
}
