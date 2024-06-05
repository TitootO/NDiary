using NDiary.Model;
namespace NDiary.ViewModels
{
    public class GroupViewModel
	{
		public GroupViewModel(List<Group> groups, List<Student> students)
		{
			Groups = groups;
			Students = students;
		}

		public List<Group> Groups { get; set; }
		public List<Student> Students { get; set; }
	}
}
