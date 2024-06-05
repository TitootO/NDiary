using Microsoft.AspNetCore.Mvc.Rendering;
using NDiary.Model;

namespace NDiary.Models
{
    public class GroupListModel
	{
		public IEnumerable<Group> Groups { get; set; } = new List<Group>();
		public IEnumerable<Student> Students { get; set; } = new List<Student>();
		public SelectList Faculties { get; set; } = new SelectList(new List<Faculty>(), "Id", "Name");
	}
}
