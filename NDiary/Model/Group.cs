using System.ComponentModel.DataAnnotations.Schema;

namespace NDiary.Model
{
    public class Group
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
        [ForeignKey(nameof(Faculty))]
        public int? FacultyId { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        
        public Teacher Tutor { get; set; }
        [ForeignKey(nameof(Tutor))]
        public int? TutorId { get; set; }
        public Group() 
        {
            Students = new List<Student>();
            Subjects = new List<Subject>();
        }
    }
}
