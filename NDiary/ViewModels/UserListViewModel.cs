using Microsoft.AspNetCore.Mvc.Rendering;
using NDiary.Model;

namespace NDiary.ViewModels
{
    public class UserListViewModel
	{
		public IEnumerable<User> Users { get; set; } = new List<User>();
		public SelectList Roles { get; set; } = new SelectList(new List<Role>(), "Id", "Name");
	}
}
