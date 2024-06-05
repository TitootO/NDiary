using NDiary.Model;

namespace NDiary.Models
{
    public class Homework
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int GroupId { get; set; }
		public Group Group { get; set; }
		public int SubjectId { get; set; }
		public Subject Subject { get; set; }
		public DateTime DataCompletion {  get; set; }
		
	}
}
