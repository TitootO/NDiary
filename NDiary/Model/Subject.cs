using System.Text.RegularExpressions;

namespace NDiary.Model
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Group Group { get; set; }
        public Dictionary<DateOnly, Day> Day { get; set; } = new Dictionary<DateOnly, Day>();
	}
}
