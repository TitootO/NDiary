using NDiary.Model;

namespace NDiary.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public Subject Subject { get; set; }
    }
}
