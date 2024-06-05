using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NDiary.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
   
        public User User { get; set; }
        public Group Group { get; set; }
        public List<Parent> Parent { get; set; } = new List<Parent>();
        //public List<int> Parents { get; set; }
        //public int TeacherId { get; set; }
        //public Teacher Teacher { get; set; }
        //public int TeacherId { get; set; }
        //public Teacher Teacher { get; set; }
    }
}
