using System.Text.RegularExpressions;

namespace NDiary.Model
{
    /// <summary>
    /// Курс 
    /// </summary>
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Связанная группа 
        /// </summary>
        public Group Group { get; set; }
        public List<Day> Day { get; set; } = new List<Day>();
	}
}
