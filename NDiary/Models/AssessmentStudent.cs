using NDiary.Model;

namespace NDiary.Models
{
    public class AssessmentStudent
	{
		public int Id { get; set; }
		public Student Student { get; set; }
		public int Assessment { get; set; }
		public Subject Subject { get; set; }		
		public DateTime Data { get; set; }
	}
}
