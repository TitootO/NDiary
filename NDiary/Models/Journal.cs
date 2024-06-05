using Microsoft.EntityFrameworkCore.Storage;
using NDiary.Model;

namespace NDiary.Models
{
    public class Journal
	{
		public int Id { get; set; }
		public int StudentId;
		public Student Student { get; set; }
		public int SubjctId { get; set; }
		public Subject Subject { get; set; }

		public bool Visit { get; set; }
		public int Assessment { get; set; }

	}
}
