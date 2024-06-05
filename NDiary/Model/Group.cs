namespace NDiary.Model
{
    public class Group
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();
        
        public Teacher Tutor { get; set; }

        //public int TutorId { get; set; }
        //public Tutor Tutor { get; set; }
    }
}
